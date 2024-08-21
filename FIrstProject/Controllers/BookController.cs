using FIrstProject.Data;
using FIrstProject.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FIrstProject.Controllers
{
    [Route( "api/[controller]" )]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly ApplicationDBContext _Context;

        public BookController( ApplicationDBContext context )
        {
            _Context = context;
        }
        [HttpPost]
        public async Task<IActionResult> Post( [FromBody] Book book )
        {
            await _Context.Tbl_Books.AddAsync( book );
            await _Context.SaveChangesAsync();
            return Ok();
        }
    }
}
