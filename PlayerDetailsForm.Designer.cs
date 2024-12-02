namespace A3_TradingCards
{
    partial class PlayerDetailsForm
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
            btnOK = new Button();
            txtName = new TextBox();
            txtTeam = new TextBox();
            txtRuns = new TextBox();
            txtWickets = new TextBox();
            txtStrikeRate = new TextBox();
            txtCatches = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // btnOK
            // 
            btnOK.Location = new Point(108, 299);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(94, 29);
            btnOK.TabIndex = 0;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(134, 26);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 1;
            // 
            // txtTeam
            // 
            txtTeam.Location = new Point(134, 71);
            txtTeam.Name = "txtTeam";
            txtTeam.Size = new Size(125, 27);
            txtTeam.TabIndex = 2;
            // 
            // txtRuns
            // 
            txtRuns.Location = new Point(134, 116);
            txtRuns.Name = "txtRuns";
            txtRuns.Size = new Size(125, 27);
            txtRuns.TabIndex = 3;
            // 
            // txtWickets
            // 
            txtWickets.Location = new Point(134, 161);
            txtWickets.Name = "txtWickets";
            txtWickets.Size = new Size(125, 27);
            txtWickets.TabIndex = 4;
            // 
            // txtStrikeRate
            // 
            txtStrikeRate.Location = new Point(134, 203);
            txtStrikeRate.Name = "txtStrikeRate";
            txtStrikeRate.Size = new Size(125, 27);
            txtStrikeRate.TabIndex = 5;
            // 
            // txtCatches
            // 
            txtCatches.Location = new Point(134, 250);
            txtCatches.Name = "txtCatches";
            txtCatches.Size = new Size(125, 27);
            txtCatches.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 33);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 7;
            label1.Text = "Name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 78);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 8;
            label2.Text = "Team :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 123);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 9;
            label3.Text = "Runs :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 168);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 10;
            label4.Text = "Wickets :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 210);
            label5.Name = "label5";
            label5.Size = new Size(87, 20);
            label5.TabIndex = 11;
            label5.Text = "Strike Rate :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(28, 257);
            label6.Name = "label6";
            label6.Size = new Size(67, 20);
            label6.TabIndex = 12;
            label6.Text = "Catches :";
            // 
            // PlayerDetailsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(422, 340);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtCatches);
            Controls.Add(txtStrikeRate);
            Controls.Add(txtWickets);
            Controls.Add(txtRuns);
            Controls.Add(txtTeam);
            Controls.Add(txtName);
            Controls.Add(btnOK);
            Name = "PlayerDetailsForm";
            Text = "PlayerDetailsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOK;
        private TextBox txtName;
        private TextBox txtTeam;
        private TextBox txtRuns;
        private TextBox txtWickets;
        private TextBox txtStrikeRate;
        private TextBox txtCatches;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}