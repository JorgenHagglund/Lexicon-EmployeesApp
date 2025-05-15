using System.ComponentModel.DataAnnotations;

namespace EmployeesApp.Web.Models;

public class Employee
{
    public int Id { get; set; }

    [Display(Name = "Full Name", Prompt = "Name")]
    [Required(ErrorMessage = "Name is required")]
    public string Name { get; set; }

    [Display(Name = "E-mail address", Prompt = "E-mail address")]
    [EmailAddress(ErrorMessage = "E-mail address is invalid")]
    public string Email { get; set; }
}
