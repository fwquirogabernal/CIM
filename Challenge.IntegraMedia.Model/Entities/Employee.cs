using System.ComponentModel.DataAnnotations.Schema;

namespace Challenge.IntegraMedia.Model.Entities
{
    [Table("Employees")]
    public class Employee: Person
    {
        public string Identification { get; set; }
    }
}
