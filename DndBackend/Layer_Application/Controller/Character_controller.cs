using Layer_Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Layer_Application.DTOs;
using Layer_Infrastructure;

namespace CharacterAPiControllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharactersController : ControllerBase
    {
        private readonly DndDbContext _context;

        public CharactersController(DndDbContext context)
        {
            _context = context;
        }

        // GET: api/characters
        [HttpGet]
        public async Task<IActionResult> GetAllCharacters()
        {
            var characters = await _context.Characters
                .Include(c => c.Race)
                .Include(c => c.Class)
                .Include(c => c.Alignment)
                .Include(c => c.StatusBase)
                .Include(c => c.StatusBonus)
                .ToListAsync();

            return Ok(characters);
        }

        // GET: api/characters/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCharacterById(int id)
        {
            var character = await _context.Characters
                .Include(c => c.Race)
                .Include(c => c.Class)
                .Include(c => c.Alignment)
                .Include(c => c.StatusBase)
                .Include(c => c.StatusBonus)
                .FirstOrDefaultAsync(c => c.CharacterId == id);

            if (character == null)
                return NotFound();

            return Ok(character);
        }

        // POST: api/characters
        [HttpPost]
        public async Task<IActionResult> CreateCharacter([FromBody] CreateCharacterRequest request)
        {
            // สร้าง StatusBase ผ่าน constructor (สมมติ StatusBase มี constructor ที่รับค่า)
            var statusBase = new StatusBase(
                request.StatusBase.Str,
                request.StatusBase.Agi,
                request.StatusBase.Int,
                request.StatusBase.Wis,
                request.StatusBase.Con,
                request.StatusBase.Cha
            );

            var character = new Character(
                request.CharacterName,
                request.Level,
                request.RaceId,
                request.ClassId,
                request.AlignmentId,
                statusBase
            );

            _context.Characters.Add(character);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetCharacterById), new { id = character.CharacterId }, character);
        }
    }
}