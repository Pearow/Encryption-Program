using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Encryption_Program_Interface
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (!File.Exists("./Dicts"))
            {
                Directory.CreateDirectory("./Dicts");
            }
            if (Directory.GetFiles("./Dicts").Length == 0)
            {
                DialogResult inf = MessageBox.Show("No language file found! Do you want to choose?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (inf == DialogResult.Yes)
                {
                    OpenFileDialog dialog = new OpenFileDialog();
                    dialog.Filter = "*.txt|";
                    dialog.DefaultExt = ".txt";
                    DialogResult path = dialog.ShowDialog();
                    if (dialog.FileName.EndsWith("txt"))
                    {
                        File.Copy(dialog.FileName, $"./dicts/{dialog.SafeFileName}");
                    }
                }
                else
                {
                    return;
                }
            }
            Application.Run(new Form1());
        }
    }
}
