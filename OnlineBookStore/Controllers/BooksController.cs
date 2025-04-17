namespace OnlineBookStore.Controllers;

using Microsoft.AspNetCore.Mvc;
using OnlineBookStore.Models.DTOs;
using OnlineBookStore.Services.Interfaces;

[Route("api/v1/[controller]")]
[ApiController]
public class BooksController : ControllerBase
{
    private readonly IBookService _bookService;

    public BooksController(IBookService bookService)
    {
        _bookService = bookService;
    }

    [HttpPost]
    public async Task<IActionResult> CreateBook([FromBody] BookDto bookDto)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        try
        {
            var book = await _bookService.CreateBookAsync(bookDto);
            return CreatedAtAction(nameof(GetBook), new { id = book.Id }, book);
        }
        catch (ArgumentException ex)
        {
            return BadRequest(ex.Message);
        }
        catch (Exception)
        {
            return StatusCode(500, "An error occurred while creating the book.");
        }
    }
    
    [HttpGet]
    public async Task<IActionResult> GetAllBooks()
    {
        try
        {
            var books = await _bookService.GetAllBooksAsync();
            return Ok(books);
        }
        catch (Exception)
        {
            return StatusCode(500, "An error occurred while retrieving the books.");
        }
    }


    // Placeholder for CreatedAtAction reference
    [HttpGet("{id}")]
    public IActionResult GetBook(int id)
    {
        // Implement later
        return Ok();
    }
}