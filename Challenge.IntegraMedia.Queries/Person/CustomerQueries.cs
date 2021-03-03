using Challenge.IntegraMedia.Model.Entities;
using Challenge.IntegraMedia.Persistence.Setup;
using Challenge.IntegraMedia.Queries.BaseQuery;
using Challenge.IntegraMedia.Queries.Person.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Challenge.IntegraMedia.Queries.Person
{
    public class CustomerQueries : BaseQuery<Customer>, ICustomerQueries
    {
        public CustomerQueries(IDataBaseContext context) : base(context)
        {

        }
        public override IEnumerable<Customer> GetAll()
        {
            return ExecuteQuery(c => c.Customers.ToArray());
        }

        public override Customer GetById(int id)
        {
            return ExecuteQuery(c => c.Customers.FirstOrDefault(cs => cs.Id == id));
        }

        public IEnumerable<Customer> GetByFirstOrLastName(string name)
        {
            if (string.IsNullOrEmpty(name)) throw new ArgumentNullException(nameof(name));

            return ExecuteQuery(c => c.Customers.Where(cs => cs.FirstName.Contains(name) || cs.LastName.Contains(name))
                                        .Include(c => c.CreaditCard).ToArray());
        }
    }
}
