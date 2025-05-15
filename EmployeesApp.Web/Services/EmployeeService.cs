using EmployeesApp.Web.Models;

namespace EmployeesApp.Web.Services;

public class EmployeeService
{
    static int nextId = 2;
    static List<Employee> employees = new List<Employee>
    {
        new Employee { Id = 1, Name = "John Doe", Email = "JohnDoe@world.com" },
    };
    public void AddEmployee(Employee employee)
    {   
        if (employee.Id < nextId)
            employee.Id = nextId++;
        employees.Add(employee);
    }
    public Employee? GetEmployeeById(int id) => employees.SingleOrDefault(e => e.Id == id);
    public Employee[] GetEmployees() => 
        employees
            .OrderBy(e => e.Name)
            .ToArray();
}
