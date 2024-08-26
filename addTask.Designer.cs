namespace app_de_tareas
{
    partial class addTask
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
            labelAddTask = new Label();
            textBoxName = new TextBox();
            labelTaskName = new Label();
            label3 = new Label();
            textBoxDescription = new TextBox();
            buttonSaveTask = new Button();
            buttonClearTask = new Button();
            SuspendLayout();
            // 
            // labelAddTask
            // 
            labelAddTask.AutoSize = true;
            labelAddTask.Font = new Font("Segoe UI", 15F);
            labelAddTask.Location = new Point(227, 37);
            labelAddTask.Name = "labelAddTask";
            labelAddTask.Size = new Size(132, 28);
            labelAddTask.TabIndex = 0;
            labelAddTask.Text = "Agregar tarea";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(199, 113);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(263, 23);
            textBoxName.TabIndex = 1;
            // 
            // labelTaskName
            // 
            labelTaskName.AutoSize = true;
            labelTaskName.Location = new Point(85, 116);
            labelTaskName.Name = "labelTaskName";
            labelTaskName.Size = new Size(108, 15);
            labelTaskName.TabIndex = 2;
            labelTaskName.Text = "Nombre de la tarea";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(124, 162);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 3;
            label3.Text = "Descripción";
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(199, 162);
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(263, 23);
            textBoxDescription.TabIndex = 4;
            // 
            // buttonSaveTask
            // 
            buttonSaveTask.Location = new Point(227, 232);
            buttonSaveTask.Name = "buttonSaveTask";
            buttonSaveTask.Size = new Size(75, 23);
            buttonSaveTask.TabIndex = 5;
            buttonSaveTask.Text = "Guardar";
            buttonSaveTask.UseVisualStyleBackColor = true;
            buttonSaveTask.Click += buttonSaveTask_Click;
            // 
            // buttonClearTask
            // 
            buttonClearTask.Location = new Point(329, 232);
            buttonClearTask.Name = "buttonClearTask";
            buttonClearTask.Size = new Size(75, 23);
            buttonClearTask.TabIndex = 6;
            buttonClearTask.Text = "Limpiar";
            buttonClearTask.UseVisualStyleBackColor = true;
            buttonClearTask.Click += buttonClearTask_Click;
            // 
            // addTask
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(567, 325);
            Controls.Add(buttonClearTask);
            Controls.Add(buttonSaveTask);
            Controls.Add(textBoxDescription);
            Controls.Add(label3);
            Controls.Add(labelTaskName);
            Controls.Add(textBoxName);
            Controls.Add(labelAddTask);
            Name = "addTask";
            Text = "addTask";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelAddTask;
        private TextBox textBoxName;
        private Label labelTaskName;
        private Label label3;
        private TextBox textBoxDescription;
        private Button buttonSaveTask;
        private Button buttonClearTask;
    }
}