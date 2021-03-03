using Challenge.IntegraMedia.Model.Interfaces;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Challenge.IntegraMedia.Model.Entities
{
    [Table("CreditCards")]
    public class CreditCard : IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string OwnerName { get; set; }
        public long Number { get; set; }
        public DateTime DueDate { get; set; }
        public int Code { get; set; }
        public int IdCustomer { get; set; }

        [ForeignKey(nameof(IdCustomer))]
        public Customer Customer { get; set; }
    }
}
