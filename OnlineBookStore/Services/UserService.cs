

using OnlineBookStore.Repositories.Interfaces;
using OnlineBookStore.Models.Entities;
using OnlineBookStore.Services.Interfaces;

namespace OnlineBookStore.Services;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;

    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public void Register(User user)
    {
        _userRepository.AddUser(user);
    }

    public List<User> GetAllUsers()
    {
        return _userRepository.GetUsers();
    }
}