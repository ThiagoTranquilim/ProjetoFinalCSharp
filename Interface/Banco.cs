using Org.BouncyCastle.Asn1.X509;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using Interface.Forms;

namespace Interface
{
    internal class Banco
    {
        MySqlConnection conexao = new MySqlConnection("server=localhost;user id=root;password=;database=projeto_bar; convert zero datetime=True");
        public String mensagem;
        public DataTable listaCliente()
        {

            MySqlCommand cmd = new MySqlCommand("proc_listaCliente", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexao.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable tabela = new DataTable();
                da.Fill(tabela);
                return tabela;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return null;
            }
            finally
            {
                conexao.Close();
            }



        }
        public bool insereCliente(Cliente c)
        {
            MySqlCommand cmd = new MySqlCommand("proc_insereCliente", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("nomeCliente", c.NomeCliente);
            cmd.Parameters.AddWithValue("enderecoCliente", c.EnderecoCliente);
            cmd.Parameters.AddWithValue("telefoneCliente", c.TelefoneCliente);
            cmd.Parameters.AddWithValue("cpfCliente", c.CpfCliente);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }
        public DataTable listaMarca()
        {
            // comentario
            MySqlCommand cmd = new MySqlCommand("proc_listaMarca", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexao.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable tabela = new DataTable();
                da.Fill(tabela);
                return tabela;
            }// fim try
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return null;
            }
            finally
            {
                conexao.Close();
            }

        }

        public DataTable listaCategoria()
        {
            // comentario
            MySqlCommand cmd = new MySqlCommand("proc_listaCategoria", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexao.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable tabela = new DataTable();
                da.Fill(tabela);
                return tabela;
            }// fim try
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return null;
            }
            finally
            {
                conexao.Close();
            }

        }

        public bool insereProduto(Produto p)
        {
            MySqlCommand cmd = new MySqlCommand("proc_insereProduto", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("nomeProduto", p.NomeProduto);
            cmd.Parameters.AddWithValue("precoCusto", p.PrecoCusto);
            cmd.Parameters.AddWithValue("precoVenda", p.PrecoVenda);
            cmd.Parameters.AddWithValue("MARCA_codMarca", p.MARCA_codMarca1);
            cmd.Parameters.AddWithValue("CATEGORIA_codCategoria", p.CATEGORIA_codCategoria1);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }

        public DataTable listaProduto()
        {

            MySqlCommand cmd = new MySqlCommand("proc_listaProduto", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexao.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable tabela = new DataTable();
                da.Fill(tabela);
                return tabela;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return null;
            }
            finally
            {
                conexao.Close();
            }
        }

        public DataTable listaVenda()
        {

            MySqlCommand cmd = new MySqlCommand("proc_listaVenda", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexao.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable tabela = new DataTable();
                da.Fill(tabela);
                return tabela;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return null;
            }
            finally
            {
                conexao.Close();
            }
        }

        public bool deletaCliente(int codCliente)
        {
            MySqlCommand cmd = new MySqlCommand("proc_deleteCliente", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("codigo", codCliente);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery(); // executa o comando
                return true;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }

        public bool deletaProduto(int codProduto)
        {
            MySqlCommand cmd = new MySqlCommand("proc_deleteProduto", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("codigo", codProduto);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery(); // executa o comando
                return true;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }

        public bool insereMarca(String nomeMarca)
        {
            MySqlCommand cmd = new MySqlCommand("proc_insereMarca", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("nomeNovo", nomeMarca);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery(); // executa o comando
                return true;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }

        public bool insereVenda (Venda v)
        {
            MySqlCommand cmd = new MySqlCommand("proc_insereVenda", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("mesaCliente", v.MesaVenda);
            cmd.Parameters.AddWithValue("dataHoraVenda", v.DataHoraVenda);
            cmd.Parameters.AddWithValue("fkcodCliente", v.CLIENTE_codCliente1);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }

        public bool deletaVenda(int codVenda)
        {
            MySqlCommand cmd = new MySqlCommand("proc_deleteVenda", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("codigo", codVenda);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery(); // executa o comando
                return true;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }

        public bool insereCategoria(String nomeCategoria)
        {
            MySqlCommand cmd = new MySqlCommand("proc_insereCategoria", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("nomeNovo", nomeCategoria);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery(); // executa o comando
                return true;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }

        public bool verifica(string user, string pass)
        {
            string senhaHash = Biblioteca.makeHash(pass);
            MySqlCommand cmd = new MySqlCommand("consultaLogin", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("usuario", user);
            cmd.Parameters.AddWithValue("senha", senhaHash);
            try
            {
                conexao.Open();//abrindo a conexão;
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();// tabela virtual
                da.Fill(ds); //passando os valores consultados para o DataSet
                if (ds.Tables[0].Rows.Count > 0) // verifica se houve retorno
                    return true;
                else
                    return false;

            }
            catch (MySqlException er)
            {
                mensagem = "Erro" + er.Message;
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }

        public bool alteraProduto(Produto p, int codProduto)
        {
            MySqlCommand cmd = new MySqlCommand("proc_UpdateProduto", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("nomeAlterado", p.NomeProduto);
            cmd.Parameters.AddWithValue("custoAlterado", p.PrecoCusto);
            cmd.Parameters.AddWithValue("vendaAlterado", p.PrecoVenda);
            cmd.Parameters.AddWithValue("marcaAlterado", p.MARCA_codMarca1);
            cmd.Parameters.AddWithValue("categoriaAlterado", p.CATEGORIA_codCategoria1);
            cmd.Parameters.AddWithValue("codigo", p.CodProduto);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery(); // executa o comando
                return true;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }

        public DataTable listaProdutoUpdate()
        {

            MySqlCommand cmd = new MySqlCommand("proc_listaProdutoCodAndNome", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexao.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable tabela = new DataTable();
                da.Fill(tabela);
                return tabela;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return null;
            }
            finally
            {
                conexao.Close();
            }
        }

        public bool alteraCliente(Cliente c, int codCliente)
        {
            MySqlCommand cmd = new MySqlCommand("proc_UpdateCliente", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("nomeAlterado", c.NomeCliente);
            cmd.Parameters.AddWithValue("enderecoAlterado", c.EnderecoCliente);
            cmd.Parameters.AddWithValue("telefoneAlterado", c.TelefoneCliente);
            cmd.Parameters.AddWithValue("cpfAlterado", c.CpfCliente);
            cmd.Parameters.AddWithValue("codigo", c.CodCliente);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery(); // executa o comando
                return true;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }

        public bool alteraVenda(Venda v, int codVenda)
        {
            MySqlCommand cmd = new MySqlCommand("proc_UpdateVenda", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("mesaAlterado", v.MesaVenda);
            cmd.Parameters.AddWithValue("dataAlterado", v.DataHoraVenda);
            cmd.Parameters.AddWithValue("fkcodClienteAlterado", v.CLIENTE_codCliente1);
            cmd.Parameters.AddWithValue("codigo", v.CodVenda);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery(); // executa o comando
                return true;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }

        public DataTable listaClienteUpdate()
        {

            MySqlCommand cmd = new MySqlCommand("proc_listaClienteCodandNome", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexao.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable tabela = new DataTable();
                da.Fill(tabela);
                return tabela;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return null;
            }
            finally
            {
                conexao.Close();
            }
        }

        public DataTable listaVendaUpdate()
        {

            MySqlCommand cmd = new MySqlCommand("proc_listaVendaCodAndNome", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexao.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable tabela = new DataTable();
                da.Fill(tabela);
                return tabela;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return null;
            }
            finally
            {
                conexao.Close();
            }
        }

    }
}
        
