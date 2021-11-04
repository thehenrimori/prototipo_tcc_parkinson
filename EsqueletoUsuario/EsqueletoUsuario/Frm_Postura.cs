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
    public partial class Frm_Postura : Form
    {
        public Frm_Postura()
        {
            InitializeComponent();
        }

        private void lbl_inicial_Click(object sender, EventArgs e)
        {

        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            Frm_Instrucao frm = new Frm_Instrucao();
            frm.Show();
            this.Hide();
        }

        private void btn_proximo_Click(object sender, EventArgs e)
        {
            Frm_Marcha frmM = new Frm_Marcha();
            frmM.Show();
            this.Hide();
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            Frm_tronco frmT = new Frm_tronco();
            frmT.Show();
            this.Hide();
        }

        private void picturePostura_3_Click(object sender, EventArgs e)
        {

        }
    }
}
