using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace GCF.Models
{
    
    public class DatabaseContext : DbContext
    {
        public DbSet<PostContactModel> posts { get; set; }
        public DbSet<MembersModel> Members { get; set; }
    }
}