using AppointmentScheduling.Models.ViewModels;
using AppointmentScheduling.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AppointmentScheduling.Controllers;

public class AppointmentController : Controller
{
    private readonly IAppointmentService _appointmentService;

    public AppointmentController(IAppointmentService appointmentService)
    {
        _appointmentService = appointmentService;
    }

    public async Task<IActionResult> Index()
    {
        var doctors = await _appointmentService.GetDoctors();
        var doctorsSelectList = doctors?.Select(d => new SelectListItem()
        {
            Text = d.Name,
            Value = d.Id
        });

        ViewBag.DoctorsSelectList = doctorsSelectList ?? Array.Empty<SelectListItem>();
        
        return View();
    }
    
    public async Task<IEnumerable<PatientViewModel>?> GetPatients()
    {
        return await _appointmentService.GetPatients();
    }
}