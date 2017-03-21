namespace hamsterpajPostDownload
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
            this.GetPost = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Agelbl13 = new System.Windows.Forms.Label();
            this.Agelbl11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Pages = new System.Windows.Forms.Label();
            this.numPagesTextBox = new System.Windows.Forms.TextBox();
            this.TeamSpeak = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GetPost
            // 
            this.GetPost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GetPost.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.GetPost.Location = new System.Drawing.Point(269, 313);
            this.GetPost.Name = "GetPost";
            this.GetPost.Size = new System.Drawing.Size(236, 80);
            this.GetPost.TabIndex = 0;
            this.GetPost.Text = "Get Post";
            this.GetPost.UseVisualStyleBackColor = true;
            this.GetPost.Click += new System.EventHandler(this.GetPost_Click);
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(251, 381);
            this.listBox1.TabIndex = 1;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // Agelbl13
            // 
            this.Agelbl13.AutoSize = true;
            this.Agelbl13.Location = new System.Drawing.Point(297, 282);
            this.Agelbl13.Name = "Agelbl13";
            this.Agelbl13.Size = new System.Drawing.Size(13, 13);
            this.Agelbl13.TabIndex = 2;
            this.Agelbl13.Text = "0";
            // 
            // Agelbl11
            // 
            this.Agelbl11.AutoSize = true;
            this.Agelbl11.Location = new System.Drawing.Point(297, 295);
            this.Agelbl11.Name = "Agelbl11";
            this.Agelbl11.Size = new System.Drawing.Size(13, 13);
            this.Agelbl11.TabIndex = 3;
            this.Agelbl11.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "11:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "13:";
            // 
            // Pages
            // 
            this.Pages.AutoSize = true;
            this.Pages.Location = new System.Drawing.Point(275, 12);
            this.Pages.Name = "Pages";
            this.Pages.Size = new System.Drawing.Size(35, 13);
            this.Pages.TabIndex = 6;
            this.Pages.Text = "label3";
            // 
            // numPagesTextBox
            // 
            this.numPagesTextBox.Location = new System.Drawing.Point(347, 9);
            this.numPagesTextBox.Name = "numPagesTextBox";
            this.numPagesTextBox.Size = new System.Drawing.Size(100, 20);
            this.numPagesTextBox.TabIndex = 8;
            // 
            // TeamSpeak
            // 
            this.TeamSpeak.Location = new System.Drawing.Point(351, 164);
            this.TeamSpeak.Name = "TeamSpeak";
            this.TeamSpeak.Size = new System.Drawing.Size(75, 23);
            this.TeamSpeak.TabIndex = 9;
            this.TeamSpeak.Text = "button1";
            this.TeamSpeak.UseVisualStyleBackColor = true;
            this.TeamSpeak.Click += new System.EventHandler(this.TeamSpeak_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 410);
            this.Controls.Add(this.TeamSpeak);
            this.Controls.Add(this.numPagesTextBox);
            this.Controls.Add(this.Pages);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Agelbl11);
            this.Controls.Add(this.Agelbl13);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.GetPost);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GetPost;
        private System.Windows.Forms.ListBox listBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label Agelbl13;
        private System.Windows.Forms.Label Agelbl11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Pages;
        private System.Windows.Forms.TextBox numPagesTextBox;
        private System.Windows.Forms.Button TeamSpeak;
    }
}

