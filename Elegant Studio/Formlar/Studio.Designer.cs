
using MaterialSkin.Controls;
using System.Windows.Forms;

namespace Elegant_Studio
{
    partial class Studio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Studio));
            this.menuyazilari = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.farklıKaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.düzenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geriAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yineleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kopyalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yapıştırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.görünümToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.antaresNetworkeYayınlaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.derleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.derleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.derleVeÇalıştırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yayınlaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.biçimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.araçlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kodtabcontrol = new System.Windows.Forms.TabControl();
            this.kodpage1 = new System.Windows.Forms.TabPage();
            this.kodtexteditor1 = new ICSharpCode.TextEditor.TextEditorControl();
            this.ciktitabcontrol = new System.Windows.Forms.TabControl();
            this.ciktitab = new System.Windows.Forms.TabPage();
            this.ciktitextbox = new System.Windows.Forms.TextBox();
            this.hatalistesitab = new System.Windows.Forms.TabPage();
            this.cozumgezginipanel = new System.Windows.Forms.Panel();
            this.cozumtreeview = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.cozungezginibaslik = new System.Windows.Forms.Panel();
            this.asagipanel = new System.Windows.Forms.Panel();
            this.mousexylabel = new System.Windows.Forms.Label();
            this.statuslabel = new System.Windows.Forms.Label();
            this.baslatbutton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.debugrelcombo = new System.Windows.Forms.ComboBox();
            this.cozumsagtik = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.yeniKlasörToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniDosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuyazilari.SuspendLayout();
            this.kodtabcontrol.SuspendLayout();
            this.kodpage1.SuspendLayout();
            this.ciktitabcontrol.SuspendLayout();
            this.ciktitab.SuspendLayout();
            this.cozumgezginipanel.SuspendLayout();
            this.cozungezginibaslik.SuspendLayout();
            this.asagipanel.SuspendLayout();
            this.cozumsagtik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuyazilari
            // 
            this.menuyazilari.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.menuyazilari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.menuyazilari.Dock = System.Windows.Forms.DockStyle.None;
            this.menuyazilari.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.düzenToolStripMenuItem,
            this.görünümToolStripMenuItem,
            this.projeToolStripMenuItem,
            this.derleToolStripMenuItem,
            this.biçimToolStripMenuItem,
            this.araçlarToolStripMenuItem,
            this.yardımToolStripMenuItem});
            this.menuyazilari.Location = new System.Drawing.Point(351, 29);
            this.menuyazilari.Name = "menuyazilari";
            this.menuyazilari.Size = new System.Drawing.Size(554, 24);
            this.menuyazilari.TabIndex = 1;
            this.menuyazilari.Text = "MenuStrip";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniToolStripMenuItem,
            this.kaydetToolStripMenuItem,
            this.farklıKaydetToolStripMenuItem});
            this.dosyaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // yeniToolStripMenuItem
            // 
            this.yeniToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.yeniToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.yeniToolStripMenuItem.Name = "yeniToolStripMenuItem";
            this.yeniToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.yeniToolStripMenuItem.Text = "Yeni";
            this.yeniToolStripMenuItem.Click += new System.EventHandler(this.yeniToolStripMenuItem_Click);
            // 
            // kaydetToolStripMenuItem
            // 
            this.kaydetToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.kaydetToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.kaydetToolStripMenuItem.Name = "kaydetToolStripMenuItem";
            this.kaydetToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.kaydetToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.kaydetToolStripMenuItem.Text = "Kaydet";
            this.kaydetToolStripMenuItem.Click += new System.EventHandler(this.kaydetToolStripMenuItem_Click);
            // 
            // farklıKaydetToolStripMenuItem
            // 
            this.farklıKaydetToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.farklıKaydetToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.farklıKaydetToolStripMenuItem.Name = "farklıKaydetToolStripMenuItem";
            this.farklıKaydetToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.farklıKaydetToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.farklıKaydetToolStripMenuItem.Text = "Farklı Kaydet";
            // 
            // düzenToolStripMenuItem
            // 
            this.düzenToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.düzenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.geriAlToolStripMenuItem,
            this.yineleToolStripMenuItem,
            this.kesToolStripMenuItem,
            this.kopyalaToolStripMenuItem,
            this.yapıştırToolStripMenuItem,
            this.silToolStripMenuItem1});
            this.düzenToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.düzenToolStripMenuItem.Name = "düzenToolStripMenuItem";
            this.düzenToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.düzenToolStripMenuItem.Text = "Düzen";
            // 
            // geriAlToolStripMenuItem
            // 
            this.geriAlToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.geriAlToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.geriAlToolStripMenuItem.Name = "geriAlToolStripMenuItem";
            this.geriAlToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.geriAlToolStripMenuItem.Text = "Geri Al";
            this.geriAlToolStripMenuItem.Click += new System.EventHandler(this.geriAlToolStripMenuItem_Click);
            // 
            // yineleToolStripMenuItem
            // 
            this.yineleToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.yineleToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.yineleToolStripMenuItem.Name = "yineleToolStripMenuItem";
            this.yineleToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.yineleToolStripMenuItem.Text = "Yinele";
            this.yineleToolStripMenuItem.Click += new System.EventHandler(this.yineleToolStripMenuItem_Click);
            // 
            // kesToolStripMenuItem
            // 
            this.kesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.kesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.kesToolStripMenuItem.Name = "kesToolStripMenuItem";
            this.kesToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.kesToolStripMenuItem.Text = "Kes";
            this.kesToolStripMenuItem.Click += new System.EventHandler(this.kesToolStripMenuItem_Click);
            // 
            // kopyalaToolStripMenuItem
            // 
            this.kopyalaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.kopyalaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.kopyalaToolStripMenuItem.Name = "kopyalaToolStripMenuItem";
            this.kopyalaToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.kopyalaToolStripMenuItem.Text = "Kopyala";
            // 
            // yapıştırToolStripMenuItem
            // 
            this.yapıştırToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.yapıştırToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.yapıştırToolStripMenuItem.Name = "yapıştırToolStripMenuItem";
            this.yapıştırToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.yapıştırToolStripMenuItem.Text = "Yapıştır";
            // 
            // silToolStripMenuItem1
            // 
            this.silToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.silToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.silToolStripMenuItem1.Name = "silToolStripMenuItem1";
            this.silToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            this.silToolStripMenuItem1.Text = "Sil";
            // 
            // görünümToolStripMenuItem
            // 
            this.görünümToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.görünümToolStripMenuItem.Name = "görünümToolStripMenuItem";
            this.görünümToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.görünümToolStripMenuItem.Text = "Görünüm";
            // 
            // projeToolStripMenuItem
            // 
            this.projeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.antaresNetworkeYayınlaToolStripMenuItem});
            this.projeToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.projeToolStripMenuItem.Name = "projeToolStripMenuItem";
            this.projeToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.projeToolStripMenuItem.Text = "Proje";
            // 
            // antaresNetworkeYayınlaToolStripMenuItem
            // 
            this.antaresNetworkeYayınlaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.antaresNetworkeYayınlaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.antaresNetworkeYayınlaToolStripMenuItem.Name = "antaresNetworkeYayınlaToolStripMenuItem";
            this.antaresNetworkeYayınlaToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.antaresNetworkeYayınlaToolStripMenuItem.Text = "Antares Network\'e Yayınla";
            this.antaresNetworkeYayınlaToolStripMenuItem.Click += new System.EventHandler(this.antaresNetworkeYayınlaToolStripMenuItem_Click);
            // 
            // derleToolStripMenuItem
            // 
            this.derleToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.derleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.derleToolStripMenuItem1,
            this.derleVeÇalıştırToolStripMenuItem,
            this.yayınlaToolStripMenuItem});
            this.derleToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.derleToolStripMenuItem.Name = "derleToolStripMenuItem";
            this.derleToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.derleToolStripMenuItem.Text = "Derle";
            // 
            // derleToolStripMenuItem1
            // 
            this.derleToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.derleToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.derleToolStripMenuItem1.Name = "derleToolStripMenuItem1";
            this.derleToolStripMenuItem1.Size = new System.Drawing.Size(155, 22);
            this.derleToolStripMenuItem1.Text = "Derle";
            this.derleToolStripMenuItem1.Click += new System.EventHandler(this.derleToolStripMenuItem1_Click);
            // 
            // derleVeÇalıştırToolStripMenuItem
            // 
            this.derleVeÇalıştırToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.derleVeÇalıştırToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.derleVeÇalıştırToolStripMenuItem.Name = "derleVeÇalıştırToolStripMenuItem";
            this.derleVeÇalıştırToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.derleVeÇalıştırToolStripMenuItem.Text = "Derle ve Çalıştır";
            this.derleVeÇalıştırToolStripMenuItem.Click += new System.EventHandler(this.derleVeÇalıştırToolStripMenuItem_Click);
            // 
            // yayınlaToolStripMenuItem
            // 
            this.yayınlaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.yayınlaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.yayınlaToolStripMenuItem.Name = "yayınlaToolStripMenuItem";
            this.yayınlaToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.yayınlaToolStripMenuItem.Text = "Yayınla";
            this.yayınlaToolStripMenuItem.Click += new System.EventHandler(this.yayınlaToolStripMenuItem_Click);
            // 
            // biçimToolStripMenuItem
            // 
            this.biçimToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.biçimToolStripMenuItem.Name = "biçimToolStripMenuItem";
            this.biçimToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.biçimToolStripMenuItem.Text = "Biçim";
            // 
            // araçlarToolStripMenuItem
            // 
            this.araçlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ayarlarToolStripMenuItem});
            this.araçlarToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.araçlarToolStripMenuItem.Name = "araçlarToolStripMenuItem";
            this.araçlarToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.araçlarToolStripMenuItem.Text = "Araçlar";
            // 
            // ayarlarToolStripMenuItem
            // 
            this.ayarlarToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.ayarlarToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ayarlarToolStripMenuItem.Name = "ayarlarToolStripMenuItem";
            this.ayarlarToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.ayarlarToolStripMenuItem.Text = "Ayarlar";
            this.ayarlarToolStripMenuItem.Click += new System.EventHandler(this.ayarlarToolStripMenuItem_Click);
            // 
            // yardımToolStripMenuItem
            // 
            this.yardımToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            this.yardımToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.yardımToolStripMenuItem.Text = "Yardım";
            // 
            // kodtabcontrol
            // 
            this.kodtabcontrol.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kodtabcontrol.Controls.Add(this.kodpage1);
            this.kodtabcontrol.Location = new System.Drawing.Point(12, 94);
            this.kodtabcontrol.Name = "kodtabcontrol";
            this.kodtabcontrol.SelectedIndex = 0;
            this.kodtabcontrol.Size = new System.Drawing.Size(893, 337);
            this.kodtabcontrol.TabIndex = 2;
            this.kodtabcontrol.Selected += new System.Windows.Forms.TabControlEventHandler(this.kodtabcontrol_Selected);
            this.kodtabcontrol.TabIndexChanged += new System.EventHandler(this.kodtabcontrol_TabIndexChanged);
            this.kodtabcontrol.VisibleChanged += new System.EventHandler(this.kodtabcontrol_VisibleChanged);
            // 
            // kodpage1
            // 
            this.kodpage1.Controls.Add(this.kodtexteditor1);
            this.kodpage1.Location = new System.Drawing.Point(4, 22);
            this.kodpage1.Name = "kodpage1";
            this.kodpage1.Padding = new System.Windows.Forms.Padding(3);
            this.kodpage1.Size = new System.Drawing.Size(885, 311);
            this.kodpage1.TabIndex = 0;
            this.kodpage1.Text = "dosya.cs";
            this.kodpage1.UseVisualStyleBackColor = true;
            // 
            // kodtexteditor1
            // 
            this.kodtexteditor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kodtexteditor1.IsReadOnly = false;
            this.kodtexteditor1.Location = new System.Drawing.Point(3, 3);
            this.kodtexteditor1.Name = "kodtexteditor1";
            this.kodtexteditor1.Size = new System.Drawing.Size(879, 305);
            this.kodtexteditor1.TabIndex = 0;
            // 
            // ciktitabcontrol
            // 
            this.ciktitabcontrol.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ciktitabcontrol.Controls.Add(this.ciktitab);
            this.ciktitabcontrol.Controls.Add(this.hatalistesitab);
            this.ciktitabcontrol.Location = new System.Drawing.Point(16, 434);
            this.ciktitabcontrol.Name = "ciktitabcontrol";
            this.ciktitabcontrol.SelectedIndex = 0;
            this.ciktitabcontrol.Size = new System.Drawing.Size(889, 190);
            this.ciktitabcontrol.TabIndex = 3;
            // 
            // ciktitab
            // 
            this.ciktitab.Controls.Add(this.ciktitextbox);
            this.ciktitab.Location = new System.Drawing.Point(4, 22);
            this.ciktitab.Name = "ciktitab";
            this.ciktitab.Padding = new System.Windows.Forms.Padding(3);
            this.ciktitab.Size = new System.Drawing.Size(881, 164);
            this.ciktitab.TabIndex = 0;
            this.ciktitab.Text = "Çıktı";
            this.ciktitab.UseVisualStyleBackColor = true;
            // 
            // ciktitextbox
            // 
            this.ciktitextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ciktitextbox.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ciktitextbox.Location = new System.Drawing.Point(3, 3);
            this.ciktitextbox.Multiline = true;
            this.ciktitextbox.Name = "ciktitextbox";
            this.ciktitextbox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ciktitextbox.Size = new System.Drawing.Size(875, 158);
            this.ciktitextbox.TabIndex = 0;
            // 
            // hatalistesitab
            // 
            this.hatalistesitab.Location = new System.Drawing.Point(4, 22);
            this.hatalistesitab.Name = "hatalistesitab";
            this.hatalistesitab.Padding = new System.Windows.Forms.Padding(3);
            this.hatalistesitab.Size = new System.Drawing.Size(881, 164);
            this.hatalistesitab.TabIndex = 1;
            this.hatalistesitab.Text = "Hata Listesi";
            this.hatalistesitab.UseVisualStyleBackColor = true;
            // 
            // cozumgezginipanel
            // 
            this.cozumgezginipanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cozumgezginipanel.BackColor = System.Drawing.Color.White;
            this.cozumgezginipanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cozumgezginipanel.Controls.Add(this.cozumtreeview);
            this.cozumgezginipanel.Location = new System.Drawing.Point(911, 77);
            this.cozumgezginipanel.Name = "cozumgezginipanel";
            this.cozumgezginipanel.Size = new System.Drawing.Size(289, 547);
            this.cozumgezginipanel.TabIndex = 4;
            // 
            // cozumtreeview
            // 
            this.cozumtreeview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cozumtreeview.Location = new System.Drawing.Point(-1, 26);
            this.cozumtreeview.Name = "cozumtreeview";
            this.cozumtreeview.Size = new System.Drawing.Size(289, 487);
            this.cozumtreeview.TabIndex = 0;
            this.cozumtreeview.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.cozumtreeview_NodeMouseDoubleClick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Çözüm Gezgini";
            // 
            // cozungezginibaslik
            // 
            this.cozungezginibaslik.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cozungezginibaslik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.cozungezginibaslik.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cozungezginibaslik.Controls.Add(this.label1);
            this.cozungezginibaslik.Location = new System.Drawing.Point(911, 77);
            this.cozungezginibaslik.Name = "cozungezginibaslik";
            this.cozungezginibaslik.Size = new System.Drawing.Size(289, 28);
            this.cozungezginibaslik.TabIndex = 2;
            // 
            // asagipanel
            // 
            this.asagipanel.BackColor = System.Drawing.Color.DodgerBlue;
            this.asagipanel.Controls.Add(this.mousexylabel);
            this.asagipanel.Controls.Add(this.statuslabel);
            this.asagipanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.asagipanel.Location = new System.Drawing.Point(0, 628);
            this.asagipanel.Name = "asagipanel";
            this.asagipanel.Size = new System.Drawing.Size(1212, 26);
            this.asagipanel.TabIndex = 5;
            // 
            // mousexylabel
            // 
            this.mousexylabel.AutoSize = true;
            this.mousexylabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mousexylabel.ForeColor = System.Drawing.Color.White;
            this.mousexylabel.Location = new System.Drawing.Point(908, 3);
            this.mousexylabel.Name = "mousexylabel";
            this.mousexylabel.Size = new System.Drawing.Size(29, 17);
            this.mousexylabel.TabIndex = 1;
            this.mousexylabel.Text = "0, 0";
            // 
            // statuslabel
            // 
            this.statuslabel.AutoSize = true;
            this.statuslabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.statuslabel.ForeColor = System.Drawing.Color.White;
            this.statuslabel.Location = new System.Drawing.Point(4, 4);
            this.statuslabel.Name = "statuslabel";
            this.statuslabel.Size = new System.Drawing.Size(38, 17);
            this.statuslabel.TabIndex = 0;
            this.statuslabel.Text = "Hazır";
            // 
            // baslatbutton
            // 
            this.baslatbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.baslatbutton.Depth = 0;
            this.baslatbutton.Location = new System.Drawing.Point(113, 68);
            this.baslatbutton.MouseState = MaterialSkin.MouseState.HOVER;
            this.baslatbutton.Name = "baslatbutton";
            this.baslatbutton.Primary = true;
            this.baslatbutton.Size = new System.Drawing.Size(75, 23);
            this.baslatbutton.TabIndex = 6;
            this.baslatbutton.Text = "Başlat";
            this.baslatbutton.UseVisualStyleBackColor = true;
            this.baslatbutton.Click += new System.EventHandler(this.baslatbutton_Click);
            // 
            // debugrelcombo
            // 
            this.debugrelcombo.FormattingEnabled = true;
            this.debugrelcombo.Items.AddRange(new object[] {
            "Debug",
            "Release"});
            this.debugrelcombo.Location = new System.Drawing.Point(12, 69);
            this.debugrelcombo.Name = "debugrelcombo";
            this.debugrelcombo.Size = new System.Drawing.Size(95, 21);
            this.debugrelcombo.TabIndex = 7;
            this.debugrelcombo.Text = "Debug";
            // 
            // cozumsagtik
            // 
            this.cozumsagtik.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniKlasörToolStripMenuItem,
            this.yeniDosyaToolStripMenuItem,
            this.silToolStripMenuItem});
            this.cozumsagtik.Name = "cozumsagtik";
            this.cozumsagtik.Size = new System.Drawing.Size(132, 70);
            this.cozumsagtik.Opening += new System.ComponentModel.CancelEventHandler(this.cozumsagtik_Opening);
            // 
            // yeniKlasörToolStripMenuItem
            // 
            this.yeniKlasörToolStripMenuItem.Name = "yeniKlasörToolStripMenuItem";
            this.yeniKlasörToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.yeniKlasörToolStripMenuItem.Text = "Yeni Klasör";
            this.yeniKlasörToolStripMenuItem.Click += new System.EventHandler(this.yeniKlasörToolStripMenuItem_Click);
            // 
            // yeniDosyaToolStripMenuItem
            // 
            this.yeniDosyaToolStripMenuItem.Name = "yeniDosyaToolStripMenuItem";
            this.yeniDosyaToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.yeniDosyaToolStripMenuItem.Text = "Yeni Dosya";
            this.yeniDosyaToolStripMenuItem.Click += new System.EventHandler(this.yeniDosyaToolStripMenuItem_Click);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Studio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1212, 654);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.debugrelcombo);
            this.Controls.Add(this.baslatbutton);
            this.Controls.Add(this.asagipanel);
            this.Controls.Add(this.cozungezginibaslik);
            this.Controls.Add(this.cozumgezginipanel);
            this.Controls.Add(this.ciktitabcontrol);
            this.Controls.Add(this.kodtabcontrol);
            this.Controls.Add(this.menuyazilari);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuyazilari;
            this.Name = "Studio";
            this.Text = "        Elegant Studio 2021";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Studio_FormClosing);
            this.Load += new System.EventHandler(this.Studio_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Studio_MouseMove);
            this.menuyazilari.ResumeLayout(false);
            this.menuyazilari.PerformLayout();
            this.kodtabcontrol.ResumeLayout(false);
            this.kodpage1.ResumeLayout(false);
            this.ciktitabcontrol.ResumeLayout(false);
            this.ciktitab.ResumeLayout(false);
            this.ciktitab.PerformLayout();
            this.cozumgezginipanel.ResumeLayout(false);
            this.cozungezginibaslik.ResumeLayout(false);
            this.cozungezginibaslik.PerformLayout();
            this.asagipanel.ResumeLayout(false);
            this.asagipanel.PerformLayout();
            this.cozumsagtik.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.MenuStrip menuyazilari;
        public System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem düzenToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem görünümToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem projeToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem derleToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem biçimToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem araçlarToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
        public System.Windows.Forms.TabPage kodpage1;
        public ICSharpCode.TextEditor.TextEditorControl kodtexteditor1;
        public System.Windows.Forms.TabPage ciktitab;
        public System.Windows.Forms.TabPage hatalistesitab;
        public System.Windows.Forms.Panel cozumgezginipanel;
        public System.Windows.Forms.TreeView cozumtreeview;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Panel cozungezginibaslik;
        public System.Windows.Forms.Panel asagipanel;
        public System.Windows.Forms.Label mousexylabel;
        public System.Windows.Forms.Label statuslabel;
        public System.Windows.Forms.TextBox ciktitextbox;
        public System.Windows.Forms.ComboBox debugrelcombo;
        public System.Windows.Forms.ContextMenuStrip cozumsagtik;
        public System.Windows.Forms.ToolStripMenuItem yeniKlasörToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem yeniDosyaToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        public MaterialRaisedButton baslatbutton;
        public System.Windows.Forms.TabControl kodtabcontrol;
        private System.Windows.Forms.ToolStripMenuItem yeniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem farklıKaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geriAlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yineleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kopyalaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yapıştırToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem derleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem derleVeÇalıştırToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yayınlaToolStripMenuItem;
        public System.Windows.Forms.TabControl ciktitabcontrol;
        private PictureBox pictureBox1;
        private ToolStripMenuItem ayarlarToolStripMenuItem;
        private ToolStripMenuItem antaresNetworkeYayınlaToolStripMenuItem;
    }
}