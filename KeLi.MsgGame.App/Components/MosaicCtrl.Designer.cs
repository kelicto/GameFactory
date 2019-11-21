using KeLi.MsgGame.App.Properties;

namespace KeLi.MsgGame.App.Components
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
            this.LblSecondProperty = new System.Windows.Forms.Label();
            this.LblFirstProperty = new System.Windows.Forms.Label();
            this.LblMosaicName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblSecondProperty
            // 
            this.LblSecondProperty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblSecondProperty.BackColor = System.Drawing.Color.Transparent;
            this.LblSecondProperty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(214)))), ((int)(((byte)(4)))));
            this.LblSecondProperty.Location = new System.Drawing.Point(0, 34);
            this.LblSecondProperty.Name = "LblSecondProperty";
            this.LblSecondProperty.Size = new System.Drawing.Size(120, 17);
            this.LblSecondProperty.TabIndex = 24;
            this.LblSecondProperty.Text = "+86.0点破甲";
            this.LblSecondProperty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblFirstProperty
            // 
            this.LblFirstProperty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblFirstProperty.BackColor = System.Drawing.Color.Transparent;
            this.LblFirstProperty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(214)))), ((int)(((byte)(4)))));
            this.LblFirstProperty.Location = new System.Drawing.Point(0, 17);
            this.LblFirstProperty.Name = "LblFirstProperty";
            this.LblFirstProperty.Size = new System.Drawing.Size(120, 17);
            this.LblFirstProperty.TabIndex = 23;
            this.LblFirstProperty.Text = "+1000.0点力量";
            this.LblFirstProperty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblMosaicName
            // 
            this.LblMosaicName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblMosaicName.BackColor = System.Drawing.Color.Transparent;
            this.LblMosaicName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(98)))), ((int)(((byte)(182)))));
            this.LblMosaicName.Location = new System.Drawing.Point(0, 0);
            this.LblMosaicName.Name = "LblMosaicName";
            this.LblMosaicName.Size = new System.Drawing.Size(120, 17);
            this.LblMosaicName.TabIndex = 22;
            this.LblMosaicName.Text = "西凉战神元神卡 Lv.5";
            this.LblMosaicName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MosaicCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Controls.Add(this.LblSecondProperty);
            this.Controls.Add(this.LblFirstProperty);
            this.Controls.Add(this.LblMosaicName);
            this.Name = "MosaicCtrl";
            this.Size = new System.Drawing.Size(120, 51);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label LblSecondProperty;
        public System.Windows.Forms.Label LblFirstProperty;
        public System.Windows.Forms.Label LblMosaicName;
    }
}
