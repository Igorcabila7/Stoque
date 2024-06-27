using Microsoft.AspNetCore.Mvc;
using Stock.Application.DTOs;
using Stock.Application.Interfaces;
using Stock.Application.Services;


namespace PrincipalStock.Controllers
{
    public class ContactosController : Controller
    {
        private readonly IContactosService _ContactosService;

        public ContactosController(IContactosService contactosService)
        {
            _ContactosService = contactosService;
        }

        [HttpPost("Cadastrar")]
        public async Task<IActionResult> Incluir(ContactosDTO contactosDTO)
        {
            var contactosService = await _ContactosService.Incluir(contactosDTO);
            if (contactosDTO == null)
            {
                return BadRequest("Ocorreu um erro ao cadastar contacto");
            }
            return Ok(" alterado com sucesso");
        }

        [HttpPut("Atualizar")]
        public async Task<IActionResult> Alterar(ContactosDTO contactoDTO)
        {
            var ContactosAlterado = await _ContactosService.Alterar(contactoDTO);
            if (ContactosAlterado == null)
            {
                return BadRequest("Ocorreu um erro ao alterar contacto");
            }
            return Ok("Contacto alterado com sucesso");
        }

        [HttpDelete("Deletar")]
        public async Task<IActionResult> Excluir(int id)
        {
            var contactoExcluido = await _ContactosService.Excluir(id);
            if (contactoExcluido == null)
            {
                return BadRequest("Ocorreu um erro ao Excluir contacto");
            }
            return Ok("contacto excluido com sucesso");
        }

        [HttpGet("Contacto")]
        public async Task<IActionResult> Selecionar(int id)
        {
            var ContactoSelecionado = await _ContactosService.SelecionarAsync(id);
            if (ContactoSelecionado == null)
            {
                return NotFound("Contacto nao encontrado");
            }
            return Ok("Contacto encontrado");
        }

        [HttpGet("Todos Contactos")]
        public async Task<IActionResult> SelecionarTodos()
        {
            var Contacto = await _ContactosService.SelecionarTodosAsync();


            return Ok(Contacto);
        }


    }
}
