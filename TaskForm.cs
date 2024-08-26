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
    public partial class TaskForm : Form
    {
        private TaskManager _taskManager;

        public TaskForm(TaskManager taskManager)
        {
            InitializeComponent();
            _taskManager = taskManager;
            ConfigureDataGridView();
            LoadTasks();
        }

        private void ConfigureDataGridView()
        {
            if (dataGridViewTask.Columns.Count == 0)
            {
                dataGridViewTask.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "NameColumn",
                    HeaderText = "Nombre",
                    DataPropertyName = "Name",
                    Width = 150
                });

                dataGridViewTask.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "DescriptionColumn",
                    HeaderText = "Descripción",
                    DataPropertyName = "Description",
                    Width = 250
                });
            }

            dataGridViewTask.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTask.AutoGenerateColumns = true;
            dataGridViewTask.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadTasks()
        {
            var tasks = _taskManager.GetTasks();
            dataGridViewTask.DataSource = null;
            dataGridViewTask.DataSource = tasks;
        }

        private void buttonDeleteTask_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewTask.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewTask.SelectedRows[0];

                if (selectedRow.DataBoundItem is TaskList taskToRemove)
                {
                    _taskManager.RemoveTask(taskToRemove);
                    LoadTasks();
                }
                else
                {
                    MessageBox.Show("No se pudo obtener la tarea seleccionada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una tarea para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
