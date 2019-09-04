namespace YTLoader
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dlButton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progPercent = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.filename = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(85, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(320, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Video URL:";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // dlButton
            // 
            this.dlButton.Location = new System.Drawing.Point(12, 61);
            this.dlButton.Name = "dlButton";
            this.dlButton.Size = new System.Drawing.Size(109, 31);
            this.dlButton.TabIndex = 2;
            this.dlButton.Text = "&Download";
            this.dlButton.UseVisualStyleBackColor = true;
            this.dlButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(128, 62);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(250, 30);
            this.progressBar1.TabIndex = 3;
            this.progressBar1.Click += new System.EventHandler(this.ProgressBar1_Click);
            // 
            // progPercent
            // 
            this.progPercent.AutoSize = true;
            this.progPercent.BackColor = System.Drawing.Color.Transparent;
            this.progPercent.Location = new System.Drawing.Point(384, 70);
            this.progPercent.Name = "progPercent";
            this.progPercent.Size = new System.Drawing.Size(21, 13);
            this.progPercent.TabIndex = 4;
            this.progPercent.Text = "0%";
            this.progPercent.Click += new System.EventHandler(this.Label2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(85, 32);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(320, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // filename
            // 
            this.filename.AutoSize = true;
            this.filename.Location = new System.Drawing.Point(12, 35);
            this.filename.Name = "filename";
            this.filename.Size = new System.Drawing.Size(52, 13);
            this.filename.TabIndex = 1;
            this.filename.Text = "Filename:";
            this.filename.Click += new System.EventHandler(this.Label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 106);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.progPercent);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.dlButton);
            this.Controls.Add(this.filename);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "YT MP3 Downloader";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button dlButton;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label progPercent;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label filename;
    }
}

