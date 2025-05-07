using Microsoft.AspNetCore.Mvc;
using GestInvest.Data;
using GestInvest.Models;

namespace GestInvest.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AcaoController : ControllerBase
    {
        private readonly AppDbContext _context;

        public AcaoController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult<Acao>> CriarAcao([FromBody] NovaAcaoDTO novaAcao)
        {
            var acao = new Acao
            {
                Nome = novaAcao.Nome,
                Empresa = novaAcao.Empresa,
                DataCompra = novaAcao.DataCompra,
                Moeda = novaAcao.Moeda,
                Preco = novaAcao.Preco
            };

            _context.Acoes.Add(acao);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(ObterPorId), new { id = acao.Id }, acao);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Acao>> ObterPorId(int id)
        {
            var acao = await _context.Acoes.FindAsync(id);
            if (acao == null) return NotFound();
            return Ok(acao);
        }
    }
}
