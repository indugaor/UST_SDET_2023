using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace regular
{
    internal class TaskItem
    {
        public TaskItem(int taskId, string? taskDescription)
        {
            TaskId = taskId;
            TaskDescription = taskDescription;
            IsCompleted = false;
        }

        public int TaskId { get; set; }
        public string? TaskDescription { get; set; }
        public bool IsCompleted { get; set; }

    }
}