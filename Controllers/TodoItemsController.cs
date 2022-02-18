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
    [Authorize]
    public class TodoItemsController : ControllerBase
    {
        private readonly TodoContext _context;

        public TodoItemsController(TodoContext context)
        {
            _context = context;
        }

        // GET: api/TodoItems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TodoItem>>> GetTodoItems()
        {
            return await _context.TodoItems.ToListAsync();
        }

        // GET: api/TodoItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<TodoItem>>> GetTodoItem(int id)
        {
            var todoItem = _context.TodoItems.Where(row => row.board.Id == id);

            if (todoItem == null)
            {
                return NotFound();
            }

            return await todoItem.ToListAsync();
        }

        [HttpGet("uncompletedTodos")]
        public async Task<ActionResult<IEnumerable<TodoItem>>> uncompletedTodoItems()
        {
            var todoItem = _context.TodoItems.Where(row => row.Done== false);

            if (todoItem == null)
            {
                return NotFound();
            }

            return await todoItem.ToListAsync();
        }

        // PUT: api/TodoItems/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTodoItem(int id, TodoItem todoItem)
        {
            if (id != todoItem.Id)
            {
                return BadRequest();
            }

            var item = await _context.TodoItems.FirstOrDefaultAsync(item => item.Id == id);

            item.updated = DateTime.UtcNow;
            item.Title = todoItem.Title;
            item.Done = todoItem.Done;

            // item.board_id = todoItem.board_id;

            _context.Entry(item).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TodoItemExists(id))
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

        [HttpPatch("{id}")]

        public async Task<IActionResult> PatchTodoItem(int id, TodoItem todoItem)

        {

            if (id != todoItem.Id)

            {

                return BadRequest();

            }

            var item = await _context.TodoItems.FirstOrDefaultAsync(item => item.Id == id);

            if (item == null) return BadRequest();

            item.Title = todoItem.Title == null ? item.Title : todoItem.Title;

            item.updated = DateTime.UtcNow;

            item.Done = todoItem.Done;

             //item.board = todoItem.board == 0 ? item.board_id : todoItem.board_id;

            _context.SaveChangesAsync();

            return Ok(item);

        }

        // POST: api/TodoItems
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TodoItem>> PostTodoItem(TodoItem todoItem)
        {
             var board = _context.Board.Find(todoItem.board.Id);

            todoItem.board = board;
            _context.TodoItems.Add(todoItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetTodoItem), new { id = todoItem.Id }, todoItem);
        }

        // DELETE: api/TodoItems/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTodoItem(int id)
        {
            var todoItem = await _context.TodoItems.FindAsync(id);
            if (todoItem == null)
            {
                return NotFound();
            }

            _context.TodoItems.Remove(todoItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TodoItemExists(long id)
        {
            return _context.TodoItems.Any(e => e.Id == id);
        }
    }
}
