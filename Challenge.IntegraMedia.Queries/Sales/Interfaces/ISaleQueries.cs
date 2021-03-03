using Challenge.IntegraMedia.Model.Entities;
using Challenge.IntegraMedia.Queries.BaseQuery;
using System.Collections.Generic;

namespace Challenge.IntegraMedia.Queries.Sales.Interfaces
{
    public interface ISaleQueries : IQuery<Sale>
    {
        IEnumerable<Sale> GetByEmployee(string EmployeeNamem = null, string identification = null);
        IEnumerable<Sale> GetByCustomerName(string customerName);
    }
}
