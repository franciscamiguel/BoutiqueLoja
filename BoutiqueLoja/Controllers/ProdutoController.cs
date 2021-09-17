using BoutiqueLoja.Bussiness;
using BoutiqueLoja.Data;
using BoutiqueLoja.Modelo;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RouteAttribute = Microsoft.AspNetCore.Components.RouteAttribute;

namespace BoutiqueLoja.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly IRepositorio repositorio;
        public readonly ProdutoBussiness ProdutoBussiness;

        public ProdutoController(IRepositorio repositorio, ProdutoBussiness produtoBusiness)
        {
            this.repositorio = repositorio;
            this.ProdutoBussiness = produtoBusiness;
        }

        [HttpGet("buscar-produto/{id}")]
        public async Task<ActionResult> BuscarProduto(int id)
        {

            var produto = ProdutoBussiness.BuscarProduto(id);
            return Ok(produto);
        }
        [HttpGet("exibir-produto")]
        public ActionResult ExibirProduto()
        {
            var produto = ProdutoBussiness.ExibirProdutos();
            return Ok(produto);
        }
        /// <returns></returns>
        [HttpPost("salvar-produto")]
        public async Task<IActionResult> SalvarProduto(Produto produto)
        {
            var _produto = await ProdutoBussiness.SalvarProduto(produto);

            return Ok(_produto);
        }

        [HttpPut("atualizar-produto/{id}")]
        public async Task<ActionResult> AtualizarProduto(Produto produto)
        {

            var _produto = await ProdutoBussiness.AtualizarProduto(produto);

            return Ok(_produto);

        }

        //[HttpDelete("excluir-produto")]
        //public async Task<ActionResult> ExcluirProduto(Produto produto)
        //{
        //    repositorio.ExcluirProduto(produto);

        //    return Ok();
        //}

    }
}
