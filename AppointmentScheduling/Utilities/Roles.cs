using Microsoft.AspNetCore.Mvc.Rendering;

namespace AppointmentScheduling.Utilities;

public static class Roles
{
    public const string Admin = "Admin";
    public const string Patient = "Patient";
    public const string Doctor = "Doctor";

    public static List<SelectListItem> GetRolesForDropDown()
    {
        return new List<SelectListItem>
        {
            new() { Value = Admin, Text = Admin },
            new() { Value = Patient, Text = Patient },
            new() { Value = Doctor, Text = Doctor }
        };
    }
}