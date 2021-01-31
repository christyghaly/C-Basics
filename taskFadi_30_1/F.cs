using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using taskFadi_30_1.Interfaces;

namespace taskFadi_30_1
{
    public class F: FadiChr
    {
        public string Christeen()
        {
            string chris = "From Class F, interface FadiChr, Function Christeen";
            Console.WriteLine(chris);
            return chris;
        }

        public void ChristeenA()
        {
            Console.WriteLine("F, interface FadiChr");
        }
        public  int ChristeenB( int b)
        {
            b -= 2;
            Console.WriteLine("F Class, interface FadiChr b= " + b);

            return  b;
        }

        public string Fadi()
        {
            string Fad = "From Class F, interface FadiChr,Function Fadi";
            Console.WriteLine(Fad);
            return Fad;
        }
        public void FadiA(int x)
        {
            Console.WriteLine("From FadiChr Interface,F class where x= " + x);
        }
       public string FadiB(int x)
        {
            string res = "F class from FadiChr Interface x=" + x.ToString();
            Console.WriteLine(res);
            return res;
        }
        public void TestCommon()
        {
            Console.WriteLine("TestCommon from FadiChr, F Class");
        }
    }
}
