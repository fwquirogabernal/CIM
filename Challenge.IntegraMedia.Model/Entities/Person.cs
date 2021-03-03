using Challenge.IntegraMedia.Model.Interfaces;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Challenge.IntegraMedia.Model.Entities
{
    public abstract class Person : IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DNI { get; set; }
        public DateTime DateBirth { get; set; }
        public int Age => DateTime.UtcNow.Year - DateBirth.Year;
    }
}
