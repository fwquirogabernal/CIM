using Challenge.IntegraMedia.Model.Entities;
using Challenge.IntegraMedia.Persistence.Setup;
using Challenge.IntegraMedia.Queries.BaseQuery;
using Challenge.IntegraMedia.Queries.Person.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Challenge.IntegraMedia.Queries.Person
{
    public class EmployeeQueries: BaseQuery<Employee>, IEmployeeQueries
    {
        public EmployeeQueries(IDataBaseContext context) : base(context)
        {

        }

        public override IEnumerable<Employee> GetAll()
        {
            return ExecuteQuery(c => c.Employees.ToArray());
        }

        public override Employee GetById(int id)
        {
            return ExecuteQuery(c => c.Employees.FirstOrDefault(e => e.Id == id));
        }

        public Employee GetByIdentification(string id)
        {
            if (string.IsNullOrEmpty(id)) throw new ArgumentNullException(nameof(id));

            return ExecuteQuery(c => c.Employees.FirstOrDefault(e => e.Identification == id));
        }

        public IEnumerable<Employee> GetByFirstOrLastName(string name)
        {
            if (string.IsNullOrEmpty(name)) throw new ArgumentNullException(nameof(name));

            return ExecuteQuery(c => c.Employees.Where(e => e.FirstName.Contains(name) || e.LastName.Contains(name)).ToArray());
        }

    }
}
