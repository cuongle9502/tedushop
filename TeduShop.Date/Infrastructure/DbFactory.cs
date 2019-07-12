using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Date.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        TedushopDbContext dbContext;

        public TedushopDbContext Iint()
        {
            return dbContext ?? (dbContext = new TedushopDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
