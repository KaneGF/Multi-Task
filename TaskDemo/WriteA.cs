using System;
using System.IO;
using System.Threading.Tasks;

namespace TaskDemo
{
    public class WriteA : ITask
    {
        public void Execute(string name, string text)
        {
            var path = Environment.CurrentDirectory;
            var fileName = name + ".txt";
            var fullPath = path + fileName;
            //if (!File.Exists(fullPath))
            //{
            //    File.Create(fullPath);
            //}

            //FileStream fs = new FileStream(fullPath, FileMode.Open);
            //StreamWriter sw = new StreamWriter(fs);
            //sw.WriteLine(text);
            //sw.Close();
            //sw.Dispose();
            //fs.Close();
            //fs.Dispose();


            string[] messages = new string[10];
            for (int i = 0; i < 10; i++)
            {
                messages[i] = i.ToString();
            }
            foreach (var msg in messages)
            {
                Task.Factory.StartNew(() =>
                   WriteSomting(msg, name)
                );
            }
        }

        private void WriteSomting(string s, string name)
        {
            Console.WriteLine("{0},{1}", s, name);
        }
    }
}
