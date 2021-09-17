using BoutiqueLoja.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoutiqueLoja.Data.ClienteData
{
    public class ClienteRepositorio : IClienteRepositorio
    {
        private readonly DataContext context;
        private readonly IRepositorio repositorio;

        public ClienteRepositorio(DataContext context, IRepositorio repositorio)
        {
            this.context = context;
            this.repositorio = repositorio;
        }

        public void AtualizarCliente<T>(T entidade) where T : class
        {
            context.Update(entidade);
        }

        public Cliente BuscarCliente(int id)
        {
            var Cliente = context.Clientes
                .FirstOrDefault(a => a.Id == id);

            return Cliente;
        }

        public void ExcluirCliente<T>(T entidade) where T : class
        {
            repositorio.Excluir(entidade);
        }

        public List<Cliente> BuscarClientes()
        {
            return context.Clientes.ToList();
        }

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
