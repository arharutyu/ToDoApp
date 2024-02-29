using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoApp
{
    public partial class ToDo : Form
    {
        Schedule mySchedule = new Schedule();

        public ToDo()
        {
            InitializeComponent();
        }

        private void addTask_Click(object sender, EventArgs e)
        {
            string taskText = addTaskTextBox.Text;

            MyTask task = new MyTask();
            task.name = taskText;
            task.description = "";
            task.id = Guid.NewGuid();
            task.completed = false;

            mySchedule.tasks.Add(task);
            UpdateTasksListBox();

            addTaskTextBox.Text = "";

            MessageBox.Show("Task added: " + taskText, "Task Added");
        }

        private void UpdateTasksListBox()
        {
            tasksListBox.Items.Clear();
            completedTasks.Items.Clear();
            foreach (MyTask task in mySchedule.tasks)
            {
                if (!task.completed)
                {
                    tasksListBox.Items.Add(task.id + ": " + task.name, task.completed);
                }
                else
                {
                    completedTasks.Items.Add(task.id + ": " + task.name);
                }
            }
        }

        private void tasksListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = tasksListBox.SelectedIndex;
            if (selectedIndex != -1)
            {
                MyTask selectedTask = mySchedule.tasks[selectedIndex];

                if (!selectedTask.completed)
                {
                    selectedTask.completed = true;
                }
                UpdateTasksListBox();
            }
        }
    }
}
