using Challenge.IntegraMedia.Model.Entities;
using Challenge.IntegraMedia.Persistence.Setup;
using Challenge.IntegraMedia.Queries.BaseQuery;
using Challenge.IntegraMedia.Queries.Sales.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge.IntegraMedia.Queries.Sales
{
    public class SaleLineQueries : BaseQuery<SaleLine>, ISaleLineQueries
    {
        public SaleLineQueries(IDataBaseContext context) : base(context)
        {

        }
        public override IEnumerable<SaleLine> GetAll()
        {
            throw new NotImplementedException();
        }

        public override SaleLine GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SaleLine> GetSaleLinesByIdSale(int idSale)
        {
            if (idSale <= 0) throw new ArgumentOutOfRangeException(nameof(idSale)); 

            return ExecuteQuery(c => c.SaleLines.Where(sl => sl.IdSale == idSale).ToArray());
        }
    }
}
