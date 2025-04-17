namespace OnlineBookStore.Services.Interfaces;

using OnlineBookStore.Models.DTOs;
using OnlineBookStore.Models.Entities;

public interface IBookService
{
    Task<Books> CreateBookAsync(BookDto bookDto);
    Task<IEnumerable<BookDto>> GetAllBooksAsync();

}