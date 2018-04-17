using System;
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
        string TitleRead = Directory.GetCurrentDirectory() + "//" + "GenreTitles.txt"; // Locates the file which contains genre titles.
        string[] TrackNames = File.ReadAllLines("GenreConfig.txt"); // Creates an array for tracks to be inputted.
        string pathToSongs = Directory.GetCurrentDirectory() + "\\";  // For the actual jukebox player, this is the path to the song folder.

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
            listBox_PlayList.Items.Clear(); // Wipes the playlist
            textBox_Now_Playing.Text = null; // Wipes the currently playing box.
            StreamReader myInputStream = File.OpenText(PathToDirectory + ("GenreConfig.txt"));
            List<string> Tracks = new List<string>(); // Using a list, the text file is read into the listbox.
            using (StreamReader reader = new StreamReader(PathToDirectory + "GenreConfig.txt"))
            {
                string Track;
                while ((Track = reader.ReadLine()) != null)
                {
                    listBox_Genre_List.Items.Add(Track); // Adds each track in turn, if the file is not null.
                }
            }
                if (listBox_Genre_List == null)
                {
                textBox_GenreTitle.Text = "No Genres Yet!"; // Otherwise, we are promted with an error.
                }
                else
                {
                    textBox_GenreTitle.Text = File.ReadAllText(TitleRead); // Reads the title into its file.

                }
            myInputStream.Close(); // Making sure to close the connection so that the file writes.
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            listBox_Genre_List.Items.Clear(); // This updates the genre and reads it into this listbox.
            listBox_PlayList.Items.Clear(); // Wipes the playlist.
            textBox_Now_Playing.Text = null;
            StreamReader myInputStream = File.OpenText(PathToDirectory + ("GenreConfig.txt"));
            List<string> Tracks = new List<string>(); // Using a list, the text file is read into the listbox.
            using (StreamReader reader = new StreamReader(PathToDirectory + "GenreConfig.txt"))
            {
                string Track;
                while ((Track = reader.ReadLine()) != null)
                {
                    listBox_Genre_List.Items.Add(Track);
                }
            }
            if (listBox_Genre_List == null)
            {
                textBox_GenreTitle.Text = "No Genres Yet!";
            }
            else
            {
                textBox_GenreTitle.Text = File.ReadAllText(TitleRead);

            }
            myInputStream.Close();

            WMPLib.WindowsMediaPlayer JukeBox = new WMPLib.WindowsMediaPlayer();
            string pathToSongs = Directory.GetCurrentDirectory() + "\\";
            JukeBox.URL = (pathToSongs + "//Songs/" + textBox_Now_Playing.Text);
            JukeBox.controls.play();
        }

        private void timer_Moving_Tracks_Tick(object sender, EventArgs e)
        {
            while (listBox_Genre_List.Items.Count>0 && listBox_PlayList.Items.Count<1)
            {
                timer_Moving_Tracks.Start();
                listBox_PlayList.Items.Add(listBox_Genre_List.Items[0].ToString());
                listBox_Genre_List.Items.RemoveAt(0);
            }
           
            
        }

        private void timer_Move_to_Playing_Tick(object sender, EventArgs e)
        {
            while ((textBox_Now_Playing.Text == "") && (listBox_PlayList.Items.Count > 0))

            {
                timer_Move_to_Playing.Start();
                textBox_Now_Playing.Text = listBox_PlayList.Items[0].ToString();
                listBox_PlayList.Items.RemoveAt(0);

            }
            
        }

        private void textBox_Now_Playing_TextChanged(object sender, EventArgs e)
        {
            WMPLib.WindowsMediaPlayer axWindowsMediaPlayer = new WMPLib.WindowsMediaPlayer(); // This is my instance of the media player.
            axWindowsMediaPlayer.URL = (pathToSongs + "//Songs/" + textBox_Now_Playing.Text); // This is how it finds the songs to play.
            axWindowsMediaPlayer.controls.play(); // When it is time, the song will play.
        }

        private void btn_Skip_Click(object sender, EventArgs e)
        {
            textBox_Now_Playing.Text = null;
            axWindowsMediaPlayer.Ctlcontrols.stop();
        }
    }
}
