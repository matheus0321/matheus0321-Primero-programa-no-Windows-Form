using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula60
{
    public partial class F_Principal : Form
    {
        public F_Principal()
        {
            InitializeComponent();
        }

        private void F_Principal_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        { 
            if (txtVeiculo.Text == "")
            {
                MessageBox.Show("Digite um veiculo");
                txtVeiculo.Focus();
                return;
            }

            txtLista.Text += txtVeiculo.Text +" , ";
            // txtLista.Text = txtLista.Text + txtVeiculo.Text ;
            txtVeiculo.Clear();
            txtVeiculo.Focus();

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtLista.Clear();
            txtVeiculo.Clear();
            txtVeiculo.Focus();

        }
    }
}
