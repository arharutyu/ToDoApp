using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp
{
    internal class Schedule
    {
        public List<MyTask> tasks = new List<MyTask>();

        public Schedule()
        {
            tasks = new List<MyTask>();
        }

        public List<MyTask> completedTasks()
        {
            return this.tasks.Where(task => task.completed).ToList<MyTask>();
        }

        public List<MyTask> sortedOutstandingTasks()
        {
            var sortedTasks = this.tasks.Where(task => !task.completed)
                                      .OrderBy(task => task.dueDate);
            return sortedTasks.ToList<MyTask>();
        }
    }
}
