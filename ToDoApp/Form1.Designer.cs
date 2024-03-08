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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToDo));
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
            this.markComplete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tasksDueTodayCountDisplay = new System.Windows.Forms.TextBox();
            this.oustandingTasksCountDisplay = new System.Windows.Forms.TextBox();
            this.allDoneText = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // addTask
            // 
            this.addTask.Location = new System.Drawing.Point(82, 266);
            this.addTask.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addTask.Name = "addTask";
            this.addTask.Size = new System.Drawing.Size(119, 28);
            this.addTask.TabIndex = 0;
            this.addTask.Text = "Add Task";
            this.addTask.UseVisualStyleBackColor = true;
            this.addTask.Click += new System.EventHandler(this.addTask_Click);
            // 
            // addTaskTextBox
            // 
            this.addTaskTextBox.Location = new System.Drawing.Point(10, 53);
            this.addTaskTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.addTaskTextBox.Name = "addTaskTextBox";
            this.addTaskTextBox.Size = new System.Drawing.Size(263, 22);
            this.addTaskTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Task Name:";
            // 
            // myTasksLabel
            // 
            this.myTasksLabel.AutoSize = true;
            this.myTasksLabel.Location = new System.Drawing.Point(17, 169);
            this.myTasksLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.myTasksLabel.Name = "myTasksLabel";
            this.myTasksLabel.Size = new System.Drawing.Size(143, 16);
            this.myTasksLabel.TabIndex = 4;
            this.myTasksLabel.Text = "My Outstanding Tasks:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 598);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Completed Tasks:";
            // 
            // tasksListView
            // 
            this.tasksListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tasksListView.CheckBoxes = true;
            this.tasksListView.HideSelection = false;
            this.tasksListView.Location = new System.Drawing.Point(20, 200);
            this.tasksListView.Margin = new System.Windows.Forms.Padding(4);
            this.tasksListView.MultiSelect = false;
            this.tasksListView.Name = "tasksListView";
            this.tasksListView.Size = new System.Drawing.Size(1033, 310);
            this.tasksListView.TabIndex = 7;
            this.tasksListView.UseCompatibleStateImageBehavior = false;
            // 
            // completedTasksListView
            // 
            this.completedTasksListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.completedTasksListView.Enabled = false;
            this.completedTasksListView.HideSelection = false;
            this.completedTasksListView.Location = new System.Drawing.Point(20, 618);
            this.completedTasksListView.Margin = new System.Windows.Forms.Padding(4);
            this.completedTasksListView.MultiSelect = false;
            this.completedTasksListView.Name = "completedTasksListView";
            this.completedTasksListView.Size = new System.Drawing.Size(1033, 216);
            this.completedTasksListView.TabIndex = 8;
            this.completedTasksListView.UseCompatibleStateImageBehavior = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 91);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Description:";
            // 
            // addTaskDescription
            // 
            this.addTaskDescription.Location = new System.Drawing.Point(10, 111);
            this.addTaskDescription.Margin = new System.Windows.Forms.Padding(4);
            this.addTaskDescription.Multiline = true;
            this.addTaskDescription.Name = "addTaskDescription";
            this.addTaskDescription.Size = new System.Drawing.Size(261, 93);
            this.addTaskDescription.TabIndex = 10;
            // 
            // addTaskDueDate
            // 
            this.addTaskDueDate.Location = new System.Drawing.Point(10, 238);
            this.addTaskDueDate.Margin = new System.Windows.Forms.Padding(4);
            this.addTaskDueDate.Name = "addTaskDueDate";
            this.addTaskDueDate.Size = new System.Drawing.Size(263, 22);
            this.addTaskDueDate.TabIndex = 11;
            // 
            // addTaskDueDateLabel
            // 
            this.addTaskDueDateLabel.AutoSize = true;
            this.addTaskDueDateLabel.Location = new System.Drawing.Point(10, 218);
            this.addTaskDueDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addTaskDueDateLabel.Name = "addTaskDueDateLabel";
            this.addTaskDueDateLabel.Size = new System.Drawing.Size(67, 16);
            this.addTaskDueDateLabel.TabIndex = 12;
            this.addTaskDueDateLabel.Text = "Due Date:";
            // 
            // markComplete
            // 
            this.markComplete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.markComplete.Location = new System.Drawing.Point(19, 517);
            this.markComplete.Name = "markComplete";
            this.markComplete.Size = new System.Drawing.Size(185, 31);
            this.markComplete.TabIndex = 13;
            this.markComplete.Text = "Mark Task(s) Complete";
            this.markComplete.UseVisualStyleBackColor = true;
            this.markComplete.Click += new System.EventHandler(this.markComplete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.addTaskTextBox);
            this.groupBox1.Controls.Add(this.addTaskDueDate);
            this.groupBox1.Controls.Add(this.addTaskDueDateLabel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.addTaskDescription);
            this.groupBox1.Controls.Add(this.addTask);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(1100, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 316);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Task";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1091, 551);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(332, 319);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // tasksDueTodayCountDisplay
            // 
            this.tasksDueTodayCountDisplay.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tasksDueTodayCountDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tasksDueTodayCountDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tasksDueTodayCountDisplay.Location = new System.Drawing.Point(19, 26);
            this.tasksDueTodayCountDisplay.Multiline = true;
            this.tasksDueTodayCountDisplay.Name = "tasksDueTodayCountDisplay";
            this.tasksDueTodayCountDisplay.ReadOnly = true;
            this.tasksDueTodayCountDisplay.Size = new System.Drawing.Size(466, 27);
            this.tasksDueTodayCountDisplay.TabIndex = 16;
            this.tasksDueTodayCountDisplay.Text = "Calculating tasks due today";
            // 
            // oustandingTasksCountDisplay
            // 
            this.oustandingTasksCountDisplay.BackColor = System.Drawing.SystemColors.ControlLight;
            this.oustandingTasksCountDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.oustandingTasksCountDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oustandingTasksCountDisplay.Location = new System.Drawing.Point(20, 59);
            this.oustandingTasksCountDisplay.Multiline = true;
            this.oustandingTasksCountDisplay.Name = "oustandingTasksCountDisplay";
            this.oustandingTasksCountDisplay.ReadOnly = true;
            this.oustandingTasksCountDisplay.Size = new System.Drawing.Size(465, 35);
            this.oustandingTasksCountDisplay.TabIndex = 17;
            this.oustandingTasksCountDisplay.Text = "Calculating total oustanding tasks";
            // 
            // allDoneText
            // 
            this.allDoneText.BackColor = System.Drawing.SystemColors.ControlLight;
            this.allDoneText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.allDoneText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allDoneText.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.allDoneText.Location = new System.Drawing.Point(19, 98);
            this.allDoneText.Multiline = true;
            this.allDoneText.Name = "allDoneText";
            this.allDoneText.ReadOnly = true;
            this.allDoneText.Size = new System.Drawing.Size(465, 35);
            this.allDoneText.TabIndex = 18;
            this.allDoneText.Text = "Yay! You\'re all done :)";
            this.allDoneText.Visible = false;
            // 
            // ToDo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1440, 922);
            this.Controls.Add(this.allDoneText);
            this.Controls.Add(this.oustandingTasksCountDisplay);
            this.Controls.Add(this.tasksDueTodayCountDisplay);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.markComplete);
            this.Controls.Add(this.completedTasksListView);
            this.Controls.Add(this.tasksListView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.myTasksLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(968, 775);
            this.Name = "ToDo";
            this.Text = "To Do App";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Button markComplete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tasksDueTodayCountDisplay;
        private System.Windows.Forms.TextBox oustandingTasksCountDisplay;
        private System.Windows.Forms.TextBox allDoneText;
    }
}

