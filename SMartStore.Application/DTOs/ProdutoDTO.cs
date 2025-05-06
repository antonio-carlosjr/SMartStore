using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMartStore.Application.DTOs
{
    public class ProdutoDTO
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public string Tipo { get; set; } // "fisico" ou "digital"
        public decimal? Peso { get; set; } // apenas para produtos físicos
    }
}
