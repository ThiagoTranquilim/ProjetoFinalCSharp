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
    public partial class FrmUpdateCliente : Form
    {
        int idAlterar;
        public FrmUpdateCliente()
        {
            InitializeComponent();
        }

        void listaClienteUpdate()
        {
            Banco con = new Banco();
            dgMais.DataSource = con.listaClienteUpdate();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente();
            c.NomeCliente = txtAlteraNome.Text;
            c.EnderecoCliente = Convert.ToString(txtAlteraEndereco.Text);
            c.TelefoneCliente = Convert.ToString(txtAlteraTelefone.Text);
            c.CpfCliente = Convert.ToString(txtAlteraCpf.Text);
            c.CodCliente = Convert.ToInt32(txtAlteraCodCliente.Text);
            // Envia os dados para alterar
            Banco conecta = new Banco();
            bool retorno = conecta.alteraCliente(c, idAlterar);
            if (retorno == true)
                MessageBox.Show("Dados alterados com sucesso");
            else
                MessageBox.Show("erro");

            listaClienteUpdate();
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
            this.Close();
        }

        private void FrmUpdateCliente_Load(object sender, EventArgs e)
        {
            listaClienteUpdate();
        }
    }
}
