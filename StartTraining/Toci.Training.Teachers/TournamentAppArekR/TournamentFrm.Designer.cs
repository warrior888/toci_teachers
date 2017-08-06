namespace TournamentAppArekR
{
    partial class TournamentFrm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTrnmtScore = new System.Windows.Forms.DataGridView();
            this.Gracz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Drużyna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Punkty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtAddUser = new System.Windows.Forms.TextBox();
            this.lblEnterNewPlayer = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numNumberOfPlayers = new System.Windows.Forms.NumericUpDown();
            this.btnNumberOfPlayers = new System.Windows.Forms.Button();
            this.btnStartTournament = new System.Windows.Forms.Button();
            this.btnGetDuell = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrnmtScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNumberOfPlayers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.Orange;
            this.btnAddUser.Enabled = false;
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Location = new System.Drawing.Point(143, 95);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(75, 23);
            this.btnAddUser.TabIndex = 0;
            this.btnAddUser.Text = "Dodaj";
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tabela wyników";
            // 
            // dgvTrnmtScore
            // 
            this.dgvTrnmtScore.AllowUserToAddRows = false;
            this.dgvTrnmtScore.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvTrnmtScore.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTrnmtScore.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTrnmtScore.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvTrnmtScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrnmtScore.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Gracz,
            this.Drużyna,
            this.Punkty});
            this.dgvTrnmtScore.Location = new System.Drawing.Point(12, 238);
            this.dgvTrnmtScore.Name = "dgvTrnmtScore";
            this.dgvTrnmtScore.Size = new System.Drawing.Size(481, 345);
            this.dgvTrnmtScore.TabIndex = 2;
            // 
            // Gracz
            // 
            this.Gracz.HeaderText = "Gracz";
            this.Gracz.Name = "Gracz";
            // 
            // Drużyna
            // 
            this.Drużyna.HeaderText = "Drużyna";
            this.Drużyna.Name = "Drużyna";
            // 
            // Punkty
            // 
            this.Punkty.HeaderText = "Punkty";
            this.Punkty.Name = "Punkty";
            // 
            // txtAddUser
            // 
            this.txtAddUser.Enabled = false;
            this.txtAddUser.Location = new System.Drawing.Point(12, 96);
            this.txtAddUser.Name = "txtAddUser";
            this.txtAddUser.Size = new System.Drawing.Size(122, 20);
            this.txtAddUser.TabIndex = 3;
            this.txtAddUser.TextChanged += new System.EventHandler(this.txtAddUser_TextChanged);
            this.txtAddUser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAddUser_KeyDown);
            // 
            // lblEnterNewPlayer
            // 
            this.lblEnterNewPlayer.AutoSize = true;
            this.lblEnterNewPlayer.Location = new System.Drawing.Point(12, 80);
            this.lblEnterNewPlayer.Name = "lblEnterNewPlayer";
            this.lblEnterNewPlayer.Size = new System.Drawing.Size(114, 13);
            this.lblEnterNewPlayer.TabIndex = 4;
            this.lblEnterNewPlayer.Text = "Wprowadź imię gracza";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Wprowadź ilość graczy";
            // 
            // numNumberOfPlayers
            // 
            this.numNumberOfPlayers.Increment = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numNumberOfPlayers.Location = new System.Drawing.Point(15, 30);
            this.numNumberOfPlayers.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numNumberOfPlayers.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numNumberOfPlayers.Name = "numNumberOfPlayers";
            this.numNumberOfPlayers.Size = new System.Drawing.Size(50, 20);
            this.numNumberOfPlayers.TabIndex = 6;
            this.numNumberOfPlayers.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // btnNumberOfPlayers
            // 
            this.btnNumberOfPlayers.BackColor = System.Drawing.Color.DarkOrange;
            this.btnNumberOfPlayers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNumberOfPlayers.Location = new System.Drawing.Point(70, 29);
            this.btnNumberOfPlayers.Name = "btnNumberOfPlayers";
            this.btnNumberOfPlayers.Size = new System.Drawing.Size(75, 23);
            this.btnNumberOfPlayers.TabIndex = 7;
            this.btnNumberOfPlayers.Text = "OK";
            this.btnNumberOfPlayers.UseVisualStyleBackColor = false;
            this.btnNumberOfPlayers.Click += new System.EventHandler(this.btnNumberOfPlayers_Click);
            // 
            // btnStartTournament
            // 
            this.btnStartTournament.BackColor = System.Drawing.Color.LimeGreen;
            this.btnStartTournament.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartTournament.Location = new System.Drawing.Point(12, 153);
            this.btnStartTournament.Name = "btnStartTournament";
            this.btnStartTournament.Size = new System.Drawing.Size(206, 23);
            this.btnStartTournament.TabIndex = 8;
            this.btnStartTournament.Text = "Rozpocznij turniej";
            this.btnStartTournament.UseVisualStyleBackColor = false;
            this.btnStartTournament.Visible = false;
            this.btnStartTournament.Click += new System.EventHandler(this.btnStartTournament_Click);
            // 
            // btnGetDuell
            // 
            this.btnGetDuell.Location = new System.Drawing.Point(530, 94);
            this.btnGetDuell.Name = "btnGetDuell";
            this.btnGetDuell.Size = new System.Drawing.Size(75, 23);
            this.btnGetDuell.TabIndex = 9;
            this.btnGetDuell.Text = "Pojedynek";
            this.btnGetDuell.UseVisualStyleBackColor = true;
            this.btnGetDuell.Click += new System.EventHandler(this.btnGetDuell_Click);
            // 
            // Tournament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 595);
            this.Controls.Add(this.btnGetDuell);
            this.Controls.Add(this.btnStartTournament);
            this.Controls.Add(this.btnNumberOfPlayers);
            this.Controls.Add(this.numNumberOfPlayers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblEnterNewPlayer);
            this.Controls.Add(this.txtAddUser);
            this.Controls.Add(this.dgvTrnmtScore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddUser);
            this.Name = "Tournament";
            this.Text = "Toci Tournament";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrnmtScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNumberOfPlayers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTrnmtScore;
        private System.Windows.Forms.TextBox txtAddUser;
        private System.Windows.Forms.Label lblEnterNewPlayer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gracz;
        private System.Windows.Forms.DataGridViewTextBoxColumn Drużyna;
        private System.Windows.Forms.DataGridViewTextBoxColumn Punkty;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numNumberOfPlayers;
        private System.Windows.Forms.Button btnNumberOfPlayers;
        private System.Windows.Forms.Button btnStartTournament;
        private System.Windows.Forms.Button btnGetDuell;
    }
}

