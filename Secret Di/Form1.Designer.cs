
namespace Secret_Di
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btsave = new System.Windows.Forms.Button();
            this.btopen = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.cbDict = new System.Windows.Forms.ComboBox();
            this.lbfile = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 375);
            this.panel1.TabIndex = 0;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(776, 375);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // btsave
            // 
            this.btsave.Location = new System.Drawing.Point(695, 411);
            this.btsave.Name = "btsave";
            this.btsave.Size = new System.Drawing.Size(93, 27);
            this.btsave.TabIndex = 1;
            this.btsave.Text = "Save";
            this.btsave.UseVisualStyleBackColor = true;
            this.btsave.Click += new System.EventHandler(this.btsave_Click);
            // 
            // btopen
            // 
            this.btopen.Location = new System.Drawing.Point(593, 411);
            this.btopen.Name = "btopen";
            this.btopen.Size = new System.Drawing.Size(96, 28);
            this.btopen.TabIndex = 2;
            this.btopen.Text = "Open";
            this.btopen.UseVisualStyleBackColor = true;
            this.btopen.Click += new System.EventHandler(this.btopen_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // cbDict
            // 
            this.cbDict.FormattingEnabled = true;
            this.cbDict.Location = new System.Drawing.Point(12, 415);
            this.cbDict.Name = "cbDict";
            this.cbDict.Size = new System.Drawing.Size(163, 21);
            this.cbDict.TabIndex = 3;
            this.cbDict.SelectedIndexChanged += new System.EventHandler(this.cbDict_SelectedIndexChanged);
            // 
            // lbfile
            // 
            this.lbfile.AutoSize = true;
            this.lbfile.Location = new System.Drawing.Point(21, 6);
            this.lbfile.MaximumSize = new System.Drawing.Size(154, 18);
            this.lbfile.Name = "lbfile";
            this.lbfile.Size = new System.Drawing.Size(52, 13);
            this.lbfile.TabIndex = 4;
            this.lbfile.Text = "File name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbfile);
            this.Controls.Add(this.cbDict);
            this.Controls.Add(this.btopen);
            this.Controls.Add(this.btsave);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btsave;
        private System.Windows.Forms.Button btopen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox cbDict;
        private System.Windows.Forms.Label lbfile;
    }
}

