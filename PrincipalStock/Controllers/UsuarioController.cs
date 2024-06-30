using Microsoft.AspNetCore.Mvc;
using PrincipalStock.Models;
using Stock.Application.DTOs;
using Stock.Application.Interfaces;
using Stock.Application.Services;

namespace PrincipalStock.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : Controller
    {
        private readonly IUsuarioService _usuarioService;

        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }
        [HttpPost("login")]
        public async Task<ActionResult> logarUsuario(loginDTO credencias)
        {
            var result = await _usuarioService.logarUsuario(credencias);
            if(result == false) 
            {
                return BadRequest("Ocorreu um erro ao cadastar o usuario");
            }
            Ok(result);
        }

        [HttpPost("Cadastrar")]
        public async Task<ActionResult> Incluir (UsuarioDTO usuarioDTO)
        {   
            var usuarioService = await _usuarioService.Incluir(usuarioDTO);

            if (usuarioService == null)
            {
                return BadRequest("Ocorreu um erro ao cadastar o usuario");
            }
            return Ok(" alterado com sucesso");
        }

        [HttpPut("Atualizar")]
        public async Task<IActionResult> Alterar(UsuarioDTO usuarioDTO)
        {
            var usuarioAlterado = await _usuarioService.Alterar(usuarioDTO);
            if (usuarioAlterado == null)
            {
                return BadRequest("Ocorreu um erro ao alterar usuario");
            }
            return Ok("usuario alterado com sucesso");
        }

        [HttpDelete("Deletar")]
        public async Task<IActionResult> Excluir(int id)
        {
            var usuarioExcluido = await _usuarioService.Excluir(id);
            if (usuarioExcluido == null)
            {
                return BadRequest("Ocorreu um erro ao Excluir usuario");
            }
            return Ok("usuario excluido com sucesso");
        }

        [HttpGet("usuario")]
        public async Task<IActionResult> Selecionar(int id)
        {
            var usuarioSelecionado = await _usuarioService.SelecionarAsync(id);
            if (usuarioSelecionado == null)
            {
                return NotFound("Usuario nao encontrado");
            }
            return Ok("Usuario encontrado");
        }

        [HttpGet("Todos usuarios")]
        public async Task<IActionResult> SelecionarTodos()
        {
            var usuarios = await _usuarioService.SelecionarTodosAsync();
          
            return Ok(usuarios);
        }

    }     
}
