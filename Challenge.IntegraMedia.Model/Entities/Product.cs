using Challenge.IntegraMedia.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Challenge.IntegraMedia.Model.Entities
{
    [Table("Products")]
    public class Product : IEntity
    {
        public Product()
        {
            SaleLines = new HashSet<SaleLine>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Trademark { get; set; }
        public DateTime DueDate { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        public int IdProvider { get; set; }

        public Provider Provider { get; set; }
        public ICollection<SaleLine> SaleLines { get; set; }
    }
}
