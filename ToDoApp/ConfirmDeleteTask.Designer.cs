namespace ToDoApp
{
    partial class ConfirmDeleteTask
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
            this.btnCompleteTask = new System.Windows.Forms.Button();
            this.btnCancelComplete = new System.Windows.Forms.Button();
            this.confirmDeleteDialogText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCompleteTask
            // 
            this.btnCompleteTask.Location = new System.Drawing.Point(45, 46);
            this.btnCompleteTask.Margin = new System.Windows.Forms.Padding(4);
            this.btnCompleteTask.Name = "btnCompleteTask";
            this.btnCompleteTask.Size = new System.Drawing.Size(123, 28);
            this.btnCompleteTask.TabIndex = 0;
            this.btnCompleteTask.Text = "Delete Task(s)";
            this.btnCompleteTask.UseVisualStyleBackColor = true;
            this.btnCompleteTask.Click += new System.EventHandler(this.btnDeleteTask_Click);
            // 
            // btnCancelComplete
            // 
            this.btnCancelComplete.Location = new System.Drawing.Point(176, 46);
            this.btnCancelComplete.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelComplete.Name = "btnCancelComplete";
            this.btnCancelComplete.Size = new System.Drawing.Size(100, 28);
            this.btnCancelComplete.TabIndex = 1;
            this.btnCancelComplete.Text = "Cancel";
            this.btnCancelComplete.UseVisualStyleBackColor = true;
            this.btnCancelComplete.Click += new System.EventHandler(this.btnCancelDelete_Click);
            // 
            // confirmDeleteDialogText
            // 
            this.confirmDeleteDialogText.AutoSize = true;
            this.confirmDeleteDialogText.Location = new System.Drawing.Point(16, 11);
            this.confirmDeleteDialogText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.confirmDeleteDialogText.Name = "confirmDeleteDialogText";
            this.confirmDeleteDialogText.Size = new System.Drawing.Size(250, 16);
            this.confirmDeleteDialogText.TabIndex = 2;
            this.confirmDeleteDialogText.Text = "Are you sure you want to delete this task?";
            // 
            // ConfirmDeleteTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 97);
            this.Controls.Add(this.confirmDeleteDialogText);
            this.Controls.Add(this.btnCancelComplete);
            this.Controls.Add(this.btnCompleteTask);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ConfirmDeleteTask";
            this.Text = "Delete Task?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCompleteTask;
        private System.Windows.Forms.Button btnCancelComplete;
        public System.Windows.Forms.Label confirmDeleteDialogText;
    }
}