using KeLi.MsgGame.App.Components.Part;
using KeLi.MsgGame.App.Properties;

namespace KeLi.MsgGame.App.Forms
{
    sealed partial class FurnishPropertyForm
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
            this.fscZytz = new FurnishSuitCtrl();
            this.bpcProperty = new BasePropertyCtrl();
            this.ftcTitle = new FurnishTypeCtrl();
            this.mcMosaic = new MosaicCtrl();
            this.mcWqzx = new MagicCtrl();
            this.lblFightPower = new System.Windows.Forms.Label();
            this.lblFightName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMosaicTitle
            // 
            this.lblMosaicTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblMosaicTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(151)))), ((int)(((byte)(5)))));
            this.lblMosaicTitle.Location = new System.Drawing.Point(11, 339);
            this.lblMosaicTitle.Name = "lblMosaicTitle";
            this.lblMosaicTitle.Size = new System.Drawing.Size(58, 17);
            this.lblMosaicTitle.TabIndex = 64;
            this.lblMosaicTitle.Text = "镶嵌加成";
            this.lblMosaicTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblArtificeTitle
            // 
            this.lblArtificeTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblArtificeTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(151)))), ((int)(((byte)(5)))));
            this.lblArtificeTitle.Location = new System.Drawing.Point(11, 421);
            this.lblArtificeTitle.Name = "lblArtificeTitle";
            this.lblArtificeTitle.Size = new System.Drawing.Size(58, 17);
            this.lblArtificeTitle.TabIndex = 63;
            this.lblArtificeTitle.Text = "炼化加成";
            this.lblArtificeTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblArmStory
            // 
            this.lblArmStory.BackColor = System.Drawing.Color.Transparent;
            this.lblArmStory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(132)))), ((int)(((byte)(153)))));
            this.lblArmStory.Location = new System.Drawing.Point(11, 486);
            this.lblArmStory.Name = "lblArmStory";
            this.lblArmStory.Size = new System.Drawing.Size(298, 68);
            this.lblArmStory.TabIndex = 51;
            this.lblArmStory.Text = "这是一段装备历史故事。";
            // 
            // lblDetail
            // 
            this.lblDetail.BackColor = System.Drawing.Color.Transparent;
            this.lblDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(5)))), ((int)(((byte)(3)))));
            this.lblDetail.Location = new System.Drawing.Point(11, 588);
            this.lblDetail.Name = "lblDetail";
            this.lblDetail.Size = new System.Drawing.Size(168, 17);
            this.lblDetail.TabIndex = 65;
            this.lblDetail.Text = "装备附加的能力不带入竞技场";
            // 
            // fscZytz
            // 
            this.fscZytz.BackColor = System.Drawing.Color.Transparent;
            this.fscZytz.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.fscZytz.Location = new System.Drawing.Point(11, 196);
            this.fscZytz.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fscZytz.Name = "fscZytz";
            this.fscZytz.Size = new System.Drawing.Size(150, 136);
            this.fscZytz.TabIndex = 67;
            // 
            // bpcProperty
            // 
            this.bpcProperty.BackColor = System.Drawing.Color.Transparent;
            this.bpcProperty.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bpcProperty.Location = new System.Drawing.Point(11, 121);
            this.bpcProperty.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bpcProperty.Name = "bpcProperty";
            this.bpcProperty.Size = new System.Drawing.Size(120, 68);
            this.bpcProperty.TabIndex = 68;
            // 
            // ftcTitle
            // 
            this.ftcTitle.BackColor = System.Drawing.Color.Transparent;
            this.ftcTitle.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ftcTitle.Location = new System.Drawing.Point(11, 12);
            this.ftcTitle.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.ftcTitle.Name = "ftcTitle";
            this.ftcTitle.Size = new System.Drawing.Size(160, 102);
            this.ftcTitle.TabIndex = 69;
            // 
            // mcMosaic
            // 
            this.mcMosaic.BackColor = System.Drawing.Color.Transparent;
            this.mcMosaic.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mcMosaic.Location = new System.Drawing.Point(11, 363);
            this.mcMosaic.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mcMosaic.Name = "mcMosaic";
            this.mcMosaic.Size = new System.Drawing.Size(150, 51);
            this.mcMosaic.TabIndex = 70;
            // 
            // mcWqzx
            // 
            this.mcWqzx.BackColor = System.Drawing.Color.Transparent;
            this.mcWqzx.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mcWqzx.Location = new System.Drawing.Point(11, 445);
            this.mcWqzx.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mcWqzx.Name = "mcWqzx";
            this.mcWqzx.Size = new System.Drawing.Size(280, 34);
            this.mcWqzx.TabIndex = 71;
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
            // FurnishPropertyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(320, 620);
            this.Controls.Add(this.lblFightPower);
            this.Controls.Add(this.lblFightName);
            this.Controls.Add(this.mcWqzx);
            this.Controls.Add(this.mcMosaic);
            this.Controls.Add(this.ftcTitle);
            this.Controls.Add(this.bpcProperty);
            this.Controls.Add(this.fscZytz);
            this.Controls.Add(this.lblMosaicTitle);
            this.Controls.Add(this.lblArtificeTitle);
            this.Controls.Add(this.lblArmStory);
            this.Controls.Add(this.lblDetail);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "FurnishPropertyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FurnishPropertyForm";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblMosaicTitle;
        private System.Windows.Forms.Label lblArtificeTitle;
        private System.Windows.Forms.Label lblArmStory;
        private System.Windows.Forms.Label lblDetail;
        private FurnishSuitCtrl fscZytz;
        private BasePropertyCtrl bpcProperty;
        private FurnishTypeCtrl ftcTitle;
        private MosaicCtrl mcMosaic;
        private MagicCtrl mcWqzx;
        private System.Windows.Forms.Label lblFightPower;
        private System.Windows.Forms.Label lblFightName;
    }
}