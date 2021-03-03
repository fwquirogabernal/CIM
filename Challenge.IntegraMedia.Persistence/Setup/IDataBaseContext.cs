using Challenge.IntegraMedia.Model.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace Challenge.IntegraMedia.Persistence.Setup
{
    public interface IDataBaseContext : IDisposable
    {
        DbSet<Customer> Customers { get; }
        DbSet<CreditCard> CreaditCards { get; }
        DbSet<Employee> Employees { get; }
        DbSet<Product> Products { get; }
        DbSet<Provider> Providers { get; }
        DbSet<Sale> Sales { get; }
        DbSet<SaleLine> SaleLines { get; }

        int SaveChanges();

    }
}
