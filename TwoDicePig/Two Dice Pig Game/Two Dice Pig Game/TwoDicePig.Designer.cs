namespace Two_Dice_Pig_Game
{
    partial class frmTwoDicePig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTwoDicePig));
            this.gbPig = new System.Windows.Forms.GroupBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.txtP1GameScore = new System.Windows.Forms.TextBox();
            this.txtP1TurnTotal = new System.Windows.Forms.TextBox();
            this.lblP1GameScore = new System.Windows.Forms.Label();
            this.lblP1TurnTotal = new System.Windows.Forms.Label();
            this.btnP1Hold = new System.Windows.Forms.Button();
            this.btnP1Play = new System.Windows.Forms.Button();
            this.txtP2GameScore = new System.Windows.Forms.TextBox();
            this.txtP2TurnTotal = new System.Windows.Forms.TextBox();
            this.lbP2GameScore = new System.Windows.Forms.Label();
            this.lblP2TurnTotal = new System.Windows.Forms.Label();
            this.btnP2Hold = new System.Windows.Forms.Button();
            this.btnP2Play = new System.Windows.Forms.Button();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.pbDice2 = new System.Windows.Forms.PictureBox();
            this.pbDice1 = new System.Windows.Forms.PictureBox();
            this.gbPig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDice2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDice1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbPig
            // 
            this.gbPig.BackColor = System.Drawing.Color.MediumAquamarine;
            this.gbPig.Controls.Add(this.lblInfo);
            this.gbPig.Controls.Add(this.lblTitle);
            this.gbPig.Controls.Add(this.btnNewGame);
            this.gbPig.Controls.Add(this.txtP1GameScore);
            this.gbPig.Controls.Add(this.txtP1TurnTotal);
            this.gbPig.Controls.Add(this.lblP1GameScore);
            this.gbPig.Controls.Add(this.lblP1TurnTotal);
            this.gbPig.Controls.Add(this.btnP1Hold);
            this.gbPig.Controls.Add(this.btnP1Play);
            this.gbPig.Controls.Add(this.txtP2GameScore);
            this.gbPig.Controls.Add(this.txtP2TurnTotal);
            this.gbPig.Controls.Add(this.lbP2GameScore);
            this.gbPig.Controls.Add(this.lblP2TurnTotal);
            this.gbPig.Controls.Add(this.btnP2Hold);
            this.gbPig.Controls.Add(this.btnP2Play);
            this.gbPig.Controls.Add(this.lblPlayer2);
            this.gbPig.Controls.Add(this.lblPlayer1);
            this.gbPig.Controls.Add(this.pbDice2);
            this.gbPig.Controls.Add(this.pbDice1);
            this.gbPig.Location = new System.Drawing.Point(12, 26);
            this.gbPig.Name = "gbPig";
            this.gbPig.Size = new System.Drawing.Size(1046, 697);
            this.gbPig.TabIndex = 1;
            this.gbPig.TabStop = false;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(442, 91);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 25);
            this.lblInfo.TabIndex = 24;
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("MV Boli", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(395, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(245, 44);
            this.lblTitle.TabIndex = 23;
            this.lblTitle.Text = "Two Dice Pig!";
            // 
            // btnNewGame
            // 
            this.btnNewGame.BackColor = System.Drawing.Color.LightCoral;
            this.btnNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGame.Location = new System.Drawing.Point(434, 580);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(134, 70);
            this.btnNewGame.TabIndex = 4;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = false;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // txtP1GameScore
            // 
            this.txtP1GameScore.Enabled = false;
            this.txtP1GameScore.ForeColor = System.Drawing.Color.Black;
            this.txtP1GameScore.Location = new System.Drawing.Point(246, 443);
            this.txtP1GameScore.Name = "txtP1GameScore";
            this.txtP1GameScore.ReadOnly = true;
            this.txtP1GameScore.Size = new System.Drawing.Size(100, 22);
            this.txtP1GameScore.TabIndex = 1;
            // 
            // txtP1TurnTotal
            // 
            this.txtP1TurnTotal.Enabled = false;
            this.txtP1TurnTotal.ForeColor = System.Drawing.Color.Black;
            this.txtP1TurnTotal.Location = new System.Drawing.Point(246, 384);
            this.txtP1TurnTotal.Name = "txtP1TurnTotal";
            this.txtP1TurnTotal.ReadOnly = true;
            this.txtP1TurnTotal.Size = new System.Drawing.Size(100, 22);
            this.txtP1TurnTotal.TabIndex = 0;
            // 
            // lblP1GameScore
            // 
            this.lblP1GameScore.AutoSize = true;
            this.lblP1GameScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP1GameScore.Location = new System.Drawing.Point(106, 439);
            this.lblP1GameScore.Name = "lblP1GameScore";
            this.lblP1GameScore.Size = new System.Drawing.Size(122, 25);
            this.lblP1GameScore.TabIndex = 10;
            this.lblP1GameScore.Text = "Game Score";
            // 
            // lblP1TurnTotal
            // 
            this.lblP1TurnTotal.AutoSize = true;
            this.lblP1TurnTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP1TurnTotal.Location = new System.Drawing.Point(126, 384);
            this.lblP1TurnTotal.Name = "lblP1TurnTotal";
            this.lblP1TurnTotal.Size = new System.Drawing.Size(102, 25);
            this.lblP1TurnTotal.TabIndex = 6;
            this.lblP1TurnTotal.Text = "Turn Total";
            // 
            // btnP1Hold
            // 
            this.btnP1Hold.BackColor = System.Drawing.Color.ForestGreen;
            this.btnP1Hold.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnP1Hold.Location = new System.Drawing.Point(244, 498);
            this.btnP1Hold.Name = "btnP1Hold";
            this.btnP1Hold.Size = new System.Drawing.Size(124, 55);
            this.btnP1Hold.TabIndex = 3;
            this.btnP1Hold.Text = "Hold";
            this.btnP1Hold.UseVisualStyleBackColor = false;
            this.btnP1Hold.Click += new System.EventHandler(this.btnP1Hold_Click);
            // 
            // btnP1Play
            // 
            this.btnP1Play.BackColor = System.Drawing.Color.ForestGreen;
            this.btnP1Play.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnP1Play.Location = new System.Drawing.Point(104, 498);
            this.btnP1Play.Name = "btnP1Play";
            this.btnP1Play.Size = new System.Drawing.Size(124, 55);
            this.btnP1Play.TabIndex = 2;
            this.btnP1Play.Text = "Play";
            this.btnP1Play.UseVisualStyleBackColor = false;
            this.btnP1Play.Click += new System.EventHandler(this.btnP1Play_Click);
            // 
            // txtP2GameScore
            // 
            this.txtP2GameScore.Enabled = false;
            this.txtP2GameScore.ForeColor = System.Drawing.Color.Black;
            this.txtP2GameScore.Location = new System.Drawing.Point(768, 443);
            this.txtP2GameScore.Name = "txtP2GameScore";
            this.txtP2GameScore.ReadOnly = true;
            this.txtP2GameScore.Size = new System.Drawing.Size(100, 22);
            this.txtP2GameScore.TabIndex = 6;
            // 
            // txtP2TurnTotal
            // 
            this.txtP2TurnTotal.Enabled = false;
            this.txtP2TurnTotal.ForeColor = System.Drawing.Color.Black;
            this.txtP2TurnTotal.Location = new System.Drawing.Point(768, 384);
            this.txtP2TurnTotal.Name = "txtP2TurnTotal";
            this.txtP2TurnTotal.ReadOnly = true;
            this.txtP2TurnTotal.Size = new System.Drawing.Size(100, 22);
            this.txtP2TurnTotal.TabIndex = 5;
            // 
            // lbP2GameScore
            // 
            this.lbP2GameScore.AutoSize = true;
            this.lbP2GameScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbP2GameScore.Location = new System.Drawing.Point(628, 439);
            this.lbP2GameScore.Name = "lbP2GameScore";
            this.lbP2GameScore.Size = new System.Drawing.Size(122, 25);
            this.lbP2GameScore.TabIndex = 12;
            this.lbP2GameScore.Text = "Game Score";
            // 
            // lblP2TurnTotal
            // 
            this.lblP2TurnTotal.AutoSize = true;
            this.lblP2TurnTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP2TurnTotal.Location = new System.Drawing.Point(648, 384);
            this.lblP2TurnTotal.Name = "lblP2TurnTotal";
            this.lblP2TurnTotal.Size = new System.Drawing.Size(102, 25);
            this.lblP2TurnTotal.TabIndex = 8;
            this.lblP2TurnTotal.Text = "Turn Total";
            // 
            // btnP2Hold
            // 
            this.btnP2Hold.BackColor = System.Drawing.Color.ForestGreen;
            this.btnP2Hold.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnP2Hold.Location = new System.Drawing.Point(763, 498);
            this.btnP2Hold.Name = "btnP2Hold";
            this.btnP2Hold.Size = new System.Drawing.Size(124, 55);
            this.btnP2Hold.TabIndex = 7;
            this.btnP2Hold.Text = "Hold";
            this.btnP2Hold.UseVisualStyleBackColor = false;
            this.btnP2Hold.Click += new System.EventHandler(this.btnP2Hold_Click);
            // 
            // btnP2Play
            // 
            this.btnP2Play.BackColor = System.Drawing.Color.ForestGreen;
            this.btnP2Play.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnP2Play.Location = new System.Drawing.Point(626, 498);
            this.btnP2Play.Name = "btnP2Play";
            this.btnP2Play.Size = new System.Drawing.Size(124, 55);
            this.btnP2Play.TabIndex = 6;
            this.btnP2Play.Text = "Play";
            this.btnP2Play.UseVisualStyleBackColor = false;
            this.btnP2Play.Click += new System.EventHandler(this.btnP2Play_Click);
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.AutoSize = true;
            this.lblPlayer2.Font = new System.Drawing.Font("MV Boli", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer2.Location = new System.Drawing.Point(678, 337);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(138, 37);
            this.lblPlayer2.TabIndex = 5;
            this.lblPlayer2.Text = "Player 2";
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.AutoSize = true;
            this.lblPlayer1.Font = new System.Drawing.Font("MV Boli", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1.Location = new System.Drawing.Point(195, 337);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(130, 37);
            this.lblPlayer1.TabIndex = 4;
            this.lblPlayer1.Text = "Player 1";
            // 
            // pbDice2
            // 
            this.pbDice2.Location = new System.Drawing.Point(570, 139);
            this.pbDice2.Name = "pbDice2";
            this.pbDice2.Size = new System.Drawing.Size(128, 128);
            this.pbDice2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbDice2.TabIndex = 1;
            this.pbDice2.TabStop = false;
            // 
            // pbDice1
            // 
            this.pbDice1.Location = new System.Drawing.Point(336, 139);
            this.pbDice1.Name = "pbDice1";
            this.pbDice1.Size = new System.Drawing.Size(128, 128);
            this.pbDice1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbDice1.TabIndex = 0;
            this.pbDice1.TabStop = false;
            // 
            // frmTwoDicePig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1070, 754);
            this.Controls.Add(this.gbPig);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTwoDicePig";
            this.Text = "Two Dice Pig Game";
            this.gbPig.ResumeLayout(false);
            this.gbPig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDice2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDice1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPig;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.TextBox txtP1GameScore;
        private System.Windows.Forms.TextBox txtP1TurnTotal;
        private System.Windows.Forms.Label lblP1GameScore;
        private System.Windows.Forms.Label lblP1TurnTotal;
        private System.Windows.Forms.Button btnP1Hold;
        private System.Windows.Forms.Button btnP1Play;
        private System.Windows.Forms.TextBox txtP2GameScore;
        private System.Windows.Forms.TextBox txtP2TurnTotal;
        private System.Windows.Forms.Label lbP2GameScore;
        private System.Windows.Forms.Label lblP2TurnTotal;
        private System.Windows.Forms.Button btnP2Hold;
        private System.Windows.Forms.Button btnP2Play;
        private System.Windows.Forms.Label lblPlayer2;
        private System.Windows.Forms.Label lblPlayer1;
        private System.Windows.Forms.PictureBox pbDice2;
        private System.Windows.Forms.PictureBox pbDice1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblInfo;
    }
}

