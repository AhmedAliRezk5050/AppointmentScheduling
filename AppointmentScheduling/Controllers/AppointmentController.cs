using AppointmentScheduling.Models.ViewModels;
using AppointmentScheduling.Services;
using Microsoft.AspNetCore.Mvc;

namespace AppointmentScheduling.Controllers;

public class AppointmentController : Controller
{
    private readonly IAppointmentService _appointmentService;

    public AppointmentController(IAppointmentService appointmentService)
    {
        _appointmentService = appointmentService;
    }

    public async Task<IEnumerable<DoctorViewModel>?> GetDoctors()
    {
        return await _appointmentService.GetDoctors();
    }
    
    public async Task<IEnumerable<PatientViewModel>?> GetPatients()
    {
        return await _appointmentService.GetPatients();
    }
}