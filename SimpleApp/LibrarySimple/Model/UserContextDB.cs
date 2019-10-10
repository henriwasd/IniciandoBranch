using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySimple.Model
{
    public class UserContextDB : DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}
