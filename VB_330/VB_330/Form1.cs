using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VB_330
{
    
    public partial class Form1 : Form
    {
        string[] pictures = new string[0];
        int selectedIndex = 0;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void exitButton_click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Confirm", "You sure you want to exit the application", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            //Opens the file browser to find a folder
            FolderBrowserDialog folder = new FolderBrowserDialog();
            if (folder.ShowDialog() == DialogResult.OK)
            {
                pictures = Directory.GetFiles(folder.SelectedPath); // retrieves the pictures from selected folder
                this.Text = "Photo Gallery - " + folder.SelectedPath; // update the title to current file

                selectedIndex = 0;
                updateImage();
            } 
        }
        void updateImage()
        {
            positionLabel.Text = (selectedIndex + 1).ToString() + " / " + pictures.Count();
            galleryBox.Load(pictures[selectedIndex]); // Load new image
            rightItem.Enabled = true;
            leftItem.Enabled = true;
        }

    }
}
