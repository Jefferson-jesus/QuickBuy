using Microsoft.AspNetCore.Mvc;
using Quickbuy.Dominio.Contratos;
using Quickbuy.Dominio.Entidades;
using System;

namespace Quickbuy.Web.Controllers
{
    [Route("api/[controller]")]
    //[ApiController]
    public class UsuarioController : Controller
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost("VerificarUsuario")]
        public ActionResult VerificarUsuario([FromBody] Usuario usuario)
        {
            try
            {
                var usuarioRetorno = _usuarioRepository.Obter(usuario.Email, usuario.Senha);

                if (usuarioRetorno != null)
                    return Ok(usuario);

                return BadRequest("Usuario ou senha invalido");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        public ActionResult Post([FromBody] Usuario usuario)
        {
            try
            {
                var usuarioCadastrado = _usuarioRepository.Obter(usuario.Email);

                if (usuarioCadastrado != null)
                    return BadRequest("Usuario já cadastrado no sistema");

                //usuarioCadastrado.Validate();

                //if (!usuarioCadastrado.EhValido)
                //    return BadRequest(usuarioCadastrado.ObterMensagensValidacao());

                _usuarioRepository.Adiconar(usuario);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}