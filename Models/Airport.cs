using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace testApp.Models;

public class Airport 
{
    [Key]
    public int ?Id { get; set; }
    [AllowNull]
    [Column(TypeName ="VARCHAR(2000)")]
    public string ?City { get; set; }

    [Required]
    [Column(TypeName ="VARCHAR(2000)")]
    public string ?Code { get; set; }
}