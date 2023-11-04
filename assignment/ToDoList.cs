using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace regular
{
    internal class ToDoList
    {
        private List<TaskItem> tasks;
        public ToDoList()
        {
            tasks = new List<TaskItem>();
        }


    public void AddTask(string taskdescription)
        {
            int taskId = tasks.Count + 1;
            TaskItem task = new TaskItem(taskId, taskdescription);
            tasks.Add(task);
            Console.WriteLine("Task added: " + taskdescription);
        }
        public void RemoveTask(int taskId)
        {
            TaskItem taskToRemove = tasks.Find(t => t.TaskId == taskId);
            if (taskToRemove != null)
            {
                tasks.Remove(taskToRemove);
                Console.WriteLine("Task removed: " + taskToRemove.TaskDescription);
            }
            else
            {
                Console.WriteLine("Task not found. ");
            }
        }
        public void MarkTaskAsCompleted(int taskId)
        {
            TaskItem taskToComplete = tasks.Find(t => t.TaskId == taskId);
            if ((taskToComplete != null))
            {
                taskToComplete.IsCompleted = true;
                Console.WriteLine("Task marked as completed: " + taskToComplete.TaskDescription);

            }
            else
            {
                Console.WriteLine("Task not found. ");
            }
        }
        public void DisplayTasks()
        {
            Console.WriteLine("Task List: ");
            foreach (var task in tasks)
            {
                Console.WriteLine($"{task.TaskId}. {task.TaskDescription} (Completed: {task.IsCompleted})");
            }
        }
        public void DisplayPendingTasks()
        {
            Console.WriteLine("Pending Tasks:");
            var pendingTasks = tasks.Where(testc => !testc.IsCompleted).ToList();
            foreach (var task in pendingTasks)
            {
                Console.WriteLine($"{task.TaskId}. {task.TaskDescription}");
            }
        }
        public void DisplayCompletedTasks()
        {
            Console.WriteLine("Completed Tasks:");
            var completedTasks = tasks.Where(testc => testc.IsCompleted).ToList();
            foreach (var task in completedTasks)
            {
                Console.WriteLine($"{task.TaskId}. {task.TaskDescription}");
            }
        }
    }
}
