using KeLi.MengSang.Furnishs;

namespace KeLi.MengSang.Forms
{
    sealed partial class HeroDataFrm
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
            this.lblJiChuShuXing = new System.Windows.Forms.Label();
            this.lblWuLiShuXing = new System.Windows.Forms.Label();
            this.lblFaShuShuXing = new System.Windows.Forms.Label();
            this.lblQiTaShuXing = new System.Windows.Forms.Label();
            this.lblZhanChangShenBingProp = new System.Windows.Forms.Label();
            this.PfpcPhysical = new PhysicalFurnish();
            this.mfpcMagic = new MagicFurnish();
            this.OfpcOther = new ResourcesFurnish();
            this.lblZhanChangShenBingValue = new System.Windows.Forms.Label();
            this.baseFurnish1 = new BaseFurnish();
            this.SuspendLayout();
            // 
            // lblJiChuShuXing
            // 
            this.lblJiChuShuXing.BackColor = System.Drawing.Color.Transparent;
            this.lblJiChuShuXing.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblJiChuShuXing.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(173)))), ((int)(((byte)(122)))));
            this.lblJiChuShuXing.Location = new System.Drawing.Point(12, 12);
            this.lblJiChuShuXing.Name = "lblJiChuShuXing";
            this.lblJiChuShuXing.Size = new System.Drawing.Size(75, 26);
            this.lblJiChuShuXing.TabIndex = 7;
            this.lblJiChuShuXing.Text = "基础属性";
            this.lblJiChuShuXing.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblWuLiShuXing
            // 
            this.lblWuLiShuXing.BackColor = System.Drawing.Color.Transparent;
            this.lblWuLiShuXing.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblWuLiShuXing.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(173)))), ((int)(((byte)(122)))));
            this.lblWuLiShuXing.Location = new System.Drawing.Point(12, 138);
            this.lblWuLiShuXing.Name = "lblWuLiShuXing";
            this.lblWuLiShuXing.Size = new System.Drawing.Size(75, 26);
            this.lblWuLiShuXing.TabIndex = 7;
            this.lblWuLiShuXing.Text = "物理属性";
            this.lblWuLiShuXing.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFaShuShuXing
            // 
            this.lblFaShuShuXing.BackColor = System.Drawing.Color.Transparent;
            this.lblFaShuShuXing.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblFaShuShuXing.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(173)))), ((int)(((byte)(122)))));
            this.lblFaShuShuXing.Location = new System.Drawing.Point(12, 234);
            this.lblFaShuShuXing.Name = "lblFaShuShuXing";
            this.lblFaShuShuXing.Size = new System.Drawing.Size(75, 26);
            this.lblFaShuShuXing.TabIndex = 7;
            this.lblFaShuShuXing.Text = "法术属性";
            this.lblFaShuShuXing.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblQiTaShuXing
            // 
            this.lblQiTaShuXing.BackColor = System.Drawing.Color.Transparent;
            this.lblQiTaShuXing.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblQiTaShuXing.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(173)))), ((int)(((byte)(122)))));
            this.lblQiTaShuXing.Location = new System.Drawing.Point(12, 331);
            this.lblQiTaShuXing.Name = "lblQiTaShuXing";
            this.lblQiTaShuXing.Size = new System.Drawing.Size(75, 26);
            this.lblQiTaShuXing.TabIndex = 7;
            this.lblQiTaShuXing.Text = "其它属性";
            this.lblQiTaShuXing.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblZhanChangShenBingProp
            // 
            this.lblZhanChangShenBingProp.BackColor = System.Drawing.Color.Transparent;
            this.lblZhanChangShenBingProp.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblZhanChangShenBingProp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(202)))), ((int)(((byte)(176)))));
            this.lblZhanChangShenBingProp.Location = new System.Drawing.Point(12, 466);
            this.lblZhanChangShenBingProp.Name = "lblZhanChangShenBingProp";
            this.lblZhanChangShenBingProp.Size = new System.Drawing.Size(53, 22);
            this.lblZhanChangShenBingProp.TabIndex = 9;
            this.lblZhanChangShenBingProp.Text = "神兵值: ";
            this.lblZhanChangShenBingProp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PfpcPhysical
            // 
            this.PfpcPhysical.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PfpcPhysical.BackColor = System.Drawing.Color.Transparent;
            this.PfpcPhysical.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PfpcPhysical.Location = new System.Drawing.Point(12, 169);
            this.PfpcPhysical.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PfpcPhysical.Name = "PfpcPhysical";
            this.PfpcPhysical.Size = new System.Drawing.Size(488, 53);
            this.PfpcPhysical.TabIndex = 11;
            // 
            // mfpcMagic
            // 
            this.mfpcMagic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mfpcMagic.BackColor = System.Drawing.Color.Transparent;
            this.mfpcMagic.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mfpcMagic.Location = new System.Drawing.Point(12, 265);
            this.mfpcMagic.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mfpcMagic.Name = "mfpcMagic";
            this.mfpcMagic.Size = new System.Drawing.Size(488, 53);
            this.mfpcMagic.TabIndex = 12;
            // 
            // OfpcOther
            // 
            this.OfpcOther.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OfpcOther.BackColor = System.Drawing.Color.Transparent;
            this.OfpcOther.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OfpcOther.Location = new System.Drawing.Point(12, 362);
            this.OfpcOther.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OfpcOther.Name = "OfpcOther";
            this.OfpcOther.Size = new System.Drawing.Size(488, 53);
            this.OfpcOther.TabIndex = 14;
            // 
            // lblZhanChangShenBingValue
            // 
            this.lblZhanChangShenBingValue.BackColor = System.Drawing.Color.Transparent;
            this.lblZhanChangShenBingValue.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblZhanChangShenBingValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(202)))), ((int)(((byte)(176)))));
            this.lblZhanChangShenBingValue.Location = new System.Drawing.Point(65, 466);
            this.lblZhanChangShenBingValue.Name = "lblZhanChangShenBingValue";
            this.lblZhanChangShenBingValue.Size = new System.Drawing.Size(80, 22);
            this.lblZhanChangShenBingValue.TabIndex = 9;
            this.lblZhanChangShenBingValue.Text = "[数值]";
            this.lblZhanChangShenBingValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // baseFurnish1
            // 
            this.baseFurnish1.BackColor = System.Drawing.Color.Transparent;
            this.baseFurnish1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.baseFurnish1.Location = new System.Drawing.Point(12, 42);
            this.baseFurnish1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.baseFurnish1.Name = "baseFurnish1";
            this.baseFurnish1.Size = new System.Drawing.Size(488, 84);
            this.baseFurnish1.TabIndex = 15;
            // 
            // HeroDataFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.baseFurnish1);
            this.Controls.Add(this.OfpcOther);
            this.Controls.Add(this.mfpcMagic);
            this.Controls.Add(this.PfpcPhysical);
            this.Controls.Add(this.lblZhanChangShenBingValue);
            this.Controls.Add(this.lblZhanChangShenBingProp);
            this.Controls.Add(this.lblQiTaShuXing);
            this.Controls.Add(this.lblFaShuShuXing);
            this.Controls.Add(this.lblWuLiShuXing);
            this.Controls.Add(this.lblJiChuShuXing);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "HeroDataFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblJiChuShuXing;
        private System.Windows.Forms.Label lblWuLiShuXing;
        private System.Windows.Forms.Label lblFaShuShuXing;
        private System.Windows.Forms.Label lblQiTaShuXing;
        private System.Windows.Forms.Label lblZhanChangShenBingProp;
        private PhysicalFurnish PfpcPhysical;
        private MagicFurnish mfpcMagic;
        private ResourcesFurnish OfpcOther;
        private System.Windows.Forms.Label lblZhanChangShenBingValue;
        private BaseFurnish baseFurnish1;
    }
}