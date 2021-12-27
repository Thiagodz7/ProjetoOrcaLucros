using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OrcaLucros.Data;
using OrcaLucros.Models;

namespace OrcaLucros.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrcamentosController : ControllerBase
    {
        private readonly orcamentoContext _context;

        public OrcamentosController(orcamentoContext context)
        {
            _context = context;
        }

        // GET: api/Orcamentos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Orcamentos>>> GetOrcamentos()
        {
            return await _context.Orcamentos.ToListAsync();
        }

        // GET: api/Orcamentos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Orcamentos>> GetOrcamentos(Guid id)
        {
            var orcamentos = await _context.Orcamentos.FindAsync(id);

            if (orcamentos == null)
            {
                return NotFound();
            }

            return orcamentos;
        }

        // PUT: api/Orcamentos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrcamentos(Guid id, Orcamentos orcamentos)
        {
            if (id != orcamentos.Id)
            {
                return BadRequest();
            }

            _context.Entry(orcamentos).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrcamentosExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Orcamentos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Orcamentos>> PostOrcamentos(Orcamentos orcamentos)
        {
            _context.Orcamentos.Add(orcamentos);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOrcamentos", new { id = orcamentos.Id }, orcamentos);
        }

        // DELETE: api/Orcamentos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrcamentos(Guid id)
        {
            var orcamentos = await _context.Orcamentos.FindAsync(id);
            if (orcamentos == null)
            {
                return NotFound();
            }

            _context.Orcamentos.Remove(orcamentos);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool OrcamentosExists(Guid id)
        {
            return _context.Orcamentos.Any(e => e.Id == id);
        }
    }
}
