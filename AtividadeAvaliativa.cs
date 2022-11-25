using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace veiculosproj
{
    public partial class AtividadeAvaliativa : Form
    {
        public AtividadeAvaliativa()
        {
            InitializeComponent();
            mkdData.Text = DateTime.Now.ToShortDateString();
        }

        private void AtividadeAvaliativa_Load(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            relogio.Text = DateTime.Now.ToLongTimeString();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void mkdData_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            rdParcelaUnica.Checked = false;
            rdParcelado.Checked = false;
            txtParcelas.Text=String.Empty;
            txtParcela.Text=String.Empty;
            txtValor.Text = String.Empty;
            txtPlaca.Text = String.Empty;
            txtImposto.Text = String.Empty;

        }

        private void txtPlaca_Enter(object sender, EventArgs e)
        {
            txtPlaca.Focus();
        }

        private void mkdData_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        
        }

        private void txtPlaca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ((char)Keys.Enter))
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
                /*txtValor.Focus();*/
            } 
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPlaca_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
