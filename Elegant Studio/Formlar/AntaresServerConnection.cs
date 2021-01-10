using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elegant_Studio.Formlar
{
    public partial class AntaresServerConnection : MaterialForm
    {
        public string key;

        public AntaresServerConnection(string keyjuan)
        {
            InitializeComponent();

            key = keyjuan;

            label2.Text = "Key: " + key;
        }

        public void indirveklonla(string key)
        {
            Thread thread = new Thread(() => {
                WebClient client = new WebClient();
                client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
                client.DownloadFileAsync(new Uri("http://fikret.ml/elegant/projeler/" + key + ".zip"), @"indirilmis/" + key + ".zip");
            });

            thread.Start();
        }

        public void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            double bytesIn = double.Parse(e.BytesReceived.ToString());
            double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
            double percentage = bytesIn / totalBytes * 100;

            progressBar1.Value = int.Parse(Math.Truncate(percentage).ToString());

            label3.Text = e.TotalBytesToReceive + " byte'dan " + e.BytesReceived + "'si indirildi.";
        }

        public void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            this.Hide();

            string projad;

            using (ZipArchive zip = ZipFile.Open("indirilmis/" + key + ".zip", ZipArchiveMode.Read))
            {
                projad = zip.Entries[0].FullName.Split(Path.DirectorySeparatorChar).First();
            }

            ZipFile.ExtractToDirectory("indirilmis/" + key + ".zip", Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "elegant"));

            File.Delete("indirilmis/" + key + ".zip");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Studio(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "elegant", projad), projad));
        }

        private void AntaresServerConnection_Load(object sender, EventArgs e)
        {
            indirveklonla(key);
        }

        public void DeleteDirectory(string target_dir)
        {
            string[] files = Directory.GetFiles(target_dir);
            string[] dirs = Directory.GetDirectories(target_dir);

            foreach (string file in files)
            {
                File.SetAttributes(file, FileAttributes.Normal);
                File.Delete(file);
            }

            foreach (string dir in dirs)
            {
                DeleteDirectory(dir);
            }

            Directory.Delete(target_dir, false);
        }
    }
}
