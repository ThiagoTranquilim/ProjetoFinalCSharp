using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Categoria
    {
        int codCategoria;
        string nomeCategoria;

        public string NomeCategoria { get => nomeCategoria; set => nomeCategoria = value; }
        public int CodCategoria { get => codCategoria; set => codCategoria = value; }
    }
}
