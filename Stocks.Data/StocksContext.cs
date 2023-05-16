using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Stocks.Data.Entities;

namespace Stocks.Data
{
    public class StocksContext : IdentityDbContext<AppUser, AppRole, int>
    {
        public StocksContext(DbContextOptions<StocksContext> options ) : base( options )
        {
            
        }

        protected override void OnModelCreating( ModelBuilder builder )
        {
            base.OnModelCreating( builder );

            builder.ApplyConfigurationsFromAssembly( Assembly.GetExecutingAssembly( ) );
        }
    }
}
