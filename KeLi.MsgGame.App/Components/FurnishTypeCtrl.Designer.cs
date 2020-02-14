using KeLi.MsgGame.App.Properties;

namespace KeLi.MsgGame.App.Components
{
    partial class FurnishTypeCtrl
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
            this.lblCanSplit = new System.Windows.Forms.Label();
            this.lblCanDiscard = new System.Windows.Forms.Label();
            this.lblEnhance = new System.Windows.Forms.Label();
            this.lblIsBinding = new System.Windows.Forms.Label();
            this.lblFurnishType = new System.Windows.Forms.Label();
            this.lblFurnishName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCanSplit
            // 
            this.lblCanSplit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCanSplit.BackColor = System.Drawing.Color.Transparent;
            this.lblCanSplit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(186)))), ((int)(((byte)(183)))));
            this.lblCanSplit.Location = new System.Drawing.Point(0, 85);
            this.lblCanSplit.Name = "lblCanSplit";
            this.lblCanSplit.Size = new System.Drawing.Size(160, 17);
            this.lblCanSplit.TabIndex = 38;
            this.lblCanSplit.Text = "[是否可以分解]";
            this.lblCanSplit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCanDiscard
            // 
            this.lblCanDiscard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCanDiscard.BackColor = System.Drawing.Color.Transparent;
            this.lblCanDiscard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(186)))), ((int)(((byte)(183)))));
            this.lblCanDiscard.Location = new System.Drawing.Point(0, 68);
            this.lblCanDiscard.Name = "lblCanDiscard";
            this.lblCanDiscard.Size = new System.Drawing.Size(160, 17);
            this.lblCanDiscard.TabIndex = 37;
            this.lblCanDiscard.Text = "[是否可以丢弃]";
            this.lblCanDiscard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEnhance
            // 
            this.lblEnhance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEnhance.BackColor = System.Drawing.Color.Transparent;
            this.lblEnhance.ForeColor = System.Drawing.Color.Purple;
            this.lblEnhance.Location = new System.Drawing.Point(0, 51);
            this.lblEnhance.Name = "lblEnhance";
            this.lblEnhance.Size = new System.Drawing.Size(160, 17);
            this.lblEnhance.TabIndex = 36;
            this.lblEnhance.Text = "[强化等级]";
            this.lblEnhance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblIsBinding
            // 
            this.lblIsBinding.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIsBinding.BackColor = System.Drawing.Color.Transparent;
            this.lblIsBinding.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(214)))), ((int)(((byte)(4)))));
            this.lblIsBinding.Location = new System.Drawing.Point(0, 34);
            this.lblIsBinding.Name = "lblIsBinding";
            this.lblIsBinding.Size = new System.Drawing.Size(160, 17);
            this.lblIsBinding.TabIndex = 35;
            this.lblIsBinding.Text = "[是否绑定]";
            this.lblIsBinding.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFurnishType
            // 
            this.lblFurnishType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFurnishType.BackColor = System.Drawing.Color.Transparent;
            this.lblFurnishType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(186)))), ((int)(((byte)(183)))));
            this.lblFurnishType.Location = new System.Drawing.Point(0, 17);
            this.lblFurnishType.Name = "lblFurnishType";
            this.lblFurnishType.Size = new System.Drawing.Size(160, 17);
            this.lblFurnishType.TabIndex = 34;
            this.lblFurnishType.Text = "[装备类型]>[穿戴部位]";
            this.lblFurnishType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFurnishName
            // 
            this.lblFurnishName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFurnishName.BackColor = System.Drawing.Color.Transparent;
            this.lblFurnishName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(100)))), ((int)(((byte)(70)))));
            this.lblFurnishName.Location = new System.Drawing.Point(0, 0);
            this.lblFurnishName.Name = "lblFurnishName";
            this.lblFurnishName.Size = new System.Drawing.Size(210, 17);
            this.lblFurnishName.TabIndex = 40;
            this.lblFurnishName.Text = "[装备名]([炼化类型])+[等级]";
            this.lblFurnishName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FurnishTypeCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Controls.Add(this.lblCanSplit);
            this.Controls.Add(this.lblCanDiscard);
            this.Controls.Add(this.lblEnhance);
            this.Controls.Add(this.lblIsBinding);
            this.Controls.Add(this.lblFurnishType);
            this.Controls.Add(this.lblFurnishName);
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "FurnishTypeCtrl";
            this.Size = new System.Drawing.Size(160, 102);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCanSplit;
        private System.Windows.Forms.Label lblCanDiscard;
        private System.Windows.Forms.Label lblEnhance;
        private System.Windows.Forms.Label lblIsBinding;
        private System.Windows.Forms.Label lblFurnishType;
        private System.Windows.Forms.Label lblFurnishName;
    }
}
