using System;
using System.ComponentModel.DataAnnotations;
using EmployeeContacts.Application.DTOs.Address;
using EmployeeContacts.Application.DTOs.Telephone;

namespace EmployeeContacts.Application.DTOs.Employee
{
    public abstract class BaseEmployeeDTO
    {
        [Required]
        public string? FirstName { get; set; }

        [Required]
        public string? LastName { get; set; }

        [Required]
        public string? Email { get; set; }

        [Required]
        public int DateOfBirth { get; set; }

        [Required]
        public int SocialSecurityNumber { get; set; }

        public List<AddressDTO>? Addresses { get; set; }
        public List<TelephoneDTO>? Telephones { get; set; }

    }
}

