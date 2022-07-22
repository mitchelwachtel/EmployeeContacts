using System;
using EmployeeContacts.Application.DTOs.Contact;

namespace EmployeeContacts.Application.DTOs.Employee
{
    public class EmployeeDTO : BaseEmployeeDTO
    {
        public int Id { get; set; }

        public List<ContactDTO>? Contacts { get; set; }

    }
}

