using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Encryption_Program;

namespace Encryption_Program_Interface
{
    public partial class Form1 : Form
    {
        private Encryption encrypter;
        private ArrayList directories;
        public Form1()
        {
            encrypter = new Encryption("");
            directories = new ArrayList();
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            encrypter.sentence = textBox1.Text;
            string output;
            if (encryptButton.Checked)
            {
                output = encrypter.Encrypt();
            }
            else
            {
                output = encrypter.Decrypt();
                if (encrypter.LastErrors > 0)
                {
                    comboBox1.SelectedItem = encrypter.Find();
                    output = encrypter.Decrypt();
                }
            }
            outputLabel.Text = output;
            if (output != null && output != "" && checkBox1.Checked)
            {
                Clipboard.SetText(outputLabel.Text);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkBox1.Checked = Properties.Settings.Default.autocopy;
            SetDicts();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.autocopy = checkBox1.Checked;
            Properties.Settings.Default.Save();
        }

        private void labelofftimer_Tick(object sender, EventArgs e)
        {
            copylabel.Visible = false;
            labelofftimer.Stop();
        }

        private void outputLabel_DoubleClick(object sender, EventArgs e)
        {
            if (outputLabel.Text != "")
            {
                Clipboard.SetText(outputLabel.Text);
            }
            copylabel.Visible = true;
            labelofftimer.Start();
        }

        private void encryptButton_CheckedChanged(object sender, EventArgs e)
        {
            encrypter.sentence = textBox1.Text;
            outputLabel.Text = encrypter.Encrypt();
        }

        private void decryptButton_CheckedChanged(object sender, EventArgs e)
        {
            encrypter.sentence = textBox1.Text;
            outputLabel.Text = encrypter.Decrypt();
        }

        private void SetDicts()
        {

            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(encrypter.ScanLang());
            if (comboBox1.Items.Contains(Properties.Settings.Default.dictionary))
            {
                comboBox1.SelectedItem = Properties.Settings.Default.dictionary;
            }
            else if (comboBox1.Items.Count > 0)
            {
                comboBox1.SelectedIndex = 0;
            }
        }

        private string Changedict(string dict)
        {
            if (comboBox1.Items.Contains(dict))
            {
                encrypter.ChangeDict(Convert.ToString(comboBox1.SelectedItem));
                Properties.Settings.Default.dictionary = dict;
                Properties.Settings.Default.Save();
                return dict;
            }
            else if (comboBox1.Items.Count > 0)
            {
                Properties.Settings.Default.dictionary = Convert.ToString(comboBox1.SelectedItem);
                Properties.Settings.Default.Save();
                return Convert.ToString(comboBox1.SelectedItem);
            }
            else
            {
                return null;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Changedict(Convert.ToString(comboBox1.SelectedItem));
            if (encryptButton.Checked)
            {
                outputLabel.Text = encrypter.Encrypt();
            }
            else
            {
                outputLabel.Text = encrypter.Decrypt();
            }
        }
        private void Scroller_scroll(object sender, ScrollEventArgs e)
        {
            return;
        }
    }
}
