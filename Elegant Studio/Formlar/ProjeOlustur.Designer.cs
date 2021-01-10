
namespace Elegant_Studio
{
    partial class ProjeOlustur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjeOlustur));
            this.klasorac = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.projeyolutextbox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.projeaditextbox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.materialFlatButton1);
            this.panel1.Controls.Add(this.projeyolutextbox);
            this.panel1.Controls.Add(this.projeaditextbox);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(728, 272);
            this.panel1.TabIndex = 0;
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(554, 189);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(72, 36);
            this.materialFlatButton1.TabIndex = 14;
            this.materialFlatButton1.Text = "Oluştur";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // projeyolutextbox
            // 
            this.projeyolutextbox.Depth = 0;
            this.projeyolutextbox.Hint = "";
            this.projeyolutextbox.Location = new System.Drawing.Point(130, 79);
            this.projeyolutextbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.projeyolutextbox.Name = "projeyolutextbox";
            this.projeyolutextbox.PasswordChar = '\0';
            this.projeyolutextbox.SelectedText = "";
            this.projeyolutextbox.SelectionLength = 0;
            this.projeyolutextbox.SelectionStart = 0;
            this.projeyolutextbox.Size = new System.Drawing.Size(234, 23);
            this.projeyolutextbox.TabIndex = 13;
            this.projeyolutextbox.UseSystemPasswordChar = false;
            // 
            // projeaditextbox
            // 
            this.projeaditextbox.Depth = 0;
            this.projeaditextbox.Hint = "";
            this.projeaditextbox.Location = new System.Drawing.Point(130, 32);
            this.projeaditextbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.projeaditextbox.Name = "projeaditextbox";
            this.projeaditextbox.PasswordChar = '\0';
            this.projeaditextbox.SelectedText = "";
            this.projeaditextbox.SelectionLength = 0;
            this.projeaditextbox.SelectionStart = 0;
            this.projeaditextbox.Size = new System.Drawing.Size(234, 23);
            this.projeaditextbox.TabIndex = 12;
            this.projeaditextbox.Text = "KonsolProjesi";
            this.projeaditextbox.UseSystemPasswordChar = false;
            this.projeaditextbox.TextChanged += new System.EventHandler(this.projeaditextbox_TextChanged_1);
            this.projeaditextbox.VisibleChanged += new System.EventHandler(this.projeaditextbox_VisibleChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(370, 76);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 29);
            this.button2.TabIndex = 11;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(37, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "Proje Yolu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(37, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Proje Adı:";
            // 
            // ProjeOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 333);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProjeOlustur";
            this.Text = "Elegant Studio Proje Oluşturucu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog klasorac;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialSingleLineTextField projeyolutextbox;
        private MaterialSkin.Controls.MaterialSingleLineTextField projeaditextbox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}