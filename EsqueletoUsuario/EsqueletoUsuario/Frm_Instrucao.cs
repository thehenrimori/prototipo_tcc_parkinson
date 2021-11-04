using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsqueletoUsuario
{
    public partial class Frm_Instrucao : Form
    {
        public Frm_Instrucao()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {

        }

        private void btn_tronco_Click(object sender, EventArgs e)
        {
            Frm_tronco frmT = new Frm_tronco();
            frmT.Show();
            this.Hide();
        }

        private void btn_marcha_Click(object sender, EventArgs e)
        {
            Frm_Marcha frmM = new Frm_Marcha();
            frmM.Show();
            this.Hide();
        }

        private void btn_postura_Click(object sender, EventArgs e)
        {
            Frm_Postura frmP = new Frm_Postura();
            frmP.Show();
            this.Hide();
        }
    }
}
