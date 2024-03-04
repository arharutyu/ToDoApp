namespace ToDoApp
{
    partial class ConfirmCompleteTask
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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCompleteTask
            // 
            this.btnCompleteTask.Location = new System.Drawing.Point(34, 37);
            this.btnCompleteTask.Name = "btnCompleteTask";
            this.btnCompleteTask.Size = new System.Drawing.Size(92, 23);
            this.btnCompleteTask.TabIndex = 0;
            this.btnCompleteTask.Text = "Mark Complete";
            this.btnCompleteTask.UseVisualStyleBackColor = true;
            this.btnCompleteTask.Click += new System.EventHandler(this.btnCompleteTask_Click);
            // 
            // btnCancelComplete
            // 
            this.btnCancelComplete.Location = new System.Drawing.Point(132, 37);
            this.btnCancelComplete.Name = "btnCancelComplete";
            this.btnCancelComplete.Size = new System.Drawing.Size(75, 23);
            this.btnCancelComplete.TabIndex = 1;
            this.btnCancelComplete.Text = "Cancel";
            this.btnCancelComplete.UseVisualStyleBackColor = true;
            this.btnCancelComplete.Click += new System.EventHandler(this.btnCancelComplete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Are you sure you want to complete this task?";
            // 
            // ConfirmCompleteTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 79);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelComplete);
            this.Controls.Add(this.btnCompleteTask);
            this.Name = "ConfirmCompleteTask";
            this.Text = "Complete Task?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCompleteTask;
        private System.Windows.Forms.Button btnCancelComplete;
        private System.Windows.Forms.Label label1;
    }
}