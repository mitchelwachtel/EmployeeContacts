using System;
using System.ComponentModel.DataAnnotations;

namespace EmployeeContacts.Domain.Entities.Communication
{
    public class Address : BaseCommunication
    {
        [Required]
        public string? Street { get; set; }

        [Required]
        public string? City { get; set; }

        [Required]
        public string? State { get; set; }

        [Required]
        public int PostalCode { get; set; }
    }
}


