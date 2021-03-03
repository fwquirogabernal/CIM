using Challenge.IntegraMedia.Commands.BaseCommand;
using modref = Challenge.IntegraMedia.Model.Entities;

namespace Challenge.IntegraMedia.Commands.Product
{
    public interface IProductCommand: ICommand<modref.Product>
    {
    }
}
