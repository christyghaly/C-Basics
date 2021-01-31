using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using taskFadi_30_1.Interfaces;

namespace taskFadi_30_1
{
    public class ClassFadi1:Fadi
    {
        public void FadiA(int x)
        {
            Console.WriteLine("From Fadi Interface,ClassFadi1 x= " + x);
        }

        public string FadiB(int x)
        {
            string res = "ClassFadi1 from Fadi Interface x=" + x.ToString();
            Console.WriteLine(res);
            return res;
        }

        public void TestCommon()
        {
            Console.WriteLine("TestCommon Fadi Class ClassFadi1");
        }
    }
}
