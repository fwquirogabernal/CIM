using Challenge.IntegraMedia.Model.Entities;
using Challenge.IntegraMedia.Persistence.Setup;
using Challenge.IntegraMedia.Queries.BaseQuery;
using Challenge.IntegraMedia.Queries.Sales.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Challenge.IntegraMedia.Queries.Sales
{
    public class SalesQueries : BaseQuery<Sale>, ISaleQueries
    {
        public SalesQueries(IDataBaseContext context) : base(context)
        {

        }
        public override IEnumerable<Sale> GetAll()
        {
            return ExecuteQuery(c => c.Sales.ToArray());
        }

        public override Sale GetById(int id)
        {
            return ExecuteQuery(c => c.Sales.FirstOrDefault(s => s.Id == id));
        }

        public IEnumerable<Sale> GetByCustomerName(string customerName)
        {
            if (string.IsNullOrEmpty(customerName)) throw new ArgumentNullException(nameof(customerName));

            return ExecuteQuery(c => c.Sales.Where(s => s.Customer.FirstName.Contains(customerName) 
                                        || s.Customer.LastName.Contains(customerName))
                                            .ToArray());
        }

        public IEnumerable<Sale> GetByEmployee(string EmployeeNamem = null, string identification = null)
        {
            if (string.IsNullOrEmpty(EmployeeNamem) && string.IsNullOrEmpty(identification)) throw new ArgumentNullException($"{nameof(EmployeeNamem)} - {nameof(identification)}");

            return ExecuteQuery(c => c.Sales.Where(s => s.Employee.FirstName.Contains(EmployeeNamem)
                                        || s.Employee.LastName.Contains(EmployeeNamem) 
                                        || s.Employee.Identification == identification)
                                            .ToArray());
        }
    }
}
