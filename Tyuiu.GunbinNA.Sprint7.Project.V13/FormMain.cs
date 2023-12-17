using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.GunbinNA.Sprint7.Project.V13.Lib;

namespace Tyuiu.GunbinNA.Sprint7.Project.V13
{
    public partial class FormMain : Form
    {
        WMPLib.WindowsMediaPlayer music = new WMPLib.WindowsMediaPlayer();
        string path;
        bool isPlaying = false;
        public FormMain()
        {
            InitializeComponent();
            music.URL = @"C:\Users\wackko\Desktop\ListSongs.mp3";
            music.settings.volume = 10;
            music.controls.play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (isPlaying)
            {
                music.controls.stop();
                button2.BackColor = Color.Red;
            }
            else
            {
                music.controls.play();
                button2.BackColor = Color.FromArgb(192, 255, 192);
            }

            isPlaying = !isPlaying;
        }
    }
}
