using Domain;

namespace Infrostructure;

public class EmployeeService
{
    public List<Employee> _employees;

    public EmployeeService()
    {
        _employees = new List<Employee>();
    }

        // Creat
    public void AddEmployee(Employee employee)
    {
        _employees.Add(employee);
    }

       //Read
    public List<Employee> GetEmployees()
    {
        return _employees;
    }
    public int CountEMployees()
    {
        return _employees.Count;
    }
}
