using Challenge.IntegraMedia.Model.Entities;

namespace Challenge.IntegraMedia.Commands.Dtos
{
    public class ProviderDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ProviderDto FromEnity(Provider provider)
        {
            return new ProviderDto
            {
                Id = provider.Id,
                Name = provider.Name
            };
        }

        public Provider ToEntity(ProviderDto dto)
        {
            return new Provider
            {
                Id = dto.Id,
                Name = dto.Name
            };
        }
    }
}
