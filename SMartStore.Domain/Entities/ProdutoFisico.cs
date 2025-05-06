using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMartStore.Domain.Entities
{
    public class ProdutoFisico : Produto
    {
        public decimal Peso { get; set; }

        public override decimal CalcularDesconto()
        {
            return Preco * 0.1m; 
        }
    }
}
