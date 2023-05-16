using System.ComponentModel.DataAnnotations;

namespace HackathonLoginApp;

public sealed class User
{
    public int Id { get; set; }

    [Required, MinLength(2), MaxLength(32)]
    public string Username { get; set; } = string.Empty;

    [Required, DataType(DataType.Password), MaxLength(512)]
    public string Password { get; set; } = string.Empty;

    [Required, MinLength(2), MaxLength(32)]
    public string DisplayName { get; set; } = string.Empty;

    public DateTime RegistrationDate { get; set; }
}
