using Challenge.IntegraMedia.Model.Entities;

namespace Challenge.IntegraMedia.Commands.Dtos
{
    public class SaleLineDto
    {
        public int Id { get; set; }
        public int Cuantity { get; set; }
        public ProductDto Product { get; set; }
        public int SubTotal { get; set; }
        public int IdSale { get; set; }

        public static SaleLineDto FromEntity(SaleLine saleLine)
        {
            return new SaleLineDto
            {
                Id = saleLine.Id,
                Cuantity = saleLine.Cuantity,
                Product = ProductDto.FromEntity(saleLine.Product),
                SubTotal = saleLine.SubTotal
            };
        }

        public static SaleLine ToEntity(SaleLineDto dto)
        {
            return new SaleLine
            {
                Cuantity = dto.Cuantity,
                SubTotal = dto.SubTotal,
                IdProducto = dto.Product.Id
            };
        }
    }
}
