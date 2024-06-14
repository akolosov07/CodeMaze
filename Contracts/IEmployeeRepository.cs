using Entities.Models;
using Shared;
using Shared.RequestFeatures;

namespace Contracts
{
    public interface IEmployeeRepository
    {
        Task<PagedList<Employee>> GetEmployeesAsync(Guid companyId, EmployeeParameters employeeParameters, 
            bool trackChanges);
        Task<Employee> GetEmployeeAsync(Guid companyId, Guid id, bool trackChanges);
        void CreateEmployeeForCompanyAsync(Guid companyId, Employee employee);
        void DeleteEmployeeAsync(Employee employee);
    }
}
