using System;
using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/usuario")] 
    public class UsuarioController : ControllerBase
    {
        // GET: /api/usuario/listar
        [HttpGet]
        [Route("listar")]
        public IActionResult Listar()
        {
            Usuario usuario = new Usuario
            {
                Email = "seuemail@dominio.com",
                Senha = "123456"
            };
            return Ok(usuario);
        }

        // Exercício: cadastrar um usuário recebendo as informações da URL
        // Exercício: cadastrar um usuário recebendo as informações do corpo da requisição
        [HttpPost]
        public IActionResult Cadastrar()
        {
            return null;
        }

    }
}