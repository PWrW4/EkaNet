using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Models;

namespace Entity
{
    class Program
    {
        static void Main(string[] args)
        {
            var taskRepo = new MyTaskRepository(new AppContext());
            while (true)
            {

                Console.Clear();
                taskRepo.GetAllTasks();
                Console.WriteLine("\n Co chcesz zrobic? \n " +
                                  "0 - Wyjść \n " +
                                  "1 - Dodac zadanie \n " +
                                  "2 - Usunac zadanie \n");
                var userInput = Console.ReadLine();
                int userDigit;
                if (int.TryParse(userInput, out userDigit))
                {
                    UserChoice userChoice = (UserChoice)userDigit;
                    switch (userChoice)
                    {
                        case UserChoice.Exit:
                            return;
                        case UserChoice.AddTask:
                            var task = new MyTask
                            {
                                Name = "Idz na piwo!",
                                DueDate = DateTime.Now
                            };
                            taskRepo.AddMyTask(task);
                            break;
                        case UserChoice.RemoveTask:
                            RemoveTask();
                            break;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }
                }
            }
        }

        private static void RemoveTask()
        {
            throw new NotImplementedException();
        }

        private static void AddNewTask()
        {
            throw new NotImplementedException();
        }
    }
}
