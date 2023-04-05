using LibraryTracking.Core.DTOs;
using LibraryTracking.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace LibraryTrackingSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : CustomBaseController
    {
        private readonly IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        public async Task<IActionResult> GetBooks()
        {
            return ActionResultInstance(await _bookService.GetAllAsync());
        }

        [HttpPost]
        public async Task<IActionResult> AddBook(BookDto bookDto)
        {
            return ActionResultInstance(await _bookService.AddAsync(bookDto));
        }

        [HttpPut]
        public async Task<IActionResult> UpdateBook(BookDto bookDto)
        {
            return ActionResultInstance(await _bookService.Update(bookDto.Id));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBook(int id)
        {
            return ActionResultInstance(await _bookService.Remove(id));
        }
    }
}
