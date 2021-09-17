using BoutiqueLoja.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoutiqueLoja.Data.ProdutoData
{
   public interface IProdutoRepositorio
    {
        void Adiconar<T>(T entidade) where T : class;

        Task<bool> Salvar();

        void AtualizarProduto<T>(T entidade) where T : class;

        Produto BuscarProduto(int id);

        List<Produto> BuscarProdutos();

        void ExcluirProduto<T>(T entidade) where T : class;
    }
}
