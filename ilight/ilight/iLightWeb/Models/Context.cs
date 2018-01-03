using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace ilight.Models
{
    public class Context : DbContext
    {
        public DbSet<Users> Users { get; set; }
        public DbSet<Downloads> Downloads { get; set; }
    }
}
