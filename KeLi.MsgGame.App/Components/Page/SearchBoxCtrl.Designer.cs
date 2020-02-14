namespace KeLi.MsgGame.App.Components.Page
{
    partial class SearchBoxCtrl
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
            this.lblCmd = new System.Windows.Forms.Label();
            this.TxtInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblCmd
            // 
            this.lblCmd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCmd.BackColor = System.Drawing.Color.Transparent;
            this.lblCmd.Location = new System.Drawing.Point(95, 0);
            this.lblCmd.Name = "lblCmd";
            this.lblCmd.Size = new System.Drawing.Size(29, 29);
            this.lblCmd.TabIndex = 11;
            this.lblCmd.Text = "#";
            this.lblCmd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtInput
            // 
            this.TxtInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(31)))), ((int)(((byte)(21)))));
            this.TxtInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtInput.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TxtInput.ForeColor = System.Drawing.SystemColors.Control;
            this.TxtInput.Location = new System.Drawing.Point(0, 0);
            this.TxtInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtInput.Name = "TxtInput";
            this.TxtInput.Size = new System.Drawing.Size(124, 29);
            this.TxtInput.TabIndex = 10;
            // 
            // SearchBoxCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblCmd);
            this.Controls.Add(this.TxtInput);
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "SearchBoxCtrl";
            this.Size = new System.Drawing.Size(120, 29);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCmd;
        private System.Windows.Forms.TextBox TxtInput;
    }
}
