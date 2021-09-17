using BoutiqueLoja.Bussiness;
using BoutiqueLoja.Data;
using BoutiqueLoja.Modelo;
using BoutiqueLoja.Migrations;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RouteAttribute = Microsoft.AspNetCore.Components.RouteAttribute;
using Fornecedor = BoutiqueLoja.Modelo.Fornecedor;

namespace BoutiqueLoja.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FornecedorController : ControllerBase
    {

        private readonly IRepositorio repositorio;
        public readonly FornecedorBussiness FornecedorBussiness;

        public FornecedorController(IRepositorio repositorio, FornecedorBussiness fornecedorBusiness)
        {
            this.repositorio = repositorio;
            this.FornecedorBussiness = fornecedorBusiness;
        }

        [HttpGet("buscar-fornecedor/{id}")]
        public async Task<ActionResult> BuscarFornecedor(int id)
        {

            var fornecedor = FornecedorBussiness.BuscarFornecedor(id);
            return Ok(fornecedor);
        }
        [HttpGet("exibir-fornecedor")]
        public ActionResult ExibirFornecedores()
        {
            var fornecedor = FornecedorBussiness.ExibirFornecedores();
            return Ok(fornecedor);
        }
        /// <returns></returns>
        [HttpPost("salvar-fornecedor")]
        public async Task<IActionResult> SalvarFornecedor(Fornecedor fornecedor)
        {
            var _fornecedor = await FornecedorBussiness.SalvarFornecedor(fornecedor);

            return Ok(_fornecedor);
        }

        [HttpPut("atualizar-fornecedor/{id}")]
        public async Task<ActionResult> AtualizarFornecedor(Fornecedor fornecedor)
        {

            var _fornecedor = await FornecedorBussiness.AtualizarFornecedor(fornecedor);

            return Ok(_fornecedor);

        }

        //[HttpDelete("excluir-fornecedor")]
        //public async Task<ActionResult> ExcluirFornecedor(Fornecedor fornecedor)
        //{
        //    repositorio.ExcluirFornecedor(fornecedor);

        //    return Ok();
        //}
    }

}