using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPIBooks.Data;
using WebAPIBooks.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPIBooks.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public BooksController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllBooks()
        {
            var books = await _context.Book.ToListAsync();
            return Ok(books);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBook([FromRoute] int id)
        {
            var book = await _context.Book.FirstOrDefaultAsync(b => b.Id == id);
            if (book is not null)
                return Ok(book);
            else return BadRequest("kitap bulunamadi");
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Book book)
        {
            _context.Book.Add(book);
            await _context.SaveChangesAsync();
            return Ok($"kitap eklendi;\n{book}");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateBook([FromBody] Book book)
        {
            //var bookToUpdate = await _context.Book.FirstOrDefaultAsync(b => b.Id == id);
            //if (bookToUpdate is not null)
            //{
                //auto mapper ..
                //bookToUpdate.KitapAdi = kitap.KitapAdi;
                //bookToUpdate.YazarId = kitap.YazarId;
                //bookToUpdate.SayfaSayisi = kitap.SayfaSayisi;
                //bookToUpdate.Fiyat = kitap.SayfaSayisi;
                //bookToUpdate.YayineviId = kitap.YayineviId;
                //bookToUpdate.KategoriId = kitap.KategoriId;
                //_context.Update(bookToUpdate);

                _context.Entry(book).State = EntityState.Modified; //ikinci yol
                await _context.SaveChangesAsync();
                return Ok(book);
            //}
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            //var book = await _context.Kitaps.FirstOrDefaultAsync(b => b.Id == id); //bu satir refactoring yapilacak her yerde ayni satir...
            var bookToDelete = await _context.Book.FindAsync(id);
            _context.Book.Remove(bookToDelete);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
