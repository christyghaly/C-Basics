using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using taskFadi_30_1.Interfaces;

namespace taskFadi_30_1
{
    public class ClassFadi2:Fadi
    {
        public void FadiA(int x)
        {
            Console.WriteLine("From Fadi Interface,ClassFadi2 x= " + x);
        }

        public string FadiB(int x)
        {
            string res = "ClassFadi2 from Fadi Interface x=" + x.ToString();
            Console.WriteLine(res);
            return res;
        }

        public void TestCommon()
        {
            Console.WriteLine("TestCommon Fadi Class ClassFadi2");
        }
    }
}
