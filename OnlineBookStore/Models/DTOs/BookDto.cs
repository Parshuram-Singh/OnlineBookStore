namespace OnlineBookStore.Models.DTOs;

using System.ComponentModel.DataAnnotations;

public class BookDto
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Title is required")]
    [StringLength(200, ErrorMessage = "Title cannot exceed 200 characters")]
    public string Title { get; set; }

    [Required(ErrorMessage = "ISBN is required")]
    [RegularExpression(@"^(?=(?:\D*\d){10}(?:(?:\D*\d){3})?$)[\d-]+$|^(?=(?:\D*\d){13}(?:(?:\D*\d){0})?$)[\d-]+$",
        ErrorMessage = "Invalid ISBN format (10 or 13 digits)")]
    [StringLength(17, ErrorMessage = "ISBN cannot exceed 17 characters")]
    public string ISBN { get; set; }

    [Required(ErrorMessage = "Price is required")]
    [Range(0.01, 10000.00, ErrorMessage = "Price must be between 0.01 and 10000.00")]
    public decimal Price { get; set; }
}