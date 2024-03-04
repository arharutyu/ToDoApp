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

            // Temporarily detach the event handler to avoid automatic selection
            tasksListView.SelectedIndexChanged -= tasksListView_SelectedIndexChanged;

            UpdateTasksListView();

            // Reattach the event handler
            tasksListView.SelectedIndexChanged += tasksListView_SelectedIndexChanged;

            addTaskTextBox.Text = "";
            addTaskDescription.Text = "";
            addTaskDueDate.Value = DateTime.Now;

            MessageBox.Show("Task added: " + taskText, "Task Added");
        }

        private bool isTaskOverdue(string dueDate)
        {
            DateTime currentDate = DateTime.Today;
            string dateTimeFormat = "dd-MM-yyyy";

            if (DateTime.TryParseExact(dueDate, dateTimeFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime result))
            {
                return result < currentDate;
            }
            else
            {
                // Handle the case where the due date couldn't be parsed
                throw new ArgumentException("Invalid due date format", nameof(dueDate));
            }
        }

        private void UpdateTasksListView()
        {
            // Save the selected index before updating the data source
            int selectedTaskIndex = tasksListView.SelectedIndices.Count > 0 ? tasksListView.SelectedIndices[0] : -1;

            tasksListView.Items.Clear();
            foreach (MyTask task in mySchedule.tasks.Where(task => !task.completed))
            {
                ListViewItem item = new ListViewItem(task.name);
                item.SubItems.Add(task.description);
                item.SubItems.Add(task.dueDate.ToString("dd-MM-yyyy"));

                if (isTaskOverdue(task.dueDate.ToString("dd-MM-yyyy")))
                {
                    item.ForeColor = Color.Red;
                }

                tasksListView.Items.Add(item);
            }

            // Restore the selection if it was saved
            if (selectedTaskIndex != -1 && selectedTaskIndex < tasksListView.Items.Count)
            {
                tasksListView.Items[selectedTaskIndex].Selected = true;
            }

            completedTasksListView.Items.Clear();
            foreach (MyTask task in mySchedule.completedTasks)
            {
                ListViewItem item = new ListViewItem(task.name);
                item.SubItems.Add(task.description);
                item.SubItems.Add(task.dueDate.ToString("dd-MM-yyyy"));
                item.SubItems.Add(task.completedDate.ToString("dd-MM-yyyy"));
                completedTasksListView.Items.Add(item);
            }
        }

        private void tasksListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Display the confirmation dialog
            using (var confirmationDialog = new ConfirmCompleteTask())
            {
                var result = confirmationDialog.ShowDialog();

                // Check the result of the confirmation dialog
                if (result == DialogResult.Yes)
                {
                    if (!updatingListView && tasksListView.SelectedItems.Count > 0)
                    {
                        ListViewItem selectedItem = tasksListView.SelectedItems[0];
                        int selectedIndex = tasksListView.Items.IndexOf(selectedItem);

                        MyTask selectedTask = mySchedule.tasks
                            .Where(task => !task.completed)
                            .ElementAtOrDefault(selectedIndex);

                        if (selectedTask != null && !selectedTask.completed)
                        {
                            // Mark the selected task as complete
                            selectedTask.CompleteTask();

                            // Move the task from tasks to completedTasks
                            mySchedule.tasks.Remove(selectedTask);
                            mySchedule.completedTasks.Add(selectedTask);

                            // Update the data binding
                            updatingListView = true;
                            UpdateTasksListView();
                            updatingListView = false;
                        }
                    }
                }
                // If "Cancel" is clicked, do nothing
            }
        }

    }

}
