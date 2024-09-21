using crudusingAjax.Data;

namespace crudusingAjax.Interface
{
    public interface IEmployee
    {
        Employee GetEmployeeById(int employeeId);
        List<Employee> GetAllEmployees();
        void Add(Employee employee);
        void Update(Employee employee);
        void Delete(int employeeId);
    }
}
