using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp
{
    internal class MyTask
    {
        public Guid id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public bool completed { get; set; }
        public DateTime dueDate { get; set; }
        public DateTime completedDate { get; set; }

        public void CompleteTask()
        {
            completed = true;
            completedDate = DateTime.Now;
        }

        public bool isOverdue()
        {
            return (dueDate < DateTime.Today);
        }

        public bool isDueToday()
        {
            return (dueDate.Date == DateTime.Today);
        }
        
    }
}
