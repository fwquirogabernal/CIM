using Challenge.IntegraMedia.Model.Entities;
using System;

namespace Challenge.IntegraMedia.Commands.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DNI { get; set; }
        public DateTime DateBirth { get; set; }
        public int Age { get; set; }
        public int IdCreditCard { get; set; }

        public static CustomerDto FromEntity(Customer customer)
        {
            return new CustomerDto
            {
                Id = customer.Id,
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                DNI = customer.DNI,
                DateBirth = customer.DateBirth,
                Age = customer.Age,
                IdCreditCard = customer.IdCreditCard
            };
        }

        public static Customer ToEntity(CustomerDto dto)
        {
            return new Customer
            {
                Id = dto.Id,
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                DNI = dto.DNI,
                DateBirth = dto.DateBirth,
                IdCreditCard = dto.IdCreditCard
            };
        }
    }
}
