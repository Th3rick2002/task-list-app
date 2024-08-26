namespace app_de_tareas
{
    public partial class MainForm : Form
    {
        private addTask _addTaskForm;
        private TaskForm _taskForm;
        private TaskManager _taskManager;

        public MainForm()
        {
            InitializeComponent();
            _taskManager = new TaskManager();
            _taskManager.TaskAdded += OnTaskAdded;
            _taskManager.TaskRemoved += OnTaskRemoved;
        }

        private void buttonAddTask_Click(object sender, EventArgs e)
        {
            this.Hide();

            if (_addTaskForm == null || _addTaskForm.IsDisposed)
            {
                _addTaskForm = new addTask(_taskManager);
            }

            _addTaskForm.ShowDialog();
            this.Show();
        }

        private void buttonViewTask_Click(object sender, EventArgs e)
        {
            this.Hide();

            if (_taskForm == null || _taskForm.IsDisposed)
            {
                _taskForm = new TaskForm(_taskManager);
            }

            _taskForm.ShowDialog();
            this.Show();
        }

        private void OnTaskAdded(object sender, TaskEventArgs e)
        {
            MessageBox.Show($"Tarea agregada: {e.Task.Name}", "Tarea Agregada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void OnTaskRemoved(object sender, TaskEventArgs e)
        {
            MessageBox.Show($"Tarea eliminada: {e.Task.Name}", "Tarea Eliminada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
