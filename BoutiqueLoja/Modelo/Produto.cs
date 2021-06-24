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
        public string Tipo { get; set; }
        public decimal Valor { get; set; }
        public string Departamento { get; set; }
        
    }
}
