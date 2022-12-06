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
    public partial class FormOrders : Form
    {
        public FormOrders()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgProduto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            int linha = dgVenda.CurrentRow.Index;// pega a linha selecionada
            int idRemover = Convert.ToInt32(
                dgVenda.Rows[linha].Cells["codVenda"].Value.ToString());
            DialogResult resp =
                 MessageBox.Show
                   ("Confirma exclusão?", "Remove Venda",
                            MessageBoxButtons.OKCancel);
            if (resp == DialogResult.OK)
            {
                Banco conecta = new Banco();
                bool retorno = conecta.deletaVenda(idRemover);
                if (retorno == true)
                    MessageBox.Show("Venda excluida");
                else
                    MessageBox.Show("erro");
                listaVenda();
            }// fim if ok
            else
                MessageBox.Show("Operação cancelada");
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            FrmAddOrder frmAddOrder = new FrmAddOrder();
            this.Hide();
            frmAddOrder.ShowDialog();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            (dgVenda.DataSource as DataTable).DefaultView.RowFilter = String.Format("Cliente like '{0}%'", textBox1.Text);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        void listaVenda()
        {
            Banco con = new Banco();
            dgVenda.DataSource = con.listaVenda();
        }

        private void FormOrders_Load(object sender, EventArgs e)
        {
            listaVenda();
        }
    }
}
