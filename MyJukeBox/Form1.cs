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
        string TitleRead = Directory.GetCurrentDirectory() + "//" + "GenreTitles.txt";  
        // Declaring a string variable for the items the application will be reading in.
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
            listBox_PlayList.Items.Clear(); // Wipes the playlist
            textBox_Now_Playing.Text = null; // Wipes the currently playing box.
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
        }

        private void listBox_PlayList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            Player.URL = listBox_PlayList.SelectedItem.ToString();
            Player.Ctlcontrols.play();
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
    }
}
