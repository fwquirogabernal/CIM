using System.ComponentModel.DataAnnotations.Schema;

namespace Challenge.IntegraMedia.Model.Entities
{
    [Table("Customers")]
    public class Customer: Person
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdCreditCard { get; set; }

        [ForeignKey(nameof(IdCreditCard ))]
        public CreditCard CreaditCard { get; set; }
    }
}
