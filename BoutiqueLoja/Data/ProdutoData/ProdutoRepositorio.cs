using BoutiqueLoja.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoutiqueLoja.Data.ProdutoData 
{
    public class ProdutoRepositorio : IProdutoRepositorio
    {
        private readonly DataContext context;
        private readonly IRepositorio repositorio;

        public ProdutoRepositorio(DataContext context, IRepositorio repositorio)
        {
            this.context = context;
            this.repositorio = repositorio;
        }

        public void AtualizarProduto<T>(T entidade) where T : class
        {
            context.Update(entidade);
        }

        public Produto BuscarProduto(int id)
        {
            var Produto = context.Produtos
                .FirstOrDefault(a => a.Id == id);

            return Produto;
        }

        public void ExcluirProduto<T>(T entidade) where T : class
        {
            repositorio.Excluir(entidade);
        }

        public List<Produto> BuscarProdutos() => context.Produtos.ToList();

        public void Adiconar<T>(T entidade) where T : class
        {
            repositorio.Adiconar(entidade);
        }

        public void Atualizar<T>(T entidade) where T : class
        {
            repositorio.Atualizar(entidade);
        }

        public async Task<bool> Salvar()
        {
            return await repositorio.Salvar();
        }
    }
}
