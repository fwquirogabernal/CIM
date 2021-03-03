using Challenge.IntegraMedia.Model.Entities;
using System;

namespace Challenge.IntegraMedia.Commands.Dtos
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Trademark { get; set; }
        public DateTime DueDate { get; set; }
        public decimal Price { get; set; }
        public int IdProvider { get; set; }

        public static Product ToEntity(ProductDto dto)
        {
            return new Product
            {
                Name = dto.Name,
                Trademark = dto.Trademark,
                DueDate = dto.DueDate,
                Price = dto.Price,
                IdProvider = dto.IdProvider
            };
        }

        public static ProductDto FromEntity(Product product)
        {
            return new ProductDto
            {
                Id = product.Id,
                Name = product.Name,
                Trademark = product.Trademark,
                DueDate = product.DueDate,
                Price = product.Price,
                IdProvider = product.IdProvider
            };
        }
    }
}
