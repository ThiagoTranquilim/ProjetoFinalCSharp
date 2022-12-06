using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface.Forms
{
    public partial class FrmAddOrder : Form
    {
        public FrmAddOrder()
        {
            InitializeComponent();
        }

        private void FrmAddOrder_Load(object sender, EventArgs e)
        {

        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
            this.Close();
        }

        void limpaCampos()
        {
            txtMesaCliente.Text = "";
            txtDataHoraCliente.Text = "";
            txtNomeCliente.Text = "";
            txtMesaCliente.Focus();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Venda v = new Venda();
            v.MesaVenda = Convert.ToInt32(txtMesaCliente.Text);
            v.DataHoraVenda = Convert.ToDateTime(txtDataHoraCliente.Text);
            v.CLIENTE_codCliente1 = Convert.ToString(txtNomeCliente.Text);


            Banco conecta = new Banco();
            bool retorno = conecta.insereVenda(v);
            if (retorno == true)
            {
                MessageBox.Show("Dados inseridos com sucesso");
            }
            else
                MessageBox.Show("Erro");

            limpaCampos();
        }
    }
}
