using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Models;

namespace Entity
{
    public class AppContext: DbContext
    {
        public DbSet<MyTask> MyTasks { get; set; }
    }
}
