using System.ComponentModel.DataAnnotations;

namespace AppointmentScheduling.Models.ViewModels;

public class RegisterViewModel
{
    public string Name { get; set; } = null!;

    [EmailAddress] public string Email { get; set; } = null!;

    [DataType(DataType.Password)]
    [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long", MinimumLength = 6)]
    public string Password { get; set; } = null!;

    [Display(Name = "Confirm Password")]
    [DataType(DataType.Password)]
    [Compare("Password", ErrorMessage = "Passwords must match")]
    public string ConfirmPassword { get; set; } = null!;

    [Display(Name = "Role Name")] public string RoleName { get; set; } = null!;
}