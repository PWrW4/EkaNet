using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EkaNet_7.Models;

namespace EkaNet_7
{
    public class AppContext : DbContext
    {
        public DbSet<MyTask> MyTasks { get; set; }
    }
}
