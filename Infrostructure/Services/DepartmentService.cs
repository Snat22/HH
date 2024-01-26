using Domain;

namespace Infrostructure;

public class DepartmentService
{

    public List<Department> _department;

    public DepartmentService()
    {
        _department = new List<Department>();
    }

        // Creat
    public void AddEmployee(Department department)
    {
        _department.Add(department);
    }

       //Read
    public List<Department> GetEmployees()
    {
        return _department;
    }
    public int CountEMployees()
    {
        return _department.Count;
    }

    
}
