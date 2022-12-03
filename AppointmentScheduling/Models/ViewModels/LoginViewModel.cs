using System.ComponentModel.DataAnnotations;

namespace AppointmentScheduling.Models.ViewModels;

public class LoginViewModel
{
    [EmailAddress]
    [Display(Prompt = "Email")]
    public string Email { get; set; } = null!;
    
    [Display(Prompt = "Password")]
    [DataType(DataType.Password)]
    public string Password { get; set; } = null!;

    [Display(Name = "Remember me?")]
    public bool RememberMe { get; set; }
}