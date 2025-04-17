namespace OnlineBookStore.Repositories;

using Microsoft.EntityFrameworkCore;
using OnlineBookStore.Data;
using OnlineBookStore.Models.Entities;
using OnlineBookStore.Repositories.Interfaces;

public class BookRepository : IBookRepository
{
    private readonly BookstoreDbContext _context;

    public BookRepository(BookstoreDbContext context)
    {
        _context = context;
    }

    public async Task<Books> CreateAsync(Books book)
    {
        _context.Books.Add(book);
        await _context.SaveChangesAsync();
        return book;
    }
    
    public async Task<IEnumerable<Books>> GetAllAsync()
    {
        return await _context.Books.ToListAsync();
    }

}