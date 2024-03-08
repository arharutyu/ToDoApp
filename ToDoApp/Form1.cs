using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoApp
{
    public partial class ToDo : Form
    {
        Schedule mySchedule = new Schedule();
        private bool updatingListView = false;

        public ToDo()
        {
            InitializeComponent();

            // Set up the ListView controls
            tasksListView.View = View.Details;
            tasksListView.FullRowSelect = true;
            tasksListView.Columns.Add("Task", 100);
            tasksListView.Columns.Add("Id", 0);
            tasksListView.Columns.Add("Description", 200);
            tasksListView.Columns.Add("Due Date", 100);

            completedTasksListView.View = View.Details;
            completedTasksListView.FullRowSelect = true;
            completedTasksListView.Columns.Add("Task", 100);
            completedTasksListView.Columns.Add("Description", 200);
            completedTasksListView.Columns.Add("Due Date", 100);
            completedTasksListView.Columns.Add("Completed Date", 100);
        }

        private void addTask_Click(object sender, EventArgs e)
        {
            string taskText = addTaskTextBox.Text;
            string taskDescription = addTaskDescription.Text;
            DateTime taskDueDate = addTaskDueDate.Value;

            MyTask task = new MyTask();
            task.name = taskText;
            task.description = taskDescription;
            task.dueDate = taskDueDate;
            task.id = Guid.NewGuid();
            task.completed = false;

            mySchedule.tasks.Add(task);
            UpdateTasksListView();

            addTaskTextBox.Text = "";
            addTaskDescription.Text = "";
            addTaskDueDate.Value = DateTime.Now;

            //MessageBox.Show("Task added: " + taskText, "Task Added");
        }

        private void UpdateTasksListView()
        {
            tasksListView.Items.Clear();

            var sortedTasks = mySchedule.tasks.Where(task => !task.completed)
                                      .OrderBy(task => task.dueDate);

            foreach (MyTask task in sortedTasks)
            {
                ListViewItem item = new ListViewItem(task.name);
                item.SubItems.Add(task.id.ToString());
                item.SubItems.Add(task.description);
                item.SubItems.Add(task.dueDate.ToString("dd-MM-yyyy"));

                if (task.isOverdue())
                {
                    item.ForeColor = Color.Red;
                } else if (task.isDueToday())
                {
                    item.ForeColor = Color.Blue;
                }

                tasksListView.Items.Add(item);
            }

            completedTasksListView.Items.Clear();
            foreach (MyTask task in mySchedule.tasks.Where(task => task.completed))
            {
                ListViewItem item = new ListViewItem(task.name);
                item.SubItems.Add(task.description);
                item.SubItems.Add(task.dueDate.ToString("dd-MM-yyyy"));
                item.SubItems.Add(task.completedDate.ToString("dd-MM-yyyy"));
                completedTasksListView.Items.Add(item);
            }
        }

        private void markComplete_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem task in tasksListView.CheckedItems)
            {
                Guid guid = new Guid(task.SubItems[1].Text);
                MyTask checkedTask = mySchedule.tasks.FirstOrDefault(m => m.id == guid);

                checkedTask.CompleteTask();

                UpdateTasksListView();
            }
        }
    }
}
