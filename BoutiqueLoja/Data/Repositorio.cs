using BoutiqueLoja.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoutiqueLoja.Data
{
    public class Repositorio : IRepositorio
    {
        private readonly DataContext context;

        public Repositorio(DataContext context)
        {
            this.context = context;
        }
        public void Adiconar<T>(T entidade) where T : class =>
         context.Add(entidade);

        public Cliente BuscarCliente(int id)
        {
            var Cliente = context.Clientes
                .FirstOrDefault(a => a.Id == id);

            return Cliente;
        }
        public void AtualizarCliente<T>(T entidade) where T : class
        {
            context.Update(entidade);
        }
        public async Task<bool> Salvar() => await context.SaveChangesAsync() > 0;

        public void ExcluirCliente<T>(T entidade) where T : class
        {
            context.Remove(entidade);
        }
        public List<Cliente> BuscarClientes()
        {
            return context.Clientes.ToList();
        }
        public void BuscarFornecedor<T>(T entidade) where T : class
        {
            context.Update(entidade);
        }
        public void BuscarVendedor<T>(T entidade) where T : class
        {
            context.Update(entidade);
        }
        public void BuscarProduto<T>(T entidade) where T : class 
        {
            context.Update(entidade);
        }
    }
}
