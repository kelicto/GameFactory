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
            this.lblRoomList = new System.Windows.Forms.Label();
            this.PnlContent = new System.Windows.Forms.Panel();
            this.PnlPage = new System.Windows.Forms.Panel();
            this.lblMatch = new System.Windows.Forms.Label();
            this.lblAll = new System.Windows.Forms.Label();
            this.lblLast = new System.Windows.Forms.Label();
            this.lblCreateRoom = new System.Windows.Forms.Label();
            this.lblPagePosition = new System.Windows.Forms.Label();
            this.lblNext = new System.Windows.Forms.Label();
            this.lblMapName = new System.Windows.Forms.Label();
            this.lblRecord = new System.Windows.Forms.Label();
            this.lblFlee = new System.Windows.Forms.Label();
            this.lblGaming = new System.Windows.Forms.Label();
            this.lblPerson = new System.Windows.Forms.Label();
            this.lblLive = new System.Windows.Forms.Label();
            this.PnlTitle = new System.Windows.Forms.Panel();
            this.lblSelectMap = new System.Windows.Forms.Label();
            this.lblSearchRoom = new System.Windows.Forms.Label();
            this.PnlPage.SuspendLayout();
            this.PnlTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRoomList
            // 
            this.lblRoomList.BackColor = System.Drawing.Color.Transparent;
            this.lblRoomList.Location = new System.Drawing.Point(0, 0);
            this.lblRoomList.Name = "lblRoomList";
            this.lblRoomList.Size = new System.Drawing.Size(240, 32);
            this.lblRoomList.TabIndex = 8;
            this.lblRoomList.Text = "房间列表";
            this.lblRoomList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.PnlPage.Controls.Add(this.lblMatch);
            this.PnlPage.Controls.Add(this.lblAll);
            this.PnlPage.Controls.Add(this.lblLast);
            this.PnlPage.Controls.Add(this.lblCreateRoom);
            this.PnlPage.Controls.Add(this.lblPagePosition);
            this.PnlPage.Controls.Add(this.lblNext);
            this.PnlPage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlPage.Location = new System.Drawing.Point(0, 342);
            this.PnlPage.Name = "PnlPage";
            this.PnlPage.Size = new System.Drawing.Size(360, 44);
            this.PnlPage.TabIndex = 14;
            // 
            // lblMatch
            // 
            this.lblMatch.BackColor = System.Drawing.Color.Transparent;
            this.lblMatch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMatch.Location = new System.Drawing.Point(50, 6);
            this.lblMatch.Name = "lblMatch";
            this.lblMatch.Size = new System.Drawing.Size(38, 32);
            this.lblMatch.TabIndex = 12;
            this.lblMatch.Text = "匹配";
            this.lblMatch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAll
            // 
            this.lblAll.BackColor = System.Drawing.Color.Transparent;
            this.lblAll.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAll.Location = new System.Drawing.Point(6, 6);
            this.lblAll.Name = "lblAll";
            this.lblAll.Size = new System.Drawing.Size(38, 32);
            this.lblAll.TabIndex = 12;
            this.lblAll.Text = "综合";
            this.lblAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLast
            // 
            this.lblLast.BackColor = System.Drawing.Color.Transparent;
            this.lblLast.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLast.Location = new System.Drawing.Point(113, 6);
            this.lblLast.Name = "lblLast";
            this.lblLast.Size = new System.Drawing.Size(32, 32);
            this.lblLast.TabIndex = 11;
            this.lblLast.Text = "<";
            this.lblLast.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCreateRoom
            // 
            this.lblCreateRoom.BackColor = System.Drawing.Color.Transparent;
            this.lblCreateRoom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCreateRoom.Location = new System.Drawing.Point(294, 6);
            this.lblCreateRoom.Name = "lblCreateRoom";
            this.lblCreateRoom.Size = new System.Drawing.Size(60, 32);
            this.lblCreateRoom.TabIndex = 8;
            this.lblCreateRoom.Text = "创建房间";
            this.lblCreateRoom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPagePosition
            // 
            this.lblPagePosition.BackColor = System.Drawing.Color.Transparent;
            this.lblPagePosition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPagePosition.Location = new System.Drawing.Point(151, 6);
            this.lblPagePosition.Name = "lblPagePosition";
            this.lblPagePosition.Size = new System.Drawing.Size(59, 32);
            this.lblPagePosition.TabIndex = 8;
            this.lblPagePosition.Text = "1/100";
            this.lblPagePosition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNext
            // 
            this.lblNext.BackColor = System.Drawing.Color.Transparent;
            this.lblNext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNext.Location = new System.Drawing.Point(216, 6);
            this.lblNext.Name = "lblNext";
            this.lblNext.Size = new System.Drawing.Size(32, 32);
            this.lblNext.TabIndex = 10;
            this.lblNext.Text = ">";
            this.lblNext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMapName
            // 
            this.lblMapName.BackColor = System.Drawing.Color.Transparent;
            this.lblMapName.Location = new System.Drawing.Point(0, 32);
            this.lblMapName.Name = "lblMapName";
            this.lblMapName.Size = new System.Drawing.Size(112, 32);
            this.lblMapName.TabIndex = 8;
            this.lblMapName.Text = "<所有地图>";
            this.lblMapName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRecord
            // 
            this.lblRecord.BackColor = System.Drawing.Color.Transparent;
            this.lblRecord.Location = new System.Drawing.Point(240, 0);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(60, 32);
            this.lblRecord.TabIndex = 9;
            this.lblRecord.Text = "存档";
            this.lblRecord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFlee
            // 
            this.lblFlee.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblFlee.BackColor = System.Drawing.Color.Transparent;
            this.lblFlee.Location = new System.Drawing.Point(328, 32);
            this.lblFlee.Name = "lblFlee";
            this.lblFlee.Size = new System.Drawing.Size(32, 32);
            this.lblFlee.TabIndex = 9;
            this.lblFlee.Text = "$";
            this.lblFlee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGaming
            // 
            this.lblGaming.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblGaming.BackColor = System.Drawing.Color.Transparent;
            this.lblGaming.Location = new System.Drawing.Point(296, 32);
            this.lblGaming.Name = "lblGaming";
            this.lblGaming.Size = new System.Drawing.Size(32, 32);
            this.lblGaming.TabIndex = 9;
            this.lblGaming.Text = "$";
            this.lblGaming.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPerson
            // 
            this.lblPerson.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPerson.BackColor = System.Drawing.Color.Transparent;
            this.lblPerson.Location = new System.Drawing.Point(264, 32);
            this.lblPerson.Name = "lblPerson";
            this.lblPerson.Size = new System.Drawing.Size(32, 32);
            this.lblPerson.TabIndex = 9;
            this.lblPerson.Text = "$";
            this.lblPerson.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLive
            // 
            this.lblLive.BackColor = System.Drawing.Color.Transparent;
            this.lblLive.Location = new System.Drawing.Point(300, 0);
            this.lblLive.Name = "lblLive";
            this.lblLive.Size = new System.Drawing.Size(60, 32);
            this.lblLive.TabIndex = 10;
            this.lblLive.Text = "直播";
            this.lblLive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PnlTitle
            // 
            this.PnlTitle.Controls.Add(this.lblLive);
            this.PnlTitle.Controls.Add(this.lblPerson);
            this.PnlTitle.Controls.Add(this.lblGaming);
            this.PnlTitle.Controls.Add(this.lblFlee);
            this.PnlTitle.Controls.Add(this.lblSelectMap);
            this.PnlTitle.Controls.Add(this.lblRecord);
            this.PnlTitle.Controls.Add(this.lblSearchRoom);
            this.PnlTitle.Controls.Add(this.lblMapName);
            this.PnlTitle.Controls.Add(this.lblRoomList);
            this.PnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTitle.Location = new System.Drawing.Point(0, 0);
            this.PnlTitle.Name = "PnlTitle";
            this.PnlTitle.Size = new System.Drawing.Size(360, 65);
            this.PnlTitle.TabIndex = 0;
            // 
            // lblSelectMap
            // 
            this.lblSelectMap.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSelectMap.BackColor = System.Drawing.Color.Transparent;
            this.lblSelectMap.Location = new System.Drawing.Point(112, 32);
            this.lblSelectMap.Name = "lblSelectMap";
            this.lblSelectMap.Size = new System.Drawing.Size(32, 32);
            this.lblSelectMap.TabIndex = 9;
            this.lblSelectMap.Text = "v";
            this.lblSelectMap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSearchRoom
            // 
            this.lblSearchRoom.BackColor = System.Drawing.Color.Transparent;
            this.lblSearchRoom.Location = new System.Drawing.Point(144, 32);
            this.lblSearchRoom.Name = "lblSearchRoom";
            this.lblSearchRoom.Size = new System.Drawing.Size(120, 32);
            this.lblSearchRoom.TabIndex = 8;
            this.lblSearchRoom.Text = "搜索房间...";
            this.lblSearchRoom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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

        private System.Windows.Forms.Label lblRoomList;
        private System.Windows.Forms.Panel PnlContent;
        private System.Windows.Forms.Panel PnlPage;
        private System.Windows.Forms.Label lblLast;
        private System.Windows.Forms.Label lblPagePosition;
        private System.Windows.Forms.Label lblNext;
        private System.Windows.Forms.Label lblMatch;
        private System.Windows.Forms.Label lblAll;
        private System.Windows.Forms.Label lblCreateRoom;
        private System.Windows.Forms.Label lblMapName;
        private System.Windows.Forms.Label lblRecord;
        private System.Windows.Forms.Label lblFlee;
        private System.Windows.Forms.Label lblGaming;
        private System.Windows.Forms.Label lblPerson;
        private System.Windows.Forms.Label lblLive;
        private System.Windows.Forms.Panel PnlTitle;
        private System.Windows.Forms.Label lblSelectMap;
        private System.Windows.Forms.Label lblSearchRoom;
    }
}
