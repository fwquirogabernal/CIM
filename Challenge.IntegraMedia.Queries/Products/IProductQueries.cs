using Challenge.IntegraMedia.Model.Entities;
using Challenge.IntegraMedia.Queries.BaseQuery;
using System.Collections.Generic;

namespace Challenge.IntegraMedia.Queries.Products
{
    public interface IProductQueries: IQuery<Product>
    {
        IEnumerable<Product> GetByName(string name);
    }
}
