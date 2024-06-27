using DiarioDaGratidaoV2.Shared.Entidades;
using DiarioDaGratidaoV2.Shared.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DiarioDaGratidaoV2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotaController : ControllerBase
    {
        private readonly INotaRepository _notaRepository;

        public NotaController(INotaRepository notaRepository)
        {
            _notaRepository = notaRepository;
        }

        [HttpGet("Notas")]
        public async Task<ActionResult<List<Nota>>> GetAllNotasAsync()
        {
            var notas = await _notaRepository.GetAllNotasAsync();
            return Ok(notas);
        }

        [HttpGet("Nota/{id}")]
        public async Task<ActionResult<List<Nota>>> GetSinglenotaAsync(int id)
        {
            var nota = await _notaRepository.GetNotaAsync(id);
            return Ok(nota);
        }

        [HttpPost("Add-nota")]
        public async Task<ActionResult<List<Nota>>> AddnotaAsync(Nota model)
        {
            var nota = await _notaRepository.AddNotaAsync(model);
            return Ok(nota);
        }

        [HttpPut("Update-nota")]
        public async Task<ActionResult<List<Nota>>> UpdatenotaAsync(Nota model)
        {
            var nota = await _notaRepository.UpdateNotaAsync(model);
            return Ok(nota);
        }

        [HttpDelete("Delete-nota/{id}")]
        public async Task<ActionResult<List<Nota>>> DeletenotaAsync(int id)
        {
            var nota = await _notaRepository.DeleteNotaAsync(id);
            return Ok(nota);
        }
    }
}
