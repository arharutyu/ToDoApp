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
            this.tasksListBox = new System.Windows.Forms.CheckedListBox();
            this.myTasksLabel = new System.Windows.Forms.Label();
            this.completedTasks = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addTask
            // 
            this.addTask.Location = new System.Drawing.Point(441, 62);
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
            this.addTaskTextBox.Location = new System.Drawing.Point(401, 37);
            this.addTaskTextBox.Name = "addTaskTextBox";
            this.addTaskTextBox.Size = new System.Drawing.Size(167, 20);
            this.addTaskTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(398, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Task:";
            // 
            // tasksListBox
            // 
            this.tasksListBox.FormattingEnabled = true;
            this.tasksListBox.Location = new System.Drawing.Point(12, 37);
            this.tasksListBox.Name = "tasksListBox";
            this.tasksListBox.Size = new System.Drawing.Size(292, 94);
            this.tasksListBox.TabIndex = 3;
            this.tasksListBox.SelectedIndexChanged += new System.EventHandler(this.tasksListBox_SelectedIndexChanged);
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
            // completedTasks
            // 
            this.completedTasks.FormattingEnabled = true;
            this.completedTasks.Location = new System.Drawing.Point(12, 193);
            this.completedTasks.Name = "completedTasks";
            this.completedTasks.Size = new System.Drawing.Size(292, 160);
            this.completedTasks.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Completed Tasks:";
            // 
            // ToDo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.completedTasks);
            this.Controls.Add(this.myTasksLabel);
            this.Controls.Add(this.tasksListBox);
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
        private System.Windows.Forms.CheckedListBox tasksListBox;
        private System.Windows.Forms.Label myTasksLabel;
        private System.Windows.Forms.ListBox completedTasks;
        private System.Windows.Forms.Label label2;
    }
}

