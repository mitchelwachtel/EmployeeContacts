using System;
using System.ComponentModel.DataAnnotations;
using EmployeeContacts.Application.DTOs.Address;
using EmployeeContacts.Application.DTOs.Telephone;

namespace EmployeeContacts.Application.DTOs.Contact
{
    public abstract class BaseContactDTO
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public string Email { get; set; }

        public bool PrimaryContact { get; set; }

        [Required]
        public int EmployeeId { get; set; }

        public List<AddressDTO>? Addresses { get; set; }
        public List<TelephoneDTO>? Telephones { get; set; }
    }
}

