namespace OnlineBookStore.Repositories.Interfaces;

using OnlineBookStore.Models.Entities;

public interface IBookRepository
{
    Task<Books> CreateAsync(Books book);
    Task<IEnumerable<Books>> GetAllAsync();

}