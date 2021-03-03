using Challenge.IntegraMedia.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge.IntegraMedia.Commands.Dtos
{
    public class SaleDto
    {
        public int Id { get; set; }
        public int IdCustomer { get; set; }
        public int IdEmployee { get; set; }
        public DateTime Date { get; set; }
        public CustomerDto Customer { get; set; }
        public EmployeeDto Employee { get; set; }
        public SaleLineDto[] saleLineDtos { get; set; }

        public static SaleDto FromEntity(Sale sale)
        {
            return new SaleDto
            {
                Id = sale.Id,
                Date = sale.Date,
                Customer = CustomerDto.FromEntity(sale.Customer),
                Employee = EmployeeDto.FromEntity(sale.Employee),
                saleLineDtos = sale.SaleLines.Select(sl => SaleLineDto.FromEntity(sl)).ToArray()
            };
        }

        public static Sale ToEntity(SaleDto dto)
        {
            return new Sale
            {
                IdCustomer = dto.Customer.Id,
                IdEmployee = dto.Employee.Id,
                Date = dto.Date,
            };
        }
    }
}
