using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Date.Infrastructure
{
    public  interface IDbFactory : IDisposable
    {
        TedushopDbContext Iint();
    }
}
