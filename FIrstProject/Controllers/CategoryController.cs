using FIrstProject.Data;
using FIrstProject.Model;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FIrstProject.Controllers
{
    [Route( "api/[controller]" )]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private ApplicationDBContext _Context;

        public CategoryController( ApplicationDBContext context )
        {
            _Context = context;
        }

        // GET: api/<CategoryController>
        [HttpGet]
        public async Task< IActionResult> Get()
        {
            return Ok(await _Context.Categories.ToListAsync());
        }

        // GET api/<CategoryController>/5
        [HttpGet( "{id}" )]
        public async Task<IActionResult> Get( int id )
        {
            return Ok(await _Context.Categories.FirstOrDefaultAsync(x=>x.Id==id));
        }

        // POST api/<CategoryController>
        [HttpPost]
        public async Task<IActionResult> Post( [FromBody] Category category )
        {
          await _Context.Categories.AddAsync(category);
          await  _Context.SaveChangesAsync();
            return Ok();
        }

        // PUT api/<CategoryController>/5
        [HttpPut( "{id}" )]
        public async Task<IActionResult> Put( int id , [FromBody] Category category )
        {
            var categoryData =await _Context.Categories.FirstOrDefaultAsync( x => x.Id == id );
            if (categoryData == null)
            {
                return NotFound();
            }
            else
            {
                categoryData.Title = category.Title;
                categoryData.DisplyOrder = category.DisplyOrder;
                _Context.Categories.Update( categoryData );
              await  _Context.SaveChangesAsync();
                return Ok( "Catogory Updated" );
            }
        }

        // DELETE api/<CategoryController>/5
        [HttpDelete( "{id}" )]
        public async Task<IActionResult> Delete( int id )
        {
            var categoryData=await _Context.Categories.FindAsync(id);
            if (categoryData == null)
            {

                return NotFound();
            }
            else
            {
                _Context.Categories.Remove( categoryData );
              await  _Context.SaveChangesAsync();
                return Ok( "Catogory Deleted" );
            }
            
        }
    }
}
