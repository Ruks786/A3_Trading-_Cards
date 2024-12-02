namespace A3_TradingCards
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
            lstPlayers = new ListBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            picPlayer = new PictureBox();
            lblName = new Label();
            lblTeam = new Label();
            lblRuns = new Label();
            lblWickets = new Label();
            lblStrikeRate = new Label();
            lblCatches = new Label();
            ((System.ComponentModel.ISupportInitialize)picPlayer).BeginInit();
            SuspendLayout();
            // 
            // lstPlayers
            // 
            lstPlayers.BackColor = SystemColors.ControlLight;
            lstPlayers.FormattingEnabled = true;
            lstPlayers.Location = new Point(12, 12);
            lstPlayers.Name = "lstPlayers";
            lstPlayers.Size = new Size(229, 424);
            lstPlayers.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.MintCream;
            btnAdd.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(12, 441);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.MintCream;
            btnUpdate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(121, 441);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.MintCream;
            btnDelete.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(71, 490);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // picPlayer
            // 
            picPlayer.Location = new Point(247, 12);
            picPlayer.Name = "picPlayer";
            picPlayer.Size = new Size(200, 200);
            picPlayer.SizeMode = PictureBoxSizeMode.StretchImage;
            picPlayer.TabIndex = 5;
            picPlayer.TabStop = false;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(248, 245);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 6;
            lblName.Text = "Name";
            // 
            // lblTeam
            // 
            lblTeam.AutoSize = true;
            lblTeam.Location = new Point(248, 277);
            lblTeam.Name = "lblTeam";
            lblTeam.Size = new Size(45, 20);
            lblTeam.TabIndex = 7;
            lblTeam.Text = "Team";
            // 
            // lblRuns
            // 
            lblRuns.AutoSize = true;
            lblRuns.Location = new Point(248, 311);
            lblRuns.Name = "lblRuns";
            lblRuns.Size = new Size(40, 20);
            lblRuns.TabIndex = 8;
            lblRuns.Text = "Runs";
            // 
            // lblWickets
            // 
            lblWickets.AutoSize = true;
            lblWickets.Location = new Point(248, 344);
            lblWickets.Name = "lblWickets";
            lblWickets.Size = new Size(60, 20);
            lblWickets.TabIndex = 9;
            lblWickets.Text = "Wickets";
            // 
            // lblStrikeRate
            // 
            lblStrikeRate.AutoSize = true;
            lblStrikeRate.Location = new Point(248, 377);
            lblStrikeRate.Name = "lblStrikeRate";
            lblStrikeRate.Size = new Size(76, 20);
            lblStrikeRate.TabIndex = 10;
            lblStrikeRate.Text = "StrikeRate";
            // 
            // lblCatches
            // 
            lblCatches.AutoSize = true;
            lblCatches.Location = new Point(248, 414);
            lblCatches.Name = "lblCatches";
            lblCatches.Size = new Size(60, 20);
            lblCatches.TabIndex = 11;
            lblCatches.Text = "Catches";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(580, 531);
            Controls.Add(lblCatches);
            Controls.Add(lblStrikeRate);
            Controls.Add(lblWickets);
            Controls.Add(lblRuns);
            Controls.Add(lblTeam);
            Controls.Add(lblName);
            Controls.Add(picPlayer);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(lstPlayers);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)picPlayer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstPlayers;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private PictureBox picPlayer;
        private Label lblName;
        private Label lblTeam;
        private Label lblRuns;
        private Label lblWickets;
        private Label lblStrikeRate;
        private Label lblCatches;
    }
}
