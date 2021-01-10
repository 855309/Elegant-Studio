using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elegant_Studio
{
    public partial class AnaEkran : MaterialForm
    {
        public AnaEkran()
        {
            InitializeComponent();
        }

        private void yeniprojebutton_Click(object sender, EventArgs e)
        {

        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            ProjeOlustur po = new ProjeOlustur();
            po.Show();
            this.Hide();
        }
    }
}
