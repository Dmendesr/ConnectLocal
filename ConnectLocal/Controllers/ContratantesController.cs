using ConnectLocal.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ConnectLocal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContratantesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ContratantesController(AppDbContext context)
        {
            _context = context;         
        }

        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            var model = await _context.Contratantes.ToListAsync();
            return Ok(model);
        }
    }
}
