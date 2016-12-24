using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EkaNet_7.Models;

namespace EkaNet_7
{
    class Program
    {
        static void Main(string[] args)
        {
            var taskRepo = new MyTasksRepository(new AppContext());
            Console.Clear();
            taskRepo.GetAllTasks();
            Console.WriteLine("\n Co chcesz zrobic\n" + 
                                "0 - wyjsc\n" +
                                "1 - dodac zadanie\n" +
                                "2 - usunac zadanie \n");

            var userInput = Console.ReadLine();
            int userDigit;
            if (int.TryParse(userInput,out userDigit))
            {
                UserChoise userChoise = (UserChoise)userDigit;

                switch (userChoise)
                {
                    case UserChoise.Exit:
                        break;
                    case UserChoise.AddTask:
                        AddMyTask();
                        var task = new MyTask
                        {
                            Name = "idz na piwo",
                            DueTime = 
                            
                            
                        };
                        taskRepo.AddMyTask();
                        break;
                    case UserChoise.RemoveTask:
                        RemoveTask();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }

        private static void RemoveTask()
        {
            throw new NotImplementedException();
        }

        private static void AddMyTask()
        {
            throw new NotImplementedException();
        }
    }
}
