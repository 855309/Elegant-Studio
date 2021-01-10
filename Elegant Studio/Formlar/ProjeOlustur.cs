using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elegant_Studio
{
    public partial class ProjeOlustur : MaterialForm
    {
        public ProjeOlustur()
        {
            InitializeComponent();
            projeyolutextbox.Text = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "elegant", projeaditextbox.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (klasorac.ShowDialog() == DialogResult.OK)
            {
                projeyolutextbox.Text = klasorac.SelectedPath;
            }
        }

        private void projeaditextbox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void olusturbutton_Click(object sender, EventArgs e)
        {

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

        private void projeaditextbox_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void projeaditextbox_TextChanged_1(object sender, EventArgs e)
        {
            projeyolutextbox.Text = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "elegant", projeaditextbox.Text);
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(projeyolutextbox.Text))
            {
                DeleteDirectory(projeyolutextbox.Text);
            }

            Directory.CreateDirectory(projeyolutextbox.Text);

            ProcessStartInfo pinfo = new ProcessStartInfo();
            pinfo.FileName = "dotnet";
            pinfo.Arguments = "new console";
            pinfo.WorkingDirectory = projeyolutextbox.Text;
            pinfo.UseShellExecute = true;
            pinfo.CreateNoWindow = true;

            Process.Start(pinfo).WaitForExit();

            Studio st = new Studio(projeyolutextbox.Text, projeaditextbox.Text);

            this.Close();

            st.Show();
        }
    }
}
