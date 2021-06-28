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
    public class RootsController : ControllerBase
    {
        private readonly WebApiDotNetCoreContext _context;

        public RootsController(WebApiDotNetCoreContext context)
        {
            _context = context;
        }

        // GET: api/Roots
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Root>>> GetRoot()
        {
            return await _context.Root.ToListAsync();
        }

        // GET: api/Roots/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Root>> GetRoot(int id)
        {
            var root = await _context.Root.FindAsync(id);

            if (root == null)
            {
                return NotFound();
            }

            return root;
        }

        // PUT: api/Roots/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRoot(int id, Root root)
        {
            if (id != root.ID)
            {
                return BadRequest();
            }

            _context.Entry(root).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RootExists(id))
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

        // POST: api/Roots
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Root>> PostRoot(Root root)
        {
            _context.Root.Add(root);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRoot", new { id = root.ID }, root);
        }

        // DELETE: api/Roots/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRoot(int id)
        {
            var root = await _context.Root.FindAsync(id);
            if (root == null)
            {
                return NotFound();
            }

            _context.Root.Remove(root);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RootExists(int id)
        {
            return _context.Root.Any(e => e.ID == id);
        }
    }
}
