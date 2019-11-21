using KeLi.MsgGame.App.Properties;

namespace KeLi.MsgGame.App.Components
{
    partial class MatchCtrl
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
            this.LblMatch = new System.Windows.Forms.Label();
            this.LblLeft = new System.Windows.Forms.Label();
            this.LblRight = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblMatch
            // 
            this.LblMatch.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LblMatch.BackColor = System.Drawing.Color.Transparent;
            this.LblMatch.Location = new System.Drawing.Point(32, 0);
            this.LblMatch.Name = "LblMatch";
            this.LblMatch.Size = new System.Drawing.Size(100, 100);
            this.LblMatch.TabIndex = 12;
            this.LblMatch.Text = "开始匹配";
            this.LblMatch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblMatch.Click += new System.EventHandler(this.LblMatch_Click);
            // 
            // LblLeft
            // 
            this.LblLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LblLeft.BackColor = System.Drawing.Color.Transparent;
            this.LblLeft.Location = new System.Drawing.Point(0, 68);
            this.LblLeft.Name = "LblLeft";
            this.LblLeft.Size = new System.Drawing.Size(32, 32);
            this.LblLeft.TabIndex = 13;
            this.LblLeft.Text = "v";
            this.LblLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblLeft.Click += new System.EventHandler(this.LblLeft_Click);
            // 
            // LblRight
            // 
            this.LblRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LblRight.BackColor = System.Drawing.Color.Transparent;
            this.LblRight.Location = new System.Drawing.Point(132, 68);
            this.LblRight.Name = "LblRight";
            this.LblRight.Size = new System.Drawing.Size(32, 32);
            this.LblRight.TabIndex = 13;
            this.LblRight.Text = "v";
            this.LblRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblRight.Click += new System.EventHandler(this.LblRight_Click);
            // 
            // MatchCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Controls.Add(this.LblRight);
            this.Controls.Add(this.LblLeft);
            this.Controls.Add(this.LblMatch);
            this.Name = "MatchCtrl";
            this.Size = new System.Drawing.Size(170, 100);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblMatch;
        private System.Windows.Forms.Label LblLeft;
        private System.Windows.Forms.Label LblRight;
    }
}
