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
    public partial class FrmupdateVenda : Form
    {
        int idAlterar;
        public FrmupdateVenda()
        {
            InitializeComponent();
        }

        private void FrmupdateVenda_Load(object sender, EventArgs e)
        {
            listaVendaUpdate();
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
            this.Close();
        }

        void listaVendaUpdate()
        {
            Banco con = new Banco();
            dgMais.DataSource = con.listaVendaUpdate();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Venda v = new Venda();
            v.MesaVenda = Convert.ToInt32(txtAlteraMesa.Text);
            v.DataHoraVenda = Convert.ToDateTime(txtAlteraDataHora.Text);
            v.CLIENTE_codCliente1 = Convert.ToString(txtAlteraCliente.Text);
            v.CodVenda = Convert.ToInt32(txtCodVenda.Text);
            // Envia os dados para alterar
            Banco conecta = new Banco();
            bool retorno = conecta.alteraVenda(v, idAlterar);
            if (retorno == true)
                MessageBox.Show("Dados alterados com sucesso");
            else
                MessageBox.Show("erro");

            listaVendaUpdate();
        }
    }
}
