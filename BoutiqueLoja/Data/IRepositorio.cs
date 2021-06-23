using BoutiqueLoja.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoutiqueLoja.Data
{
    public interface IRepositorio
    {
        void Adiconar<T>(T entidade) where T : class;

        Task<bool> Salvar();

        Cliente BuscarCliente(int id);

        List<Cliente> BuscarClientes();
        void AtualizarCliente<T>(T entidade) where T : class;

        void ExcluirCliente<T>(T entidade) where T : class;

        void BuscarFornecedor<T>(T entidade) where T : class;

        void BuscarVendedor<T>(T entidade) where T : class;

        void BuscarProduto<T>(T entidade) where T : class;

    }
}
