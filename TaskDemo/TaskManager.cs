using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TaskDemo
{
    public class TaskManager
    {
        private static object Lock = new object();
        private static TaskManager manage;
        public static Dictionary<int, string> dic = new Dictionary<int, string>();
        private Task[] tasks;

        public static TaskManager Instance
        {
            get
            {
                lock (Lock)
                {
                    manage = manage ?? new TaskManager();
                }
                return manage;
            }
        }

        public TaskManager()
        {
            var task = new Task(() => Start());
            task.Start();
        }

        private void Start()
        {
            tasks = new Task[10];

            string[] messages = new string[10];
            for (int i = 20; i < 30; i++)
            {
                messages[i - 20] = i.ToString();
            }
            foreach (var msg in messages)
            {
                Task.Factory.StartNew(() => new WriteA().Execute(msg, msg));
            }
        }
    }
}
