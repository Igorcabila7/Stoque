using Microsoft.AspNetCore.Mvc;
using Stock.Application.DTOs;
using Stock.Application.Interfaces;
using Stock.Application.Services;

namespace PrincipalStock.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class MovimentoStockController : Controller
    {

        private readonly IMovimentoStockService _movimentoService;


        public MovimentoStockController(IMovimentoStockService movimentoService)
        {
            _movimentoService = movimentoService;
        }

        [HttpPost("Cadastrar")]
        public async Task<IActionResult> Incluir(MovimentoStockDTO movimentoDTO)
        {
            var movimentoService = await _movimentoService.Incluir(movimentoDTO);
            if (movimentoDTO == null)
            {
                return BadRequest("Ocorreu um erro ao cadastar o movimento");
            }
            return Ok("  Movimento cadastrado com sucesso");
        }

        [HttpGet("Movimento")]
        public async Task<IActionResult> Selecionar(int id)
        {
            var movimentoSelecionado = await _movimentoService.SelecionarAsync(id);
            if (movimentoSelecionado == null)
            {
                return NotFound("Movimento nao encontrado");
            }
            return Ok("Movimento encontrado");
        }

        [HttpGet("Todos usuarios")]
        public async Task<IActionResult> SelecionarTodos()
        {
            var movimentos = await _movimentoService.SelecionarTodosAsync();


            return Ok(movimentos);
        }

    }
}
