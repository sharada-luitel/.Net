using crudusingAjax.Data;
using crudusingAjax.Interface;

namespace crudusingAjax.Repository
{
    public class EmployeeRepository : IEmployee
    {
        private readonly EmployeeRepository _context;
        public EmployeeRepository(EmployeeDbContext employee)
        {
            _context = employee;

        }
        public void Add(Employee employee)
        {
            throw new NotImplementedException();
        }

        public void Delete(int employeeId)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetAllEmployees()
        {
            throw new NotImplementedException();
        }

        public Employee GetEmployeeById(int employeeId)
        {
            throw new NotImplementedException();
        }

        public void Update(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
