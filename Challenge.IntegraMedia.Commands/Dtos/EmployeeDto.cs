using Challenge.IntegraMedia.Model.Entities;
using System;

namespace Challenge.IntegraMedia.Commands.Dtos
{
    public class EmployeeDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DNI { get; set; }
        public DateTime DateBirth { get; set; }
        public int Age { get; set; }
        public string Identification { get; set; }

        public static EmployeeDto FromEntity(Employee employee)
        {
            return new EmployeeDto
            {
                Id = employee.Id,
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                DNI = employee.DNI,
                DateBirth = employee.DateBirth,
                Age = employee.Age,
                Identification = employee.Identification
            };
        }

        public static Employee ToEntity(EmployeeDto dto)
        {
            return new Employee
            {
                Id = dto.Id,
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                DNI = dto.DNI,
                DateBirth = dto.DateBirth,
                Identification = dto.Identification
            };
        }
    }
}
