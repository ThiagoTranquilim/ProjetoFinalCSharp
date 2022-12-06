using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Interface.Forms
{
    public partial class FrmUpdateProduto : Form
    {
        int idAlterar;
        public FrmUpdateProduto()
        {
            InitializeComponent();
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmUpdateProduto_Load(object sender, EventArgs e)
        {
            listaProdutoUpdate();
            listaMarca();
            listaCategoria();
        }

        void listaMarca()
        {
            Banco con = new Banco();
            DataTable tabelaDados = new DataTable();
            tabelaDados = con.listaMarca();
            cbAlteraMarca.DataSource = tabelaDados;
            cbAlteraMarca.DisplayMember = "nomeMarca";
            cbAlteraMarca.ValueMember = "codMarca";
            cbAlteraMarca.Text = "";
        }

        void listaCategoria()
        {
            Banco con = new Banco();
            DataTable tabelaDados = new DataTable();
            tabelaDados = con.listaCategoria();
            cbAlteraCategoria.DataSource = tabelaDados;
            cbAlteraCategoria.DisplayMember = "nomeCategoria";
            cbAlteraCategoria.ValueMember = "codCategoria";
            cbAlteraCategoria.Text = "";
        }

        void listaProdutoUpdate()
        {
            Banco con = new Banco();
            dgMais.DataSource = con.listaProdutoUpdate();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Produto p = new Produto();
            p.NomeProduto = txtAlteraNome.Text;
            p.PrecoCusto = Convert.ToInt32(txtAlteraPrecoCusto.Text);
            p.PrecoVenda = Convert.ToInt32(txtAlteraPrecoVenda.Text);
            p.MARCA_codMarca1 = Convert.ToInt32(cbAlteraMarca.SelectedValue.ToString());
            p.CATEGORIA_codCategoria1 = Convert.ToInt32(cbAlteraCategoria.SelectedValue.ToString());
            p.CodProduto = Convert.ToInt32(txtAlteracodProduto.Text);
            // Envia os dados para alterar
            Banco conecta = new Banco();
            bool retorno = conecta.alteraProduto(p, idAlterar);
            if (retorno == true)
                MessageBox.Show("Dados alterados com sucesso");
            else
                MessageBox.Show("erro");

            listaProdutoUpdate();
        }

        private void dgMais_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
