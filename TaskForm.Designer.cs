namespace app_de_tareas
{
    partial class TaskForm
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
            label1 = new Label();
            dataGridViewTask = new DataGridView();
            buttonDeleteTask = new Button();
            buttonMenu = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTask).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(196, 19);
            label1.Name = "label1";
            label1.Size = new Size(65, 28);
            label1.TabIndex = 0;
            label1.Text = "Tareas";
            // 
            // dataGridViewTask
            // 
            dataGridViewTask.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTask.Location = new Point(22, 59);
            dataGridViewTask.Name = "dataGridViewTask";
            dataGridViewTask.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridViewTask.Size = new Size(412, 164);
            dataGridViewTask.TabIndex = 1;
            // 
            // buttonDeleteTask
            // 
            buttonDeleteTask.Location = new Point(454, 95);
            buttonDeleteTask.Name = "buttonDeleteTask";
            buttonDeleteTask.Size = new Size(75, 23);
            buttonDeleteTask.TabIndex = 2;
            buttonDeleteTask.Text = "Eliminar";
            buttonDeleteTask.UseVisualStyleBackColor = true;
            buttonDeleteTask.Click += buttonDeleteTask_Click_1;
            // 
            // buttonMenu
            // 
            buttonMenu.Location = new Point(454, 153);
            buttonMenu.Name = "buttonMenu";
            buttonMenu.Size = new Size(75, 23);
            buttonMenu.TabIndex = 3;
            buttonMenu.Text = "Menu Principal";
            buttonMenu.UseVisualStyleBackColor = true;
            buttonMenu.Click += buttonMenu_Click;
            // 
            // TaskForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(553, 265);
            Controls.Add(buttonMenu);
            Controls.Add(buttonDeleteTask);
            Controls.Add(dataGridViewTask);
            Controls.Add(label1);
            Name = "TaskForm";
            Text = "TaskForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewTask).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridViewTask;
        private Button buttonDeleteTask;
        private Button buttonMenu;
    }
}