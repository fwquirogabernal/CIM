using Challenge.IntegraMedia.Model.Interfaces;
using Challenge.IntegraMedia.Persistence.Setup;
using System;
using System.Collections.Generic;

namespace Challenge.IntegraMedia.Queries.BaseQuery
{
    public abstract class BaseQuery<TEntity> : IQuery<TEntity> where TEntity : IEntity
    {
        private readonly IDataBaseContext _context;

        protected BaseQuery(IDataBaseContext context)
        {
            _context = context;
        }

        public abstract IEnumerable<TEntity> GetAll();

        public abstract TEntity GetById(int id);

        protected TEntity ExecuteQuery<TEntity>(Func<IDataBaseContext, TEntity> function)
        {
            using (_context)
            {
                return function(_context);
            }
        }
    }
}
