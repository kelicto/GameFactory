
namespace KeLi.HulaiSang.Forms
{
    partial class HeroListForm
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
            this.label16 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.heroInfo1 = new KeLi.HulaiSang.Hero.HeroInfoControl();
            this.heroInfo2 = new KeLi.HulaiSang.Hero.HeroInfoControl();
            this.heroInfo3 = new KeLi.HulaiSang.Hero.HeroInfoControl();
            this.SuspendLayout();
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(0, 250);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(32, 32);
            this.label16.TabIndex = 22;
            this.label16.Text = "<";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(965, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 32);
            this.label1.TabIndex = 22;
            this.label1.Text = ">";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // heroInfo1
            // 
            this.heroInfo1.BackColor = System.Drawing.Color.Teal;
            this.heroInfo1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.heroInfo1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.heroInfo1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(202)))), ((int)(((byte)(176)))));
            this.heroInfo1.Location = new System.Drawing.Point(45, 9);
            this.heroInfo1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.heroInfo1.Name = "heroInfo1";
            this.heroInfo1.Size = new System.Drawing.Size(298, 548);
            this.heroInfo1.TabIndex = 23;
            // 
            // heroInfo2
            // 
            this.heroInfo2.BackColor = System.Drawing.Color.Teal;
            this.heroInfo2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.heroInfo2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.heroInfo2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(202)))), ((int)(((byte)(176)))));
            this.heroInfo2.Location = new System.Drawing.Point(349, 9);
            this.heroInfo2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.heroInfo2.Name = "heroInfo2";
            this.heroInfo2.Size = new System.Drawing.Size(298, 548);
            this.heroInfo2.TabIndex = 23;
            // 
            // heroInfo3
            // 
            this.heroInfo3.BackColor = System.Drawing.Color.Teal;
            this.heroInfo3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.heroInfo3.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.heroInfo3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(202)))), ((int)(((byte)(176)))));
            this.heroInfo3.Location = new System.Drawing.Point(653, 9);
            this.heroInfo3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.heroInfo3.Name = "heroInfo3";
            this.heroInfo3.Size = new System.Drawing.Size(298, 548);
            this.heroInfo3.TabIndex = 23;
            // 
            // HeroListFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 570);
            this.Controls.Add(this.heroInfo3);
            this.Controls.Add(this.heroInfo2);
            this.Controls.Add(this.heroInfo1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label16);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "HeroListFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HeroListFrm";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label1;
        private Hero.HeroInfoControl heroInfo1;
        private Hero.HeroInfoControl heroInfo2;
        private Hero.HeroInfoControl heroInfo3;
    }
}