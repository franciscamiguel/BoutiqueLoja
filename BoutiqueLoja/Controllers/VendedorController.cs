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
    public class VendedorController : ControllerBase
    {
        private readonly IRepositorio repositorio;
        public readonly VendedorBussiness vendedorBussiness;

        public VendedorController(IRepositorio repositorio, VendedorBussiness vendedorBusiness)
        {
            this.repositorio = repositorio;
            this.vendedorBussiness = vendedorBusiness;
        }
        [HttpGet("buscar-vendedor/{id}")]
        public async Task<ActionResult> BuscarVendedor(int id)
        {

            var vendedor = vendedorBussiness.BuscarVendedor(id);
            return Ok(vendedor);
        }
        [HttpGet("exibir-vendedor")]
        public ActionResult ExibirVendedor()
        {
            var vendedor = vendedorBussiness.ExibirVendedor();
            return Ok(vendedor);
        }
        [HttpPost("salvar-vendedor")]
        public async Task<IActionResult> SalvarVendedor(Vendedor vendedor)
        {
            var _vendedor = await vendedorBussiness.SalvarVendedor(vendedor);

            return Ok(_vendedor);
        }
        [HttpPut("atualizar-vendedor/{id}")]
        public async Task<ActionResult> AtualizarVendedor(Vendedor vendedor)
        {

            var _vendedor = await vendedorBussiness.AtualizarVendedor(vendedor);

            return Ok(_vendedor);

        }
        //[HttpDelete("excluir-vendedor")]
        //public async Task<ActionResult> ExcluirVendedor(Vendedor vendedor)
        //{
        //    repositorio.ExcluirVendedor(vendedor);

        //    return Ok();
        //}

    }
}
