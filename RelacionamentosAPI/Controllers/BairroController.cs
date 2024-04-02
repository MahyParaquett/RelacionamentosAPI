using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RelacionamentosAPI.Data;
using RelacionamentosAPI.Dtos;
using RelacionamentosAPI.Models;

namespace RelacionamentosAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BairroController : ControllerBase
    {
        private readonly AppDbContext _context;

        public BairroController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> criarCasa(CasaCriacaoDto casaDto)
        {
            var novaCasa = new CasaModel()
            {
                Descricao = casaDto.Descricao
            };

            var endereco = new EnderecoModel()
            {
                Rua = casaDto.enderecoDto.Rua,
                Numero = casaDto.enderecoDto.Numero
            };

            var quartos = casaDto.quartos.Select(q => new QuartoModel {Descricao = q.Descricao, Casa = novaCasa}).ToList();

            var moradores = casaDto.moradores.Select(m => new MoradorModel {Nome = m.Nome, Casa = new List<CasaModel> {novaCasa} }).ToList();

            novaCasa.Endereco = endereco;
            novaCasa.Quartos = quartos;
            novaCasa.Morador = moradores;

            _context.Casas.Add(novaCasa);
            await _context.SaveChangesAsync();

            return Ok(await _context.Casas.Include(e => e.Endereco).Include(q => q.Quartos).Include(m => m.Morador).ToListAsync());
        }
    }
}
