using BoutiqueLoja.Data.ClienteData;
using BoutiqueLoja.Migrations;
using BoutiqueLoja.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fornecedor = BoutiqueLoja.Modelo.Fornecedor;

namespace BoutiqueLoja.Data.FornecedorData
{
    public class FornecedorRepositorio : IFornecedorRepositorio
    {
        private readonly DataContext context;
        private readonly IRepositorio repositorio;

        public FornecedorRepositorio(DataContext context, IRepositorio repositorio)
        {
            this.context = context;
            this.repositorio = repositorio;
        }

        public void AtualizarFornecedor<T>(T entidade) where T : class
        {
            context.Update(entidade);
        }

        public Fornecedor BuscarFornecedor(int id)
        {
            var Fornecedor = context.Fornecedores
                .FirstOrDefault(a => a.Id == id);

            return Fornecedor;
        }

        public void ExcluirFornecedor<T>(T entidade) where T : class
        {
            repositorio.Excluir(entidade);
        }

        public List<Fornecedor> BuscarFornecedores() => context.Fornecedores.ToList();

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
