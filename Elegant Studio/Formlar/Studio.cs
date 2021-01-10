using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using Elegant_Studio.Araclar;
using Elegant_Studio.Formlar;
using ICSharpCode.TextEditor;
using ICSharpCode.TextEditor.Document;
using MaterialSkin.Controls;

namespace Elegant_Studio
{
    public partial class Studio : MaterialForm
    {
        public string anapath = "../../";

        public string projeadi;

        public Studio(string projeyolu, string projeadip)
        {
            InitializeComponent();

            anapath = projeyolu;

            var kontroller = hepsinigetir(this);

            kodpage1.Text = "Program.cs";

            kodtexteditor1.Text = File.ReadAllText(Path.Combine(anapath, "Program.cs"));

            foreach (Control c in kontroller)
            {
                c.MouseMove += mousehareketetti;
            }

            KlasorListele(cozumtreeview, anapath);

            string dir = "highlight/";
            FileSyntaxModeProvider fsmProvider;
            if (Directory.Exists(dir))
            {
                fsmProvider = new FileSyntaxModeProvider(dir);
                HighlightingManager.Manager.AddSyntaxModeFileProvider(fsmProvider);
                //kodtexteditor1.SetHighlighting("C#");
            }

            debugrelcombo.SelectedItem = debugrelcombo.Items[0];

            Control.CheckForIllegalCrossThreadCalls = false;

            projeadi = projeadip;
        }

        public void KlasorListele(TreeView treeView, string path)
        {
            treeView.Nodes.Clear();
            var rootDirectoryInfo = new DirectoryInfo(path);

            TreeNode tn = CreateDirectoryNode(rootDirectoryInfo);

            treeView.Nodes.Add(tn);

            cozumtreeview.ContextMenuStrip = cozumsagtik;
        }

        public TreeNode CreateDirectoryNode(DirectoryInfo directoryInfo)
        {
            var directoryNode = new TreeNode(directoryInfo.Name);

            foreach (var directory in directoryInfo.GetDirectories())
            {
                directoryNode.Nodes.Add(CreateDirectoryNode(directory));
            }
            foreach (var file in directoryInfo.GetFiles())
            {
                directoryNode.Nodes.Add(new TreeNode(file.Name));
            }

            return directoryNode;
        }

        private void Studio_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        public List<Control> hepsinigetir(Control anakontrol)
        {
            var liste = new List<Control>();

            foreach (Control c in anakontrol.Controls)
            {
                foreach (var kontrol in hepsinigetir(c))
                {
                    liste.Add(kontrol);
                }

                liste.Add(c);
            }

            return liste;
        }

        public void mousehareketetti(object sender, MouseEventArgs e)
        {
            mousexylabel.Text = Cursor.Position.X.ToString() + ", " + Cursor.Position.Y.ToString();
        }

        private void cozumtreeview_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (File.Exists(Path.Combine(anapath, "..", cozumtreeview.SelectedNode.FullPath)))
            {
                dosyaac(Path.Combine(anapath, "..", cozumtreeview.SelectedNode.FullPath), cozumtreeview.SelectedNode.FullPath);
            }
        }

        public void dosyaac(string dosyayolu, string nodeyolu)
        {
            string[] spl = anapath.Split(Path.DirectorySeparatorChar);
            string projeadi = spl.Last();

            TabPage sekme = new TabPage();
            sekme.Text = nodeyolu.Replace(nodeyolu.Split(Path.DirectorySeparatorChar).First() + Path.DirectorySeparatorChar, "");
            TextEditorControl tc = new TextEditorControl();
            tc.Dock = DockStyle.Fill;
            tc.Text = File.ReadAllText(dosyayolu);
            //tc.SetHighlighting("C#");
            sekme.Controls.Add(tc);
            tc.MouseMove += mousehareketetti;
            kodtabcontrol.TabPages.Add(sekme);
            kodtabcontrol.SelectTab(sekme);
        }

        private void baslatbutton_Click(object sender, EventArgs e)
        {
            ciktitextbox.Clear();

            herseyikaydet();

            asagipanel.BackColor = Color.Orange;

            derle();

            calistir();
            asagipanel.BackColor = Color.DodgerBlue;
        }

        public void derle()
        {
            ProcessStartInfo pinfo = new ProcessStartInfo();
            pinfo.FileName = "dotnet";
            pinfo.Arguments = "build --configuration " + debugrelcombo.GetItemText(debugrelcombo.SelectedItem);
            pinfo.WorkingDirectory = anapath;
            pinfo.UseShellExecute = false;
            pinfo.CreateNoWindow = true;
            pinfo.RedirectStandardOutput = true;
            pinfo.StandardOutputEncoding = Encoding.GetEncoding("iso-8859-9");
            //pinfo.RedirectStandardError = true;

            var program = new Process();
            program.StartInfo = pinfo;
            program.OutputDataReceived += datageldi;
            //program.ErrorDataReceived += datageldi;
            //Console.OutputEncoding = Encoding.GetEncoding("iso-8859-9");
            program.Start();
            program.BeginOutputReadLine();
            //program.BeginErrorReadLine();

            program.WaitForExit();
        }

        public void calistir()
        {
            string[] spl = anapath.Split(Path.DirectorySeparatorChar);
            string projeadi = spl.Last();

            Process.Start(Path.Combine(anapath, "bin", debugrelcombo.GetItemText(debugrelcombo.SelectedItem), "net5.0", projeadi + ".exe")).WaitForExit();
        }

        public void herseyikaydet()
        {
            foreach (TabPage sekme in kodtabcontrol.TabPages)
            {
                if (File.Exists(Path.Combine(anapath, sekme.Text)))
                {
                    File.WriteAllText(Path.Combine(anapath, sekme.Text), sekme.Controls[0].Text);
                }
                else
                {
                    //kodtabcontrol.TabPages.Remove(sekme);
                }
            }
        }

        public string cevir(string yazi)
        {
            yazi = yazi.Replace("ü", "u");
            yazi = yazi.Replace("ı", "i");
            yazi = yazi.Replace("ö", "o");
            yazi = yazi.Replace("ü", "u");
            yazi = yazi.Replace("ş", "s");
            yazi = yazi.Replace("ğ", "g");
            yazi = yazi.Replace("ç", "c");
            yazi = yazi.Replace("Ü", "U");
            yazi = yazi.Replace("İ", "I");
            yazi = yazi.Replace("Ö", "O");
            yazi = yazi.Replace("Ü", "U");
            yazi = yazi.Replace("Ş", "S");
            yazi = yazi.Replace("Ğ", "G");
            yazi = yazi.Replace("Ç", "C");

            return yazi;
        }

        public void datageldi(object sender, DataReceivedEventArgs outLine)
        {
            if (outLine.Data != null)
            {
                ciktitextbox.Text += outLine.Data + "\r\n";
            }
        }

        private void cozumsagtik_Opening(object sender, CancelEventArgs e)
        {
            if (cozumtreeview.SelectedNode != null)
            {
                string nodeyolu = cozumtreeview.SelectedNode.FullPath;

                string sonyol;

                if (cozumtreeview.SelectedNode.Parent != null)
                {
                    sonyol = Path.Combine(anapath, nodeyolu.Replace(nodeyolu.Split(Path.DirectorySeparatorChar).First() + Path.DirectorySeparatorChar, ""));
                }
                else
                {
                    sonyol = anapath;
                }

                bool klasormu = File.GetAttributes(sonyol).HasFlag(FileAttributes.Directory);

                if (!klasormu)
                {
                    yeniKlasörToolStripMenuItem.Enabled = false;
                    yeniDosyaToolStripMenuItem.Enabled = false;
                }
                else
                {
                    yeniKlasörToolStripMenuItem.Enabled = true;
                    yeniDosyaToolStripMenuItem.Enabled = true;
                }
            }
        }

        private void Studio_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Kaydetmek ister misiniz?", "Elegant Studio", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (cevap == DialogResult.Yes)
            {
                herseyikaydet();
            }
            else
            {
                Environment.Exit(0);
            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string nodeyolu = cozumtreeview.SelectedNode.FullPath;

            string sonyol;

            if (cozumtreeview.SelectedNode.Parent != null)
            {
                sonyol = Path.Combine(anapath, nodeyolu.Replace(nodeyolu.Split(Path.DirectorySeparatorChar).First() + Path.DirectorySeparatorChar, ""));
            }
            else
            {
                sonyol = anapath;
            }

            bool klasormu = File.GetAttributes(sonyol).HasFlag(FileAttributes.Directory);

            if (klasormu)
            {
                DeleteDirectory(sonyol);
            }
            else
            {
                File.Delete(sonyol);
            }

            KlasorListele(cozumtreeview, anapath);
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

        private void yeniKlasörToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string nodeyolu = cozumtreeview.SelectedNode.FullPath;

            string sonyol;

            if (cozumtreeview.SelectedNode.Parent != null)
            {
                sonyol = Path.Combine(anapath, nodeyolu.Replace(nodeyolu.Split(Path.DirectorySeparatorChar).First() + Path.DirectorySeparatorChar, ""));
            }
            else
            {
                sonyol = anapath;
            }

            OlusturDialog od = new OlusturDialog(sonyol, true);


            if (od.ShowDialog() == DialogResult.OK)
            {
                string xsonyol;

                if (cozumtreeview.SelectedNode.Parent != null)
                {
                    xsonyol = Path.Combine(anapath, nodeyolu.Replace(nodeyolu.Split(Path.DirectorySeparatorChar).First() + Path.DirectorySeparatorChar, ""), od.drm);
                }
                else
                {
                    xsonyol = Path.Combine(anapath, od.drm);
                }

                Directory.CreateDirectory(xsonyol);
            }

            KlasorListele(cozumtreeview, anapath);
        }

        private void yeniDosyaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string nodeyolu = cozumtreeview.SelectedNode.FullPath;

            string sonyol;

            if (cozumtreeview.SelectedNode.Parent != null)
            {
                sonyol = Path.Combine(anapath, nodeyolu.Replace(nodeyolu.Split(Path.DirectorySeparatorChar).First() + Path.DirectorySeparatorChar, ""));
            }
            else
            {
                sonyol = anapath;
            }

            OlusturDialog od = new OlusturDialog(sonyol, false);


            if (od.ShowDialog() == DialogResult.OK)
            {
                string xsonyol;

                if (cozumtreeview.SelectedNode.Parent != null)
                {
                    xsonyol = Path.Combine(anapath, nodeyolu.Replace(nodeyolu.Split(Path.DirectorySeparatorChar).First() + Path.DirectorySeparatorChar, ""), od.drm);
                }
                else
                {
                    xsonyol = Path.Combine(anapath, od.drm);
                }

                File.Create(xsonyol).Dispose();
            }

            KlasorListele(cozumtreeview, anapath);
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            herseyikaydet();
        }

        private void yeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            herseyikaydet();

            this.Close();

            ProjeOlustur po = new ProjeOlustur();

            po.Show();
        }

        private void geriAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextEditorControl tec = (TextEditorControl)kodtabcontrol.SelectedTab.Controls[0];

            tec.Undo();
        }

        private void yineleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextEditorControl tec = (TextEditorControl)kodtabcontrol.SelectedTab.Controls[0];

            tec.Redo();
        }

        private void kesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextEditorControl tec = (TextEditorControl)kodtabcontrol.SelectedTab.Controls[0];
        }

        private void Studio_Load(object sender, EventArgs e)
        {
            DiscordRich.Initialize(projeadi, kodtabcontrol.SelectedTab.Text.Split(Path.DirectorySeparatorChar).Last());
        }

        private void kodtabcontrol_TabIndexChanged(object sender, EventArgs e)
        {
            //DiscordRich.guncelle(projeadi, kodtabcontrol.SelectedTab.Text.Split(Path.DirectorySeparatorChar).Last());
        }

        private void kodtabcontrol_VisibleChanged(object sender, EventArgs e)
        {
            
        }

        private void kodtabcontrol_Selected(object sender, TabControlEventArgs e)
        {
            DiscordRich.guncelle(projeadi, kodtabcontrol.SelectedTab.Text.Split(Path.DirectorySeparatorChar).Last());
        }

        private void ayarlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ayarlar ay = new Ayarlar();
            ay.Show();
        }

        private void derleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            derle();
        }

        private void derleVeÇalıştırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            derle();
            calistir();
        }

        private void yayınlaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        string key = "0000000000";

        private void antaresNetworkeYayınlaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            key = RandomString(10);

            antyayinla(key);
        }

        private static Random random = new Random();

        public static string RandomString(int length)
        {
            const string chars = "abcdefghijklmnopqrstuvyzwxABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public void antyayinla(string key)
        {
            herseyikaydet();

            if (!Directory.Exists("yayinlar"))
            {
                Directory.CreateDirectory("yayinlar");
            }

            Directory.CreateDirectory(Path.Combine("yayinlar", key));

            ZipFile.CreateFromDirectory(anapath, Path.Combine("yayinlar", key, key + ".zip"));

            Copy(anapath, Path.Combine("yayinlar", key));

            using (WebClient wc = new WebClient())
            {
                wc.UploadFile("http://fikret.ml/elegant/yukle.php", Path.Combine("yayinlar", key, key + ".zip"));
            }

            DiscordRich.partiac(key);

            DeleteDirectory(Path.Combine("yayinlar", key));

            MessageBox.Show("Projeniz Elegant Studio serverine yüklendi.\r\nArtık Discord'da proje daveti atabilirsiniz.");
        }

        public static void Copy(string sourceDirectory, string targetDirectory)
        {
            var diSource = new DirectoryInfo(sourceDirectory);
            var diTarget = new DirectoryInfo(Path.Combine(targetDirectory, diSource.Name));

            CopyAll(diSource, diTarget);
        }

        public static void CopyAll(DirectoryInfo source, DirectoryInfo target)
        {
            Directory.CreateDirectory(target.FullName);

            // Copy each file into the new directory.
            foreach (FileInfo fi in source.GetFiles())
            {
                Console.WriteLine(@"Copying {0}\{1}", target.FullName, fi.Name);
                fi.CopyTo(Path.Combine(target.FullName, fi.Name), true);
            }

            // Copy each subdirectory using recursion.
            foreach (DirectoryInfo diSourceSubDir in source.GetDirectories())
            {
                DirectoryInfo nextTargetSubDir =
                    target.CreateSubdirectory(diSourceSubDir.Name);
                CopyAll(diSourceSubDir, nextTargetSubDir);
            }
        }
    }
}
