namespace KeLi.HulaiSang.Pages
{
    partial class ChatMessageControl
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
            this.lblLast = new System.Windows.Forms.Label();
            this.lblNext = new System.Windows.Forms.Label();
            this.lblBottom = new System.Windows.Forms.Label();
            this.lblGamer = new System.Windows.Forms.Label();
            this.lblSend = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLast
            // 
            this.lblLast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLast.BackColor = System.Drawing.Color.Transparent;
            this.lblLast.ForeColor = System.Drawing.Color.White;
            this.lblLast.Location = new System.Drawing.Point(0, 22);
            this.lblLast.Name = "lblLast";
            this.lblLast.Size = new System.Drawing.Size(32, 32);
            this.lblLast.TabIndex = 11;
            this.lblLast.Text = "^";
            this.lblLast.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNext
            // 
            this.lblNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNext.BackColor = System.Drawing.Color.Transparent;
            this.lblNext.ForeColor = System.Drawing.Color.White;
            this.lblNext.Location = new System.Drawing.Point(0, 54);
            this.lblNext.Name = "lblNext";
            this.lblNext.Size = new System.Drawing.Size(32, 32);
            this.lblNext.TabIndex = 11;
            this.lblNext.Text = "v";
            this.lblNext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBottom
            // 
            this.lblBottom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblBottom.BackColor = System.Drawing.Color.Transparent;
            this.lblBottom.ForeColor = System.Drawing.Color.White;
            this.lblBottom.Location = new System.Drawing.Point(0, 86);
            this.lblBottom.Name = "lblBottom";
            this.lblBottom.Size = new System.Drawing.Size(32, 32);
            this.lblBottom.TabIndex = 11;
            this.lblBottom.Text = "B";
            this.lblBottom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGamer
            // 
            this.lblGamer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblGamer.BackColor = System.Drawing.Color.Transparent;
            this.lblGamer.ForeColor = System.Drawing.Color.White;
            this.lblGamer.Location = new System.Drawing.Point(32, 118);
            this.lblGamer.Name = "lblGamer";
            this.lblGamer.Size = new System.Drawing.Size(70, 32);
            this.lblGamer.TabIndex = 12;
            this.lblGamer.Text = "张翼德之力";
            this.lblGamer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSend
            // 
            this.lblSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSend.BackColor = System.Drawing.Color.Transparent;
            this.lblSend.ForeColor = System.Drawing.Color.White;
            this.lblSend.Location = new System.Drawing.Point(328, 118);
            this.lblSend.Name = "lblSend";
            this.lblSend.Size = new System.Drawing.Size(32, 32);
            this.lblSend.TabIndex = 11;
            this.lblSend.Text = "v";
            this.lblSend.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMin
            // 
            this.lblMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMin.BackColor = System.Drawing.Color.Transparent;
            this.lblMin.ForeColor = System.Drawing.Color.White;
            this.lblMin.Location = new System.Drawing.Point(0, 118);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(32, 32);
            this.lblMin.TabIndex = 11;
            this.lblMin.Text = "-";
            this.lblMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(102, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 32);
            this.label1.TabIndex = 12;
            this.label1.Text = "你好，张翼德！";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ChatMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblGamer);
            this.Controls.Add(this.lblSend);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.lblBottom);
            this.Controls.Add(this.lblNext);
            this.Controls.Add(this.lblLast);
            this.Name = "ChatMessage";
            this.Size = new System.Drawing.Size(360, 150);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblLast;
        private System.Windows.Forms.Label lblNext;
        private System.Windows.Forms.Label lblBottom;
        private System.Windows.Forms.Label lblGamer;
        private System.Windows.Forms.Label lblSend;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label label1;
    }
}
