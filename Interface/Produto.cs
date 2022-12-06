using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Interface
{
    //nome, precoCusto, precoVenda
    internal class Produto
    {
        int codProduto;
        string nomeProduto;
        float precoCusto;
        float precoVenda;
        int MARCA_codMarca;
        int CATEGORIA_codCategoria;

        public float PrecoVenda { get => precoVenda; set => precoVenda = value; }
        public float PrecoCusto { get => precoCusto; set => precoCusto = value; }
        public string NomeProduto { get => nomeProduto; set => nomeProduto = value; }
        public int MARCA_codMarca1 { get => MARCA_codMarca; set => MARCA_codMarca = value; }
        public int CATEGORIA_codCategoria1 { get => CATEGORIA_codCategoria; set => CATEGORIA_codCategoria = value; }
        public int CodProduto { get => codProduto; set => codProduto = value; }
    }
}
