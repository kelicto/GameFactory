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
            this.lblMosaicTitle = new System.Windows.Forms.Label();
            this.lblArtificeTitle = new System.Windows.Forms.Label();
            this.lblArmStory = new System.Windows.Forms.Label();
            this.lblDetail = new System.Windows.Forms.Label();
            this.lblFightName = new System.Windows.Forms.Label();
            this.bpcProperty = new KeLi.MsgGame.App.Components.BasePropertyCtrl();
            this.ftcTitle = new KeLi.MsgGame.App.Components.FurnishTypeCtrl();
            this.mcBfwl = new KeLi.MsgGame.App.Components.MagicCtrl();
            this.mcGyhd = new KeLi.MsgGame.App.Components.MagicCtrl();
            this.mcFjzz = new KeLi.MsgGame.App.Components.MagicCtrl();
            this.mcMosaic = new KeLi.MsgGame.App.Components.MosaicCtrl();
            this.mcWqzx = new KeLi.MsgGame.App.Components.MagicCtrl();
            this.ascXytz = new KeLi.MsgGame.App.Components.ArmSuitCtrl();
            this.lblFightPower = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMosaicTitle
            // 
            this.lblMosaicTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblMosaicTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(151)))), ((int)(((byte)(5)))));
            this.lblMosaicTitle.Location = new System.Drawing.Point(11, 472);
            this.lblMosaicTitle.Name = "lblMosaicTitle";
            this.lblMosaicTitle.Size = new System.Drawing.Size(69, 17);
            this.lblMosaicTitle.TabIndex = 31;
            this.lblMosaicTitle.Text = "镶嵌加成";
            this.lblMosaicTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblArtificeTitle
            // 
            this.lblArtificeTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblArtificeTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(151)))), ((int)(((byte)(5)))));
            this.lblArtificeTitle.Location = new System.Drawing.Point(11, 552);
            this.lblArtificeTitle.Name = "lblArtificeTitle";
            this.lblArtificeTitle.Size = new System.Drawing.Size(69, 17);
            this.lblArtificeTitle.TabIndex = 30;
            this.lblArtificeTitle.Text = "炼化加成";
            this.lblArtificeTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblArmStory
            // 
            this.lblArmStory.BackColor = System.Drawing.Color.Transparent;
            this.lblArmStory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(132)))), ((int)(((byte)(153)))));
            this.lblArmStory.Location = new System.Drawing.Point(11, 615);
            this.lblArmStory.Name = "lblArmStory";
            this.lblArmStory.Size = new System.Drawing.Size(298, 68);
            this.lblArmStory.TabIndex = 18;
            this.lblArmStory.Text = "三万年前，魔界发兵百万入侵人族，人族一溃千里。就在人族惨遭灭种之时，电闪雷鸣，异象突显，流血漂橹的大地下起了雪花，人族不世出神秘强者出现了！神兵一出，冰封万里，百" +
    "万神魔瞬间灰飞烟灭！";
            // 
            // lblDetail
            // 
            this.lblDetail.BackColor = System.Drawing.Color.Transparent;
            this.lblDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(5)))), ((int)(((byte)(3)))));
            this.lblDetail.Location = new System.Drawing.Point(11, 718);
            this.lblDetail.Name = "lblDetail";
            this.lblDetail.Size = new System.Drawing.Size(175, 17);
            this.lblDetail.TabIndex = 32;
            this.lblDetail.Text = "装备附加的能力不带入竞技场";
            // 
            // lblFightName
            // 
            this.lblFightName.BackColor = System.Drawing.Color.Transparent;
            this.lblFightName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(151)))), ((int)(((byte)(5)))));
            this.lblFightName.Location = new System.Drawing.Point(11, 689);
            this.lblFightName.Name = "lblFightName";
            this.lblFightName.Size = new System.Drawing.Size(50, 17);
            this.lblFightName.TabIndex = 17;
            this.lblFightName.Text = "神兵值:";
            // 
            // bpcProperty
            // 
            this.bpcProperty.BackColor = System.Drawing.Color.Transparent;
            this.bpcProperty.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bpcProperty.Location = new System.Drawing.Point(11, 119);
            this.bpcProperty.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bpcProperty.Name = "bpcProperty";
            this.bpcProperty.Size = new System.Drawing.Size(120, 68);
            this.bpcProperty.TabIndex = 34;
            // 
            // ftcTitle
            // 
            this.ftcTitle.BackColor = System.Drawing.Color.Transparent;
            this.ftcTitle.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ftcTitle.Location = new System.Drawing.Point(11, 11);
            this.ftcTitle.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.ftcTitle.Name = "ftcTitle";
            this.ftcTitle.Size = new System.Drawing.Size(160, 102);
            this.ftcTitle.TabIndex = 36;
            // 
            // mcBfwl
            // 
            this.mcBfwl.BackColor = System.Drawing.Color.Transparent;
            this.mcBfwl.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mcBfwl.Location = new System.Drawing.Point(11, 301);
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
            this.mcFjzz.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mcFjzz.Name = "mcFjzz";
            this.mcFjzz.Size = new System.Drawing.Size(280, 51);
            this.mcFjzz.TabIndex = 38;
            // 
            // mcMosaic
            // 
            this.mcMosaic.BackColor = System.Drawing.Color.Transparent;
            this.mcMosaic.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mcMosaic.Location = new System.Drawing.Point(11, 495);
            this.mcMosaic.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mcMosaic.Name = "mcMosaic";
            this.mcMosaic.Size = new System.Drawing.Size(150, 51);
            this.mcMosaic.TabIndex = 39;
            // 
            // mcWqzx
            // 
            this.mcWqzx.BackColor = System.Drawing.Color.Transparent;
            this.mcWqzx.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mcWqzx.Location = new System.Drawing.Point(11, 575);
            this.mcWqzx.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mcWqzx.Name = "mcWqzx";
            this.mcWqzx.Size = new System.Drawing.Size(280, 34);
            this.mcWqzx.TabIndex = 38;
            // 
            // ascXytz
            // 
            this.ascXytz.BackColor = System.Drawing.Color.Transparent;
            this.ascXytz.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ascXytz.Location = new System.Drawing.Point(11, 193);
            this.ascXytz.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ascXytz.Name = "ascXytz";
            this.ascXytz.Size = new System.Drawing.Size(150, 102);
            this.ascXytz.TabIndex = 40;
            // 
            // lblFightPower
            // 
            this.lblFightPower.BackColor = System.Drawing.Color.Transparent;
            this.lblFightPower.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(151)))), ((int)(((byte)(5)))));
            this.lblFightPower.Location = new System.Drawing.Point(61, 689);
            this.lblFightPower.Name = "lblFightPower";
            this.lblFightPower.Size = new System.Drawing.Size(50, 17);
            this.lblFightPower.TabIndex = 17;
            this.lblFightPower.Text = "[数值]";
            // 
            // ArmPropertyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(320, 750);
            this.Controls.Add(this.ascXytz);
            this.Controls.Add(this.mcMosaic);
            this.Controls.Add(this.mcWqzx);
            this.Controls.Add(this.mcFjzz);
            this.Controls.Add(this.mcGyhd);
            this.Controls.Add(this.mcBfwl);
            this.Controls.Add(this.ftcTitle);
            this.Controls.Add(this.bpcProperty);
            this.Controls.Add(this.lblMosaicTitle);
            this.Controls.Add(this.lblArtificeTitle);
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
        private System.Windows.Forms.Label lblMosaicTitle;
        private System.Windows.Forms.Label lblArtificeTitle;
        private System.Windows.Forms.Label lblArmStory;
        private System.Windows.Forms.Label lblDetail;
        private System.Windows.Forms.Label lblFightName;
        private Components.BasePropertyCtrl bpcProperty;
        private Components.FurnishTypeCtrl ftcTitle;
        private Components.MagicCtrl mcBfwl;
        private Components.MagicCtrl mcGyhd;
        private Components.MagicCtrl mcFjzz;
        private Components.MosaicCtrl mcMosaic;
        private Components.MagicCtrl mcWqzx;
        private Components.ArmSuitCtrl ascXytz;
        private System.Windows.Forms.Label lblFightPower;
    }
}