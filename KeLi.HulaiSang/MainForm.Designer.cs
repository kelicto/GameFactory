
using KeLi.HulaiSang.Pages;

namespace KeLi.HulaiSang
{
    sealed partial class MainForm
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
            this.resourcePage1 = new KeLi.HulaiSang.Pages.ResourceInfoControl();
            this.chatMessage1 = new ChatMessageControl();
            this.mainMenu1 = new MainMenuControl();
            this.activeTask1 = new ActiveTaskControl();
            this.levelPage1 = new KeLi.HulaiSang.Pages.LevelInfoControl();
            this.SuspendLayout();
            // 
            // resourcePage1
            // 
            this.resourcePage1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.resourcePage1.BackColor = System.Drawing.Color.Transparent;
            this.resourcePage1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.resourcePage1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(202)))), ((int)(((byte)(176)))));
            this.resourcePage1.Location = new System.Drawing.Point(520, 0);
            this.resourcePage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.resourcePage1.Name = "resourcePage1";
            this.resourcePage1.Size = new System.Drawing.Size(300, 22);
            this.resourcePage1.TabIndex = 8;
            // 
            // chatMessage1
            // 
            this.chatMessage1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chatMessage1.BackColor = System.Drawing.Color.Transparent;
            this.chatMessage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chatMessage1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chatMessage1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(202)))), ((int)(((byte)(176)))));
            this.chatMessage1.Location = new System.Drawing.Point(0, 450);
            this.chatMessage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chatMessage1.Name = "chatMessage1";
            this.chatMessage1.Size = new System.Drawing.Size(360, 150);
            this.chatMessage1.TabIndex = 7;
            // 
            // mainMenu1
            // 
            this.mainMenu1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mainMenu1.BackColor = System.Drawing.Color.Transparent;
            this.mainMenu1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mainMenu1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(202)))), ((int)(((byte)(176)))));
            this.mainMenu1.Location = new System.Drawing.Point(850, 500);
            this.mainMenu1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mainMenu1.Name = "mainMenu1";
            this.mainMenu1.Size = new System.Drawing.Size(350, 100);
            this.mainMenu1.TabIndex = 6;
            // 
            // activeTask1
            // 
            this.activeTask1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.activeTask1.BackColor = System.Drawing.Color.Transparent;
            this.activeTask1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.activeTask1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(202)))), ((int)(((byte)(176)))));
            this.activeTask1.Location = new System.Drawing.Point(1150, 120);
            this.activeTask1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.activeTask1.Name = "activeTask1";
            this.activeTask1.Size = new System.Drawing.Size(50, 300);
            this.activeTask1.TabIndex = 5;
            // 
            // levelPage1
            // 
            this.levelPage1.BackColor = System.Drawing.Color.Transparent;
            this.levelPage1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.levelPage1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(202)))), ((int)(((byte)(176)))));
            this.levelPage1.Location = new System.Drawing.Point(0, 0);
            this.levelPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.levelPage1.Name = "levelPage1";
            this.levelPage1.Size = new System.Drawing.Size(272, 144);
            this.levelPage1.TabIndex = 0;
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.resourcePage1);
            this.Controls.Add(this.chatMessage1);
            this.Controls.Add(this.mainMenu1);
            this.Controls.Add(this.activeTask1);
            this.Controls.Add(this.levelPage1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "MainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private Pages.LevelInfoControl levelPage1;
        private ActiveTaskControl activeTask1;
        private MainMenuControl mainMenu1;
        private ChatMessageControl chatMessage1;
        private Pages.ResourceInfoControl resourcePage1;
    }
}

