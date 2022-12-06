using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Interface
{
    internal class Marca
    {
        int codMarca;
        string nomeMarca;

        public string NomeMarca { get => nomeMarca; set => nomeMarca = value; }
        public int CodMarca { get => codMarca; set => codMarca = value; }
    }
}
