using OnlineBookStore.Models.Entities;

namespace OnlineBookStore.Repositories.Interfaces;

public interface IUserRepository
{
    void AddUser(User user);
    List<User> GetUsers();
}