namespace KeLi.GameFactory.Components.Parts
{
    partial class MagicComponent
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
            this.lblMagicDetail = new System.Windows.Forms.Label();
            this.lblMagicName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMagicDetail
            // 
            this.lblMagicDetail.BackColor = System.Drawing.Color.Transparent;
            this.lblMagicDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMagicDetail.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMagicDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(186)))), ((int)(((byte)(183)))));
            this.lblMagicDetail.Location = new System.Drawing.Point(0, 17);
            this.lblMagicDetail.Name = "lblMagicDetail";
            this.lblMagicDetail.Size = new System.Drawing.Size(280, 34);
            this.lblMagicDetail.TabIndex = 14;
            this.lblMagicDetail.Text = "这是一段技能说明。";
            // 
            // lblMagicName
            // 
            this.lblMagicName.BackColor = System.Drawing.Color.Transparent;
            this.lblMagicName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMagicName.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMagicName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(98)))), ((int)(((byte)(182)))));
            this.lblMagicName.Location = new System.Drawing.Point(0, 0);
            this.lblMagicName.Name = "lblMagicName";
            this.lblMagicName.Size = new System.Drawing.Size(280, 17);
            this.lblMagicName.TabIndex = 13;
            this.lblMagicName.Text = "[技能名称] Lv.[等级]";
            this.lblMagicName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MagicCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Controls.Add(this.lblMagicDetail);
            this.Controls.Add(this.lblMagicName);
            this.Name = "MagicComponent";
            this.Size = new System.Drawing.Size(280, 51);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMagicName;
        private System.Windows.Forms.Label lblMagicDetail;
    }
}
