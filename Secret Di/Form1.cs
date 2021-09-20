using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Encryption_Program;
using System.IO;

namespace Secret_Di
{
    public partial class Form1 : Form
    {
        Encryption Encryptor;
        StreamReader file;
        public Form1()
        {
            InitializeComponent();
            Encryptor = new Encryption("");
            cbDict.Items.AddRange(Encryptor.ScanLang());
            if (!string.IsNullOrEmpty(Settings1.Default.Dict))
            {
                cbDict.SelectedItem = Settings1.Default.Dict;

            }
            else
            {
                cbDict.SelectedIndex = 0;
                Settings1.Default.Dict = cbDict.Items[0].ToString();
            }
            ReadF(Settings1.Default.lastpath);
        }

        async private void ReadF(string path)
        {
            if (file != null)
            {
                file.Close();
            }
            file = new StreamReader(path);
            try
            {
                Encryptor.sentence = await file.ReadToEndAsync();
            }
            catch (FileNotFoundException) { return; }
            Settings1.Default.lastpath = path;
            cbDict.SelectedItem = Encryptor.Find();
            richTextBox1.Text = Encryptor.Decrypt();
            lbfile.Text = path.Split('\\').Last();
        }

        async private void Save()
        {
            string path = Settings1.Default.lastpath;
            string data_raw = richTextBox1.Text;
            Encryptor.sentence = data_raw;
            string data = Encryptor.Encrypt();
            File.SetCreationTime(path, new DateTime(2003, 6, 26));
            if (file != null)
            {
                file.Close();
            }

            using (StreamWriter writer = new StreamWriter(path))
            {
                await writer.WriteAsync(data);
                await writer.FlushAsync();
                writer.Close();
            }
            ReadF(path);
        }

        private void btsave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void cbDict_SelectedIndexChanged(object sender, EventArgs e)
        {
            Encryptor.ChangeDict(cbDict.SelectedItem.ToString());
            Settings1.Default.Dict = cbDict.SelectedItem.ToString();
        }

        private void btopen_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string path = openFileDialog1.FileName;
            if (!string.IsNullOrEmpty(path))
            {
                ReadF(path);
                Settings1.Default.Dict = path;
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings1.Default.Save();
        }
    }
}
