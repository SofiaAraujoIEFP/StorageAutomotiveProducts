using Microsoft.EntityFrameworkCore;
using StorageAutomotiveProducts.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageAutomotiveProducts.Data
{
    public class BusinessDbContext : DbContext
    {
        DbSet<Products> Product { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=SQL6033.site4now.net;Initial Catalog=db_ab23ce_davidaleluia;User Id=db_ab23ce_davidaleluia_admin;Password=Passcode007");
        }
    }
}

