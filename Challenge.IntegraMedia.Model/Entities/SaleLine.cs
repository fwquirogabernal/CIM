using Challenge.IntegraMedia.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge.IntegraMedia.Model.Entities
{
    [Table("SaleLines")]
    public class SaleLine : IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int Cuantity { get; set; }
        public int IdProducto { get; set; }
        public int SubTotal { get; set; }
        public int IdSale { get; set; }

        [ForeignKey(nameof(IdProducto))]
        public Product Product { get; set; }

        [ForeignKey(nameof(IdSale))]
        public Sale Sale { get; set; }
    }
}
