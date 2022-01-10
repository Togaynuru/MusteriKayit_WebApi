using Microsoft.EntityFrameworkCore;
using MusteriKayit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusteriKayit.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext>options):base(options)
        {

        }


        public DbSet<Customer> Customers { get; set; }
    }
}
