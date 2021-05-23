
namespace Encryption_Program_Interface
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.encryptButton = new System.Windows.Forms.RadioButton();
            this.decryptButton = new System.Windows.Forms.RadioButton();
            this.copylabel = new System.Windows.Forms.Label();
            this.labelofftimer = new System.Windows.Forms.Timer(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.main_panel = new System.Windows.Forms.Panel();
            this.outputLabel = new System.Windows.Forms.Label();
            this.main_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.AllowDrop = true;
            this.textBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox1.Location = new System.Drawing.Point(12, 158);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(520, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.checkBox1.Location = new System.Drawing.Point(478, 187);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(54, 19);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Copy";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // encryptButton
            // 
            this.encryptButton.AutoSize = true;
            this.encryptButton.Checked = true;
            this.encryptButton.Location = new System.Drawing.Point(12, 204);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(65, 19);
            this.encryptButton.TabIndex = 3;
            this.encryptButton.TabStop = true;
            this.encryptButton.Text = "Encrypt";
            this.encryptButton.UseVisualStyleBackColor = true;
            this.encryptButton.CheckedChanged += new System.EventHandler(this.encryptButton_CheckedChanged);
            // 
            // decryptButton
            // 
            this.decryptButton.AutoSize = true;
            this.decryptButton.Location = new System.Drawing.Point(12, 229);
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(66, 19);
            this.decryptButton.TabIndex = 4;
            this.decryptButton.Text = "Decrypt";
            this.decryptButton.UseVisualStyleBackColor = true;
            this.decryptButton.CheckedChanged += new System.EventHandler(this.decryptButton_CheckedChanged);
            // 
            // copylabel
            // 
            this.copylabel.AutoSize = true;
            this.copylabel.BackColor = System.Drawing.Color.Transparent;
            this.copylabel.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.copylabel.ForeColor = System.Drawing.Color.Lime;
            this.copylabel.Location = new System.Drawing.Point(126, 184);
            this.copylabel.Name = "copylabel";
            this.copylabel.Size = new System.Drawing.Size(266, 96);
            this.copylabel.TabIndex = 6;
            this.copylabel.Text = "Copied";
            this.copylabel.Visible = false;
            // 
            // labelofftimer
            // 
            this.labelofftimer.Interval = 700;
            this.labelofftimer.Tick += new System.EventHandler(this.labelofftimer_Tick);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(421, 257);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // main_panel
            // 
            this.main_panel.AutoScroll = true;
            this.main_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.main_panel.Controls.Add(this.outputLabel);
            this.main_panel.Location = new System.Drawing.Point(12, 12);
            this.main_panel.MaximumSize = new System.Drawing.Size(580, 4);
            this.main_panel.MinimumSize = new System.Drawing.Size(520, 140);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(520, 140);
            this.main_panel.TabIndex = 8;
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.BackColor = System.Drawing.Color.Transparent;
            this.outputLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.outputLabel.Location = new System.Drawing.Point(0, 0);
            this.outputLabel.MaximumSize = new System.Drawing.Size(495, 140);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(45, 15);
            this.outputLabel.TabIndex = 1;
            this.outputLabel.Text = "Output";
            this.outputLabel.DoubleClick += new System.EventHandler(this.outputLabel_DoubleClick);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(544, 281);
            this.Controls.Add(this.main_panel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.copylabel);
            this.Controls.Add(this.decryptButton);
            this.Controls.Add(this.encryptButton);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBox1);
            this.MinimumSize = new System.Drawing.Size(560, 320);
            this.Name = "Form1";
            this.Text = "Encryption Program";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.main_panel.ResumeLayout(false);
            this.main_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.RadioButton encryptButton;
        private System.Windows.Forms.RadioButton decryptButton;
        private System.Windows.Forms.Label copylabel;
        private System.Windows.Forms.Timer labelofftimer;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel main_panel;
        private System.Windows.Forms.Label outputLabel;
    }
}

