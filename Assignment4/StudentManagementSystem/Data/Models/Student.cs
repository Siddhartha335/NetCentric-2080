using System.ComponentModel.DataAnnotations;
public class Student {
    [Required]
    public int Id { get; set; }

    [Required]
    [StringLength(100, ErrorMessage = "Name length can't be more than 100.")]
    public string Name { get; set; }

    [Required]
    [EmailAddress(ErrorMessage = "Invalid Email Address")]
    public string Email { get; set; }

    [Required]
    [Range(18, 100, ErrorMessage = "Age must be between 18 and 100")]

    public int Age { get; set; }
}