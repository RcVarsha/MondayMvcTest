using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MondayMvcTest.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext() : base("MyCon")
        {

        }
        public DbSet<Moviedetail>Moviedetails{ get; set; }

    }
}