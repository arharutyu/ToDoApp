namespace ToDoApp
{
    partial class ToDo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addTask = new System.Windows.Forms.Button();
            this.addTaskTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.myTasksLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tasksListView = new System.Windows.Forms.ListView();
            this.completedTasksListView = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.addTaskDescription = new System.Windows.Forms.TextBox();
            this.addTaskDueDate = new System.Windows.Forms.DateTimePicker();
            this.addTaskDueDateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addTask
            // 
            this.addTask.Location = new System.Drawing.Point(694, 241);
            this.addTask.Margin = new System.Windows.Forms.Padding(2);
            this.addTask.Name = "addTask";
            this.addTask.Size = new System.Drawing.Size(89, 23);
            this.addTask.TabIndex = 0;
            this.addTask.Text = "Add Task";
            this.addTask.UseVisualStyleBackColor = true;
            this.addTask.Click += new System.EventHandler(this.addTask_Click);
            // 
            // addTaskTextBox
            // 
            this.addTaskTextBox.Location = new System.Drawing.Point(694, 37);
            this.addTaskTextBox.Name = "addTaskTextBox";
            this.addTaskTextBox.Size = new System.Drawing.Size(198, 20);
            this.addTaskTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(692, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Task Name:";
            // 
            // myTasksLabel
            // 
            this.myTasksLabel.AutoSize = true;
            this.myTasksLabel.Location = new System.Drawing.Point(12, 21);
            this.myTasksLabel.Name = "myTasksLabel";
            this.myTasksLabel.Size = new System.Drawing.Size(116, 13);
            this.myTasksLabel.TabIndex = 4;
            this.myTasksLabel.Text = "My Outstanding Tasks:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Completed Tasks:";
            // 
            // tasksListView
            // 
            this.tasksListView.HideSelection = false;
            this.tasksListView.Location = new System.Drawing.Point(15, 37);
            this.tasksListView.Name = "tasksListView";
            this.tasksListView.Size = new System.Drawing.Size(503, 227);
            this.tasksListView.TabIndex = 7;
            this.tasksListView.UseCompatibleStateImageBehavior = false;
            this.tasksListView.SelectedIndexChanged += new System.EventHandler(this.tasksListView_SelectedIndexChanged);
            // 
            // completedTasksListView
            // 
            this.completedTasksListView.HideSelection = false;
            this.completedTasksListView.Location = new System.Drawing.Point(15, 351);
            this.completedTasksListView.Name = "completedTasksListView";
            this.completedTasksListView.Size = new System.Drawing.Size(503, 176);
            this.completedTasksListView.TabIndex = 8;
            this.completedTasksListView.UseCompatibleStateImageBehavior = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(692, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Description:";
            // 
            // addTaskDescription
            // 
            this.addTaskDescription.Location = new System.Drawing.Point(695, 89);
            this.addTaskDescription.Multiline = true;
            this.addTaskDescription.Name = "addTaskDescription";
            this.addTaskDescription.Size = new System.Drawing.Size(197, 76);
            this.addTaskDescription.TabIndex = 10;
            // 
            // addTaskDueDate
            // 
            this.addTaskDueDate.Location = new System.Drawing.Point(694, 200);
            this.addTaskDueDate.Name = "addTaskDueDate";
            this.addTaskDueDate.Size = new System.Drawing.Size(198, 20);
            this.addTaskDueDate.TabIndex = 11;
            // 
            // addTaskDueDateLabel
            // 
            this.addTaskDueDateLabel.AutoSize = true;
            this.addTaskDueDateLabel.Location = new System.Drawing.Point(695, 181);
            this.addTaskDueDateLabel.Name = "addTaskDueDateLabel";
            this.addTaskDueDateLabel.Size = new System.Drawing.Size(56, 13);
            this.addTaskDueDateLabel.TabIndex = 12;
            this.addTaskDueDateLabel.Text = "Due Date:";
            // 
            // ToDo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 539);
            this.Controls.Add(this.addTaskDueDateLabel);
            this.Controls.Add(this.addTaskDueDate);
            this.Controls.Add(this.addTaskDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.completedTasksListView);
            this.Controls.Add(this.tasksListView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.myTasksLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addTaskTextBox);
            this.Controls.Add(this.addTask);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ToDo";
            this.Text = "To Do App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addTask;
        private System.Windows.Forms.TextBox addTaskTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label myTasksLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView tasksListView;
        private System.Windows.Forms.ListView completedTasksListView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addTaskDescription;
        private System.Windows.Forms.DateTimePicker addTaskDueDate;
        private System.Windows.Forms.Label addTaskDueDateLabel;
    }
}

