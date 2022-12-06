using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Interface
{
    //nomeCliente, telefoneCliente, enderecoCliente, codCliente, cpfCliente
    internal class Cliente
    {
        int codCliente;
        string nomeCliente;
        string enderecoCliente;
        string telefoneCliente;
        string cpfCliente;

        public string CpfCliente { get => cpfCliente; set => cpfCliente = value; }
        public string TelefoneCliente { get => telefoneCliente; set => telefoneCliente = value; }
        public string EnderecoCliente { get => enderecoCliente; set => enderecoCliente = value; }
        public string NomeCliente { get => nomeCliente; set => nomeCliente = value; }
        public int CodCliente { get => codCliente; set => codCliente = value; }
    }
}
