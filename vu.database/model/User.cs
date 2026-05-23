using System.ComponentModel.DataAnnotations.Schema;

namespace vu.database.model;

[Table("Users")]
public class User
{
    public string Name { get; set; }
    public string Password { get; set; }
}