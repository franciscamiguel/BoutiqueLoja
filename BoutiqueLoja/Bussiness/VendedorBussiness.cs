using BoutiqueLoja.Data;
using BoutiqueLoja.Data.ProdutoData;
using BoutiqueLoja.Data.VendedorData;
using BoutiqueLoja.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoutiqueLoja.Bussiness
{
    public class VendedorBussiness
    {
        private readonly IVendedorRepositorio repositorio;
        public VendedorBussiness(IVendedorRepositorio repositorio)
        {
            this.repositorio = repositorio;

        }
        public Vendedor BuscarVendedor(int id)
        {
            var vendedor = repositorio.BuscarVendedor(id);
            return vendedor;
        }
        public List<Vendedor> ExibirVendedor()
        {
            var vendedor = repositorio.BuscarVendedores();
            return vendedor;
        }
        public async Task<Vendedor> SalvarVendedor(Vendedor vendedor)
        {
            repositorio.Adiconar(vendedor);

            if (await repositorio.Salvar())
                return vendedor;

            return null;
        }
        public async Task<Vendedor> AtualizarVendedor(Vendedor vendedor)
        {
            repositorio.AtualizarVendedor(vendedor);

            if (await repositorio.Salvar())
                return vendedor;

            return null;
        }
    }
}
