﻿using System;
using EmployeeContacts.Domain.Entities.Human;

namespace EmployeeContacts.Application.Interfaces
{
    public interface IContactsRepository : IGenericRepository<Contact>
    {
        Task<List<Contact>> GetAllContactsByEmployeeIdAsync(int id);

        Task<bool> HasContactsAsync(int id);

        Task<Contact> GetPrimaryContactByEmployeeId(int id);
    }
}

