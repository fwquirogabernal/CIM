using Challenge.IntegraMedia.Model.Entities;
using Challenge.IntegraMedia.Persistence.Setup;
using Challenge.IntegraMedia.Queries.BaseQuery;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Challenge.IntegraMedia.Queries.Products
{
    public class ProductQueries : BaseQuery<Product>, IProductQueries
    {
        public ProductQueries(IDataBaseContext context) : base(context)
        {

        }
        public override IEnumerable<Product> GetAll()
        {
            return ExecuteQuery(c => c.Products.ToArray());
        }

        public override Product GetById(int id)
        {
            return ExecuteQuery(c => c.Products.FirstOrDefault(x => x.Id == id));
        }

        public IEnumerable<Product> GetByName(string name)
        {
            if (string.IsNullOrEmpty(name)) throw new ArgumentNullException(nameof(name));

            return ExecuteQuery(c => c.Products.Where(p => p.Name.Contains(name)).ToArray());
        }
    }
}
