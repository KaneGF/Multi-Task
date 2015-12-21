using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskDemo
{
    public interface ITask
    {
        void Execute(string name,string text);
    }
}
