namespace MyJukeBox
{
    partial class Setup
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
            this.groupBox_Import = new System.Windows.Forms.GroupBox();
            this.listBox_Imported_Tracks = new System.Windows.Forms.ListBox();
            this.lbl_Setup = new System.Windows.Forms.Label();
            this.btn_Import = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Copy = new System.Windows.Forms.Button();
            this.btn_Move = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.lbl_Genre_Title = new System.Windows.Forms.Label();
            this.textBox_Genre_Title = new System.Windows.Forms.TextBox();
            this.btn_Back = new System.Windows.Forms.Button();
            this.groupBox_Genre = new System.Windows.Forms.GroupBox();
            this.lbl_Genre_Control = new System.Windows.Forms.Label();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Next = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Delete_From_Genre = new System.Windows.Forms.Button();
            this.groupBox_Import.SuspendLayout();
            this.groupBox_Genre.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Import
            // 
            this.groupBox_Import.Controls.Add(this.listBox_Imported_Tracks);
            this.groupBox_Import.Location = new System.Drawing.Point(24, 45);
            this.groupBox_Import.Name = "groupBox_Import";
            this.groupBox_Import.Size = new System.Drawing.Size(187, 329);
            this.groupBox_Import.TabIndex = 0;
            this.groupBox_Import.TabStop = false;
            this.groupBox_Import.Text = "Import Tracks";
            // 
            // listBox_Imported_Tracks
            // 
            this.listBox_Imported_Tracks.FormattingEnabled = true;
            this.listBox_Imported_Tracks.Location = new System.Drawing.Point(4, 19);
            this.listBox_Imported_Tracks.Name = "listBox_Imported_Tracks";
            this.listBox_Imported_Tracks.Size = new System.Drawing.Size(179, 225);
            this.listBox_Imported_Tracks.TabIndex = 0;
            // 
            // lbl_Setup
            // 
            this.lbl_Setup.AutoSize = true;
            this.lbl_Setup.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Setup.Location = new System.Drawing.Point(170, 9);
            this.lbl_Setup.Name = "lbl_Setup";
            this.lbl_Setup.Size = new System.Drawing.Size(218, 24);
            this.lbl_Setup.TabIndex = 1;
            this.lbl_Setup.Text = "Setup the Jukebox...";
            // 
            // btn_Import
            // 
            this.btn_Import.Location = new System.Drawing.Point(43, 306);
            this.btn_Import.Name = "btn_Import";
            this.btn_Import.Size = new System.Drawing.Size(131, 25);
            this.btn_Import.TabIndex = 2;
            this.btn_Import.Text = "Browse Tracks";
            this.btn_Import.UseVisualStyleBackColor = true;
            this.btn_Import.Click += new System.EventHandler(this.btn_Import_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(43, 339);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(131, 25);
            this.btn_Clear.TabIndex = 3;
            this.btn_Clear.Text = "Clear Tracks";
            this.btn_Clear.UseVisualStyleBackColor = true;
            // 
            // btn_Copy
            // 
            this.btn_Copy.Location = new System.Drawing.Point(232, 127);
            this.btn_Copy.Name = "btn_Copy";
            this.btn_Copy.Size = new System.Drawing.Size(102, 39);
            this.btn_Copy.TabIndex = 4;
            this.btn_Copy.Text = "Copy Tracks >>";
            this.btn_Copy.UseVisualStyleBackColor = true;
            // 
            // btn_Move
            // 
            this.btn_Move.Location = new System.Drawing.Point(232, 172);
            this.btn_Move.Name = "btn_Move";
            this.btn_Move.Size = new System.Drawing.Size(102, 39);
            this.btn_Move.TabIndex = 5;
            this.btn_Move.Text = "Move Tracks >>";
            this.btn_Move.UseVisualStyleBackColor = true;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(0, 58);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(184, 186);
            this.listBox2.TabIndex = 1;
            // 
            // lbl_Genre_Title
            // 
            this.lbl_Genre_Title.AutoSize = true;
            this.lbl_Genre_Title.Location = new System.Drawing.Point(6, 16);
            this.lbl_Genre_Title.Name = "lbl_Genre_Title";
            this.lbl_Genre_Title.Size = new System.Drawing.Size(62, 13);
            this.lbl_Genre_Title.TabIndex = 2;
            this.lbl_Genre_Title.Text = "Genre Title:";
            // 
            // textBox_Genre_Title
            // 
            this.textBox_Genre_Title.Location = new System.Drawing.Point(0, 32);
            this.textBox_Genre_Title.Name = "textBox_Genre_Title";
            this.textBox_Genre_Title.Size = new System.Drawing.Size(184, 20);
            this.textBox_Genre_Title.TabIndex = 3;
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(6, 273);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(51, 44);
            this.btn_Back.TabIndex = 4;
            this.btn_Back.Text = "<<\r\nBack";
            this.btn_Back.UseVisualStyleBackColor = true;
            // 
            // groupBox_Genre
            // 
            this.groupBox_Genre.Controls.Add(this.lbl_Genre_Control);
            this.groupBox_Genre.Controls.Add(this.btn_Delete);
            this.groupBox_Genre.Controls.Add(this.btn_Add);
            this.groupBox_Genre.Controls.Add(this.btn_Next);
            this.groupBox_Genre.Controls.Add(this.btn_Back);
            this.groupBox_Genre.Controls.Add(this.textBox_Genre_Title);
            this.groupBox_Genre.Controls.Add(this.lbl_Genre_Title);
            this.groupBox_Genre.Controls.Add(this.listBox2);
            this.groupBox_Genre.Location = new System.Drawing.Point(355, 45);
            this.groupBox_Genre.Name = "groupBox_Genre";
            this.groupBox_Genre.Size = new System.Drawing.Size(184, 329);
            this.groupBox_Genre.TabIndex = 1;
            this.groupBox_Genre.TabStop = false;
            this.groupBox_Genre.Text = "Genre";
            // 
            // lbl_Genre_Control
            // 
            this.lbl_Genre_Control.AutoSize = true;
            this.lbl_Genre_Control.Location = new System.Drawing.Point(3, 247);
            this.lbl_Genre_Control.Name = "lbl_Genre_Control";
            this.lbl_Genre_Control.Size = new System.Drawing.Size(80, 13);
            this.lbl_Genre_Control.TabIndex = 8;
            this.lbl_Genre_Control.Text = "Genre Controls:";
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(63, 298);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(58, 25);
            this.btn_Delete.TabIndex = 7;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(63, 261);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(58, 25);
            this.btn_Add.TabIndex = 6;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            // 
            // btn_Next
            // 
            this.btn_Next.Location = new System.Drawing.Point(127, 273);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(51, 44);
            this.btn_Next.TabIndex = 5;
            this.btn_Next.Text = ">>\r\nNext";
            this.btn_Next.UseVisualStyleBackColor = true;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(232, 318);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(102, 39);
            this.btn_Cancel.TabIndex = 6;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Delete_From_Genre
            // 
            this.btn_Delete_From_Genre.Location = new System.Drawing.Point(232, 230);
            this.btn_Delete_From_Genre.Name = "btn_Delete_From_Genre";
            this.btn_Delete_From_Genre.Size = new System.Drawing.Size(102, 39);
            this.btn_Delete_From_Genre.TabIndex = 7;
            this.btn_Delete_From_Genre.Text = "Delete Tracks From Genre";
            this.btn_Delete_From_Genre.UseVisualStyleBackColor = true;
            // 
            // Setup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 376);
            this.Controls.Add(this.btn_Delete_From_Genre);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Move);
            this.Controls.Add(this.btn_Copy);
            this.Controls.Add(this.groupBox_Genre);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Import);
            this.Controls.Add(this.lbl_Setup);
            this.Controls.Add(this.groupBox_Import);
            this.Name = "Setup";
            this.Text = "JukeBox Setup";
            this.groupBox_Import.ResumeLayout(false);
            this.groupBox_Genre.ResumeLayout(false);
            this.groupBox_Genre.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Import;
        private System.Windows.Forms.Label lbl_Setup;
        private System.Windows.Forms.Button btn_Import;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.ListBox listBox_Imported_Tracks;
        private System.Windows.Forms.Button btn_Copy;
        private System.Windows.Forms.Button btn_Move;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label lbl_Genre_Title;
        private System.Windows.Forms.TextBox textBox_Genre_Title;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.GroupBox groupBox_Genre;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Label lbl_Genre_Control;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Delete_From_Genre;
    }
}