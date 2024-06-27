using Microsoft.AspNetCore.Mvc;
using Stock.Application.DTOs;
using Stock.Application.Interfaces;
using Stock.Application.Services;

namespace PrincipalStock.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProdutoController : Controller
    {
        private readonly IProdutoService _produtoService;

        public ProdutoController(IProdutoService produtoService)
        {
            _produtoService = produtoService;
        }

        [HttpPost("Cadastrar")]
        public async Task<IActionResult> Incluir(ProdutoDTO produtoDTO)
        {
            var produtoService = await _produtoService.Incluir(produtoDTO);
            if (produtoDTO == null)
            {
                return BadRequest("Ocorreu um erro ao cadastar o produto");
            }
            return Ok(" alterado com sucesso");
        }

        [HttpPut("Atualizar")]
        public async Task<IActionResult> Alterar(int id, ProdutoDTO produtoDTO)
        {
            var produtoAlterado = await _produtoService.Alterar(produtoDTO);
            if (produtoAlterado == null)
            {
                return BadRequest("Ocorreu um erro ao alterar o produto");
            }
            return Ok("produto alterado com sucesso");
        }

        [HttpDelete("Deletar")]
        public async Task<IActionResult> Excluir(int id)
        {
            var produtoExcluido = await _produtoService.Excluir(id);
            if (produtoExcluido == null)
            {
                return BadRequest("Ocorreu um erro ao Excluir produto");
            }
            return Ok("produto excluido com sucesso");
        }


        [HttpGet("usuario")]
        public async Task<IActionResult> Selecionar(int id)
        {
            var produtoSelecionado = await _produtoService.SelecionarAsync(id);
            if (produtoSelecionado == null)
            {
                return NotFound("Produto nao encontrado");
            }
            return Ok("Produto encontrado");
        }

        [HttpGet("Todos usuarios")]
        public async Task<IActionResult> SelecionarTodos()
        {
            var produtos = await _produtoService.SelecionarTodosAsync();
            return Ok(produtos);
        }
    }
}
