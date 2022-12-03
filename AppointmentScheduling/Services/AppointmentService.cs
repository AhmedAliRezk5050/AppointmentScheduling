using AppointmentScheduling.Models;
using AppointmentScheduling.Models.ViewModels;
using AppointmentScheduling.Utilities;
using Microsoft.AspNetCore.Identity;

namespace AppointmentScheduling.Services;

public class AppointmentService : IAppointmentService
{
    private readonly UserManager<AppUser> _userManager;

    public AppointmentService(UserManager<AppUser> userManager)
    {
        _userManager = userManager;
    }

    public async Task<IEnumerable<DoctorViewModel>?> GetDoctors()
    {
        return (await _userManager.GetUsersInRoleAsync(Roles.Doctor))
            .Select(u => new DoctorViewModel
            {
                Id = u.Id,
                Name = u.Name
            });
    }

    public async Task<IEnumerable<PatientViewModel>?> GetPatients()
    {
        return (await _userManager.GetUsersInRoleAsync(Roles.Patient))
            .Select(u => new PatientViewModel
            {
                Id = u.Id,
                Name = u.Name
            });
    }
}