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
            listBox_Genre_List.Items.Clear(); // Clears what was already in the listbox.
            textBox_GenreTitle.Text = "";
            String GenreItem;                 // Declaring a string variable for the items the application will be reading in.
            string applicationPath = Directory.GetCurrentDirectory() + "\\"; // Locates to the desired directory.
            StreamReader myInputStream = File.OpenText(applicationPath + ("GenreConfig.txt")); // Opens the congiguration file.
            GenreItem = myInputStream.ReadLine(); // Reads each line.
            if (GenreItem == null) // If the file is null, the user will be told so they may open the setup window and add some genres.
            {
                textBox_GenreTitle.Text = "No Genres yet!";
            }
            else // Otherwise, read the information into the listbox.
            {
                listBox_Genre_List.Items.Add(GenreItem);
                GenreItem = myInputStream.ReadLine();
            }
            myInputStream.Close(); // This avoids keeping the connection to the file open.
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox_Genre_List.Items.Clear(); // When loaded, this is the same as the 'refresh' button, but it checks when the form is loaded in case the user has already created genres in the past.
            textBox_GenreTitle.Text = "";
            String GenreItem;
            string applicationPath = Directory.GetCurrentDirectory() + "\\";
            StreamReader myInputStream = File.OpenText(applicationPath + ("GenreConfig.txt"));
            GenreItem = myInputStream.ReadLine();
            if (GenreItem == null)
            {
                textBox_GenreTitle.Text = "No Genres yet!";
            }
            else
            {
                listBox_Genre_List.Items.Add(GenreItem);
                GenreItem = myInputStream.ReadLine();
            }
            myInputStream.Close();

            
        }
    }
}
