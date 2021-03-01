using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Collections.Specialized;

namespace SuchFunktion
{
    public partial class Form1 : Form
    {
        List<string> ListOfDirectory = new List<string> { };
        List<string> ListOfErrors = new List<string> { };
        List<string> ListOfFiles = new List<string> { };

        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e) //Anzeige Ordner und Dateianzahl nach Suchparameter
        {
            CSearchFile C1 = new CSearchFile();
            LabelGreeting.Text = C1.Count_Folder(Ordnersuche.SelectedPath);
            CSearchFile C3 = new CSearchFile();
            FileCount.Text = C3.Count_Files(Ordnersuche.SelectedPath,TextBox.Text);
            //TextFeldContent.Text = Ordnersuche.SelectedPath; //Anzeige auf dem Label "TextBox"
        }

        private void LabelGreeting_Click(object sender, EventArgs e)
        {
            Process.Start(Ordnersuche.SelectedPath);

        }

        private void SetSearchName_TextChanged(object sender, EventArgs e)
        {
            CSearchFile C2 = new CSearchFile();
            LabelGreeting.Text = C2.Count_Folder(Ordnersuche.SelectedPath);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void folderdialog_Click(object sender, EventArgs e)
        {
            Ordnersuche.ShowDialog();
            Chosen_Folder_Real.Text = Ordnersuche.SelectedPath;
        }

        private void Chosen_Folder_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) //öffnet ausgewählten Ordner
        {
            Process.Start(Ordnersuche.SelectedPath);
        }

        public void GetSubDirectories(string DirectoryPath)
        {
            

            string[] directories = { };
            try
            {
                directories = Directory.GetDirectories(DirectoryPath);
            }
            catch
            {
                ListOfErrors.Add(DirectoryPath);
            }

            foreach (string directory in directories)
            {
                ListOfDirectory.Add(directory);
                GetSubDirectories(directory);
            }

        }
        //*******************************************************************************************************************************MAIN FUNCTION # START
        private void ShowFilesFound_Click(object sender, EventArgs e) //DataGrid Anzeige Füllung
        {
            string[] files = { };
            if (IsSearchingAll)
            {
                GetSubDirectories(Ordnersuche.SelectedPath);
                ListOfDirectory.Insert(0, Ordnersuche.SelectedPath);
                SetupProgressBar();


                foreach (string element in ListOfDirectory)
                {
                    progressBar1.Value = ListOfDirectory.IndexOf(element);
                    try
                    {
                        files = Directory.GetFiles($"{element}", $"*{TextBox.Text}*");
                    }
                    catch { };
                    foreach (string filepath in files)
                    {
                        ListOfFiles.Add(filepath);
                    }
                }
                
               files = ListOfFiles.ToArray();
            }
            else
            {
                files = Directory.GetFiles($"{Ordnersuche.SelectedPath}", $"*{TextBox.Text}*");
            }
            //**********************************************************
            string [] directories = Directory.GetDirectories(Ordnersuche.SelectedPath);
            
            List<Files> FileShow = new List<Files>();
            //hier daziwschen eine Funktion die die Filesize filtert, bevor sie in die Liste kommen.
            if (IsSearchingSize)
            {
                foreach (string file in files)
                {
                    if (SizeMaxMinSearch(textBox_Size_Start.Text, textBox_Size_End.Text, new FileInfo(file).Length)) //TextBox von/bis und die Dateilänge füttern den Filter
                    {
                        FileShow.Add(new Files { Path = file, Filename = Path.GetFileName(file), Size = SizeOfFile(file) });
                    }
                }
                datagrid_files.DataSource = FileShow;

            }
            else
            {

                foreach (string file in files)
                {
                    FileShow.Add(new Files { Path = file, Filename = Path.GetFileName(file), Size = SizeOfFile(file) });
                }
                datagrid_files.DataSource = FileShow;
            }
            DataGridViewColumn column = datagrid_files.Columns[2];
            column.Width = 360;



            //Anzeige gefundene Dateien
            //FileCount.Text = files.Length.ToString();
            FileCount.Text = FileShow.Count.ToString();
            //Anzeige gefundene Ordner 
            if (IsSearchingAll)
            {
                LabelGreeting.Text = ListOfDirectory.Count().ToString();
            }
            else
            {
                CSearchFile C1 = new CSearchFile();
                LabelGreeting.Text = C1.Count_Folder(Ordnersuche.SelectedPath);
            }

            ListOfFiles.Clear();
            ListOfDirectory.Clear();
            progressBar1.Value = progressBar1.Maximum;

        }
        //*******************************************************************************************************************************MAIN FUNCTION # END
        private string SizeOfFile (string Filepath)
        {
            double SizeInByte = new FileInfo(Filepath).Length;
            double SizeInKb = Math.Round(SizeInByte / 1024, 2);

            return SizeInKb+" kB";
        }

        private bool SizeMaxMinSearch(string start, string end ,double FileSize) //true ist Maximum - wendet den Größenfilter auf die Dateiliste an
        {
            //double ConvertToBytes = Range_Value * 1024;
            double start_int;
            double end_int;
            Double.TryParse(start, out start_int);
            Double.TryParse(end, out end_int);
            if (end_int > 0 && FileSize < end_int*1024 && start_int == 0)
            {
                return true;
            }
            if (start_int > 0 && FileSize > start_int*1024 && end_int == 0)
            {
                return true;
            }
            if (start_int > 0 && end_int > 0 && FileSize > start_int * 1024 && FileSize < end_int * 1024)
            {
                return true;
            }
                return false;
        }

        public void SetupProgressBar()
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = ListOfDirectory.Count();
        }


        public void ShowStartParameter()
        {
            string[] CommandLineArgs = Environment.GetCommandLineArgs();
            //CommandLineArgs[0]: Immer der Dateipfad 
            if (CommandLineArgs.Length > 1)
            {
                Chosen_Folder_Real.Text = $"{CommandLineArgs[1].ToString()}";
                this.Ordnersuche.SelectedPath = CommandLineArgs[1].ToString();
            }
            Console.Write("Wert 0 = ");
            Console.WriteLine(CommandLineArgs[0].ToString());
        }

        private void Chosen_Folder_Real_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(Ordnersuche.SelectedPath);
        }

        private void Form1_Load(object sender, EventArgs e) //hier eintragen was beim Start immer mitgeladen werden soll
        {
            ShowStartParameter();
            
            //Chosen_Folder_Real.Text = "E:";
            //this.Ordnersuche.SelectedPath = "E:\\";
        }
     
        private void IsEnterPressed(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ShowFilesFound_Click(this, new EventArgs());
                e.SuppressKeyPress = true;
            }
        }
        private void IsEnterPressedForSize(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //checkBoxSize_CheckedChanged(sender, e);
                checkBoxSize.Checked = true;
                
                e.SuppressKeyPress = true;
                ShowFilesFound_Click(this, new EventArgs());
            }
            
        }

        private void SelectedRowInDatagrid(object sender, EventArgs e)
        {
            SelectedRow.Text = datagrid_files.CurrentCell.RowIndex.ToString();
            int SelectedRowIndex = datagrid_files.CurrentCell.RowIndex;
            
            //Show File informatioN
            FileInfo fi = new FileInfo(datagrid_files.Rows[SelectedRowIndex].Cells[2].Value.ToString());
            var created = fi.CreationTime;
            var lastmodified = fi.LastWriteTime;
            //Anzeige in Forms
            SelectedRowFileCreated.Text = created.ToString();
            SelectedRowFileChanged.Text = lastmodified.ToString();
            SelectedRowPath.Text = datagrid_files.Rows[SelectedRowIndex].Cells[0].Value.ToString();
            SelectedRowFileSize.Text = datagrid_files.Rows[SelectedRowIndex].Cells[1].Value.ToString();
            // SelectedRowPath.Text = datagrid_files.CurrentCell.ColumnIndex.ToString();
        }



        SearchOption SearchSubPathParam = SearchOption.AllDirectories;

        private void checkBox_SubPath_CheckedChanged(object sender, EventArgs e)
        {
            if (IsSearchingAll)
            {
                IsSearchingAll = false;
                ShowFilesFound_Click(sender, e);
            }
            else
            {
                IsSearchingAll = true;
                ShowFilesFound_Click(sender, e);
            }
        }

        private
            bool IsSearchingAll = false;
            bool IsSearchingSize = false;
            bool IsShowingDetails = true;

        private void checkBoxSize_CheckedChanged(object sender, EventArgs e)
        {
            if (IsSearchingSize)
            {
                IsSearchingSize = false;
                ShowFilesFound_Click(sender, e);
                
            }
            else
            {
                IsSearchingSize = true;
                ShowFilesFound_Click(sender, e);
                
            }
        }
        private void checkBoxDetailInformation_CheckedChanged(object sender, EventArgs e)
        {
            if (IsShowingDetails) //********************** && FileCount.Text!="..." && FileCount.Text!="0"
            {
                IsShowingDetails = false;
                panel1.Visible = true;
                this.ClientSize = new System.Drawing.Size(980, 485);
            }
            else
            {
                IsShowingDetails = true;
                panel1.Visible = false;
            }
        }
        private void SizeChangedAction(object sender, EventArgs e)
        {
            int WidthOfForm = this.Size.Width;
            int HeightOfForm = this.Size.Height;
            datagrid_files.Size = new System.Drawing.Size(WidthOfForm-datagrid_files.Location.X-50, HeightOfForm-150);
        }

        private void CopyToClipboard(object sender, EventArgs e)
        {
            StringCollection paths = new StringCollection();
            try 
            {
                paths.Add(datagrid_files.Rows[datagrid_files.CurrentCell.RowIndex].Cells[2].Value.ToString()); 
                Clipboard.SetFileDropList(paths);
            }
            catch
            {

            }
                
            
        }

        private void Button_Clipboard_Click(object sender, EventArgs e)
        {
            CopyToClipboard(sender, e);
        }
    }
    public class CSearchFile : Form1
    {
        public string Count_Folder(string SearchDirectory)
        {
            directories = Directory.GetDirectories(SearchDirectory);
            int directorycount = directories.Count();
            string f= directorycount.ToString();
            
            return f;
        }
        public string Count_Files(string SearchDirectory,string SearchParameterName) //wahrscheinlich überflüssig
        {
            files = Directory.GetFiles($"{SearchDirectory}", $"{SearchParameterName}", 0);
            int File_Count = files.Count();
            string f = File_Count.ToString();
            return f;
        }
        public
            int i = 0;

        private
            string[] files = { };
            string[] directories = { };
            
    }
    public class Files
    {
        public string Filename { get; set; }
        public string Size { get; set; }
        public string Path { get; set; }
    }
    



    }
