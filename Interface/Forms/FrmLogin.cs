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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Banco conecta = new Banco();
            if (conecta.verifica(txtlogin.Text, txtsenha.Text) == true)
            {
                Form1 sis = new Form1();
                this.Hide();
                sis.ShowDialog();
                this.Close();
            }
            else
                MessageBox.Show("Usuário ou senha incorretas " + conecta.mensagem);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtsenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtlogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
