namespace Two_Dice_Pig_Game
{
    partial class frmRules
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRules));
            this.lblRules = new System.Windows.Forms.Label();
            this.lblRulesTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRules
            // 
            this.lblRules.BackColor = System.Drawing.Color.MediumAquamarine;
            this.lblRules.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRules.Location = new System.Drawing.Point(78, 90);
            this.lblRules.Name = "lblRules";
            this.lblRules.Size = new System.Drawing.Size(837, 385);
            this.lblRules.TabIndex = 0;
            this.lblRules.Text = resources.GetString("lblRules.Text");
            this.lblRules.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRulesTitle
            // 
            this.lblRulesTitle.AutoSize = true;
            this.lblRulesTitle.Font = new System.Drawing.Font("MV Boli", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRulesTitle.Location = new System.Drawing.Point(434, 9);
            this.lblRulesTitle.Name = "lblRulesTitle";
            this.lblRulesTitle.Size = new System.Drawing.Size(133, 55);
            this.lblRulesTitle.TabIndex = 25;
            this.lblRulesTitle.Text = "Rules";
            // 
            // frmRules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(960, 564);
            this.Controls.Add(this.lblRulesTitle);
            this.Controls.Add(this.lblRules);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRules";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRules;
        private System.Windows.Forms.Label lblRulesTitle;
    }
}