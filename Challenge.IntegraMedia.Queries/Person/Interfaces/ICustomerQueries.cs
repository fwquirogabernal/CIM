using Challenge.IntegraMedia.Model.Entities;
using Challenge.IntegraMedia.Queries.BaseQuery;
using System.Collections.Generic;

namespace Challenge.IntegraMedia.Queries.Person.Interfaces
{
    public interface ICustomerQueries: IQuery<Customer>
    {
        IEnumerable<Customer> GetByFirstOrLastName(string name);
    }
}
