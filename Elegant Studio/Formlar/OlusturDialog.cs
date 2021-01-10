using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elegant_Studio
{
    public partial class OlusturDialog : MaterialForm
    {
        public string drm = "";

        string juanyol = "";

        bool klsormu;

        public OlusturDialog(string yol, bool klasormu)
        {
            InitializeComponent();

            juanyol = yol;

            klsormu = klasormu;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void OlusturDialog_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void olusturbutton_Click(object sender, EventArgs e)
        {

            drm = textBox1.Text;

            this.DialogResult = DialogResult.OK;
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "")
            {
                button1.Enabled = false;
            }
            else
            {
                //button1.Enabled = true;

                if (klsormu)
                {
                    if (Directory.Exists(Path.Combine(juanyol, textBox1.Text)))
                    {
                        button1.Enabled = false;
                    }
                    else
                    {
                        button1.Enabled = true;
                    }
                }
                else
                {
                    if (File.Exists(Path.Combine(juanyol, textBox1.Text)))
                    {
                        button1.Enabled = false;
                    }
                    else
                    {
                        button1.Enabled = true;
                    }
                }
            }
        }
    }
}
