using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app_de_tareas
{
    public class TaskList
    {
        public string Name { get; private set; }
        public string Description { get; private set; }

        public TaskList(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}
