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
    public partial class Frm_Marcha : Form
    {
        public Frm_Marcha()
        {
            InitializeComponent();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            Frm_Instrucao frm = new Frm_Instrucao();
            frm.Show();
            this.Hide();
        }

        private void btn_proximo_Click(object sender, EventArgs e)
        {
            Frm_tronco frmT = new Frm_tronco();
            frmT.Show();
            this.Hide();
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            Frm_Postura frmP = new Frm_Postura();
            frmP.Show();
            this.Hide();
        }
    }
}
