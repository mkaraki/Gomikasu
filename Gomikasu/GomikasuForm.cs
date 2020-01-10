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

namespace Gomikasu
{
    public partial class GomikasuForm : Form
    {
        private static string SoundAppDir = Path.Combine(Application.StartupPath, "Sounds");

        public GomikasuForm()
        {
            InitializeComponent();

            Sounds = new Dictionary<string, System.Media.SoundPlayer>()
            {
                { "all", new System.Media.SoundPlayer(GetSoundFile("all")) },
                { "gomikasu", new System.Media.SoundPlayer(GetSoundFile("gomikasu")) },
                { "sine", new System.Media.SoundPlayer(GetSoundFile("sine")) },
            };

            if (!Directory.Exists(SoundAppDir))
            {
                MessageBox.Show("Sounds フォルダがありません。", "Gomikasu Button");
                Application.Exit();
            }
        }

        private void twitter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/otogibaraera");
        }

        private string GetSoundFile(string fname)
        {
            string path = Path.Combine(SoundAppDir, fname + ".wav");
            if (!File.Exists(path))
            { 
                MessageBox.Show($"Sounds フォルダに {fname}.wav がありません。", "Gomikasu Button");
                Environment.Exit(1);
            }
            return path;
        }

        private Dictionary<string, System.Media.SoundPlayer> Sounds;

        private void gomikasu_Click(object sender, EventArgs e)
        {
            string fn = ((Button)sender).Name;
            var player = Sounds[fn];
            player.Play();
        }

        private void about_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://mkaraki.app/Gomikasu");
        }
    }
}
