﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; // Enables the programme to read and/or write to the device's hard disk.

namespace MyJukeBox
{
    public partial class Setup : Form
    {
        public Setup()
        {
            InitializeComponent();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close(); // Simply closes this form.
        }

        private void btn_Import_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog Browse = new FolderBrowserDialog(); // This instantiates the component which allows you to browse files already stored on a user's PC.
            if (Browse.ShowDialog() == DialogResult.OK)
            {
                string[] file = Directory.GetFiles(Browse.SelectedPath); // Creates a string array for our music files.
                string[] directory = Directory.GetDirectories(Browse.SelectedPath);

                foreach (string files in file) // When a file is selected, populate to the array for the files.
                {
                    listBox_Imported_Tracks.Items.Add(Path.GetFileName(files)); // Pull the appropriate files from the array and store them in the designated listbox.
                }

                foreach (string directories in directory)
                {
                    listBox_Imported_Tracks.Items.Add(Path.GetDirectoryName(directories)); // Gets the directory path name from its string array.
                }
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            listBox_Imported_Tracks.Items.Clear(); // Allows the user to clear their file selection.
        }

        private void btn_Copy_Click(object sender, EventArgs e)
        {
            if (listBox_Imported_Tracks.Items.Count <= 0)
            {
                MessageBox.Show("You must have items available to copy. Try to import some now."); // The user is unable to copy nothing into the second listbox, and this listbox prompts them to amdend this issue.
            }
            else
            {
                listBox_Genre_Contents.Items.Add(listBox_Imported_Tracks.SelectedItem); // Copies the item currently selected in the 'import' listbox into the 'genre' listbox.
            }

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (textBox_Genre_Title.Text == "")
            {
                MessageBox.Show("Please enter a title for this genre");
            }
            else
            {
                string Path = Directory.GetCurrentDirectory() + "\\";
                StreamWriter myOutputStream = File.CreateText(Path + "GenreConfig.txt"); // This finds the current directory, and add a .txt file as I have named it here, which will act as the basis for configuring the genres a user can create.

                string[] Tracks = listBox_Genre_Contents.Items.OfType<string>().ToArray(); // This creates the array of tracks, based on what the user selects in the given listbox, and adds this to said array.

                foreach (string Values in Tracks)
                {
                    myOutputStream.WriteLine(Values); // A foreach loop writes the desired string value into the file.
                    MessageBox.Show("You have added " + Values + " to this genre");
                }



                myOutputStream.Close(); // Closing the connection to the file.
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            string Path = Directory.GetCurrentDirectory() + "\\";
            File.WriteAllText(Path + "GenreConfig.txt",string.Empty); // Here, we overwrite the text file with the 'empty' argument, essentially clearing it so that it can be redone if the user wishes.
            MessageBox.Show("You have deleted your genre configuration file. Add a new genre and some tracks to create a new one.");
        }
    }
}
