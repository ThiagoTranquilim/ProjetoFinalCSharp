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
    public partial class FormUpdate : Form
    {
        int idAlterar;
        public FormUpdate()
        {
            InitializeComponent();
        }

        private void FormMarketing_Load(object sender, EventArgs e)
        {

        }

        void listaProduto()
        {
            Banco con = new Banco();
            dgMais.DataSource = con.listaProduto();
        }

        void listaCliente()
        {
            Banco con = new Banco();
            dgMais.DataSource = con.listaCliente();
        }

        void listaVenda()
        {
            Banco con = new Banco();
            dgMais.DataSource = con.listaVenda();
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            listaProduto();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            listaCliente();
        }

        private void btnVenda_Click(object sender, EventArgs e)
        {
            listaVenda();
        }

        private void UpdateVenda_Click(object sender, EventArgs e)
        {
            FrmupdateVenda frmupdateVenda = new FrmupdateVenda();
            this.Hide();
            frmupdateVenda.ShowDialog();
            this.Close();
        }

        private void UpdateProduto_Click(object sender, EventArgs e)
        {
            FrmUpdateProduto frmUpdateProduto = new FrmUpdateProduto();
            this.Hide();
            frmUpdateProduto.ShowDialog();
            this.Close();
        }

        private void UpdateCliente_Click(object sender, EventArgs e)
        {
            FrmUpdateCliente frmUpdateCliente = new FrmUpdateCliente();
            this.Hide();
            frmUpdateCliente.ShowDialog();
            this.Close();
        }

        private void dgMais_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
