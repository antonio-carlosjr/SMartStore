using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMartStore.Domain.Entities
{
    public class ProdutoDigital : Produto
    {
        public override decimal CalcularDesconto()
        {
             return Preco * 0.3m; // 30% de desconto     
        }
    }
}
