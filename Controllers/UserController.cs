using System.Runtime.InteropServices.ObjectiveC;
using boba_API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;



    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly Dyplom2Context _context;

        public UserController(Dyplom2Context context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AspNetUser>>> GetAspNetUsers()
        {
            return await _context.AspNetUsers.ToListAsync();
        }
        
        [HttpGet("{id}")]
        public async Task<AspNetUser> Get(string id)
        {
            var user = await _context.AspNetUsers.FindAsync(id);
            if (user == null)
            {
                return null;
            }
            return user;
        }
    }
