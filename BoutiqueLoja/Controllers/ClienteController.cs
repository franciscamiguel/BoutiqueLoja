using BoutiqueLoja.Bussiness;
using BoutiqueLoja.Data;
using BoutiqueLoja.Modelo;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace BoutiqueLoja.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {

        private readonly IRepositorio repositorio;
        public readonly ClienteBussiness ClienteBussiness;

        public AlunoController(IRepositorio repositorio, ClienteBussiness clienteBusiness)
        {
            this.repositorio = repositorio;
            this.ClienteBussiness = clienteBusiness;
        }

        [HttpGet("buscar-cliente/{id}")]
        public async Task<ActionResult> BuscarCliente(int id)
        {

            var cliente = ClienteBussiness.BuscarCliente(id);
            return Ok(cliente);
        }
        [HttpGet("exibir-clientes")]
        public ActionResult ExibirAlunos()
        {
            var clientes = ClienteBussiness.ExibirClientes();
            return Ok(clientes);
        }
        /// <returns></returns>
        [HttpPost("salvar-cliente")]
        public async Task<IActionResult> SalvarCliente(Cliente cliente)
        {
            var _cliente = await ClienteBussiness.SalvarCliente(cliente);

            return Ok(_cliente);
        }

        [HttpPut("atualizar-cliente/{id}")]
        public async Task<ActionResult> AtualizarCliente(Cliente cliente)
        {

            var _cliente = await ClienteBussiness.AtualizarCliente(cliente);

            return Ok(_cliente);

        }

        [HttpDelete("excluir-cliente")]
        public async Task<ActionResult> ExcluirCliente(Cliente cliente)
        {
            repositorio.ExcluirCliente(cliente);

            return Ok();
        }
    }
    
}