using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TodoApi.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TodoApi.Controllers
{
    [Route("api/user")]
    public class UserController : ControllerBase
    {
        private readonly UserContext _context;
        public UserController(UserContext context)
        {
            _context = context;
         
        }


        // GET: api/<controller>

        // GET: api/user

        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserItem>>> GetUserItems()
        {
            return await _context.UserItems.ToListAsync();
        }


        // GET: api/user/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UserItem>> GetUserItem(long id)
        {
            var userItem = await _context.UserItems.FindAsync(id);

            if (userItem == null)
            {
                return NotFound();
            }

            return userItem;
        }
        // GET: api/<controller>
     

        // POST api/<controller>
        [HttpPost]
        
            public async Task<ActionResult<UserItem>> PostTodoItem([FromBody]UserItem item)
            {
                _context.UserItems.Add(item);
                await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetUserItem), new { id = item.Id} , item );


        }

        

        // PUT api/<controller>/5
        [HttpPut("{id}")]
       
        public async Task<IActionResult> PutUserItem(long id, UserItem item)
        {
            if (id != item.Id)
            {
                return BadRequest();
            }

            _context.Entry(item).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
