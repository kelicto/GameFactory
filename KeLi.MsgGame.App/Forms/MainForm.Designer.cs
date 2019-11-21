using KeLi.MsgGame.App.Properties;

namespace KeLi.MsgGame.App.Forms
{
    partial class MainForm
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
            this.mcMatch = new KeLi.MsgGame.App.Components.MatchCtrl();
            this.atcTask = new KeLi.MsgGame.App.Components.ActiveTaskCtrl();
            this.mcMsg = new KeLi.MsgGame.App.Components.MsgCtrl();
            this.glcGamer = new KeLi.MsgGame.App.Components.GamerListCtrl();
            this.rlcRoom = new KeLi.MsgGame.App.Components.RoomListCtrl();
            this.mmcMenu = new KeLi.MsgGame.App.Components.MainMenuCtrl();
            this.SuspendLayout();
            // 
            // mcMatch
            // 
            this.mcMatch.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.mcMatch.BackColor = System.Drawing.Color.Transparent;
            this.mcMatch.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mcMatch.Location = new System.Drawing.Point(520, 800);
            this.mcMatch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mcMatch.Name = "mcMatch";
            this.mcMatch.Size = new System.Drawing.Size(170, 100);
            this.mcMatch.TabIndex = 18;
            // 
            // atcTask
            // 
            this.atcTask.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.atcTask.BackColor = System.Drawing.Color.Transparent;
            this.atcTask.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.atcTask.Location = new System.Drawing.Point(1250, 393);
            this.atcTask.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.atcTask.Name = "atcTask";
            this.atcTask.Size = new System.Drawing.Size(50, 400);
            this.atcTask.TabIndex = 17;
            // 
            // mcMsg
            // 
            this.mcMsg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.mcMsg.BackColor = System.Drawing.Color.Transparent;
            this.mcMsg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mcMsg.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mcMsg.Location = new System.Drawing.Point(0, 644);
            this.mcMsg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mcMsg.Name = "mcMsg";
            this.mcMsg.Size = new System.Drawing.Size(360, 256);
            this.mcMsg.TabIndex = 16;
            // 
            // glcGamer
            // 
            this.glcGamer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.glcGamer.BackColor = System.Drawing.Color.Transparent;
            this.glcGamer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.glcGamer.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.glcGamer.Location = new System.Drawing.Point(940, 0);
            this.glcGamer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.glcGamer.Name = "glcGamer";
            this.glcGamer.Size = new System.Drawing.Size(360, 386);
            this.glcGamer.TabIndex = 14;
            // 
            // rlcRoom
            // 
            this.rlcRoom.BackColor = System.Drawing.Color.Transparent;
            this.rlcRoom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rlcRoom.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rlcRoom.Location = new System.Drawing.Point(0, 0);
            this.rlcRoom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rlcRoom.Name = "rlcRoom";
            this.rlcRoom.Size = new System.Drawing.Size(360, 386);
            this.rlcRoom.TabIndex = 13;
            // 
            // mmcMenu
            // 
            this.mmcMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mmcMenu.BackColor = System.Drawing.Color.Transparent;
            this.mmcMenu.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mmcMenu.Location = new System.Drawing.Point(850, 800);
            this.mmcMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mmcMenu.Name = "mmcMenu";
            this.mmcMenu.Size = new System.Drawing.Size(450, 100);
            this.mmcMenu.TabIndex = 11;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1300, 900);
            this.Controls.Add(this.mcMatch);
            this.Controls.Add(this.atcTask);
            this.Controls.Add(this.mcMsg);
            this.Controls.Add(this.glcGamer);
            this.Controls.Add(this.rlcRoom);
            this.Controls.Add(this.mmcMenu);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion
        private Components.MainMenuCtrl mmcMenu;
        private Components.RoomListCtrl rlcRoom;
        private Components.GamerListCtrl glcGamer;
        private Components.MsgCtrl mcMsg;
        private Components.ActiveTaskCtrl atcTask;
        private Components.MatchCtrl mcMatch;
    }
}