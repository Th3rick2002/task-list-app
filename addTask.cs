using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app_de_tareas
{
    public partial class addTask : Form
    {
        private TaskManager _taskManager;
        public addTask(TaskManager taskManager)
        {
            InitializeComponent();
            _taskManager = taskManager;
        }

        private void buttonSaveTask_Click(object sender, EventArgs e)
        {
            string taskName = textBoxName.Text.Trim();
            string taskDescription = textBoxDescription.Text.Trim();

            if (string.IsNullOrEmpty(taskName) || string.IsNullOrEmpty(taskDescription))
            {
                MessageBox.Show("El nombre y la descripción de la tarea son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }
      
            _taskManager.AddTask(taskName, taskDescription);

            textBoxName.Clear();
            textBoxDescription.Clear();

            this.Close();

        }

        private void buttonClearTask_Click(object sender, EventArgs e)
        {
            textBoxName.Clear();
            textBoxDescription.Clear();
        }
    }
}
