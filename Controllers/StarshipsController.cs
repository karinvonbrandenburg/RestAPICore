using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiDotNetCore.Models;

namespace WebApiDotNetCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StarshipsController : ControllerBase
    {
        private readonly WebApiDotNetCoreContext _context;

        public StarshipsController(WebApiDotNetCoreContext context)
        {
            _context = context;
        }

        // GET: api/Starships
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Starship>>> GetStarships()
        {
            return await _context.Starships.ToListAsync();
        }

        // GET: api/Starships/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Starship>> GetStarship(int id)
        {
            var starship = await _context.Starships.FindAsync(id);

            if (starship == null)
            {
                return NotFound();
            }

            return starship;
        }

        // PUT: api/Starships/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStarship(int id, Starship starship)
        {
            if (id != starship.ID)
            {
                return BadRequest();
            }

            _context.Entry(starship).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StarshipExists(id))
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

        // POST: api/Starships
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Starship>> PostStarship(Starship starship)
        {
            _context.Starships.Add(starship);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetStarship", new { id = starship.ID }, starship);
        }

        // DELETE: api/Starships/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStarship(int id)
        {
            var starship = await _context.Starships.FindAsync(id);
            if (starship == null)
            {
                return NotFound();
            }

            _context.Starships.Remove(starship);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool StarshipExists(int id)
        {
            return _context.Starships.Any(e => e.ID == id);
        }
    }
}
