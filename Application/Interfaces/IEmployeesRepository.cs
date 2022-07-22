using System;
using System.Collections.Generic;
using EmployeeContacts.Domain.Entities.Human;

namespace EmployeeContacts.Application.Interfaces
{
    public interface IEmployeesRepository : IGenericRepository<Employee>
    {

        Task<List<Employee>> GetAllAsync();

        Task<Employee> GetByEmailAsync(string? email);

        Task<Employee> GetDetailsByIdAsync(int id);

        Task<bool> ExistsAsync(int id);
    }
}

