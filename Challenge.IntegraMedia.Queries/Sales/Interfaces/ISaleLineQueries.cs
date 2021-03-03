using Challenge.IntegraMedia.Model.Entities;
using Challenge.IntegraMedia.Queries.BaseQuery;
using System.Collections.Generic;

namespace Challenge.IntegraMedia.Queries.Sales.Interfaces
{
    public interface ISaleLineQueries: IQuery<SaleLine>
    {
        IEnumerable<SaleLine> GetSaleLinesByIdSale(int idSale);
    }
}
