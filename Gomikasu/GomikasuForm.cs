using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gomikasu
{
    public partial class GomikasuForm : Form
    {
        public GomikasuForm()
        {
            InitializeComponent();
        }

        private void twitter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/otogibaraera");
        }

        private string GetSoundFile(string fname)
        {
            return "Sounds/" + fname + ".wav";
        }

        private void gomikasu_Click(object sender, EventArgs e)
        {
            string fn = ((Button)sender).Name;
            new System.Media.SoundPlayer(GetSoundFile(fn)).PlaySync();
        }

        private void about_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://mkaraki.app/Gomikasu");
        }
    }
}
