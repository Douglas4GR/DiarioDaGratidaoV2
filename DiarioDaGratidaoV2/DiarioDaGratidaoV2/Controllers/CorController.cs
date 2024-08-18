using DiarioDaGratidaoV2.Shared.Entidades;
using DiarioDaGratidaoV2.Shared.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DiarioDaGratidaoV2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CorController : ControllerBase
    {
        private readonly ICorRepository _corRepository;

        public CorController(ICorRepository corRepository)
        {
            _corRepository = corRepository;
        }

        [HttpGet("Cors")]
        public async Task<ActionResult<List<Cor>>> GetAllCorsAsync()
        {
            var cors = await _corRepository.GetAllCoresAsync();
            return Ok(cors);
        }

        [HttpGet("Cor/{id}")]
        public async Task<ActionResult<List<Cor>>> GetSinglecorAsync(int id)
        {
            var cor = await _corRepository.GetCorAsync(id);
            return Ok(cor);
        }

        [HttpPost("Add-cor")]
        public async Task<ActionResult<List<Cor>>> AddcorAsync(Cor model)
        {
            var cor = await _corRepository.AddCorAsync(model);
            return Ok(cor);
        }

        [HttpPut("Update-cor")]
        public async Task<ActionResult<List<Cor>>> UpdatecorAsync(Cor model)
        {
            var cor = await _corRepository.UpdateCorAsync(model);
            return Ok(cor);
        }

        [HttpDelete("Delete-cor/{id}")]
        public async Task<ActionResult<List<Cor>>> DeletecorAsync(int id)
        {
            var cor = await _corRepository.DeleteCorAsync(id);
            return Ok(cor);
        }
    }
}

