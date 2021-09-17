using BoutiqueLoja.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoutiqueLoja.Data.VendedorData
{
    public class VendedorRepositorio : IVendedorRepositorio
    {
        private readonly DataContext context;
        private readonly IRepositorio repositorio;

        public VendedorRepositorio(DataContext context, IRepositorio repositorio)
        {
            this.context = context;
            this.repositorio = repositorio;
        }

        public void AtualizarVendedor<T>(T entidade) where T : class
        {
            context.Update(entidade);
        }

        public Vendedor BuscarVendedor(int id)
        {
            var vendedor = context.Vendedores
                .FirstOrDefault(a => a.Id == id);

            return vendedor;
        }
        public void ExcluirVendedor<T>(T entidade) where T : class
        {
            repositorio.Excluir(entidade);
        }

        public List<Vendedor> BuscarVendedores() => context.Vendedores.ToList();

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
