using FIrstProject.Data;
using FIrstProject.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FIrstProject.Controllers
{
    [Route( "api/[controller]" )]
    [ApiController]
    public class BookCoverController : ControllerBase
    {
        private readonly ApplicationDBContext _Context;

        public BookCoverController( ApplicationDBContext context )
        {
            _Context = context;
        }
        [HttpPost]
        public async Task<IActionResult> Post( [FromBody] BookCover bookCover )
        {
            await _Context.Tbl_BookCovers.AddAsync( bookCover );
            await _Context.SaveChangesAsync();
            return Ok();
        }
        [HttpGet]
        public async Task<IActionResult> GetBookCover()
        {
            var cover= await (from Cover in  _Context.Tbl_BookCovers select new
            {
                id=Cover.ID,
                Title=Cover.Title,
                writterid=Cover.BookWrittersId,
            }).ToListAsync();
            return Ok(cover);
        }
    }
}
