using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Models;

namespace Entity
{
    public class MyTaskRepository
    {
        private readonly AppContext _appContext;

        public MyTaskRepository(AppContext appContext)
        {
            _appContext = appContext;
        }

        public void AddMyTask(MyTask myTask)
        {
            _appContext.MyTasks.Add(myTask);
            _appContext.SaveChanges();
        }

        public void RemoveMyTask(int id)
        {
            var task = _appContext.MyTasks.Find(id);
            _appContext.MyTasks.Remove(task);
            _appContext.SaveChanges();
        }

        public List<MyTask> GetAllTasks()
        {
            return _appContext.MyTasks.ToList();
        }
    }
}
