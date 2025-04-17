namespace OnlineBookStore.Models.Entities;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Books
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "Title is required")]
    [StringLength(200, ErrorMessage = "Title cannot exceed 200 characters")]
    public string Title { get; set; }

    [Required(ErrorMessage = "ISBN is required")]
    [StringLength(17, ErrorMessage = "ISBN cannot exceed 17 characters")]
    public string ISBN { get; set; }

    [Required(ErrorMessage = "Price is required")]
    [Range(0.01, 10000.00, ErrorMessage = "Price must be between 0.01 and 10000.00")]
    [Column(TypeName = "decimal(18,2)")]
    public decimal Price { get; set; }
}