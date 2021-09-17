using BoutiqueLoja.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoutiqueLoja.Data.VendedorData
{
   public interface IVendedorRepositorio
   {
        void Adiconar<T>(T entidade) where T : class;

        Task<bool> Salvar();

        void AtualizarVendedor<T>(T entidade) where T : class;

        Vendedor BuscarVendedor(int id);

        List<Vendedor> BuscarVendedores();

        void ExcluirVendedor<T>(T entidade) where T : class;
   }
}

