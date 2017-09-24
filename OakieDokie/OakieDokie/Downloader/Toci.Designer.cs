namespace Downloader
{
    partial class Toci
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.complateLabel = new System.Windows.Forms.Label();
            this.instalJoinMeButton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Pobierz joinMe";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(507, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "Pobierz mumble";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(157, 89);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(253, 16);
            this.progressBar1.TabIndex = 2;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // complateLabel
            // 
            this.complateLabel.AutoSize = true;
            this.complateLabel.Location = new System.Drawing.Point(278, 73);
            this.complateLabel.Name = "complateLabel";
            this.complateLabel.Size = new System.Drawing.Size(51, 13);
            this.complateLabel.TabIndex = 4;
            this.complateLabel.Text = "Compleat";
            this.complateLabel.Visible = false;
            // 
            // instalJoinMeButton
            // 
            this.instalJoinMeButton.Location = new System.Drawing.Point(118, 12);
            this.instalJoinMeButton.Name = "instalJoinMeButton";
            this.instalJoinMeButton.Size = new System.Drawing.Size(100, 40);
            this.instalJoinMeButton.TabIndex = 5;
            this.instalJoinMeButton.Text = "Instaluj joinMe";
            this.instalJoinMeButton.UseVisualStyleBackColor = true;
            this.instalJoinMeButton.Click += new System.EventHandler(this.instalJoinMeButton_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(401, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 40);
            this.button4.TabIndex = 6;
            this.button4.Text = "Instaluj mumble";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pobieranie";
            // 
            // Toci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 134);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.instalJoinMeButton);
            this.Controls.Add(this.complateLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Toci";
            this.Text = "Toci Oakie Dokie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label complateLabel;
        private System.Windows.Forms.Button instalJoinMeButton;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
    }
}

