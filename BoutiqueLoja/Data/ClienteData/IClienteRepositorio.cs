using BoutiqueLoja.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoutiqueLoja.Data.ClienteData
{
    public interface IClienteRepositorio
    {
        void Adiconar<T>(T entidade) where T : class;

        Task<bool> Salvar();

        void AtualizarCliente<T>(T entidade) where T : class;

        Cliente BuscarCliente(int id);

        List<Cliente> BuscarClientes();

        void ExcluirCliente<T>(T entidade) where T : class;

    }
}
