using KeLi.MsgGame.App.Components.Part;
using KeLi.MsgGame.App.Properties;

namespace KeLi.MsgGame.App.Forms
{
    sealed partial class ArmPropertyForm
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
            this.lblFightName = new System.Windows.Forms.Label();
            this.bpcProperty = new KeLi.MsgGame.App.Components.Part.BasePropertyCtrl();
            this.ftcTitle = new KeLi.MsgGame.App.Components.Part.FurnishTypeCtrl();
            this.mcBfwl = new KeLi.MsgGame.App.Components.Part.MagicCtrl();
            this.mcGyhd = new KeLi.MsgGame.App.Components.Part.MagicCtrl();
            this.mcFjzz = new KeLi.MsgGame.App.Components.Part.MagicCtrl();
            this.mcMosaic = new KeLi.MsgGame.App.Components.Part.MosaicCtrl();
            this.ascXytz = new KeLi.MsgGame.App.Components.Part.ArmSuitCtrl();
            this.lblFightPower = new System.Windows.Forms.Label();
            this.acAlchemy = new KeLi.MsgGame.App.Components.Part.AlchemyCtrl();
            this.SuspendLayout();
            // 
            // lblArmStory
            // 
            this.lblArmStory.BackColor = System.Drawing.Color.Transparent;
            this.lblArmStory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(132)))), ((int)(((byte)(153)))));
            this.lblArmStory.Location = new System.Drawing.Point(11, 637);
            this.lblArmStory.Name = "lblArmStory";
            this.lblArmStory.Size = new System.Drawing.Size(300, 52);
            this.lblArmStory.TabIndex = 18;
            this.lblArmStory.Text = "这是一段装备历史故事。";
            // 
            // lblDetail
            // 
            this.lblDetail.BackColor = System.Drawing.Color.Transparent;
            this.lblDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(5)))), ((int)(((byte)(3)))));
            this.lblDetail.Location = new System.Drawing.Point(11, 722);
            this.lblDetail.Name = "lblDetail";
            this.lblDetail.Size = new System.Drawing.Size(175, 17);
            this.lblDetail.TabIndex = 32;
            this.lblDetail.Text = "装备附加的能力不带入竞技场";
            // 
            // lblFightName
            // 
            this.lblFightName.BackColor = System.Drawing.Color.Transparent;
            this.lblFightName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(151)))), ((int)(((byte)(5)))));
            this.lblFightName.Location = new System.Drawing.Point(11, 696);
            this.lblFightName.Name = "lblFightName";
            this.lblFightName.Size = new System.Drawing.Size(50, 17);
            this.lblFightName.TabIndex = 17;
            this.lblFightName.Text = "神兵值:";
            // 
            // bpcProperty
            // 
            this.bpcProperty.BackColor = System.Drawing.Color.Transparent;
            this.bpcProperty.FirstProperty = "+第一条属性";
            this.bpcProperty.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bpcProperty.FourthProperty = "+第四条属性";
            this.bpcProperty.Location = new System.Drawing.Point(11, 119);
            this.bpcProperty.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bpcProperty.Name = "bpcProperty";
            this.bpcProperty.SecondProperty = "+第二条属性";
            this.bpcProperty.Size = new System.Drawing.Size(120, 68);
            this.bpcProperty.TabIndex = 34;
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
            this.ftcTitle.TabIndex = 36;
            // 
            // mcBfwl
            // 
            this.mcBfwl.BackColor = System.Drawing.Color.Transparent;
            this.mcBfwl.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mcBfwl.Location = new System.Drawing.Point(11, 301);
            this.mcBfwl.MagicDetail = "这是一段技能说明。";
            this.mcBfwl.MagicName = "[技能名称] Lv.[等级]";
            this.mcBfwl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mcBfwl.Name = "mcBfwl";
            this.mcBfwl.Size = new System.Drawing.Size(280, 51);
            this.mcBfwl.TabIndex = 38;
            // 
            // mcGyhd
            // 
            this.mcGyhd.BackColor = System.Drawing.Color.Transparent;
            this.mcGyhd.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mcGyhd.Location = new System.Drawing.Point(11, 358);
            this.mcGyhd.MagicDetail = "这是一段技能说明。";
            this.mcGyhd.MagicName = "[技能名称] Lv.[等级]";
            this.mcGyhd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mcGyhd.Name = "mcGyhd";
            this.mcGyhd.Size = new System.Drawing.Size(280, 51);
            this.mcGyhd.TabIndex = 38;
            // 
            // mcFjzz
            // 
            this.mcFjzz.BackColor = System.Drawing.Color.Transparent;
            this.mcFjzz.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mcFjzz.Location = new System.Drawing.Point(11, 415);
            this.mcFjzz.MagicDetail = "这是一段技能说明。";
            this.mcFjzz.MagicName = "[技能名称] Lv.[等级]";
            this.mcFjzz.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mcFjzz.Name = "mcFjzz";
            this.mcFjzz.Size = new System.Drawing.Size(280, 51);
            this.mcFjzz.TabIndex = 38;
            // 
            // mcMosaic
            // 
            this.mcMosaic.BackColor = System.Drawing.Color.Transparent;
            this.mcMosaic.FirstProperty = "+第一条属性";
            this.mcMosaic.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mcMosaic.Location = new System.Drawing.Point(11, 473);
            this.mcMosaic.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mcMosaic.MosaicName = "[元神卡名称] Lv.[卡等级]";
            this.mcMosaic.Name = "mcMosaic";
            this.mcMosaic.SecondProperty = "+第二条属性";
            this.mcMosaic.Size = new System.Drawing.Size(200, 75);
            this.mcMosaic.TabIndex = 39;
            // 
            // ascXytz
            // 
            this.ascXytz.BackColor = System.Drawing.Color.Transparent;
            this.ascXytz.BowArm = "[称号]*[弓箭套件名]";
            this.ascXytz.ClawArm = "[称号]*[拳爪套件名]";
            this.ascXytz.DoubleArm = "[称号]*[双持套件名]";
            this.ascXytz.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ascXytz.Location = new System.Drawing.Point(11, 193);
            this.ascXytz.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ascXytz.Name = "ascXytz";
            this.ascXytz.SingleArm = "[称号]*[单手套件名]";
            this.ascXytz.Size = new System.Drawing.Size(200, 102);
            this.ascXytz.SpearArm = "[称号]*[长柄套件名]";
            this.ascXytz.SuitName = "[称号]*[套装名][[件数]/5][章节套装]";
            this.ascXytz.TabIndex = 40;
            // 
            // lblFightPower
            // 
            this.lblFightPower.BackColor = System.Drawing.Color.Transparent;
            this.lblFightPower.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(151)))), ((int)(((byte)(5)))));
            this.lblFightPower.Location = new System.Drawing.Point(53, 696);
            this.lblFightPower.Name = "lblFightPower";
            this.lblFightPower.Size = new System.Drawing.Size(70, 17);
            this.lblFightPower.TabIndex = 17;
            this.lblFightPower.Text = "[数值]";
            // 
            // acAlchemy
            // 
            this.acAlchemy.BackColor = System.Drawing.Color.Transparent;
            this.acAlchemy.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.acAlchemy.Location = new System.Drawing.Point(11, 555);
            this.acAlchemy.MagicDetail = "这是一段技能说明。";
            this.acAlchemy.MagicName = "[技能名称] Lv.[等级]";
            this.acAlchemy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.acAlchemy.Name = "acAlchemy";
            this.acAlchemy.Size = new System.Drawing.Size(300, 75);
            this.acAlchemy.TabIndex = 41;
            // 
            // ArmPropertyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(320, 750);
            this.Controls.Add(this.acAlchemy);
            this.Controls.Add(this.ascXytz);
            this.Controls.Add(this.mcMosaic);
            this.Controls.Add(this.mcFjzz);
            this.Controls.Add(this.mcGyhd);
            this.Controls.Add(this.mcBfwl);
            this.Controls.Add(this.ftcTitle);
            this.Controls.Add(this.bpcProperty);
            this.Controls.Add(this.lblArmStory);
            this.Controls.Add(this.lblDetail);
            this.Controls.Add(this.lblFightPower);
            this.Controls.Add(this.lblFightName);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "ArmPropertyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblArmStory;
        private System.Windows.Forms.Label lblDetail;
        private System.Windows.Forms.Label lblFightName;
        private BasePropertyCtrl bpcProperty;
        private FurnishTypeCtrl ftcTitle;
        private MagicCtrl mcBfwl;
        private MagicCtrl mcGyhd;
        private MagicCtrl mcFjzz;
        private MosaicCtrl mcMosaic;
        private ArmSuitCtrl ascXytz;
        private System.Windows.Forms.Label lblFightPower;
        private AlchemyCtrl acAlchemy;
    }
}