using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using TodoApi.Models;

namespace TodoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : Controller
    {
        private readonly LoginContext _context;

        public LoginController(LoginContext context)
        {
            _context = context;

            if (_context.LoginItems.Count() == 0)
            {
                _context.LoginItems.Add(new LoginItem { device_id = 1 });
                _context.SaveChanges();
            }
        }

        // GET: api/Todo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LoginItem>>> GetLoginItem()
        {
            return await _context.LoginItems.ToListAsync();
        }

        // GET: api/Todo/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LoginItem>> GetLoginItem(long id)
        {
            var todoItem = await _context.LoginItems.FindAsync(id);

            if (todoItem == null)
            {
                return NotFound();
            }

            return todoItem;
        }

        // PUT: api/Todo/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLoginItem(long id, LoginItem todoItem)
        {
            if (id != todoItem.Id)
            {
                return BadRequest();
            }

            _context.Entry(todoItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LoginItemExists(id))
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

        // POST: api/Todo
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<LoginItem>> PostTodoItem(LoginItem todoItem)
        {
            _context.LoginItems.Add(todoItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetLoginItem), new { Id = todoItem.Id }, todoItem);
        }

        // // DELETE: api/Todo/5
        // [HttpDelete("{id}")]
        // public async Task<ActionResult<TodoItem>> DeleteTodoItem(long id)
        // {
        //     var todoItem = await _context.TodoItems.FindAsync(id);
        //     if (todoItem == null)
        //     {
        //         return NotFound();
        //     }

        //     _context.TodoItems.Remove(todoItem);
        //     await _context.SaveChangesAsync();

        //     return todoItem;
        // }

        private bool LoginItemExists(long id)
        {
            return _context.LoginItems.Any(e => e.Id == id);
        }
    }
}
