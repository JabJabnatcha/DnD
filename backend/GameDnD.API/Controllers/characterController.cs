using GameDnD.API.Data;
using GameDnD.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GameDnD.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharacterController : ControllerBase
    {
        private readonly GameContext _context;

        public CharacterController(GameContext context)
        {
            _context = context;
        }

        // GET: api/Character
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Character>>> GetCharacters()
        {
            // ดึงเฉพาะที่ไม่ถูก soft delete
            return await _context.Characters
                                 .Where(c => !c.IsDeleted)
                                 .Include(c => c.Items)
                                 .Include(c => c.Spells)
                                 .ToListAsync();
        }

        // GET: api/Character/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Character>> GetCharacter(int id)
        {
            var character = await _context.Characters
                                            .Include(c => c.Items)
                                            .Include(c => c.Spells)
                                            .FirstOrDefaultAsync(c => c.Id == id);

            if (character == null || character.IsDeleted)
            {
                return NotFound();
            }

            return character;
        }

        // POST: api/Character
        [HttpPost]
        public async Task<ActionResult<Character>> CreateCharacter(Character character)
        {
            _context.Characters.Add(character);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetCharacter), new { id = character.Id }, character);
        }

        // PUT: api/Character/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCharacter(int id, Character character)
        {
            if (id != character.Id)
            {
                return BadRequest();
            }

            _context.Entry(character).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Characters.Any(e => e.Id == id))
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

        // DELETE: api/Character/5 (Soft delete)
        [HttpDelete("{id}")]
        public async Task<IActionResult> SoftDeleteCharacter(int id)
        {
            var character = await _context.Characters.FindAsync(id);

            if (character == null)
            {
                return NotFound();
            }

            character.IsDeleted = true;
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
