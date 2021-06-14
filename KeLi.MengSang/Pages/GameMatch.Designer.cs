namespace KeLi.MengSang.Pages
{
    partial class GameMatch
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
            this.lblMatch = new System.Windows.Forms.Label();
            this.lblLeft = new System.Windows.Forms.Label();
            this.lblRight = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMatch
            // 
            this.lblMatch.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblMatch.BackColor = System.Drawing.Color.Transparent;
            this.lblMatch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(202)))), ((int)(((byte)(176)))));
            this.lblMatch.Location = new System.Drawing.Point(32, 0);
            this.lblMatch.Name = "lblMatch";
            this.lblMatch.Size = new System.Drawing.Size(100, 100);
            this.lblMatch.TabIndex = 12;
            this.lblMatch.Text = "开始匹配";
            this.lblMatch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMatch.Click += new System.EventHandler(this.LblMatch_Click);
            // 
            // lblLeft
            // 
            this.lblLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLeft.BackColor = System.Drawing.Color.Transparent;
            this.lblLeft.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(202)))), ((int)(((byte)(176)))));
            this.lblLeft.Location = new System.Drawing.Point(0, 68);
            this.lblLeft.Name = "lblLeft";
            this.lblLeft.Size = new System.Drawing.Size(32, 32);
            this.lblLeft.TabIndex = 13;
            this.lblLeft.Text = "v";
            this.lblLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLeft.Click += new System.EventHandler(this.LblLeft_Click);
            // 
            // lblRight
            // 
            this.lblRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRight.BackColor = System.Drawing.Color.Transparent;
            this.lblRight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(202)))), ((int)(((byte)(176)))));
            this.lblRight.Location = new System.Drawing.Point(132, 68);
            this.lblRight.Name = "lblRight";
            this.lblRight.Size = new System.Drawing.Size(32, 32);
            this.lblRight.TabIndex = 13;
            this.lblRight.Text = "v";
            this.lblRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRight.Click += new System.EventHandler(this.LblRight_Click);
            // 
            // GameMatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Controls.Add(this.lblRight);
            this.Controls.Add(this.lblLeft);
            this.Controls.Add(this.lblMatch);
            this.Name = "GameMatch";
            this.Size = new System.Drawing.Size(170, 100);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMatch;
        private System.Windows.Forms.Label lblLeft;
        private System.Windows.Forms.Label lblRight;
    }
}
