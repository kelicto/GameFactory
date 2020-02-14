namespace KeLi.MsgGame.App.Components.Part
{
    partial class MosaicCtrl
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
            this.lblSecondProperty = new System.Windows.Forms.Label();
            this.lblFirstProperty = new System.Windows.Forms.Label();
            this.lblMosaicName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSecondProperty
            // 
            this.lblSecondProperty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSecondProperty.BackColor = System.Drawing.Color.Transparent;
            this.lblSecondProperty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(214)))), ((int)(((byte)(4)))));
            this.lblSecondProperty.Location = new System.Drawing.Point(0, 34);
            this.lblSecondProperty.Name = "lblSecondProperty";
            this.lblSecondProperty.Size = new System.Drawing.Size(150, 17);
            this.lblSecondProperty.TabIndex = 24;
            this.lblSecondProperty.Text = "+[数值]点破甲";
            this.lblSecondProperty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFirstProperty
            // 
            this.lblFirstProperty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFirstProperty.BackColor = System.Drawing.Color.Transparent;
            this.lblFirstProperty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(214)))), ((int)(((byte)(4)))));
            this.lblFirstProperty.Location = new System.Drawing.Point(0, 17);
            this.lblFirstProperty.Name = "lblFirstProperty";
            this.lblFirstProperty.Size = new System.Drawing.Size(150, 17);
            this.lblFirstProperty.TabIndex = 23;
            this.lblFirstProperty.Text = "+[数值]点力量";
            this.lblFirstProperty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMosaicName
            // 
            this.lblMosaicName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMosaicName.BackColor = System.Drawing.Color.Transparent;
            this.lblMosaicName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(98)))), ((int)(((byte)(182)))));
            this.lblMosaicName.Location = new System.Drawing.Point(0, 0);
            this.lblMosaicName.Name = "lblMosaicName";
            this.lblMosaicName.Size = new System.Drawing.Size(150, 17);
            this.lblMosaicName.TabIndex = 22;
            this.lblMosaicName.Text = "[元神卡名称] Lv.[卡等级]";
            this.lblMosaicName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MosaicCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Controls.Add(this.lblSecondProperty);
            this.Controls.Add(this.lblFirstProperty);
            this.Controls.Add(this.lblMosaicName);
            this.Name = "MosaicCtrl";
            this.Size = new System.Drawing.Size(150, 51);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMosaicName;
        private System.Windows.Forms.Label lblFirstProperty;
        private System.Windows.Forms.Label lblSecondProperty;
    }
}
