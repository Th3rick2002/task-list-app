namespace app_de_tareas
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            buttonAddTask = new Button();
            buttonViewTask = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(126, 27);
            label1.Name = "label1";
            label1.Size = new Size(105, 21);
            label1.TabIndex = 0;
            label1.Text = "App de tareas";
            // 
            // buttonAddTask
            // 
            buttonAddTask.Location = new Point(44, 94);
            buttonAddTask.Name = "buttonAddTask";
            buttonAddTask.Size = new Size(89, 42);
            buttonAddTask.TabIndex = 1;
            buttonAddTask.Text = "Agregar tarea";
            buttonAddTask.UseVisualStyleBackColor = true;
            buttonAddTask.Click += buttonAddTask_Click;
            // 
            // buttonViewTask
            // 
            buttonViewTask.Location = new Point(230, 94);
            buttonViewTask.Name = "buttonViewTask";
            buttonViewTask.Size = new Size(89, 42);
            buttonViewTask.TabIndex = 2;
            buttonViewTask.Text = "Ver tareas";
            buttonViewTask.UseVisualStyleBackColor = true;
            buttonViewTask.Click += buttonViewTask_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(379, 207);
            Controls.Add(buttonViewTask);
            Controls.Add(buttonAddTask);
            Controls.Add(label1);
            Name = "MainForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonAddTask;
        private Button buttonViewTask;
    }
}
