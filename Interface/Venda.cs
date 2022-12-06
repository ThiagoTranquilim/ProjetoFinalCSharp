using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Venda
    {
        int codVenda;
        int mesaVenda;
        DateTime dataHoraVenda;
        string CLIENTE_codCliente;

        public int MesaVenda { get => mesaVenda; set => mesaVenda = value; }
        public string CLIENTE_codCliente1 { get => CLIENTE_codCliente; set => CLIENTE_codCliente = value; }
        public DateTime DataHoraVenda { get => dataHoraVenda; set => dataHoraVenda = value; }
        public int CodVenda { get => codVenda; set => codVenda = value; }
    }
}
