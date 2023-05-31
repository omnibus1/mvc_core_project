namespace Aplikacja.Models;

using System.ComponentModel.DataAnnotations;
using System.Linq;

public class UserModel
{

    public int? id { get; set; }
    // [Required]
    public string? username { get; set; }


}
