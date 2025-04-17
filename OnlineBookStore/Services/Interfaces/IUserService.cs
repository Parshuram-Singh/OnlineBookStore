using OnlineBookStore.Models.Entities;

namespace OnlineBookStore.Services.Interfaces;

public interface IUserService
{
    void Register(User user);
    List<User> GetAllUsers();
}