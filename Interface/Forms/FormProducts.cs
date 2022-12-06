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
    public partial class FormProducts : Form
    {
        public FormProducts()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            (dgProduto.DataSource as DataTable).DefaultView.RowFilter = String.Format("nome like '{0}%'", textBox1.Text);
        }


        void listaProduto()
        {
            Banco con = new Banco();
            dgProduto.DataSource = con.listaProduto();
        }

        void listaMarca()
        {
            Banco con = new Banco();
            DataTable tabelaDados = new DataTable();
            tabelaDados = con.listaMarca();
            cbMarca.DataSource = tabelaDados;
            cbMarca.DisplayMember = "nomeMarca";
            cbMarca.ValueMember = "codMarca";
            lblmsgerro.Text = con.mensagem;
            cbMarca.Text = "";
        }

        void listaCategoria()
        {
            Banco con = new Banco();
            DataTable tabelaDados = new DataTable();
            tabelaDados = con.listaCategoria();
            cbCategoria.DataSource = tabelaDados;
            cbCategoria.DisplayMember = "nomeCategoria";
            cbCategoria.ValueMember = "codCategoria";
            lblmsgerro.Text = con.mensagem;
            cbCategoria.Text = "";
        }

        void limpaCampos()
        {
            txtnomeProduto.Text = "";
            txtprecoCusto.Text = "";
            txtprecoVenda.Text = "";
            cbMarca.Text = "";
            cbCategoria.Text = "";
            txtnomeProduto.Focus();
        }

        private void FormProducts_Load(object sender, EventArgs e)
        {
            listaProduto();
            listaMarca();
            listaCategoria();
        }

        private void lblprecoCusto_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Produto p = new Produto();
            p.NomeProduto = txtnomeProduto.Text;
            p.PrecoCusto = Convert.ToSingle(txtprecoCusto.Text);
            p.PrecoVenda = Convert.ToSingle(txtprecoVenda.Text);
            p.MARCA_codMarca1 = Convert.ToInt32(cbMarca.SelectedValue.ToString());
            p.CATEGORIA_codCategoria1 = Convert.ToInt32(cbCategoria.SelectedValue.ToString());


            Banco conecta = new Banco();
            bool retorno = conecta.insereProduto(p);
            if (retorno == true)
            {
                MessageBox.Show("Dados inseridos com sucesso");
            }
            else
                lblmsgerro.Text = conecta.mensagem;

            listaProduto();
            limpaCampos();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            int linha = dgProduto.CurrentRow.Index;// pega a linha selecionada
            int idRemover = Convert.ToInt32(
                dgProduto.Rows[linha].Cells["codProduto"].Value.ToString());
            DialogResult resp =
                 MessageBox.Show
                   ("Confirma exclusão?", "Remove Produto",
                            MessageBoxButtons.OKCancel);
            if (resp == DialogResult.OK)
            {
                Banco conecta = new Banco();
                bool retorno = conecta.deletaProduto(idRemover);
                if (retorno == true)
                    MessageBox.Show("Produto excluido");
                else
                    lblmsgerro.Text = conecta.mensagem;
                listaProduto();
            }// fim if ok
            else
                MessageBox.Show("Operação cancelada");
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            FrmAddMarca frmAddMarca = new FrmAddMarca();
            this.Hide();
            frmAddMarca.ShowDialog();
            this.Close();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            FrmAddCategoria frmAddCategoria = new FrmAddCategoria();
            this.Hide();
            frmAddCategoria.ShowDialog();
            this.Close();
        }

        private void cbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
