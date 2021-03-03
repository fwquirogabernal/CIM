using Challenge.IntegraMedia.Model.Interfaces;

namespace Challenge.IntegraMedia.Commands.BaseCommand
{
    public interface ICommand<TEntity> where TEntity: IEntity
    {
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Remove(TEntity entity);
    }
}
