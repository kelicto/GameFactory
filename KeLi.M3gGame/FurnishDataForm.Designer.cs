using KeLi.GameComps.Parts;

namespace KeLi.M3Game
{
    sealed partial class FurnishDataForm
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
            this.lblArmStory = new System.Windows.Forms.Label();
            this.lblDetail = new System.Windows.Forms.Label();
            this.fscZytz = new FurnishSuitCtrl();
            this.bpcProperty = new BasePropertyCtrl();
            this.ftcTitle = new FurnishTypeCtrl();
            this.mcMosaic = new MosaicCtrl();
            this.lblFightPower = new System.Windows.Forms.Label();
            this.lblFightName = new System.Windows.Forms.Label();
            this.acAlchemy = new AlchemyCtrl();
            this.SuspendLayout();
            // 
            // lblArmStory
            // 
            this.lblArmStory.BackColor = System.Drawing.Color.Transparent;
            this.lblArmStory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(132)))), ((int)(((byte)(153)))));
            this.lblArmStory.Location = new System.Drawing.Point(11, 502);
            this.lblArmStory.Name = "lblArmStory";
            this.lblArmStory.Size = new System.Drawing.Size(327, 52);
            this.lblArmStory.TabIndex = 51;
            this.lblArmStory.Text = "这是一段装备历史故事。";
            // 
            // lblDetail
            // 
            this.lblDetail.BackColor = System.Drawing.Color.Transparent;
            this.lblDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(5)))), ((int)(((byte)(3)))));
            this.lblDetail.Location = new System.Drawing.Point(11, 585);
            this.lblDetail.Name = "lblDetail";
            this.lblDetail.Size = new System.Drawing.Size(168, 17);
            this.lblDetail.TabIndex = 65;
            this.lblDetail.Text = "装备附加的能力不带入竞技场";
            // 
            // fscZytz
            // 
            this.fscZytz.BackColor = System.Drawing.Color.Transparent;
            this.fscZytz.Belt = "[称号]*[腰带套件名]";
            this.fscZytz.Cloth = "[称号]*[铠甲套件名]";
            this.fscZytz.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.fscZytz.Handguard = "[称号]*[护手套件名]";
            this.fscZytz.Location = new System.Drawing.Point(11, 195);
            this.fscZytz.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fscZytz.Mark = "[称号]*[印章套件名]";
            this.fscZytz.Name = "fscZytz";
            this.fscZytz.Necklace = "[称号]*[项链套件名]";
            this.fscZytz.Ring = "[称号]*[戒指套件名]";
            this.fscZytz.Shoe = "[称号]*[靴子套件名]";
            this.fscZytz.Size = new System.Drawing.Size(200, 136);
            this.fscZytz.SuitName = "[称号]*[套装名][件数]/7][章节装备]";
            this.fscZytz.TabIndex = 67;
            // 
            // bpcProperty
            // 
            this.bpcProperty.BackColor = System.Drawing.Color.Transparent;
            this.bpcProperty.FirstProperty = "+第一条属性";
            this.bpcProperty.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bpcProperty.FourthProperty = "+第四条属性";
            this.bpcProperty.Location = new System.Drawing.Point(11, 120);
            this.bpcProperty.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bpcProperty.Name = "bpcProperty";
            this.bpcProperty.SecondProperty = "+第二条属性";
            this.bpcProperty.Size = new System.Drawing.Size(120, 68);
            this.bpcProperty.TabIndex = 68;
            this.bpcProperty.ThirdProperty = "+第三条属性";
            // 
            // ftcTitle
            // 
            this.ftcTitle.BackColor = System.Drawing.Color.Transparent;
            this.ftcTitle.CanDiscard = "[是否可以丢弃]";
            this.ftcTitle.CanSplit = "[是否可以分解]";
            this.ftcTitle.Enhance = "[强化等级]";
            this.ftcTitle.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ftcTitle.FurnishName = "[套装名]*[套件名][阶段]+[等级]";
            this.ftcTitle.FurnishType = "[装备类型]>[穿戴部位]";
            this.ftcTitle.IsBinding = "[是否绑定]";
            this.ftcTitle.Location = new System.Drawing.Point(11, 11);
            this.ftcTitle.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.ftcTitle.Name = "ftcTitle";
            this.ftcTitle.Size = new System.Drawing.Size(200, 102);
            this.ftcTitle.TabIndex = 69;
            // 
            // mcMosaic
            // 
            this.mcMosaic.BackColor = System.Drawing.Color.Transparent;
            this.mcMosaic.FirstProperty = "+第一条属性";
            this.mcMosaic.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mcMosaic.Location = new System.Drawing.Point(11, 338);
            this.mcMosaic.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mcMosaic.MosaicName = "[元神卡名称] Lv.[卡等级]";
            this.mcMosaic.Name = "mcMosaic";
            this.mcMosaic.SecondProperty = "+第二条属性";
            this.mcMosaic.Size = new System.Drawing.Size(200, 75);
            this.mcMosaic.TabIndex = 70;
            // 
            // lblFightPower
            // 
            this.lblFightPower.BackColor = System.Drawing.Color.Transparent;
            this.lblFightPower.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(151)))), ((int)(((byte)(5)))));
            this.lblFightPower.Location = new System.Drawing.Point(53, 561);
            this.lblFightPower.Name = "lblFightPower";
            this.lblFightPower.Size = new System.Drawing.Size(70, 17);
            this.lblFightPower.TabIndex = 72;
            this.lblFightPower.Text = "[数值]";
            // 
            // lblFightName
            // 
            this.lblFightName.BackColor = System.Drawing.Color.Transparent;
            this.lblFightName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(151)))), ((int)(((byte)(5)))));
            this.lblFightName.Location = new System.Drawing.Point(11, 561);
            this.lblFightName.Name = "lblFightName";
            this.lblFightName.Size = new System.Drawing.Size(50, 17);
            this.lblFightName.TabIndex = 73;
            this.lblFightName.Text = "神兵值:";
            // 
            // acAlchemy
            // 
            this.acAlchemy.BackColor = System.Drawing.Color.Transparent;
            this.acAlchemy.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.acAlchemy.Location = new System.Drawing.Point(11, 420);
            this.acAlchemy.MagicDetail = "这是一段技能说明。";
            this.acAlchemy.MagicName = "[技能名称] Lv.[等级]";
            this.acAlchemy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.acAlchemy.Name = "acAlchemy";
            this.acAlchemy.Size = new System.Drawing.Size(327, 75);
            this.acAlchemy.TabIndex = 74;
            // 
            // FurnishDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(350, 613);
            this.Controls.Add(this.acAlchemy);
            this.Controls.Add(this.lblFightPower);
            this.Controls.Add(this.lblFightName);
            this.Controls.Add(this.mcMosaic);
            this.Controls.Add(this.ftcTitle);
            this.Controls.Add(this.bpcProperty);
            this.Controls.Add(this.fscZytz);
            this.Controls.Add(this.lblArmStory);
            this.Controls.Add(this.lblDetail);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "FurnishDataForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FurnishPropertyForm";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblArmStory;
        private System.Windows.Forms.Label lblDetail;
        private FurnishSuitCtrl fscZytz;
        private BasePropertyCtrl bpcProperty;
        private FurnishTypeCtrl ftcTitle;
        private MosaicCtrl mcMosaic;
        private System.Windows.Forms.Label lblFightPower;
        private System.Windows.Forms.Label lblFightName;
        private AlchemyCtrl acAlchemy;
    }
}