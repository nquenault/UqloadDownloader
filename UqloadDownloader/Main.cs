using System;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Diagnostics;

namespace UqloadDownloader
{
    public partial class Main : Form
    {
        WebClient client1 = new WebClient();
        public static string downloadFolder = Application.StartupPath+"\\Downloads";

        public Main()
        {
            InitializeComponent();

            if(!Directory.Exists(downloadFolder))
            Directory.CreateDirectory(downloadFolder);

            listView1.Columns[4].Width = -2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DownloadHandler new_download = new DownloadHandler(ui_URL.Text, listView1, ui_Filename.Text, downloadFolder);
            ui_URL.Text = "";
        }

		private void button2_Click(object sender, EventArgs e)
		{
            var psi = new ProcessStartInfo();
            psi.FileName = @"explorer.exe";
            psi.Arguments = downloadFolder;
            Process.Start(psi);
		}
	}
}
