using System.ComponentModel.DataAnnotations;
using testApp.Models;

namespace testApp;

public class Flight
{
    [Key]
    public int Id { get; set; }

    [Required]
    public Airport Origin { get; set; }

    [Required]
    public Airport Destination { get; set; }
}