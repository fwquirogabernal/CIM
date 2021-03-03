using Challenge.IntegraMedia.Model.Interfaces;
using System;
using System.Collections.Generic;

namespace Challenge.IntegraMedia.Queries.BaseQuery
{
    public interface IQuery<TEntity> where TEntity : IEntity
    {
        abstract IEnumerable<TEntity> GetAll();
        abstract TEntity GetById(int id);

    }
}
