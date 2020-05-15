using Microsoft.AspNetCore.Mvc;
using Quickbuy.Dominio.Contratos;
using Quickbuy.Dominio.Entidades;
using System;

namespace Quickbuy.Web.Controllers
{
    [Route("api/[Controller]")]
    public class ProdutoController : Controller
    {
        private readonly IProdutoRepositorio _produtoRepositorio;
        public ProdutoController(IProdutoRepositorio produtoRepositorio)
        {
            _produtoRepositorio = produtoRepositorio;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_produtoRepositorio.ObterTodos());

            }
            catch (Exception ex)
            {
                return BadRequest($"Exception: ${ex.ToString()}");
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody]Produto produto)
        {
            try
            {
                _produtoRepositorio.Adiconar(produto);

                return Created("api/produto", produto);
            }
            catch (Exception ex)
            {

                return BadRequest($"Exception: ${ex.ToString()}");
            }
        }

    }
}
