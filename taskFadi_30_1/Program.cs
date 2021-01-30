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

    //////////////  INTERFACES ///////////////////
    public interface Fadi
    {
        void FadiA(int x);
        string FadiB(int x);
        void TestCommon();
    }
    public interface Christeen
    {
        void ChristeenA();
        ref int ChristeenB(ref int b);
        void TestCommon();
    }

    interface FadiChr : Fadi, Christeen
    {
        string Christeen();
        string Fadi();
        new void TestCommon(); // Intended Hiding

    }

    //Classes

    public class ClassFadi1 : Fadi
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
    public class ClassFadi2 : Fadi
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
    public class ClassChristeen1 : Christeen
    {
        public void ChristeenA()
        {
            Console.WriteLine("ClassChristeen1, interface Christeen");
        }

        public ref int ChristeenB(ref int b)
        {
            b += 1;
            Console.WriteLine("ClassChristeen1, interface Christeen b= " + b);
            return ref b;
        }

        public void TestCommon()
        {
            Console.WriteLine("TestCommon Christeen Class ClassChristeen1");
        }
    }
    public class ClassChristeen2 : Christeen
    {
        public void ChristeenA()
        {
            Console.WriteLine("ClassChristeen2, interface Christeen");

        }

        public ref int ChristeenB(ref int b)
        {
            b += 12;
            Console.WriteLine("ClassChristeen2, interface Christeen b= " + b);
            return ref b;
        }

        public void TestCommon()
        {
            Console.WriteLine("TestCommon Christeen Class ClassChristeen2");
        }
    }
   
   public class F : FadiChr
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

        public ref int ChristeenB(ref int b)
        {
            b -= 2;
            Console.WriteLine("F Class, interface FadiChr b= " + b);

            return ref b;
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
   class Empty
    {

    }
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
