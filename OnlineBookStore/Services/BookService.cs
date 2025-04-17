using OnlineBookStore.Models.DTOs;
using OnlineBookStore.Models.Entities;
using OnlineBookStore.Repositories.Interfaces;
using OnlineBookStore.Services.Interfaces;

namespace OnlineBookStore.Services;

public class BookService : IBookService
{
    private readonly IBookRepository _bookRepository;

    public BookService(IBookRepository bookRepository)
    {
        _bookRepository = bookRepository;
    }

    public async Task<Books> CreateBookAsync(BookDto bookDto)
    {
        var book = new Books
        {
            Title = bookDto.Title,
            ISBN = bookDto.ISBN,
            Price = bookDto.Price,
        };

        return await _bookRepository.CreateAsync(book);
    }
    
    public async Task<IEnumerable<BookDto>> GetAllBooksAsync()
    {
        var books = await _bookRepository.GetAllAsync();

        return books.Select(b => new BookDto()
        {
            Id = b.Id,
            Title = b.Title,
            ISBN = b.ISBN,
            Price = b.Price
        });
    }
}