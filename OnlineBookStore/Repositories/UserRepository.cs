

using OnlineBookStore.Repositories.Interfaces;
using OnlineBookStore.Models.Entities;

public class UserRepository : IUserRepository
{
    private readonly List<User> _users = new();

    public void AddUser(User user)
    {
        
    }

    public List<User> GetUsers()
    {
        return _users;
    }
}