using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using SMartStore.Application.DTOs;
using SMartStore.Domain.Entities;
using SMartStore.Domain.Interfaces;

namespace SMartStore.Application.UseCases
{
    public class AdicionarProdutoUseCase
    {
        private readonly IProdutoRepository _produtoRepository;

        public AdicionarProdutoUseCase(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public void Executar(ProdutoDTO dto)
        {
            Produto produto = dto.Tipo.ToLower() switch
            {
                "fisico" => new ProdutoFisico
                {
                    Nome = dto.Nome,
                    Preco = dto.Preco,
                    Peso = dto.Peso ?? 0 // Se o peso não for fornecido, define como 0
                },
                "digital" => new ProdutoDigital
                {
                    Nome = dto.Nome,
                    Preco = dto.Preco
                },
                _ => throw new ArgumentException("Tipo de produto inválido")
            };
        }
    }
}
