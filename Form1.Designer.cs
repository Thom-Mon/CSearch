namespace SuchFunktion
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnHierKlicken = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.LabelGreeting = new System.Windows.Forms.Label();
            this.FileCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextFeldContent = new System.Windows.Forms.Label();
            this.Ordnersuche = new System.Windows.Forms.FolderBrowserDialog();
            this.folderdialog = new System.Windows.Forms.Button();
            this.datagrid_files = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Chosen_Folder_Real = new System.Windows.Forms.LinkLabel();
            this.Chosen_Folder_Label = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBoxSize = new System.Windows.Forms.CheckBox();
            this.textBox_Size_Start = new System.Windows.Forms.TextBox();
            this.textBox_Size_End = new System.Windows.Forms.TextBox();
            this.LabelSizeStart = new System.Windows.Forms.Label();
            this.LabelSizeEnd = new System.Windows.Forms.Label();
            this.SelectedRowPath = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SelectedRowFileSize = new System.Windows.Forms.Label();
            this.SelectedRowFileCreated = new System.Windows.Forms.Label();
            this.SelectedRowFileChanged = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Button_Clipboard = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SelectedRow = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_files)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHierKlicken
            // 
            this.btnHierKlicken.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHierKlicken.Location = new System.Drawing.Point(154, 84);
            this.btnHierKlicken.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHierKlicken.Name = "btnHierKlicken";
            this.btnHierKlicken.Size = new System.Drawing.Size(100, 26);
            this.btnHierKlicken.TabIndex = 0;
            this.btnHierKlicken.Text = "Suchen...";
            this.btnHierKlicken.UseVisualStyleBackColor = true;
            this.btnHierKlicken.Click += new System.EventHandler(this.ShowFilesFound_Click);
            // 
            // LabelGreeting
            // 
            this.LabelGreeting.AutoSize = true;
            this.LabelGreeting.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelGreeting.Location = new System.Drawing.Point(793, 10);
            this.LabelGreeting.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelGreeting.Name = "LabelGreeting";
            this.LabelGreeting.Size = new System.Drawing.Size(21, 20);
            this.LabelGreeting.TabIndex = 1;
            this.LabelGreeting.Text = "...";
            this.LabelGreeting.Click += new System.EventHandler(this.LabelGreeting_Click);
            // 
            // FileCount
            // 
            this.FileCount.AutoSize = true;
            this.FileCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileCount.Location = new System.Drawing.Point(793, 36);
            this.FileCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FileCount.Name = "FileCount";
            this.FileCount.Size = new System.Drawing.Size(21, 20);
            this.FileCount.TabIndex = 3;
            this.FileCount.Text = "...";
            this.FileCount.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(733, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ordner:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(733, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Dateien:";
            // 
            // TextBox
            // 
            this.TextBox.BackColor = System.Drawing.SystemColors.Info;
            this.TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox.Location = new System.Drawing.Point(15, 84);
            this.TextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(135, 26);
            this.TextBox.TabIndex = 6;
            this.TextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.IsEnterPressed);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 62);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Suchparameter";
            // 
            // TextFeldContent
            // 
            this.TextFeldContent.AutoSize = true;
            this.TextFeldContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextFeldContent.Location = new System.Drawing.Point(200, 38);
            this.TextFeldContent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TextFeldContent.Name = "TextFeldContent";
            this.TextFeldContent.Size = new System.Drawing.Size(0, 20);
            this.TextFeldContent.TabIndex = 8;
            // 
            // Ordnersuche
            // 
            this.Ordnersuche.SelectedPath = "C:\\";
            // 
            // folderdialog
            // 
            this.folderdialog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.folderdialog.Location = new System.Drawing.Point(16, 14);
            this.folderdialog.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.folderdialog.Name = "folderdialog";
            this.folderdialog.Size = new System.Drawing.Size(77, 29);
            this.folderdialog.TabIndex = 9;
            this.folderdialog.Text = "Ordner...";
            this.folderdialog.UseVisualStyleBackColor = true;
            this.folderdialog.Click += new System.EventHandler(this.folderdialog_Click);
            // 
            // datagrid_files
            // 
            this.datagrid_files.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagrid_files.BackgroundColor = System.Drawing.SystemColors.Info;
            this.datagrid_files.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_files.Location = new System.Drawing.Point(310, 63);
            this.datagrid_files.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.datagrid_files.Name = "datagrid_files";
            this.datagrid_files.RowHeadersWidth = 17;
            this.datagrid_files.RowTemplate.Height = 31;
            this.datagrid_files.Size = new System.Drawing.Size(608, 158);
            this.datagrid_files.TabIndex = 12;
            this.datagrid_files.SelectionChanged += new System.EventHandler(this.SelectedRowInDatagrid);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Chosen_Folder_Real
            // 
            this.Chosen_Folder_Real.AutoSize = true;
            this.Chosen_Folder_Real.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chosen_Folder_Real.Location = new System.Drawing.Point(97, 36);
            this.Chosen_Folder_Real.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Chosen_Folder_Real.Name = "Chosen_Folder_Real";
            this.Chosen_Folder_Real.Size = new System.Drawing.Size(17, 16);
            this.Chosen_Folder_Real.TabIndex = 14;
            this.Chosen_Folder_Real.TabStop = true;
            this.Chosen_Folder_Real.Text = "...";
            this.Chosen_Folder_Real.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Chosen_Folder_Real_LinkClicked);
            // 
            // Chosen_Folder_Label
            // 
            this.Chosen_Folder_Label.AutoSize = true;
            this.Chosen_Folder_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.14286F);
            this.Chosen_Folder_Label.Location = new System.Drawing.Point(97, 14);
            this.Chosen_Folder_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Chosen_Folder_Label.Name = "Chosen_Folder_Label";
            this.Chosen_Folder_Label.Size = new System.Drawing.Size(122, 17);
            this.Chosen_Folder_Label.TabIndex = 15;
            this.Chosen_Folder_Label.Text = "gewählter Ordner:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(15, 121);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(181, 17);
            this.checkBox1.TabIndex = 16;
            this.checkBox1.Text = "Unterverzeichnisse durchsuchen";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox_SubPath_CheckedChanged);
            // 
            // checkBoxSize
            // 
            this.checkBoxSize.AutoSize = true;
            this.checkBoxSize.Location = new System.Drawing.Point(15, 145);
            this.checkBoxSize.Name = "checkBoxSize";
            this.checkBoxSize.Size = new System.Drawing.Size(133, 17);
            this.checkBoxSize.TabIndex = 17;
            this.checkBoxSize.Text = "Größenfilter anwenden";
            this.checkBoxSize.UseVisualStyleBackColor = true;
            this.checkBoxSize.CheckedChanged += new System.EventHandler(this.checkBoxSize_CheckedChanged);
            // 
            // textBox_Size_Start
            // 
            this.textBox_Size_Start.Location = new System.Drawing.Point(15, 179);
            this.textBox_Size_Start.Name = "textBox_Size_Start";
            this.textBox_Size_Start.Size = new System.Drawing.Size(95, 20);
            this.textBox_Size_Start.TabIndex = 18;
            this.textBox_Size_Start.KeyDown += new System.Windows.Forms.KeyEventHandler(this.IsEnterPressedForSize);
            // 
            // textBox_Size_End
            // 
            this.textBox_Size_End.Location = new System.Drawing.Point(116, 179);
            this.textBox_Size_End.Name = "textBox_Size_End";
            this.textBox_Size_End.Size = new System.Drawing.Size(100, 20);
            this.textBox_Size_End.TabIndex = 19;
            this.textBox_Size_End.KeyDown += new System.Windows.Forms.KeyEventHandler(this.IsEnterPressedForSize);
            // 
            // LabelSizeStart
            // 
            this.LabelSizeStart.AutoSize = true;
            this.LabelSizeStart.Location = new System.Drawing.Point(12, 165);
            this.LabelSizeStart.Name = "LabelSizeStart";
            this.LabelSizeStart.Size = new System.Drawing.Size(25, 13);
            this.LabelSizeStart.TabIndex = 20;
            this.LabelSizeStart.Text = "von";
            // 
            // LabelSizeEnd
            // 
            this.LabelSizeEnd.AutoSize = true;
            this.LabelSizeEnd.Location = new System.Drawing.Point(116, 164);
            this.LabelSizeEnd.Name = "LabelSizeEnd";
            this.LabelSizeEnd.Size = new System.Drawing.Size(20, 13);
            this.LabelSizeEnd.TabIndex = 21;
            this.LabelSizeEnd.Text = "bis";
            // 
            // SelectedRowPath
            // 
            this.SelectedRowPath.AutoSize = true;
            this.SelectedRowPath.Location = new System.Drawing.Point(55, 30);
            this.SelectedRowPath.Name = "SelectedRowPath";
            this.SelectedRowPath.Size = new System.Drawing.Size(186, 13);
            this.SelectedRowPath.TabIndex = 23;
            this.SelectedRowPath.Text = "Zeigt Dateinamen an des selektierten ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Detailinformationen: ";
            // 
            // SelectedRowFileSize
            // 
            this.SelectedRowFileSize.AutoSize = true;
            this.SelectedRowFileSize.Location = new System.Drawing.Point(55, 56);
            this.SelectedRowFileSize.Name = "SelectedRowFileSize";
            this.SelectedRowFileSize.Size = new System.Drawing.Size(141, 13);
            this.SelectedRowFileSize.TabIndex = 25;
            this.SelectedRowFileSize.Text = "Zeigt die Größe der Datei an";
            // 
            // SelectedRowFileCreated
            // 
            this.SelectedRowFileCreated.AutoSize = true;
            this.SelectedRowFileCreated.Location = new System.Drawing.Point(55, 83);
            this.SelectedRowFileCreated.Name = "SelectedRowFileCreated";
            this.SelectedRowFileCreated.Size = new System.Drawing.Size(109, 13);
            this.SelectedRowFileCreated.TabIndex = 26;
            this.SelectedRowFileCreated.Text = "Zeigt Erstelldatum an:";
            // 
            // SelectedRowFileChanged
            // 
            this.SelectedRowFileChanged.AutoSize = true;
            this.SelectedRowFileChanged.Location = new System.Drawing.Point(55, 110);
            this.SelectedRowFileChanged.Name = "SelectedRowFileChanged";
            this.SelectedRowFileChanged.Size = new System.Drawing.Size(162, 13);
            this.SelectedRowFileChanged.TabIndex = 27;
            this.SelectedRowFileChanged.Text = "Zeigt letztes Änderungsdatum an";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Button_Clipboard);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.SelectedRowFileChanged);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.SelectedRow);
            this.panel1.Controls.Add(this.SelectedRowFileCreated);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.SelectedRowFileSize);
            this.panel1.Controls.Add(this.SelectedRowPath);
            this.panel1.Location = new System.Drawing.Point(11, 227);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 189);
            this.panel1.TabIndex = 28;
            this.panel1.Visible = false;
            // 
            // Button_Clipboard
            // 
            this.Button_Clipboard.Location = new System.Drawing.Point(160, 152);
            this.Button_Clipboard.Name = "Button_Clipboard";
            this.Button_Clipboard.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Button_Clipboard.Size = new System.Drawing.Size(131, 23);
            this.Button_Clipboard.TabIndex = 34;
            this.Button_Clipboard.Text = "in Zwischenablage";
            this.Button_Clipboard.UseVisualStyleBackColor = true;
            this.Button_Clipboard.Click += new System.EventHandler(this.Button_Clipboard_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(-3, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "geändert:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-3, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-3, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "erstellt:";
            // 
            // SelectedRow
            // 
            this.SelectedRow.AutoSize = true;
            this.SelectedRow.Location = new System.Drawing.Point(55, 136);
            this.SelectedRow.Name = "SelectedRow";
            this.SelectedRow.Size = new System.Drawing.Size(123, 13);
            this.SelectedRow.TabIndex = 22;
            this.SelectedRow.Text = "Zeigt selektierte Zeile an";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-3, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Größe";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(15, 204);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(166, 17);
            this.checkBox2.TabIndex = 29;
            this.checkBox2.Text = "Detail-Informationen anzeigen";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBoxDetailInformation_CheckedChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(259, 84);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(46, 26);
            this.progressBar1.TabIndex = 30;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(980, 252);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.LabelSizeEnd);
            this.Controls.Add(this.LabelSizeStart);
            this.Controls.Add(this.textBox_Size_End);
            this.Controls.Add(this.textBox_Size_Start);
            this.Controls.Add(this.checkBoxSize);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Chosen_Folder_Label);
            this.Controls.Add(this.Chosen_Folder_Real);
            this.Controls.Add(this.datagrid_files);
            this.Controls.Add(this.folderdialog);
            this.Controls.Add(this.TextFeldContent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FileCount);
            this.Controls.Add(this.LabelGreeting);
            this.Controls.Add(this.btnHierKlicken);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "C - Search";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.SizeChangedAction);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_files)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHierKlicken;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label LabelGreeting;
        private System.Windows.Forms.Label FileCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label TextFeldContent;
        private System.Windows.Forms.FolderBrowserDialog Ordnersuche;
        private System.Windows.Forms.Button folderdialog;
        private System.Windows.Forms.DataGridView datagrid_files;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.LinkLabel Chosen_Folder_Real;
        private System.Windows.Forms.Label Chosen_Folder_Label;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBoxSize;
        private System.Windows.Forms.TextBox textBox_Size_Start;
        private System.Windows.Forms.TextBox textBox_Size_End;
        private System.Windows.Forms.Label LabelSizeStart;
        private System.Windows.Forms.Label LabelSizeEnd;
        private System.Windows.Forms.Label SelectedRowPath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label SelectedRowFileSize;
        private System.Windows.Forms.Label SelectedRowFileCreated;
        private System.Windows.Forms.Label SelectedRowFileChanged;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Button_Clipboard;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label SelectedRow;
    }
}

