using EmployeesApp.Web.Services;
using Microsoft.AspNetCore.Mvc;

namespace EmployeesApp.Web.Controllers;

public class EmployeesController : Controller
{
    static EmployeeService employeeService = new EmployeeService();

    [HttpGet("")]
    public IActionResult Index()
    {
        var employees = employeeService.GetEmployees();
        return View(employees);
    }

    [HttpGet("create")]
    public IActionResult Create()
    {
        return View(new Models.Employee());
    }

    [HttpPost("create")]
    public IActionResult Create(Models.Employee employee)
    {
        if (!ModelState.IsValid)
            return View(employee);

        employeeService.AddEmployee(employee);
        return RedirectToAction("Index");
    }

    [HttpGet("detail/{id:int}")]
    public IActionResult Detail(int id)
    {
        var employee = employeeService.GetEmployeeById(id);
        if (employee == null)
            return NotFound();
        return View(employee);
    }
}
