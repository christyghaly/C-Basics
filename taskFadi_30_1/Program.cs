using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskFadi_30_1
{
    //Deleagtes for adding functions inorder not to customize the lines written while calling the functions
    public delegate void FadA(int x);//FadiA
    public delegate string FadB(int x);//FadiB

    public delegate ref int ChrisB(ref int x);//ChristeenB

    public delegate void TestandChrisA();// TestCommon,ChristeenA
    public delegate string FadChrist();//Fadi,Christeen



    class Program
    {
        public static void Main(string[] args)
        {
            Class1 cls = new Class1();
            cls.Execute();
            Console.ReadKey();
        }
    }
}
