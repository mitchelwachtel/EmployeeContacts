using System;
using EmployeeContacts.Domain.Entities.Human;
using EmployeeContacts.Application.Interfaces;
using EmployeeContacts.Infrastructure.Persistence.Data;
using Microsoft.EntityFrameworkCore;

namespace EmployeeContacts.Infrastructure.Persistence.Repositories
{
    public class EmployeesRepository : GenericRepository<Employee>, IEmployeesRepository
    {
        private readonly EmployeeContactsDbContext _context;

        public EmployeesRepository(EmployeeContactsDbContext context) : base(context)
        {
            this._context = context;
        }

        //public async Task<Employee> GetByIdAsync(int id)
        //{
        //    if (id == null)
        //    {
        //        return null;
        //    }

        //    var result = await _context.Set<Employee>().FindAsync(id);
        //    return result;
        //}

        public async Task<bool> ExistsAsync(int id)
        {
            var result = await GetByIdAsync(id);
            return result != null;
        }

        public async Task<List<Employee>> GetAllAsync()
        {
            return await _context.Set<Employee>().ToListAsync();
        }

        public async Task<Employee> GetByEmailAsync(string? email)
        {
            var result = await _context.Employees.Include(q => q.Addresses).Include(q => q.Telephones).FirstOrDefaultAsync(q => q.Email == email);
            return result;
        }

        public async Task<Employee> GetDetailsByIdAsync(int id)
        {
            var result = await _context.Employees.Include(q => q.Addresses).Include(q => q.Telephones).FirstOrDefaultAsync(q => q.Id == id);
            return result;
        }

    }
}

