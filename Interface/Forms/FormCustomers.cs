using Interface.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Interface.Forms
{
    public partial class FormCustomers : Form
    {
        public FormCustomers()
        {
            InitializeComponent();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        void listaCliente()
        {
            Banco con = new Banco();
            dgCliente.DataSource = con.listaCliente();
        }

        private void FormCustomers_Load(object sender, EventArgs e)
        {
            listaCliente();
            
        }
        void limpaCampos()
        {
            txtnome.Text = "";
            txttelefone.Text = "";
            txtendereco.Text = "";
            txtcpf.Text = "";
            txtnome.Focus();
        }


        private void iconButton1_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente();
            c.NomeCliente = txtnome.Text;
            c.TelefoneCliente = txttelefone.Text;
            c.EnderecoCliente = txtendereco.Text;
            c.CpfCliente = txtcpf.Text;

            Banco conecta = new Banco();
            bool retorno = conecta.insereCliente(c);
            if (retorno == true)
            {
                MessageBox.Show("Dados inseridos com sucesso");
            }
            else
                lblmsgerro.Text = conecta.mensagem;

            listaCliente();
            limpaCampos();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            (dgCliente.DataSource as DataTable).DefaultView.RowFilter = String.Format("nome like '{0}%'", textBox1.Text);
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            {
                int linha = dgCliente.CurrentRow.Index;// pega a linha selecionada
                int idRemover = Convert.ToInt32(
                    dgCliente.Rows[linha].Cells["codCliente"].Value.ToString());
                DialogResult resp =
                     MessageBox.Show
                       ("Confirma exclusão?", "Remove Cliente",
                                MessageBoxButtons.OKCancel);
                if (resp == DialogResult.OK)
                {
                    Banco conecta = new Banco();
                    bool retorno = conecta.deletaCliente(idRemover);
                    if (retorno == true)
                        MessageBox.Show("Cliente excluido");
                    else
                        lblmsgerro.Text = conecta.mensagem;
                    listaCliente();
                }// fim if ok
                else
                    MessageBox.Show("Operação cancelada");
            }
        }
    }
}