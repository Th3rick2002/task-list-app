using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app_de_tareas
{
    public class TaskEventArgs : EventArgs
    {
        public TaskList Task { get; }
        public TaskEventArgs(TaskList task)
        {
            Task = task;
        }
    }

    public class TaskManager
    {
        private List<TaskList> _tasks = new List<TaskList>();
        public event EventHandler<TaskEventArgs> TaskAdded;
        public event EventHandler<TaskEventArgs> TaskRemoved;

        public void AddTask(string name, string description)
        {
            var task = new TaskList(name, description);
            _tasks.Add(task);
            OnTaskAdded(new TaskEventArgs(task));
        }

        public void RemoveTask(TaskList task)
        {
            if (_tasks.Remove(task))
            {
                OnTaskRemoved(new TaskEventArgs(task));
            }
        }

        public List<TaskList> GetTasks()
        {
            return _tasks;
        }

        protected virtual void OnTaskAdded(TaskEventArgs e)
        {
            TaskAdded?.Invoke(this, e);
        }

        protected virtual void OnTaskRemoved(TaskEventArgs e)
        {
            TaskRemoved?.Invoke(this, e);
        }
    }
}
