using KeLi.MsgGame.App.Properties;

namespace KeLi.MsgGame.App.Components
{
    partial class RoomListCtrl
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
            this.LblRoomList = new System.Windows.Forms.Label();
            this.PnlContent = new System.Windows.Forms.Panel();
            this.PnlPage = new System.Windows.Forms.Panel();
            this.LblMatch = new System.Windows.Forms.Label();
            this.LblAll = new System.Windows.Forms.Label();
            this.LblLast = new System.Windows.Forms.Label();
            this.LblCreateRoom = new System.Windows.Forms.Label();
            this.LblPagePosition = new System.Windows.Forms.Label();
            this.LblNext = new System.Windows.Forms.Label();
            this.LblMapName = new System.Windows.Forms.Label();
            this.LblRecord = new System.Windows.Forms.Label();
            this.LblFlee = new System.Windows.Forms.Label();
            this.LblGaming = new System.Windows.Forms.Label();
            this.LblPerson = new System.Windows.Forms.Label();
            this.LblLive = new System.Windows.Forms.Label();
            this.PnlTitle = new System.Windows.Forms.Panel();
            this.LblSelectMap = new System.Windows.Forms.Label();
            this.LblSearchRoom = new System.Windows.Forms.Label();
            this.PnlPage.SuspendLayout();
            this.PnlTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblRoomList
            // 
            this.LblRoomList.BackColor = System.Drawing.Color.Transparent;
            this.LblRoomList.Location = new System.Drawing.Point(0, 0);
            this.LblRoomList.Name = "LblRoomList";
            this.LblRoomList.Size = new System.Drawing.Size(240, 32);
            this.LblRoomList.TabIndex = 8;
            this.LblRoomList.Text = "房间列表";
            this.LblRoomList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PnlContent
            // 
            this.PnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlContent.Location = new System.Drawing.Point(0, 65);
            this.PnlContent.Name = "PnlContent";
            this.PnlContent.Size = new System.Drawing.Size(360, 277);
            this.PnlContent.TabIndex = 1;
            // 
            // PnlPage
            // 
            this.PnlPage.Controls.Add(this.LblMatch);
            this.PnlPage.Controls.Add(this.LblAll);
            this.PnlPage.Controls.Add(this.LblLast);
            this.PnlPage.Controls.Add(this.LblCreateRoom);
            this.PnlPage.Controls.Add(this.LblPagePosition);
            this.PnlPage.Controls.Add(this.LblNext);
            this.PnlPage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlPage.Location = new System.Drawing.Point(0, 342);
            this.PnlPage.Name = "PnlPage";
            this.PnlPage.Size = new System.Drawing.Size(360, 44);
            this.PnlPage.TabIndex = 14;
            // 
            // LblMatch
            // 
            this.LblMatch.BackColor = System.Drawing.Color.Transparent;
            this.LblMatch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblMatch.Location = new System.Drawing.Point(50, 6);
            this.LblMatch.Name = "LblMatch";
            this.LblMatch.Size = new System.Drawing.Size(38, 32);
            this.LblMatch.TabIndex = 12;
            this.LblMatch.Text = "匹配";
            this.LblMatch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblAll
            // 
            this.LblAll.BackColor = System.Drawing.Color.Transparent;
            this.LblAll.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblAll.Location = new System.Drawing.Point(6, 6);
            this.LblAll.Name = "LblAll";
            this.LblAll.Size = new System.Drawing.Size(38, 32);
            this.LblAll.TabIndex = 12;
            this.LblAll.Text = "综合";
            this.LblAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblLast
            // 
            this.LblLast.BackColor = System.Drawing.Color.Transparent;
            this.LblLast.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblLast.Location = new System.Drawing.Point(113, 6);
            this.LblLast.Name = "LblLast";
            this.LblLast.Size = new System.Drawing.Size(32, 32);
            this.LblLast.TabIndex = 11;
            this.LblLast.Text = "<";
            this.LblLast.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblCreateRoom
            // 
            this.LblCreateRoom.BackColor = System.Drawing.Color.Transparent;
            this.LblCreateRoom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblCreateRoom.Location = new System.Drawing.Point(294, 6);
            this.LblCreateRoom.Name = "LblCreateRoom";
            this.LblCreateRoom.Size = new System.Drawing.Size(60, 32);
            this.LblCreateRoom.TabIndex = 8;
            this.LblCreateRoom.Text = "创建房间";
            this.LblCreateRoom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblPagePosition
            // 
            this.LblPagePosition.BackColor = System.Drawing.Color.Transparent;
            this.LblPagePosition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblPagePosition.Location = new System.Drawing.Point(151, 6);
            this.LblPagePosition.Name = "LblPagePosition";
            this.LblPagePosition.Size = new System.Drawing.Size(59, 32);
            this.LblPagePosition.TabIndex = 8;
            this.LblPagePosition.Text = "1/100";
            this.LblPagePosition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblNext
            // 
            this.LblNext.BackColor = System.Drawing.Color.Transparent;
            this.LblNext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblNext.Location = new System.Drawing.Point(216, 6);
            this.LblNext.Name = "LblNext";
            this.LblNext.Size = new System.Drawing.Size(32, 32);
            this.LblNext.TabIndex = 10;
            this.LblNext.Text = ">";
            this.LblNext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblMapName
            // 
            this.LblMapName.BackColor = System.Drawing.Color.Transparent;
            this.LblMapName.Location = new System.Drawing.Point(0, 32);
            this.LblMapName.Name = "LblMapName";
            this.LblMapName.Size = new System.Drawing.Size(112, 32);
            this.LblMapName.TabIndex = 8;
            this.LblMapName.Text = "<所有地图>";
            this.LblMapName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblRecord
            // 
            this.LblRecord.BackColor = System.Drawing.Color.Transparent;
            this.LblRecord.Location = new System.Drawing.Point(240, 0);
            this.LblRecord.Name = "LblRecord";
            this.LblRecord.Size = new System.Drawing.Size(60, 32);
            this.LblRecord.TabIndex = 9;
            this.LblRecord.Text = "存档";
            this.LblRecord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblFlee
            // 
            this.LblFlee.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LblFlee.BackColor = System.Drawing.Color.Transparent;
            this.LblFlee.Location = new System.Drawing.Point(328, 32);
            this.LblFlee.Name = "LblFlee";
            this.LblFlee.Size = new System.Drawing.Size(32, 32);
            this.LblFlee.TabIndex = 9;
            this.LblFlee.Text = "$";
            this.LblFlee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblGaming
            // 
            this.LblGaming.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LblGaming.BackColor = System.Drawing.Color.Transparent;
            this.LblGaming.Location = new System.Drawing.Point(296, 32);
            this.LblGaming.Name = "LblGaming";
            this.LblGaming.Size = new System.Drawing.Size(32, 32);
            this.LblGaming.TabIndex = 9;
            this.LblGaming.Text = "$";
            this.LblGaming.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblPerson
            // 
            this.LblPerson.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LblPerson.BackColor = System.Drawing.Color.Transparent;
            this.LblPerson.Location = new System.Drawing.Point(264, 32);
            this.LblPerson.Name = "LblPerson";
            this.LblPerson.Size = new System.Drawing.Size(32, 32);
            this.LblPerson.TabIndex = 9;
            this.LblPerson.Text = "$";
            this.LblPerson.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblLive
            // 
            this.LblLive.BackColor = System.Drawing.Color.Transparent;
            this.LblLive.Location = new System.Drawing.Point(300, 0);
            this.LblLive.Name = "LblLive";
            this.LblLive.Size = new System.Drawing.Size(60, 32);
            this.LblLive.TabIndex = 10;
            this.LblLive.Text = "直播";
            this.LblLive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PnlTitle
            // 
            this.PnlTitle.Controls.Add(this.LblLive);
            this.PnlTitle.Controls.Add(this.LblPerson);
            this.PnlTitle.Controls.Add(this.LblGaming);
            this.PnlTitle.Controls.Add(this.LblFlee);
            this.PnlTitle.Controls.Add(this.LblSelectMap);
            this.PnlTitle.Controls.Add(this.LblRecord);
            this.PnlTitle.Controls.Add(this.LblSearchRoom);
            this.PnlTitle.Controls.Add(this.LblMapName);
            this.PnlTitle.Controls.Add(this.LblRoomList);
            this.PnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTitle.Location = new System.Drawing.Point(0, 0);
            this.PnlTitle.Name = "PnlTitle";
            this.PnlTitle.Size = new System.Drawing.Size(360, 65);
            this.PnlTitle.TabIndex = 0;
            // 
            // LblSelectMap
            // 
            this.LblSelectMap.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LblSelectMap.BackColor = System.Drawing.Color.Transparent;
            this.LblSelectMap.Location = new System.Drawing.Point(112, 32);
            this.LblSelectMap.Name = "LblSelectMap";
            this.LblSelectMap.Size = new System.Drawing.Size(32, 32);
            this.LblSelectMap.TabIndex = 9;
            this.LblSelectMap.Text = "v";
            this.LblSelectMap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblSearchRoom
            // 
            this.LblSearchRoom.BackColor = System.Drawing.Color.Transparent;
            this.LblSearchRoom.Location = new System.Drawing.Point(144, 32);
            this.LblSearchRoom.Name = "LblSearchRoom";
            this.LblSearchRoom.Size = new System.Drawing.Size(120, 32);
            this.LblSearchRoom.TabIndex = 8;
            this.LblSearchRoom.Text = "搜索房间...";
            this.LblSearchRoom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RoomListCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.PnlContent);
            this.Controls.Add(this.PnlPage);
            this.Controls.Add(this.PnlTitle);
            this.Name = "RoomListCtrl";
            this.Size = new System.Drawing.Size(360, 386);
            this.PnlPage.ResumeLayout(false);
            this.PnlTitle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label LblRoomList;
        private System.Windows.Forms.Panel PnlContent;
        private System.Windows.Forms.Panel PnlPage;
        private System.Windows.Forms.Label LblLast;
        private System.Windows.Forms.Label LblPagePosition;
        private System.Windows.Forms.Label LblNext;
        private System.Windows.Forms.Label LblMatch;
        private System.Windows.Forms.Label LblAll;
        private System.Windows.Forms.Label LblCreateRoom;
        private System.Windows.Forms.Label LblMapName;
        private System.Windows.Forms.Label LblRecord;
        private System.Windows.Forms.Label LblFlee;
        private System.Windows.Forms.Label LblGaming;
        private System.Windows.Forms.Label LblPerson;
        private System.Windows.Forms.Label LblLive;
        private System.Windows.Forms.Panel PnlTitle;
        private System.Windows.Forms.Label LblSelectMap;
        private System.Windows.Forms.Label LblSearchRoom;
    }
}
