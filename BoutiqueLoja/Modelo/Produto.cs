using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoutiqueLoja.Modelo
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Tipo { get; set; }
        public string Valor { get; set; }
        public string Departamento { get; set; }
        
    }
}
