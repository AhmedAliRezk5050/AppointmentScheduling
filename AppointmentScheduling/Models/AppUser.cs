using Microsoft.AspNetCore.Identity;

namespace AppointmentScheduling.Models;

public class AppUser : IdentityUser
{
    public string Name { get; set; } = null!;
}