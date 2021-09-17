using BoutiqueLoja.Data;
using BoutiqueLoja.Data.ClienteData;
using BoutiqueLoja.Data.ProdutoData;
using BoutiqueLoja.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoutiqueLoja.Bussiness
{
    public class ProdutoBussiness
    {
        private readonly IProdutoRepositorio repositorio;
        public ProdutoBussiness(IProdutoRepositorio repositorio)
        {
            this.repositorio = repositorio;

        }
        public Produto BuscarProduto(int id)
        {
            var produto = repositorio.BuscarProduto(id);
            return produto;
        }
        public List<Produto> ExibirProdutos()
        {
            var produto = repositorio.BuscarProdutos();
            return produto;
        }
        public async Task<Produto> SalvarProduto(Produto produto)
        {
            repositorio.Adiconar(produto);

            if (await repositorio.Salvar())
                return produto;

            return null;
        }
        public async Task<Produto> AtualizarProduto(Produto produto)
        {
            repositorio.AtualizarProduto(produto);

            if (await repositorio.Salvar())
                return produto;

            return null;
        }

    }
}
