using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using todoonboard_api.Models;

namespace todoonboard_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BoardController : ControllerBase
    {
        private readonly TodoContext _context;

        public BoardController(TodoContext context)
        {
            _context = context;
        }

        // GET: api/Board
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Board>>> GetBoard()
        {
            return await _context.Board.ToListAsync();
        }

        // GET: api/Board/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Board>> GetBoard(long id)
        {
            var board = await _context.Board.FindAsync(id);

            if (board == null)
            {
                return NotFound();
            }

            return board;
        }

        // PUT: api/Board/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBoard(long id, Board board)
        {
            if (id != board.Id)
            {
                return BadRequest();
            }

            _context.Entry(board).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BoardExists(id))
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

        // POST: api/Board
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Board>> PostBoard(Board board)
        {
            _context.Board.Add(board);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBoard", new { id = board.Id }, board);
        }

        // DELETE: api/Board/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBoard(long id)
        {
            var board = await _context.Board.FindAsync(id);
            if (board == null)
            {
                return NotFound();
            }

            _context.Board.Remove(board);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BoardExists(long id)
        {
            return _context.Board.Any(e => e.Id == id);
        }
    }
}
