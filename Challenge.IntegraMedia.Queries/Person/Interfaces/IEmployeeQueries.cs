using Challenge.IntegraMedia.Model.Entities;
using Challenge.IntegraMedia.Queries.BaseQuery;
using System.Collections.Generic;

namespace Challenge.IntegraMedia.Queries.Person.Interfaces
{
    public interface IEmployeeQueries: IQuery<Employee>
    {
        IEnumerable<Employee> GetByFirstOrLastName(string name);
        Employee GetByIdentification(string id);
    }
}
