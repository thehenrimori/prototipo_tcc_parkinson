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
    public partial class Frm_tronco : Form
    {
        public Frm_tronco()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_Instrucao frm = new Frm_Instrucao();
            frm.Show();
            this.Hide();
        }

        private void btn_anterior_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            Frm_Marcha frmM = new Frm_Marcha();
            frmM.Show();
            this.Hide();
        }

        private void btn_proximo_Click(object sender, EventArgs e)
        {
            Frm_Postura frmP = new Frm_Postura();
            frmP.Show();
            this.Hide();
        }
    }
}
