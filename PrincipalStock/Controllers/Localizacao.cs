using Microsoft.AspNetCore.Mvc;
using Stock.Application.DTOs;
using Stock.Application.Interfaces;
using Stock.Application.Services;

namespace PrincipalStock.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class Localizacao : Controller
    {
        private readonly ILocalizacaoService _localizacaoService;

        public Localizacao(ILocalizacaoService localizacaoService)
        {
            _localizacaoService = localizacaoService;
        }

        [HttpPost("Cadastrar")]
        public async Task<IActionResult> Incluir(LocalizacaoDTO localizacaoDTO)
        {
            var localizacaoService = await _localizacaoService.Incluir(localizacaoDTO);
            if (localizacaoDTO == null)
            {
                return BadRequest("Ocorreu um erro ao cadastar localizacao");
            }
            return Ok(" localizacao cadastrada com sucesso");
        }

        [HttpPut("Atualizar")]
        public async Task<IActionResult> Alterar(LocalizacaoDTO localizacaoDTO)
        {
            var localizacaoAlterado = await _localizacaoService.Alterar(localizacaoDTO);
            if (localizacaoAlterado == null)
            {
                return BadRequest("Ocorreu um erro ao alterar a localizacao");
            }
            return Ok("Localizacao alterado com sucesso");
        }

        [HttpDelete("Deletar")]
        public async Task<IActionResult> Excluir(int id)
        {
            var localizacaoExcluido = await _localizacaoService.Excluir(id);
            if (localizacaoExcluido == null)
            {
                return BadRequest("Ocorreu um erro ao Excluir a localizacao");
            }
            return Ok("Localizacao excluida com sucesso");
        }



        [HttpGet("Localizacao")]
        public async Task<IActionResult> Selecionar(int id)
        {
            var localizacaoSelecionada = await _localizacaoService.SelecionarAsync(id);
            if (localizacaoSelecionada == null)
            {
                return NotFound("localizacao nao encontrada");
            }
            return Ok("localizacao encontrado");
        }

        [HttpGet("Todas Localizacoes")]
        public async Task<IActionResult> SelecionarTodos()
        {
            var usuarios = await _localizacaoService.SelecionarTodosAsync();


            return Ok(usuarios);
        }


    }
}
