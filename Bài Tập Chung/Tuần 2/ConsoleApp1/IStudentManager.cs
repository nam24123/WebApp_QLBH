using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp1
{
    internal interface IStudentManager
    {
        public abstract void StudentInsert();
        public abstract void StudentUpdate(int id);
        public abstract void StudentDelete(int id);

    }
}
