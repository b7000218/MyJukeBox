namespace MyJukeBox
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.pictureBox_JukeBox = new System.Windows.Forms.PictureBox();
            this.lbl_About_JukeBox = new System.Windows.Forms.Label();
            this.textBox_About = new System.Windows.Forms.TextBox();
            this.btn_Close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_JukeBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_JukeBox
            // 
            this.pictureBox_JukeBox.Image = global::MyJukeBox.Properties.Resources.jukebox;
            this.pictureBox_JukeBox.Location = new System.Drawing.Point(10, 12);
            this.pictureBox_JukeBox.Name = "pictureBox_JukeBox";
            this.pictureBox_JukeBox.Size = new System.Drawing.Size(179, 328);
            this.pictureBox_JukeBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_JukeBox.TabIndex = 0;
            this.pictureBox_JukeBox.TabStop = false;
            // 
            // lbl_About_JukeBox
            // 
            this.lbl_About_JukeBox.AutoSize = true;
            this.lbl_About_JukeBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_About_JukeBox.Location = new System.Drawing.Point(195, 29);
            this.lbl_About_JukeBox.Name = "lbl_About_JukeBox";
            this.lbl_About_JukeBox.Size = new System.Drawing.Size(184, 22);
            this.lbl_About_JukeBox.TabIndex = 1;
            this.lbl_About_JukeBox.Text = "\'My JukeBox\' - v1.0";
            // 
            // textBox_About
            // 
            this.textBox_About.Location = new System.Drawing.Point(201, 74);
            this.textBox_About.Multiline = true;
            this.textBox_About.Name = "textBox_About";
            this.textBox_About.ReadOnly = true;
            this.textBox_About.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_About.Size = new System.Drawing.Size(177, 159);
            this.textBox_About.TabIndex = 2;
            this.textBox_About.Text = resources.GetString("textBox_About.Text");
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(232, 261);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(102, 49);
            this.btn_Close.TabIndex = 3;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 354);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.textBox_About);
            this.Controls.Add(this.lbl_About_JukeBox);
            this.Controls.Add(this.pictureBox_JukeBox);
            this.Name = "AboutForm";
            this.Text = "About";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_JukeBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_JukeBox;
        private System.Windows.Forms.Label lbl_About_JukeBox;
        private System.Windows.Forms.TextBox textBox_About;
        private System.Windows.Forms.Button btn_Close;
    }
}