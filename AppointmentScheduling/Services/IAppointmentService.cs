using AppointmentScheduling.Models.ViewModels;

namespace AppointmentScheduling.Services;

public interface IAppointmentService
{
    public Task<IEnumerable<DoctorViewModel>?> GetDoctors();
    
    public Task<IEnumerable<PatientViewModel>?> GetPatients();
}