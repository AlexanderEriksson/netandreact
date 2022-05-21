using Percistence;
using Domain;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace API.Controllers
{
    public class MessageController : BaseApiController
    {
        private readonly DataContext _context;
        public MessageController(DataContext context){
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Message>>> GetMessages(){
            return await _context.Messages.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Message>> GetMessage(Guid id){
            return await _context.Messages.FindAsync(id);
        }

    }
}