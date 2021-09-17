using BoutiqueLoja.Data.ClienteData;
using BoutiqueLoja.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoutiqueLoja.Bussiness
{
    public class ClienteBussiness
    {
        private readonly IClienteRepositorio repositorio;
        public ClienteBussiness(IClienteRepositorio repositorio)
        {
            this.repositorio = repositorio;

        }
        public Cliente BuscarCliente(int id)
        {
            var cliente = repositorio.BuscarCliente(id);
            return cliente;
        }
        public List<Cliente> ExibirClientes()
        {
            var clientes = repositorio.BuscarClientes();
            return clientes;
        }
        public async Task<Cliente> SalvarCliente(Cliente cliente)
        {
            repositorio.Adiconar(cliente);

            if (await repositorio.Salvar())
                return cliente;

            return null;
        }
        public async Task<Cliente> AtualizarCliente(Cliente cliente)
        {
            repositorio.AtualizarCliente(cliente);

            if (await repositorio.Salvar()) 
                return cliente;

            return null;
        }

        public async Task ExcluirCliente(Cliente cliente)
        {
            repositorio.ExcluirCliente(cliente);
            await repositorio.Salvar();
        }



    }
}
