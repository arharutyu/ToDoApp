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
        bool sortOutstandingTasksOrderAscending = true;
        const string ascArrow = " ▲";
        const string descArrow = " ▼";

        public ToDo()
        {
            InitializeComponent();

            // Set up the ListView controls
            tasksListView.View = View.Details;
            tasksListView.FullRowSelect = true;
            tasksListView.Columns.Add("Task", 100);
            tasksListView.Columns.Add("Id", 0);
            tasksListView.Columns.Add("Description", 200);
            tasksListView.Columns.Add("Due Date ▲", 100);
            tasksListView.Columns.Add("Category", 100);

            completedTasksListView.View = View.Details;
            completedTasksListView.FullRowSelect = true;
            completedTasksListView.Columns.Add("Task", 100);
            completedTasksListView.Columns.Add("Id", 0);
            completedTasksListView.Columns.Add("Description", 200);
            completedTasksListView.Columns.Add("Due Date", 100);
            completedTasksListView.Columns.Add("Completed Date", 100);
            completedTasksListView.Columns.Add("Category", 100);

            UpdateDisplayOutstandingAndDueTodayTasksCount();
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
            task.category = addTaskCategory.SelectedItem.ToString();

            mySchedule.tasks.Add(task);
            UpdateTasksListView();

            addTaskTextBox.Text = "";
            addTaskDescription.Text = "";
            addTaskDueDate.Value = DateTime.Now;
            addTaskCategory.SelectedIndex = -1;
            addTaskCategory.Text = "";

            //MessageBox.Show("Task added: " + taskText, "Task Added");
        }

        private void UpdateTasksListView()
        {
            tasksListView.Items.Clear();

            var sortedOutstandingTasks = sortOutstandingTasksOrderAscending
                ? mySchedule.sortedOutstandingTasks().OrderBy(task => task.dueDate)
                : mySchedule.sortedOutstandingTasks().OrderByDescending(task => task.dueDate);

            foreach (MyTask task in sortedOutstandingTasks)
            {
                ListViewItem item = new ListViewItem(task.name);
                item.SubItems.Add(task.id.ToString());
                item.SubItems.Add(task.description);
                item.SubItems.Add(task.dueDate.ToString("dd-MM-yyyy"));
                item.SubItems.Add(task.category);

                if (task.isOverdue())
                {
                    item.ForeColor = Color.Red;
                }
                else if (task.isDueToday())
                {
                    item.ForeColor = Color.Blue;
                }

                tasksListView.Items.Add(item);
            }

            completedTasksListView.Items.Clear();
            foreach (MyTask task in mySchedule.completedTasks())
            {
                ListViewItem item = new ListViewItem(task.name);
                item.SubItems.Add(task.id.ToString());
                item.SubItems.Add(task.description);
                item.SubItems.Add(task.dueDate.ToString("dd-MM-yyyy"));
                item.SubItems.Add(task.completedDate?.ToString("dd-MM-yyyy"));
                item.SubItems.Add(task.category);
                completedTasksListView.Items.Add(item);
            }

            UpdateDisplayOutstandingAndDueTodayTasksCount();
        }

        private void UpdateDisplayOutstandingAndDueTodayTasksCount()
        {
            var outstandingTasks = mySchedule.tasks.Where(task => !task.completed).Count();
            var tasksDueToday = mySchedule.tasks.Where(task => (task.dueDate.Date == DateTime.Today) && (!task.completed)).Count();
            tasksDueTodayCountDisplay.Text = "You have " + tasksDueToday + " tasks due today.";
            oustandingTasksCountDisplay.Text = "You have " + outstandingTasks + " oustanding tasks.";
            if (outstandingTasks == 0)
            {
                allDoneText.Visible = true;
            }
            else
            {
                allDoneText.Visible = false;
            }
        }

        private void markComplete_Click(object sender, EventArgs e)
        {
            if (tasksListView.CheckedItems.Count > 0)
            {

                foreach (ListViewItem task in tasksListView.CheckedItems)
                {
                    Guid guid = new Guid(task.SubItems[1].Text);
                    MyTask checkedTask = mySchedule.tasks.FirstOrDefault(m => m.id == guid);

                    checkedTask.CompleteTask();

                    UpdateTasksListView();
                    UpdateDisplayOutstandingAndDueTodayTasksCount();
                }
            }
            else
            {
                MessageBox.Show("No tasks selected.", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void deleteTaskButton_Click(object sender, EventArgs e)
        {
            if (tasksListView.CheckedItems.Count > 0)
            {
                ConfirmDeleteTask confirmDialog = new ConfirmDeleteTask();

                if (tasksListView.CheckedItems.Count == 1)
                {
                    confirmDialog.confirmDeleteDialogText.Text = "Are you sure you want to delete this task?";
                }
                else
                {
                    confirmDialog.confirmDeleteDialogText.Text = "Are you sure you want to delete " + tasksListView.CheckedItems.Count + " tasks?";
                }

                DialogResult result = confirmDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    foreach (ListViewItem task in tasksListView.CheckedItems)
                    {
                        Guid guid = new Guid(task.SubItems[1].Text);
                        MyTask checkedTask = mySchedule.tasks.FirstOrDefault(m => m.id == guid);
                        mySchedule.tasks.Remove(checkedTask);
                    }
                    UpdateTasksListView();
                    UpdateDisplayOutstandingAndDueTodayTasksCount();
                }
            }
            else
            {
                MessageBox.Show("No tasks selected.", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void revertToOutstandingTask_Click(object sender, EventArgs e)
        {
            if (completedTasksListView.CheckedItems.Count > 0)
            {
                foreach (ListViewItem task in completedTasksListView.CheckedItems)
                {
                    Guid guid = new Guid(task.SubItems[1].Text);
                    Console.WriteLine(guid);
                    MyTask checkedTask = mySchedule.tasks.FirstOrDefault(m => m.id == guid);
                    checkedTask.UnCompleteTask();
                }
                UpdateTasksListView();
                UpdateDisplayOutstandingAndDueTodayTasksCount();
            }
            else
            {
                MessageBox.Show("No tasks selected.", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TasksListView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column == 3)
            {
                sortOutstandingTasksOrderAscending = !sortOutstandingTasksOrderAscending;
                tasksListView.Columns[3].Text = tasksListView.Columns[3].Text.Substring(0, tasksListView.Columns[3].Text.Length - 2);
                if (sortOutstandingTasksOrderAscending)
                {
                    tasksListView.Columns[3].Text += ascArrow;
                }
                else
                {
                    tasksListView.Columns[3].Text += descArrow;
                }
                UpdateTasksListView();
            }
        }
    }
}
