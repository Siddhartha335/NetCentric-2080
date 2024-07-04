
using System.ComponentModel.DataAnnotations;

public class Author 
{
    public int Id {get; set;}
    public string Name {get; set;}
    public string Address {get; set;}
    public Gender Gender {get; set;}
    [Required]
    public string Email {get; set;}
    public DateTime Dob {get; set;}
}