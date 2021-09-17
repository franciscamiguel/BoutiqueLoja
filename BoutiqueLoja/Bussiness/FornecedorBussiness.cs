using BoutiqueLoja.Data;
using BoutiqueLoja.Modelo;
using BoutiqueLoja.Data.ClienteData;
using BoutiqueLoja.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fornecedor = BoutiqueLoja.Modelo.Fornecedor;

namespace BoutiqueLoja.Bussiness
{
    public class FornecedorBussiness
    {
        private readonly IFornecedorRepositorio repositorio;
        public FornecedorBussiness(IFornecedorRepositorio repositorio)
        {
            this.repositorio = repositorio;

        }
        public Fornecedor BuscarFornecedor(int id)
        {
            var fornecedor = repositorio.BuscarFornecedor(id);
            return fornecedor;
        }
        public List<Fornecedor> ExibirFornecedores()
        {
            var fornecedores = repositorio.BuscarFornecedores();
            return fornecedores;
        }
        public async Task<Fornecedor> SalvarFornecedor(Fornecedor fornecedor)
        {
            repositorio.Adiconar(fornecedor);

            if (await repositorio.Salvar())
                return fornecedor;

            return null;
        }
        public async Task<Fornecedor> AtualizarFornecedor(Fornecedor fornecedor)
        {
            repositorio.AtualizarFornecedor(fornecedor);

            if (await repositorio.Salvar())
                return fornecedor;

            return null;
        }

        
    }
}
