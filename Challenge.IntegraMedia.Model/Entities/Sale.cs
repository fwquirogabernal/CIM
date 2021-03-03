using Challenge.IntegraMedia.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Challenge.IntegraMedia.Model.Entities
{
    [Table("Sales")]
    public class Sale : IEntity
    {
        public Sale()
        {
            SaleLines = new HashSet<SaleLine>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int IdCustomer { get; set; }
        public int IdEmployee { get; set; }
        public DateTime Date { get; set; }

        public ICollection<SaleLine> SaleLines { get; set; }

        [ForeignKey(nameof(IdCustomer))]
        public Customer Customer { get; set; }

        [ForeignKey(nameof(IdEmployee))]
        public Employee Employee{ get; set; }

    }
}
