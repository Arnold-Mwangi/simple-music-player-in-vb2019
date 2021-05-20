using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kirigwi_player
{
    public partial class MusicPlayerApp : Form
    {
        public MusicPlayerApp()
        {
            InitializeComponent();
        }
        //create blobal variables of string type array to save name of tracks and path of the track
        string[] paths, files;
        private void lbllogo_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //code to select songs
            OpenFileDialog ofd = new OpenFileDialog();
            //code to select multiple songs
            ofd.Multiselect = true;
            if(ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.SafeFileNames;// save the names of the track in files array
                paths = ofd.FileNames;    // save the paths of the track in paths array
                //display the music tittle in list box
                for(int i=0; i<files.Length; i++) {
                    listBoxsongs.Items.Add(files[i]);// display songs in list box
                }
            }

        }

        private void listBoxsongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            //code to play track
            WindowsMediaPlayer.URL = paths[listBoxsongs.SelectedIndex];
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //code to close kambi music
            this.Close();
        }
    }
}
