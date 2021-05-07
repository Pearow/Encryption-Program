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

namespace Encryption_Program_Interface
{
    public partial class Form1 : Form
    {
        private Encryption encrypter;
        public Form1()
        {
            encrypter = new Encryption("", "Dangerous DONOTUSE");
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
            }
            outputLabel.Text = output;
            if (output != null && output != "" && checkBox1.Checked)
            {
                Clipboard.SetText(outputLabel.Text);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
        }

    }
}
