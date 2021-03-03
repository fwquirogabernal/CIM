using Challenge.IntegraMedia.Model.Entities;
using System;

namespace Challenge.IntegraMedia.Commands.Dtos
{
    public class CreditCardDto
    {
        public int Id { get; set; }
        public string OwnerName { get; set; }
        public long Number { get; set; }
        public DateTime DueDate { get; set; }
        public int Code { get; set; }
        public int IdCustomer { get; set; }

        public static CreditCard ToEntity(CreditCardDto dto)
        {
            return new CreditCard
            {
                DueDate = dto.DueDate,
                OwnerName = dto.OwnerName,
                Number = dto.Number,
                Code = dto.Code,
                IdCustomer = dto.IdCustomer
            };
        }
        public CreditCardDto FromEntity(CreditCard creditCard)
        {
            return new CreditCardDto
            {
                Id = creditCard.Id,
                IdCustomer = creditCard.IdCustomer,
                OwnerName = creditCard.OwnerName,
                Number = creditCard.Number,
                Code = creditCard.Code,
                DueDate = creditCard.DueDate,
            };
        }
    }
}
