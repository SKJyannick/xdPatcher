using System;
using System.Windows.Forms;
using System.Net;
using System.ComponentModel;
using System.IO;
using System.Net.NetworkInformation;

namespace xdPatcher
{
    public partial class Info : Form
    {
        WebClient wc = new WebClient();
        public Info()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Info_Load(object sender, EventArgs e)
        {
            label4.Text = "Version 1.1";
        }

        private void Info_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string path = @"xdelta3.exe";
            File.Delete(path);

            wc.DownloadFileCompleted += new AsyncCompletedEventHandler(DC);
            Uri du = new Uri("https://drive.google.com/uc?export=download&id=1Vk8xvBM6r18rhkhIMXycCXU6owbfg9l8");
            wc.DownloadFileAsync(du,"xdelta3.exe");
        }

        private void DC(object sender, AsyncCompletedEventArgs e)
        {
            if (MessageBox.Show("Download complete!") == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = pictureBox1.Name;
            sfd.Filter = "PNG|*.png|All files|*.*";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image.Save(sfd.FileName);
            }
        }
    }
}
