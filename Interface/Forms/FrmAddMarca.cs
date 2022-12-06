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
    public partial class FrmAddMarca : Form
    {
        public FrmAddMarca()
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

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Banco banco = new Banco();
            bool retorno = banco.insereMarca(txtAddMarca.Text);
            if (retorno == true)
            {
                MessageBox.Show("Nova marca inserida");
                txtAddMarca.Text = "";
                txtAddMarca.Focus();
            }
            else
                MessageBox.Show("erro");
        }

        private void FrmAddMarca_Load(object sender, EventArgs e)
        {

        }
    }
}
