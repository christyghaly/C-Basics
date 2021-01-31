using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using taskFadi_30_1.Interfaces;


namespace taskFadi_30_1
{
    public class ClassChristeen1:Christeen
    {
        public void ChristeenA()
        {
            Console.WriteLine("ClassChristeen1, interface Christeen");
        }

        public int ChristeenB(int b)
        {
            b += 1;
            Console.WriteLine("ClassChristeen1, interface Christeen b= " + b);
            return b;
        }

        public void TestCommon()
        {
            Console.WriteLine("TestCommon Christeen Class ClassChristeen1");
        }
    }
}
