namespace Toci.Training.Tournament.WojciechSeweryn
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
            this.participantLabel = new System.Windows.Forms.Label();
            this.participantNameTextBox = new System.Windows.Forms.TextBox();
            this.participantAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // participantLabel
            // 
            this.participantLabel.AutoSize = true;
            this.participantLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.participantLabel.Location = new System.Drawing.Point(12, 9);
            this.participantLabel.Name = "participantLabel";
            this.participantLabel.Size = new System.Drawing.Size(93, 20);
            this.participantLabel.TabIndex = 0;
            this.participantLabel.Text = "Uczestnik: ";
            // 
            // participantNameTextBox
            // 
            this.participantNameTextBox.Location = new System.Drawing.Point(111, 7);
            this.participantNameTextBox.Name = "participantNameTextBox";
            this.participantNameTextBox.Size = new System.Drawing.Size(175, 22);
            this.participantNameTextBox.TabIndex = 1;
            // 
            // participantAdd
            // 
            this.participantAdd.Location = new System.Drawing.Point(292, 6);
            this.participantAdd.Name = "participantAdd";
            this.participantAdd.Size = new System.Drawing.Size(121, 24);
            this.participantAdd.TabIndex = 2;
            this.participantAdd.Text = "Dodaj";
            this.participantAdd.UseVisualStyleBackColor = true;
            this.participantAdd.Click += new System.EventHandler(this.participantAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 439);
            this.Controls.Add(this.participantAdd);
            this.Controls.Add(this.participantNameTextBox);
            this.Controls.Add(this.participantLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label participantLabel;
        private System.Windows.Forms.TextBox participantNameTextBox;
        private System.Windows.Forms.Button participantAdd;
    }
}

