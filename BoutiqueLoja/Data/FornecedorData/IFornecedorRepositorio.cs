using BoutiqueLoja.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoutiqueLoja.Data.ClienteData
{
   public interface IFornecedorRepositorio
    {
        void Adiconar<T>(T entidade) where T : class;

        Task<bool> Salvar();

        void AtualizarFornecedor<T>(T entidade) where T : class;

        Fornecedor BuscarFornecedor(int id);

        List<Fornecedor> BuscarFornecedores();

        void ExcluirFornecedor<T>(T entidade) where T : class;
    }
}
