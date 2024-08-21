using FIrstProject.Data;
using FIrstProject.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;


namespace FIrstProject.Controllers
{
    [Route( "api/[controller]" )]
    [ApiController]
    public class WritterController : ControllerBase
    {
        private readonly ApplicationDBContext _Context;

        public WritterController( ApplicationDBContext context )
        {
            _Context = context;
        }
        [HttpPost]
        public async Task<IActionResult> Post( [FromBody] BookWritters bookWritters)
        {
            await _Context.Tbl_BookWritters.AddAsync( bookWritters );
            await _Context.SaveChangesAsync();
            return Ok();
        }
        [HttpGet]
        public async Task<IActionResult> GetWritters()
        {
            var writter = await (from writers in _Context.Tbl_BookWritters
                                 select new
                                 {
                                     id=writers.ID,
                                     Name=writers.Name,

                                 }).ToListAsync();
            return Ok( writter );
        }
        [HttpGet("[Action]")]
        public async Task<IActionResult> WritterDetail(int id)
        {
            var writters = await (_Context.Tbl_BookWritters.Include( x => x.Tbl_Books).Where( X => X.Id = id ).FirstOrDefaultAsync());
            return Ok( writters );
                
        }
    }
}
