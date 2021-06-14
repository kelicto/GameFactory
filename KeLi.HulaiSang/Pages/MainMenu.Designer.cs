namespace KeLi.MengSang.Pages
{
    partial class MainMenu
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
            this.lblHero = new System.Windows.Forms.Label();
            this.lblSociety = new System.Windows.Forms.Label();
            this.lblBag = new System.Windows.Forms.Label();
            this.lblAchievement = new System.Windows.Forms.Label();
            this.lblFriend = new System.Windows.Forms.Label();
            this.lblShop = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHero
            // 
            this.lblHero.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblHero.BackColor = System.Drawing.Color.Transparent;
            this.lblHero.ForeColor = System.Drawing.Color.White;
            this.lblHero.Location = new System.Drawing.Point(0, 50);
            this.lblHero.Name = "lblHero";
            this.lblHero.Size = new System.Drawing.Size(50, 50);
            this.lblHero.TabIndex = 13;
            this.lblHero.Text = "英雄";
            this.lblHero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSociety
            // 
            this.lblSociety.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSociety.BackColor = System.Drawing.Color.Transparent;
            this.lblSociety.ForeColor = System.Drawing.Color.White;
            this.lblSociety.Location = new System.Drawing.Point(50, 50);
            this.lblSociety.Name = "lblSociety";
            this.lblSociety.Size = new System.Drawing.Size(50, 50);
            this.lblSociety.TabIndex = 16;
            this.lblSociety.Text = "社会";
            this.lblSociety.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBag
            // 
            this.lblBag.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblBag.BackColor = System.Drawing.Color.Transparent;
            this.lblBag.ForeColor = System.Drawing.Color.White;
            this.lblBag.Location = new System.Drawing.Point(200, 50);
            this.lblBag.Name = "lblBag";
            this.lblBag.Size = new System.Drawing.Size(50, 50);
            this.lblBag.TabIndex = 17;
            this.lblBag.Text = "背包";
            this.lblBag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAchievement
            // 
            this.lblAchievement.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAchievement.BackColor = System.Drawing.Color.Transparent;
            this.lblAchievement.ForeColor = System.Drawing.Color.White;
            this.lblAchievement.Location = new System.Drawing.Point(100, 50);
            this.lblAchievement.Name = "lblAchievement";
            this.lblAchievement.Size = new System.Drawing.Size(50, 50);
            this.lblAchievement.TabIndex = 17;
            this.lblAchievement.Text = "成就";
            this.lblAchievement.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFriend
            // 
            this.lblFriend.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFriend.BackColor = System.Drawing.Color.Transparent;
            this.lblFriend.ForeColor = System.Drawing.Color.White;
            this.lblFriend.Location = new System.Drawing.Point(150, 50);
            this.lblFriend.Name = "lblFriend";
            this.lblFriend.Size = new System.Drawing.Size(50, 50);
            this.lblFriend.TabIndex = 17;
            this.lblFriend.Text = "好友";
            this.lblFriend.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblShop
            // 
            this.lblShop.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblShop.BackColor = System.Drawing.Color.Transparent;
            this.lblShop.ForeColor = System.Drawing.Color.White;
            this.lblShop.Location = new System.Drawing.Point(250, 0);
            this.lblShop.Name = "lblShop";
            this.lblShop.Size = new System.Drawing.Size(100, 100);
            this.lblShop.TabIndex = 17;
            this.lblShop.Text = "商城";
            this.lblShop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Controls.Add(this.lblShop);
            this.Controls.Add(this.lblFriend);
            this.Controls.Add(this.lblAchievement);
            this.Controls.Add(this.lblBag);
            this.Controls.Add(this.lblSociety);
            this.Controls.Add(this.lblHero);
            this.Name = "MainMenu";
            this.Size = new System.Drawing.Size(350, 100);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHero;
        private System.Windows.Forms.Label lblSociety;
        private System.Windows.Forms.Label lblBag;
        private System.Windows.Forms.Label lblAchievement;
        private System.Windows.Forms.Label lblFriend;
        private System.Windows.Forms.Label lblShop;
    }
}
