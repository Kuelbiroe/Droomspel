using Droomspel.data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Droomspel.data.Services
{
    public class DroomspelDbContext: DbContext
    {
        public DbSet<User> User { get; set; }
    }
}
