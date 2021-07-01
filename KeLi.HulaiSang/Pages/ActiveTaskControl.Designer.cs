namespace KeLi.HulaiSang.Pages
{
    partial class ActiveTaskControl
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
            this.lblLast = new System.Windows.Forms.Label();
            this.lblAnniversary = new System.Windows.Forms.Label();
            this.lblGameParty = new System.Windows.Forms.Label();
            this.lblCopyTask = new System.Windows.Forms.Label();
            this.lblNext = new System.Windows.Forms.Label();
            this.lblRecharge = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLast
            // 
            this.lblLast.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLast.BackColor = System.Drawing.Color.Transparent;
            this.lblLast.ForeColor = System.Drawing.Color.White;
            this.lblLast.Location = new System.Drawing.Point(-2, -2);
            this.lblLast.Name = "lblLast";
            this.lblLast.Size = new System.Drawing.Size(50, 50);
            this.lblLast.TabIndex = 18;
            this.lblLast.Text = "^";
            this.lblLast.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAnniversary
            // 
            this.lblAnniversary.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAnniversary.BackColor = System.Drawing.Color.Transparent;
            this.lblAnniversary.ForeColor = System.Drawing.Color.White;
            this.lblAnniversary.Location = new System.Drawing.Point(-2, 48);
            this.lblAnniversary.Name = "lblAnniversary";
            this.lblAnniversary.Size = new System.Drawing.Size(50, 50);
            this.lblAnniversary.TabIndex = 18;
            this.lblAnniversary.Text = "周年庆";
            this.lblAnniversary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGameParty
            // 
            this.lblGameParty.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblGameParty.BackColor = System.Drawing.Color.Transparent;
            this.lblGameParty.ForeColor = System.Drawing.Color.White;
            this.lblGameParty.Location = new System.Drawing.Point(-2, 98);
            this.lblGameParty.Name = "lblGameParty";
            this.lblGameParty.Size = new System.Drawing.Size(50, 50);
            this.lblGameParty.TabIndex = 18;
            this.lblGameParty.Text = "游乐园";
            this.lblGameParty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCopyTask
            // 
            this.lblCopyTask.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCopyTask.BackColor = System.Drawing.Color.Transparent;
            this.lblCopyTask.ForeColor = System.Drawing.Color.White;
            this.lblCopyTask.Location = new System.Drawing.Point(-2, 198);
            this.lblCopyTask.Name = "lblCopyTask";
            this.lblCopyTask.Size = new System.Drawing.Size(50, 50);
            this.lblCopyTask.TabIndex = 18;
            this.lblCopyTask.Text = "副本任务";
            this.lblCopyTask.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNext
            // 
            this.lblNext.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNext.BackColor = System.Drawing.Color.Transparent;
            this.lblNext.ForeColor = System.Drawing.Color.White;
            this.lblNext.Location = new System.Drawing.Point(-2, 248);
            this.lblNext.Name = "lblNext";
            this.lblNext.Size = new System.Drawing.Size(50, 50);
            this.lblNext.TabIndex = 18;
            this.lblNext.Text = "v";
            this.lblNext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRecharge
            // 
            this.lblRecharge.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblRecharge.BackColor = System.Drawing.Color.Transparent;
            this.lblRecharge.ForeColor = System.Drawing.Color.White;
            this.lblRecharge.Location = new System.Drawing.Point(-2, 148);
            this.lblRecharge.Name = "lblRecharge";
            this.lblRecharge.Size = new System.Drawing.Size(50, 50);
            this.lblRecharge.TabIndex = 18;
            this.lblRecharge.Text = "充值";
            this.lblRecharge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ActiveTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Controls.Add(this.lblNext);
            this.Controls.Add(this.lblRecharge);
            this.Controls.Add(this.lblCopyTask);
            this.Controls.Add(this.lblGameParty);
            this.Controls.Add(this.lblAnniversary);
            this.Controls.Add(this.lblLast);
            this.Name = "ActiveTask";
            this.Size = new System.Drawing.Size(50, 300);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblLast;
        private System.Windows.Forms.Label lblAnniversary;
        private System.Windows.Forms.Label lblGameParty;
        private System.Windows.Forms.Label lblCopyTask;
        private System.Windows.Forms.Label lblNext;
        private System.Windows.Forms.Label lblRecharge;
    }
}
