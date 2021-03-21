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

namespace JPlayer
{
    public partial class Form1 : Form
    {
        WMPLib.WindowsMediaPlayer Player = new WMPLib.WindowsMediaPlayer();
        string[] Musicas = new string[100];
        bool tocar;

        public Form1()
        {
            InitializeComponent();
        }

        private void gunaTrackBar1_Scroll(object sender, ScrollEventArgs e)
        {
            Player.settings.volume = gunaTrackBar1.Value;
        }

        private void playListToolStripMenuItem_Click(object sender, EventArgs e)
        {


            AbrirPlayList.ShowDialog();

            Musicas = AbrirPlayList.FileNames;

            PlayList_CB.Items.Clear();
            for (int i = 0; i < AbrirPlayList.SafeFileNames.Length; i++)
            {
                //
                PlayList_CB.Items.Add(AbrirPlayList.SafeFileNames[i]);
            }

            TocarMusica();
        }

        private void TocarMusica()
        {
            var file = TagLib.File.Create(Musicas[0]);

            string path = "";

            for (int i = 0; i < Musicas.Length; i++)
            {
                if (Musicas[i].Contains(PlayList_CB.Text))
                {
                    PlayList_CB.SelectedIndex = i;
                    Player.URL = Musicas[i];
                    Player.controls.play();
                    path = Musicas[i];
                    file = TagLib.File.Create(Musicas[i]);
                    break;
                }
            }

            try
            {
                var cover = TagLib.File.Create(path);
                var bin = (byte[])(file.Tag.Pictures[0].Data.Data);
                pictureBox1.BackgroundImage = Image.FromStream(new MemoryStream(bin));
            }
            catch (Exception)
            {

                pictureBox1.BackgroundImage = Properties.Resources.disco2;
            }



            SetarInfoMusica();
            PlayPauseBtn.Image = Properties.Resources.PauseButton1;
            tocar = true;
        }

        private void PlayList_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            TocarMusica();

        }

      
        private void PlayPauseBtn_Click_1(object sender, EventArgs e)
        {
            
            PlayPauseBtn.Image = Properties.Resources.PauseButton1;
            
            if ( tocar == false )
            {
                PlayPauseBtn.Image = Properties.Resources.PauseButton1;
                Player.controls.play();
                tocar = true;
            }
            else if ( tocar ==  true )
            {
                PlayPauseBtn.Image = Properties.Resources.PlayButton2;
                Player.controls.pause();
                tocar = false;
            }


        }

        private void proximoBtn_Click(object sender, EventArgs e)
        {
            ProximaMusica();  
        }

        private void anteriorBtn_Click(object sender, EventArgs e)
        {

            MusicaAnterior();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (tocar == true)
                {
                    progressoMusica.MaximumValue = Convert.ToInt32(Player.currentMedia.duration);
                    progressoMusica.Value = Convert.ToInt32(Player.controls.currentPosition);
                    duracaoCompleta_lbl.Text = Player.currentMedia.durationString;
                    duracaoAtual_lbl.Text = Player.controls.currentPositionString;
                    SetarInfoMusica();

                }
                

                if (Player.status == "Parado" && tocar == true)
                {
                    ProximaMusica();
                }

            }
            catch (Exception)
            {

         
            }

            
            
        }

        private void ProximaMusica()
        {
            if (PlayList_CB.SelectedIndex != PlayList_CB.Items.Count - 1)
            {
                PlayList_CB.SelectedIndex++;
            }
            else
            {
                PlayList_CB.SelectedIndex = 0;
            }

        }

        private void MusicaAnterior()
        {
            if (PlayList_CB.SelectedIndex == 0)
            {

                PlayList_CB.SelectedIndex = PlayList_CB.Items.Count - 1;

            }
            else
            {
                PlayList_CB.SelectedIndex--;
            }
        }

        private void SetarInfoMusica()
        {

            string Album = Player.currentMedia.getItemInfo("Album"), Autor = Player.currentMedia.getItemInfo("Author");

            if (Album == "" && Autor  ==  "")
            {
                nomeMusica.Text = Player.currentMedia.name;
                infoMusica.Text = "Autor Desconhecido" + " • " + "Album Desconhecido";
            }
            else
            {
                nomeMusica.Text = Player.currentMedia.name;
                infoMusica.Text = Player.currentMedia.getItemInfo("Author") + " • " + Player.currentMedia.getItemInfo("Album");
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Player.settings.volume = 50;
        }
    }
}
