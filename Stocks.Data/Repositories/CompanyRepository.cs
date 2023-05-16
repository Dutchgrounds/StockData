using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Stocks.Data.Entities;

namespace Stocks.Data.Repositories
{
    internal class CompanyRepository
    {
        private readonly IDbContextFactory<StocksContext> dbFactory;

        public CompanyRepository(IDbContextFactory<StocksContext> dbFactory )
        {
            this.dbFactory = dbFactory;
        }

        private async Task Add( Company company )
        {
            await using var db = await dbFactory.CreateDbContextAsync( );

            await db.AddAsync( company );
            await db.SaveChangesAsync();
        }
    }
}
