using System;
using System.ComponentModel.DataAnnotations;

namespace EmployeeContacts.Domain.Entities.Communication
{
    public class Telephone : BaseCommunication
    {

        [Required]
        public int CountryCode { get; set; }

        [Required]
        public int PhoneNumber { get; set; }



    }
}

