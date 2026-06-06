using System.ComponentModel.DataAnnotations.Schema;

namespace vu.database.model;

[Secure]
public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Password { get; set; }
}