using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace codeFirstjoinns.Models
{
    public class ApplicationDbcontext:DbContext
    {
        public DbSet<categari> categaris { get; set; }
        public DbSet<product> products { get; set; }

    }
}