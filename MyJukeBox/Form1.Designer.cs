namespace MyJukeBox
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblCopyrightNotice = new System.Windows.Forms.Label();
            this.listBox_PlayList = new System.Windows.Forms.ListBox();
            this.textBox_Now_Playing = new System.Windows.Forms.TextBox();
            this.textBox_GenreTitle = new System.Windows.Forms.TextBox();
            this.listBox_Genre_List = new System.Windows.Forms.ListBox();
            this.panel_Menu = new System.Windows.Forms.Panel();
            this.btn_About = new System.Windows.Forms.Button();
            this.btn_Setup = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.timer_Moving_Tracks = new System.Windows.Forms.Timer(this.components);
            this.timer_Move_to_Playing = new System.Windows.Forms.Timer(this.components);
            this.btn_Skip = new System.Windows.Forms.Button();
            this.panel_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCopyrightNotice
            // 
            this.lblCopyrightNotice.AutoSize = true;
            this.lblCopyrightNotice.ForeColor = System.Drawing.Color.White;
            this.lblCopyrightNotice.Location = new System.Drawing.Point(377, 0);
            this.lblCopyrightNotice.Name = "lblCopyrightNotice";
            this.lblCopyrightNotice.Size = new System.Drawing.Size(144, 13);
            this.lblCopyrightNotice.TabIndex = 0;
            this.lblCopyrightNotice.Text = "Copyright © 2018 Joe Glover";
            // 
            // listBox_PlayList
            // 
            this.listBox_PlayList.FormattingEnabled = true;
            this.listBox_PlayList.Location = new System.Drawing.Point(187, 282);
            this.listBox_PlayList.Name = "listBox_PlayList";
            this.listBox_PlayList.Size = new System.Drawing.Size(140, 108);
            this.listBox_PlayList.TabIndex = 1;
            // 
            // textBox_Now_Playing
            // 
            this.textBox_Now_Playing.BackColor = System.Drawing.Color.Lime;
            this.textBox_Now_Playing.Location = new System.Drawing.Point(168, 256);
            this.textBox_Now_Playing.Name = "textBox_Now_Playing";
            this.textBox_Now_Playing.ReadOnly = true;
            this.textBox_Now_Playing.Size = new System.Drawing.Size(181, 20);
            this.textBox_Now_Playing.TabIndex = 2;
            this.textBox_Now_Playing.TextChanged += new System.EventHandler(this.textBox_Now_Playing_TextChanged);
            // 
            // textBox_GenreTitle
            // 
            this.textBox_GenreTitle.Location = new System.Drawing.Point(168, 116);
            this.textBox_GenreTitle.Name = "textBox_GenreTitle";
            this.textBox_GenreTitle.ReadOnly = true;
            this.textBox_GenreTitle.Size = new System.Drawing.Size(181, 20);
            this.textBox_GenreTitle.TabIndex = 3;
            // 
            // listBox_Genre_List
            // 
            this.listBox_Genre_List.FormattingEnabled = true;
            this.listBox_Genre_List.HorizontalScrollbar = true;
            this.listBox_Genre_List.Location = new System.Drawing.Point(168, 133);
            this.listBox_Genre_List.Name = "listBox_Genre_List";
            this.listBox_Genre_List.Size = new System.Drawing.Size(181, 82);
            this.listBox_Genre_List.TabIndex = 4;
            this.listBox_Genre_List.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox_Genre_List_MouseDoubleClick);
            // 
            // panel_Menu
            // 
            this.panel_Menu.BackColor = System.Drawing.Color.DarkGray;
            this.panel_Menu.Controls.Add(this.btn_About);
            this.panel_Menu.Controls.Add(this.btn_Setup);
            this.panel_Menu.Location = new System.Drawing.Point(0, 462);
            this.panel_Menu.Name = "panel_Menu";
            this.panel_Menu.Size = new System.Drawing.Size(520, 30);
            this.panel_Menu.TabIndex = 5;
            // 
            // btn_About
            // 
            this.btn_About.Location = new System.Drawing.Point(81, 0);
            this.btn_About.Name = "btn_About";
            this.btn_About.Size = new System.Drawing.Size(75, 26);
            this.btn_About.TabIndex = 1;
            this.btn_About.Text = "About";
            this.btn_About.UseVisualStyleBackColor = true;
            this.btn_About.Click += new System.EventHandler(this.btn_About_Click);
            // 
            // btn_Setup
            // 
            this.btn_Setup.Location = new System.Drawing.Point(0, 0);
            this.btn_Setup.Name = "btn_Setup";
            this.btn_Setup.Size = new System.Drawing.Size(75, 26);
            this.btn_Setup.TabIndex = 0;
            this.btn_Setup.Text = "Setup";
            this.btn_Setup.UseVisualStyleBackColor = true;
            this.btn_Setup.Click += new System.EventHandler(this.btn_Setup_Click);
            // 
            // axWindowsMediaPlayer
            // 
            this.axWindowsMediaPlayer.Enabled = true;
            this.axWindowsMediaPlayer.Location = new System.Drawing.Point(142, 221);
            this.axWindowsMediaPlayer.Name = "axWindowsMediaPlayer";
            this.axWindowsMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer.OcxState")));
            this.axWindowsMediaPlayer.Size = new System.Drawing.Size(235, 47);
            this.axWindowsMediaPlayer.TabIndex = 6;
            this.axWindowsMediaPlayer.Visible = false;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Location = new System.Drawing.Point(191, 85);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(136, 25);
            this.btn_Refresh.TabIndex = 7;
            this.btn_Refresh.Text = "Refresh Genres";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // timer_Moving_Tracks
            // 
            this.timer_Moving_Tracks.Enabled = true;
            this.timer_Moving_Tracks.Interval = 1000;
            // 
            // timer_Move_to_Playing
            // 
            this.timer_Move_to_Playing.Enabled = true;
            this.timer_Move_to_Playing.Interval = 1000;
            this.timer_Move_to_Playing.Tick += new System.EventHandler(this.timer_Move_to_Playing_Tick);
            // 
            // btn_Skip
            // 
            this.btn_Skip.Location = new System.Drawing.Point(213, 396);
            this.btn_Skip.Name = "btn_Skip";
            this.btn_Skip.Size = new System.Drawing.Size(86, 26);
            this.btn_Skip.TabIndex = 8;
            this.btn_Skip.Text = "Skip Track";
            this.btn_Skip.UseVisualStyleBackColor = true;
            this.btn_Skip.Click += new System.EventHandler(this.btn_Skip_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::MyJukeBox.Properties.Resources.jukebox;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(519, 488);
            this.Controls.Add(this.btn_Skip);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.axWindowsMediaPlayer);
            this.Controls.Add(this.panel_Menu);
            this.Controls.Add(this.listBox_Genre_List);
            this.Controls.Add(this.textBox_GenreTitle);
            this.Controls.Add(this.textBox_Now_Playing);
            this.Controls.Add(this.listBox_PlayList);
            this.Controls.Add(this.lblCopyrightNotice);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "My Juke Box v1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_Menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCopyrightNotice;
        private System.Windows.Forms.ListBox listBox_PlayList;
        private System.Windows.Forms.TextBox textBox_Now_Playing;
        private System.Windows.Forms.TextBox textBox_GenreTitle;
        private System.Windows.Forms.ListBox listBox_Genre_List;
        private System.Windows.Forms.Panel panel_Menu;
        private System.Windows.Forms.Button btn_About;
        private System.Windows.Forms.Button btn_Setup;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Timer timer_Moving_Tracks;
        private System.Windows.Forms.Timer timer_Move_to_Playing;
        private System.Windows.Forms.Button btn_Skip;
    }
}

