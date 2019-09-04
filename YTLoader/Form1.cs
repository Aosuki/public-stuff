using System;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Windows.Forms;
using VideoLibrary;
using YoutubeExplode;

namespace YTLoader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private async void Button1_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog() { Description = "Select Path" })
            {
                if(fbd.ShowDialog() == DialogResult.OK)
                {
                    var youtube = YouTube.Default;
                    var video = await youtube.GetVideoAsync(textBox1.Text);
                    string filename = textBox2.Text;
                    if(filename == "")
                    {
                        filename = video.FullName;
                    }

                    using(WebClient client = new WebClient())
                    {
                        client.DownloadFileCompleted += client_Completed;
                        client.DownloadProgressChanged += dlProgressChange;
                        client.DownloadFileAsync(new Uri(video.GetUri()), fbd.SelectedPath + @"\" + filename);
                        //File.WriteAllBytes(fbd.SelectedPath + @"\" + filename, await video.GetBytesAsync());
                    }
                }
            }
        }

        private void client_Completed(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("Download Completed!");
        }

        private void dlProgressChange(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            progPercent.Text = e.ProgressPercentage + "%";
        }

        private void ProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
