using System;
using System.Windows.Forms;


namespace SuchFunktion
{
    
    public class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            
            
        }
    }
}
