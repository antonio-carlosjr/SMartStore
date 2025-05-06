using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SMartStore.Domain.Entities;

namespace SMartStore.Domain.Interfaces
{
    internal interface IProdutoRepository
    {
        Produto obterPorId(int id);
        IEnumerable<Produto> Listar();
        void Adicionar(Produto produto);
        void Atualizar(Produto produto);
        void Remover(int id);

    }
}
