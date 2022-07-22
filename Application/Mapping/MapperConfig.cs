using System;
using AutoMapper;
using EmployeeContacts.Domain.Entities.Human;
using EmployeeContacts.Domain.Entities.Communication;
using EmployeeContacts.Application.DTOs.Address;
using EmployeeContacts.Application.DTOs.Contact;
using EmployeeContacts.Application.DTOs.Employee;
using EmployeeContacts.Application.DTOs.Telephone;

namespace EmployeeContacts.Application.Mappers
{
	public class MapperConfig : Profile
	{
		public MapperConfig()
		{
			CreateMap<Employee, EmployeeDTO>().ReverseMap();
			CreateMap<Employee, CreateEmployeeDTO>().ReverseMap();
			CreateMap<Employee, UpdateEmployeeDTO>().ReverseMap();

			CreateMap<Contact, ContactDTO>().ReverseMap();
			CreateMap<Contact, CreateContactDTO>().ReverseMap();
			CreateMap<Contact, UpdateContactDTO>().ReverseMap();

			CreateMap<Address, AddressDTO>().ReverseMap();
			CreateMap<Address, CreateAddressDTO>().ReverseMap();
			CreateMap<Address, UpdateAddressDTO>().ReverseMap();

			CreateMap<Telephone, TelephoneDTO>().ReverseMap();
			CreateMap<Telephone, CreateTelephoneDTO>().ReverseMap();
			CreateMap<Telephone, UpdateTelephoneDTO>().ReverseMap();
		}
	}
}

