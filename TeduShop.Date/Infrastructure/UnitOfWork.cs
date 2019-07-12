using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Date.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDbFactory dbFactory;
        private TedushopDbContext dbContext;

        public UnitOfWork(IDbFactory dbFactory)
        {
            this.dbFactory = dbFactory;
        }

        public TedushopDbContext DbContext
        {
            get { return DbContext ?? (dbContext = dbFactory.Iint()); }
        }

        public void Commit()
        {
            DbContext.SaveChanges();
        }
    }
}
