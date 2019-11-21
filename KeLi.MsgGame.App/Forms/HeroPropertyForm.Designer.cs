using KeLi.MsgGame.App.Properties;

namespace KeLi.MsgGame.App.Forms
{
    partial class HeroPropertyForm
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
            this.LblJiChuShuXing = new System.Windows.Forms.Label();
            this.LblWuLiShuXing = new System.Windows.Forms.Label();
            this.LblFaShuShuXing = new System.Windows.Forms.Label();
            this.LblFangYuShuXing = new System.Windows.Forms.Label();
            this.LblQiTaShuXing = new System.Windows.Forms.Label();
            this.LblZhanChangShenBingProp = new System.Windows.Forms.Label();
            this.BfpcBase = new KeLi.MsgGame.App.Components.BaseFurnishPropertyCtrl();
            this.PfpcPhysical = new KeLi.MsgGame.App.Components.PhysicalFurnishPropertyCtrl();
            this.MfpcMagic = new KeLi.MsgGame.App.Components.MagicFurnishPropertyCtrl();
            this.DfpcDefense = new KeLi.MsgGame.App.Components.DefenseFurnishPropertyCtrl();
            this.OfpcOther = new KeLi.MsgGame.App.Components.OtherFurnishPropertyCtrl();
            this.LblZhanChangShenBingValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblJiChuShuXing
            // 
            this.LblJiChuShuXing.BackColor = System.Drawing.Color.Transparent;
            this.LblJiChuShuXing.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LblJiChuShuXing.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(173)))), ((int)(((byte)(122)))));
            this.LblJiChuShuXing.Location = new System.Drawing.Point(12, 12);
            this.LblJiChuShuXing.Name = "LblJiChuShuXing";
            this.LblJiChuShuXing.Size = new System.Drawing.Size(75, 26);
            this.LblJiChuShuXing.TabIndex = 7;
            this.LblJiChuShuXing.Text = "基础属性";
            this.LblJiChuShuXing.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblWuLiShuXing
            // 
            this.LblWuLiShuXing.BackColor = System.Drawing.Color.Transparent;
            this.LblWuLiShuXing.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LblWuLiShuXing.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(173)))), ((int)(((byte)(122)))));
            this.LblWuLiShuXing.Location = new System.Drawing.Point(12, 138);
            this.LblWuLiShuXing.Name = "LblWuLiShuXing";
            this.LblWuLiShuXing.Size = new System.Drawing.Size(75, 26);
            this.LblWuLiShuXing.TabIndex = 7;
            this.LblWuLiShuXing.Text = "物理属性";
            this.LblWuLiShuXing.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblFaShuShuXing
            // 
            this.LblFaShuShuXing.BackColor = System.Drawing.Color.Transparent;
            this.LblFaShuShuXing.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LblFaShuShuXing.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(173)))), ((int)(((byte)(122)))));
            this.LblFaShuShuXing.Location = new System.Drawing.Point(12, 227);
            this.LblFaShuShuXing.Name = "LblFaShuShuXing";
            this.LblFaShuShuXing.Size = new System.Drawing.Size(75, 26);
            this.LblFaShuShuXing.TabIndex = 7;
            this.LblFaShuShuXing.Text = "法术属性";
            this.LblFaShuShuXing.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblFangYuShuXing
            // 
            this.LblFangYuShuXing.BackColor = System.Drawing.Color.Transparent;
            this.LblFangYuShuXing.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LblFangYuShuXing.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(173)))), ((int)(((byte)(122)))));
            this.LblFangYuShuXing.Location = new System.Drawing.Point(12, 316);
            this.LblFangYuShuXing.Name = "LblFangYuShuXing";
            this.LblFangYuShuXing.Size = new System.Drawing.Size(75, 26);
            this.LblFangYuShuXing.TabIndex = 7;
            this.LblFangYuShuXing.Text = "防御属性";
            this.LblFangYuShuXing.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblQiTaShuXing
            // 
            this.LblQiTaShuXing.BackColor = System.Drawing.Color.Transparent;
            this.LblQiTaShuXing.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LblQiTaShuXing.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(173)))), ((int)(((byte)(122)))));
            this.LblQiTaShuXing.Location = new System.Drawing.Point(12, 374);
            this.LblQiTaShuXing.Name = "LblQiTaShuXing";
            this.LblQiTaShuXing.Size = new System.Drawing.Size(75, 26);
            this.LblQiTaShuXing.TabIndex = 7;
            this.LblQiTaShuXing.Text = "其它属性";
            this.LblQiTaShuXing.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblZhanChangShenBingProp
            // 
            this.LblZhanChangShenBingProp.BackColor = System.Drawing.Color.Transparent;
            this.LblZhanChangShenBingProp.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LblZhanChangShenBingProp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(202)))), ((int)(((byte)(176)))));
            this.LblZhanChangShenBingProp.Location = new System.Drawing.Point(12, 466);
            this.LblZhanChangShenBingProp.Name = "LblZhanChangShenBingProp";
            this.LblZhanChangShenBingProp.Size = new System.Drawing.Size(65, 22);
            this.LblZhanChangShenBingProp.TabIndex = 9;
            this.LblZhanChangShenBingProp.Text = "战场神兵: ";
            this.LblZhanChangShenBingProp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BfpcBase
            // 
            this.BfpcBase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BfpcBase.BackColor = System.Drawing.Color.Transparent;
            this.BfpcBase.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BfpcBase.Location = new System.Drawing.Point(12, 43);
            this.BfpcBase.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BfpcBase.Name = "BfpcBase";
            this.BfpcBase.Size = new System.Drawing.Size(488, 90);
            this.BfpcBase.TabIndex = 10;
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
            // MfpcMagic
            // 
            this.MfpcMagic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MfpcMagic.BackColor = System.Drawing.Color.Transparent;
            this.MfpcMagic.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MfpcMagic.Location = new System.Drawing.Point(12, 258);
            this.MfpcMagic.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MfpcMagic.Name = "MfpcMagic";
            this.MfpcMagic.Size = new System.Drawing.Size(488, 53);
            this.MfpcMagic.TabIndex = 12;
            // 
            // DfpcDefense
            // 
            this.DfpcDefense.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DfpcDefense.BackColor = System.Drawing.Color.Transparent;
            this.DfpcDefense.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DfpcDefense.Location = new System.Drawing.Point(12, 347);
            this.DfpcDefense.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DfpcDefense.Name = "DfpcDefense";
            this.DfpcDefense.Size = new System.Drawing.Size(488, 22);
            this.DfpcDefense.TabIndex = 13;
            // 
            // OfpcOther
            // 
            this.OfpcOther.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OfpcOther.BackColor = System.Drawing.Color.Transparent;
            this.OfpcOther.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OfpcOther.Location = new System.Drawing.Point(12, 405);
            this.OfpcOther.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OfpcOther.Name = "OfpcOther";
            this.OfpcOther.Size = new System.Drawing.Size(488, 53);
            this.OfpcOther.TabIndex = 14;
            // 
            // LblZhanChangShenBingValue
            // 
            this.LblZhanChangShenBingValue.BackColor = System.Drawing.Color.Transparent;
            this.LblZhanChangShenBingValue.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LblZhanChangShenBingValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(202)))), ((int)(((byte)(176)))));
            this.LblZhanChangShenBingValue.Location = new System.Drawing.Point(76, 466);
            this.LblZhanChangShenBingValue.Name = "LblZhanChangShenBingValue";
            this.LblZhanChangShenBingValue.Size = new System.Drawing.Size(80, 22);
            this.LblZhanChangShenBingValue.TabIndex = 9;
            this.LblZhanChangShenBingValue.Text = "1151236";
            this.LblZhanChangShenBingValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // HeroPropertyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.OfpcOther);
            this.Controls.Add(this.DfpcDefense);
            this.Controls.Add(this.MfpcMagic);
            this.Controls.Add(this.PfpcPhysical);
            this.Controls.Add(this.BfpcBase);
            this.Controls.Add(this.LblZhanChangShenBingValue);
            this.Controls.Add(this.LblZhanChangShenBingProp);
            this.Controls.Add(this.LblQiTaShuXing);
            this.Controls.Add(this.LblFangYuShuXing);
            this.Controls.Add(this.LblFaShuShuXing);
            this.Controls.Add(this.LblWuLiShuXing);
            this.Controls.Add(this.LblJiChuShuXing);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "HeroPropertyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblJiChuShuXing;
        private System.Windows.Forms.Label LblWuLiShuXing;
        private System.Windows.Forms.Label LblFaShuShuXing;
        private System.Windows.Forms.Label LblFangYuShuXing;
        private System.Windows.Forms.Label LblQiTaShuXing;
        private System.Windows.Forms.Label LblZhanChangShenBingProp;
        private Components.BaseFurnishPropertyCtrl BfpcBase;
        private Components.PhysicalFurnishPropertyCtrl PfpcPhysical;
        private Components.MagicFurnishPropertyCtrl MfpcMagic;
        private Components.DefenseFurnishPropertyCtrl DfpcDefense;
        private Components.OtherFurnishPropertyCtrl OfpcOther;
        private System.Windows.Forms.Label LblZhanChangShenBingValue;
    }
}