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
    [Route("api/Car")]
    [ApiController]
    public class CarController : ControllerBase
    {

        private readonly UserContext _context;
        public CarController(UserContext context)
        {
            _context = context;
            if (_context.CarItems.Count() == 0)
            {
                // Create a new TodoItem if collection is empty,
                // which means you can't delete all TodoItems.
                _context.CarItems.Add(new CarItem { CarName = "Baleno" });
                _context.SaveChanges();
            }
        }


// GET: api/<controller>

// GET: api/Car

[HttpGet]
        public async Task<ActionResult<IEnumerable<CarItem>>> GetCarItems()
        {
            return await _context.CarItems.ToListAsync();
        }
    

        // GET: api/Car/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CarItem>> GetCarItem(long id)
        {
            var carItem = await _context.CarItems.FindAsync(id);

            if (carItem == null)
            {
                return NotFound();
            }

            return carItem;
        }
    }
    
    
}

     

    