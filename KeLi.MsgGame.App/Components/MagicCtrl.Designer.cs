using KeLi.MsgGame.App.Properties;

namespace KeLi.MsgGame.App.Components
{
    partial class MagicCtrl
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
            this.LblMagicDetail = new System.Windows.Forms.Label();
            this.LblMagicName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblMagicDetail
            // 
            this.LblMagicDetail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblMagicDetail.BackColor = System.Drawing.Color.Transparent;
            this.LblMagicDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(186)))), ((int)(((byte)(183)))));
            this.LblMagicDetail.Location = new System.Drawing.Point(0, 17);
            this.LblMagicDetail.Name = "LblMagicDetail";
            this.LblMagicDetail.Size = new System.Drawing.Size(280, 35);
            this.LblMagicDetail.TabIndex = 14;
            this.LblMagicDetail.Text = "攻击时有20%几率触发，对周围550码内的敌军造成(5550+主属性*0.15)点伤害";
            // 
            // LblMagicName
            // 
            this.LblMagicName.BackColor = System.Drawing.Color.Transparent;
            this.LblMagicName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(98)))), ((int)(((byte)(182)))));
            this.LblMagicName.Location = new System.Drawing.Point(0, 0);
            this.LblMagicName.Name = "LblMagicName";
            this.LblMagicName.Size = new System.Drawing.Size(88, 17);
            this.LblMagicName.TabIndex = 13;
            this.LblMagicName.Text = "冰封万里 Lv.7";
            this.LblMagicName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MagicCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Controls.Add(this.LblMagicDetail);
            this.Controls.Add(this.LblMagicName);
            this.Name = "MagicCtrl";
            this.Size = new System.Drawing.Size(280, 51);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Label LblMagicName;
        public System.Windows.Forms.Label LblMagicDetail;
    }
}
