using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Volume_bar.Value = 50;
            label_volume.Text = "50";
        }

       

        private void btn_prev_Click(object sender, EventArgs e)
        {
            if (Track_List.SelectedIndex > 0)
            {
                Track_List.SelectedIndex = Track_List.SelectedIndex - 1;
            }
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            if (Track_List.SelectedIndex < Track_List.Items.Count - 1)
            {
                Track_List.SelectedIndex = Track_List.SelectedIndex + 1;
            }
        }

        private void btn_Play_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.play();
        }

        private void btn_Pause_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.pause();
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.stop();
            progressBar1.Value = 0;
        }
        string[] paths, files;
        private void btn_Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Mp3 files (*.mp3)|*.mp3";
            ofd.Multiselect = true;
            ofd.Title = "Open";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.SafeFileNames;
                paths = ofd.FileNames;
                for (int i = 0; i < files.Length; i++)
                {
                    Track_List.Items.Add(files[i]);
                }
            }
        }

        private void progressBar1_MouseDown(object sender, MouseEventArgs e)
        {
            Player.Ctlcontrols.currentPosition = Player.currentMedia.duration * e.X / progressBar1.Width;
        }

        private void Track_List_SelectedIndexChanged(object sender, EventArgs e)
        {
            Player.URL = paths[Track_List.SelectedIndex];
            Player.Ctlcontrols.play();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                progressBar1.Maximum = (int)Player.Ctlcontrols.currentItem.duration;
                progressBar1.Value = (int)Player.Ctlcontrols.currentPosition;
            }
            try
            {
                label_start.Text = Player.Ctlcontrols.currentPositionString;

            }
            catch
            {

            }
        }

        private void Volume_bar_Scroll(object sender, EventArgs e)
        {
            Player.settings.volume = Volume_bar.Value;
            label_volume.Text = Volume_bar.Value.ToString();
        }

        private void Download_List_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fileName = "", myStringWebResource = null;
            switch (Download_List.SelectedIndex)
            {
                case 0:
                    {
                        fileName = "OneCallAway.mp3";
                        myStringWebResource = "https://aredir.nixcdn.com/Warner_Audio35/OneCallAway-CharliePuth-6426097.mp3?st=wAmTiBW8cP4nRzrtYNBm5g&e=1649838303&t=1649751902790";
                        break;
                    }
                case 1:
                    {
                        fileName = "TheNights.mp3";
                        myStringWebResource = "https://aredir.nixcdn.com/Unv_Audio41/TheNights-Avicii-3926375.mp3?st=u7X5AtkHltwXIsHz-nef8Q&e=1649838468&t=1649752068151";
                        break;
                    }
                case 2:
                    {
                        fileName = "WaitingForLove.mp3";
                        myStringWebResource = "https://aredir.nixcdn.com/Unv_Audio45/WaitingForLove-Avicii-4203283.mp3?st=qYfPbZn-ZVlMArildvVMYw&e=1649838512&t=1649752111729";
                        break;
                    }
                case 3:
                    {
                        fileName = "WhyNotMe.mp3";
                        myStringWebResource = "https://aredir.nixcdn.com/Unv_Audio86/WhyNotMe-EnriqueIglesias-3479372.mp3?st=LYmM4NuPhDtbUTJtwRh70g&e=1649838543&t=1649752142869";
                        break;
                    }
                case 4:
                    {
                        fileName = "ShapeOfYou.mp3";
                        myStringWebResource = "https://aredir.nixcdn.com/Warner_Audio38/ShapeOfYou-EdSheeran-6443488.mp3?st=KU5yqMknWoZjCIkdmeMxew&e=1649838588&t=1649752187711";
                        break;
                    }
                case 5:
                    {
                        fileName = "Perfect.mp3";
                        myStringWebResource = "https://aredir.nixcdn.com/Warner_Audio39/Perfect-EdSheeran-6445593.mp3?st=DZwoVIDagSPL5pkLTB8DQw&e=1649838642&t=1649752242525";
                        break;
                    }
                case 6:
                    {
                        fileName = "AtMyWorst.mp3";
                        myStringWebResource = "https://aredir.nixcdn.com/Warner_Audio56/AtMyWorst-PinkSweat-6704978.mp3?st=k_70AFoJryGBQB2N2baQVg&e=1649838720&t=1649752319630";
                        break;
                    }
                case 7:
                    {
                        fileName = "Memories.mp3";
                        myStringWebResource = "https://aredir.nixcdn.com/Unv_Audio149/Memories-Maroon5-6091839.mp3?st=nY-fwa6PSL1MjffgpkHfHg&e=1649838768&t=1649752367622";
                        break;
                    }
                case 8:
                    {
                        fileName = "LetMeDownSlowly.mp3";
                        myStringWebResource = "https://aredir.nixcdn.com/Warner_Audio33/LetMeDownSlowly-AlecBenjamin-6360069.mp3?st=i9sGUiW_XMTOrdaYh6ENQw&e=1649838842&t=1649752442316";
                        break;
                    }
                case 9:
                    {
                        fileName = "Believer.mp3";
                        myStringWebResource = "https://aredir.nixcdn.com/Unv_Audio97/Believer-ImagineDragons-5564250.mp3?st=Y1vUndXe5OXvB981C8js5Q&e=1649838911&t=1649752510754";
                        break;
                    }



            }

            WebClient myWebClient = new WebClient();
            Console.WriteLine("Downloading File \"{0}\" from \"{1}\" .......\n\n", fileName, myStringWebResource);
            // Download the Web resource and save it into the current filesystem folder.
            string path = Application.StartupPath + "\\Music";
            myWebClient.DownloadFile(myStringWebResource, fileName);
            Console.WriteLine("Successfully Downloaded File \"{0}\" from \"{1}\"", fileName, myStringWebResource);
            Console.WriteLine("\nDownloaded file saved in the following file system folder:\n\t" + Application.StartupPath);



        }
    }
}
