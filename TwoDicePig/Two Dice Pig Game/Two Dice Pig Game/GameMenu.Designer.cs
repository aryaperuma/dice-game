namespace Two_Dice_Pig_Game
{
    partial class frmGameMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGameMenu));
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnMenuStartGame = new System.Windows.Forms.Button();
            this.btnMenuRules = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("MV Boli", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(60, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(848, 157);
            this.lblTitle.TabIndex = 24;
            this.lblTitle.Text = "Two Dice Pig!";
            // 
            // btnMenuStartGame
            // 
            this.btnMenuStartGame.BackColor = System.Drawing.Color.LightCoral;
            this.btnMenuStartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuStartGame.Location = new System.Drawing.Point(388, 211);
            this.btnMenuStartGame.Name = "btnMenuStartGame";
            this.btnMenuStartGame.Size = new System.Drawing.Size(273, 120);
            this.btnMenuStartGame.TabIndex = 0;
            this.btnMenuStartGame.Text = "Start Game";
            this.btnMenuStartGame.UseVisualStyleBackColor = false;
            this.btnMenuStartGame.Click += new System.EventHandler(this.btnMenuStartGame_Click);
            // 
            // btnMenuRules
            // 
            this.btnMenuRules.BackColor = System.Drawing.Color.LightCoral;
            this.btnMenuRules.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuRules.Location = new System.Drawing.Point(388, 487);
            this.btnMenuRules.Name = "btnMenuRules";
            this.btnMenuRules.Size = new System.Drawing.Size(273, 120);
            this.btnMenuRules.TabIndex = 1;
            this.btnMenuRules.Text = "Rules";
            this.btnMenuRules.UseVisualStyleBackColor = false;
            this.btnMenuRules.Click += new System.EventHandler(this.btnMenuRules_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Two_Dice_Pig_Game.Properties.Resources.twoDicePigLogoTransparent;
            this.pictureBox1.Location = new System.Drawing.Point(47, 211);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(273, 291);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Two_Dice_Pig_Game.Properties.Resources.twoDicePigLogoTransparent;
            this.pictureBox2.Location = new System.Drawing.Point(749, 211);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(273, 291);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // frmGameMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1070, 754);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnMenuRules);
            this.Controls.Add(this.btnMenuStartGame);
            this.Controls.Add(this.lblTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGameMenu";
            this.Text = "Game Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnMenuStartGame;
        private System.Windows.Forms.Button btnMenuRules;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}