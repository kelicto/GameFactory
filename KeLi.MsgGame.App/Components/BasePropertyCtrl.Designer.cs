using KeLi.MsgGame.App.Properties;

namespace KeLi.MsgGame.App.Components
{
    partial class BasePropertyCtrl
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
            this.LblFourthProperty = new System.Windows.Forms.Label();
            this.LblThirdProperty = new System.Windows.Forms.Label();
            this.LblSecondProperty = new System.Windows.Forms.Label();
            this.LblFirstProperty = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblFourthProperty
            // 
            this.LblFourthProperty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblFourthProperty.BackColor = System.Drawing.Color.Transparent;
            this.LblFourthProperty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(214)))), ((int)(((byte)(4)))));
            this.LblFourthProperty.Location = new System.Drawing.Point(0, 51);
            this.LblFourthProperty.Name = "LblFourthProperty";
            this.LblFourthProperty.Size = new System.Drawing.Size(120, 17);
            this.LblFourthProperty.TabIndex = 61;
            this.LblFourthProperty.Text = "+3950.0点灵力";
            this.LblFourthProperty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblThirdProperty
            // 
            this.LblThirdProperty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblThirdProperty.BackColor = System.Drawing.Color.Transparent;
            this.LblThirdProperty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(214)))), ((int)(((byte)(4)))));
            this.LblThirdProperty.Location = new System.Drawing.Point(0, 34);
            this.LblThirdProperty.Name = "LblThirdProperty";
            this.LblThirdProperty.Size = new System.Drawing.Size(120, 17);
            this.LblThirdProperty.TabIndex = 60;
            this.LblThirdProperty.Text = "+1550.0点智力";
            this.LblThirdProperty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblSecondProperty
            // 
            this.LblSecondProperty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblSecondProperty.BackColor = System.Drawing.Color.Transparent;
            this.LblSecondProperty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(214)))), ((int)(((byte)(4)))));
            this.LblSecondProperty.Location = new System.Drawing.Point(0, 17);
            this.LblSecondProperty.Name = "LblSecondProperty";
            this.LblSecondProperty.Size = new System.Drawing.Size(120, 17);
            this.LblSecondProperty.TabIndex = 59;
            this.LblSecondProperty.Text = "+1550.0点敏捷";
            this.LblSecondProperty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblFirstProperty
            // 
            this.LblFirstProperty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblFirstProperty.BackColor = System.Drawing.Color.Transparent;
            this.LblFirstProperty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(214)))), ((int)(((byte)(4)))));
            this.LblFirstProperty.Location = new System.Drawing.Point(0, 0);
            this.LblFirstProperty.Name = "LblFirstProperty";
            this.LblFirstProperty.Size = new System.Drawing.Size(120, 17);
            this.LblFirstProperty.TabIndex = 58;
            this.LblFirstProperty.Text = "+2550.0点力量";
            this.LblFirstProperty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BasePropertyCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Controls.Add(this.LblFourthProperty);
            this.Controls.Add(this.LblThirdProperty);
            this.Controls.Add(this.LblSecondProperty);
            this.Controls.Add(this.LblFirstProperty);
            this.Name = "BasePropertyCtrl";
            this.Size = new System.Drawing.Size(120, 68);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label LblFourthProperty;
        public System.Windows.Forms.Label LblThirdProperty;
        public System.Windows.Forms.Label LblSecondProperty;
        public System.Windows.Forms.Label LblFirstProperty;
    }
}
