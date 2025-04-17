namespace OnlineBookStore.Models.Entities;
using System.ComponentModel.DataAnnotations;

public class User
{
    public int Id { get; set; }
    [Required, EmailAddress]
    public string Email { get; set; }
    [Required]
    public string PasswordHash { get; set; }
    [Required]
    public UserRole Role { get; set; }
    
    public string FullName { get; set; }
    [Phone]
    public string PhoneNumber { get; set; }

    public User() { }
    
}

public enum UserRole
{
    Public,
    Member,
    Staff,
    Admin
}