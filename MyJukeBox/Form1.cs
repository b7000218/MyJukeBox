﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MyJukeBox
{
    public partial class Form1 : Form
    {
        string PathToDirectory = Directory.GetCurrentDirectory() + "\\"; // Locates to the desired directory.
        String GenreTitle; // Declaring a string variable for the items the application will be reading in.
        string[] TrackNames = File.ReadAllLines("GenreConfig.txt");
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_About_Click(object sender, EventArgs e)
        {
            new AboutForm().Show(); // When this button is clicked, the form for 'about' the programme opens.
        }

        private void btn_Setup_Click(object sender, EventArgs e)
        {
            new Setup().Show(); // Opens the setup window.
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            listBox_Genre_List.Items.Clear(); // This updates the genre and reads it into this listbox.
            textBox_GenreTitle.Text = "";
            StreamReader myInputStream = File.OpenText(PathToDirectory + ("GenreConfig.txt"));
            GenreTitle = myInputStream.ReadLine();
            List<string> Tracks = new List<string>(); // Using a list, the text file is read into the listbox.
            using (StreamReader reader = new StreamReader(PathToDirectory + "GenreConfig.txt"))
            {
                string Track;
                while ((Track = reader.ReadLine()) != null)
                {
                    listBox_Genre_List.Items.Add(Track);
                }
            }
                if (GenreTitle == null)
                {
                    textBox_GenreTitle.Text = "No Genres yet!";
                }
                else
                {
                    textBox_GenreTitle.Text = GenreTitle;


                }
            myInputStream.Close();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            listBox_Genre_List.Items.Clear(); // When loaded, this is the same as the 'refresh' button, but it checks when the form is loaded in case the user has already created genres in the past.
            textBox_GenreTitle.Text = "";
            StreamReader myInputStream = File.OpenText(PathToDirectory + ("GenreConfig.txt"));
            GenreTitle = myInputStream.ReadLine();
            List<string> Tracks = new List<string>();
            using (StreamReader reader = new StreamReader(PathToDirectory + "GenreConfig.txt"))
            {
                string Track;
                while ((Track = reader.ReadLine()) != null)
                {
                    listBox_Genre_List.Items.Add(Track);
                }
            }
            if (GenreTitle == null)
            {
                textBox_GenreTitle.Text = "No Genres yet!";
            }
            else
            {
                textBox_GenreTitle.Text = GenreTitle;


            }
            myInputStream.Close();

            WMPLib.WindowsMediaPlayer Player = new WMPLib.WindowsMediaPlayer();

            

            
        }
    }
}
