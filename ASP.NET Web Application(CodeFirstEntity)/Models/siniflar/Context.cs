 using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;

namespace ASP.NET_Web_Application_CodeFirstEntity_.Models.siniflar
{
    public class Context: DbContext
    {
        public DbSet<Yetenekler> Yeteneklers { get; set; }
    }
}