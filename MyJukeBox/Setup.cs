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
            }
        }
    }
}
