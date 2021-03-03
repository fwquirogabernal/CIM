using Challenge.IntegraMedia.Model.Interfaces;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Challenge.IntegraMedia.Model.Entities
{
    [Table("Providers")]
    public class Provider : IEntity
    {
        public Provider()
        {
            Products = new HashSet<Product>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
