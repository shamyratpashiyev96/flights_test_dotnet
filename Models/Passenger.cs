namespace testApp.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

public class Passenger{

    [Key]
    public int Id {get; set;}

    [Column(TypeName ="VARCHAR(2000)")]
    [Required]
    public string FirstName { get; set; }

    [Column(TypeName ="VARCHAR(2000)")]
    [Required]
    public string LastName { get; set; }
}