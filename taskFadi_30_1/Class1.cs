using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskFadi_30_1
{
    // This Class is created inorder to register the functions to the delegates 
    // since the functions are not static so we can't call them from Tha static main function
    public class Class1
    {
        ClassFadi1 Fad1 = new ClassFadi1();
        ClassFadi2 Fad2 = new ClassFadi2();
        ClassChristeen1 chr1 = new ClassChristeen1();
        ClassChristeen2 chr2 = new ClassChristeen2();
        F newF = new F();
        int x = 12;
        public void Execute()
        {
            FadA delFadA = Fad1.FadiA;
            delFadA = delFadA + Fad2.FadiA+ newF.FadiA;
            delFadA(x);

            FadB delFadB = Fad1.FadiB;
            delFadB = delFadB+Fad2.FadiB+ newF.FadiB;
            delFadB(x);
            Console.WriteLine("/////////////////////");

            ChrisB delChrisB = chr1.ChristeenB;
            delChrisB = delChrisB + chr2.ChristeenB+ newF.ChristeenB;
            delChrisB(x);
            Console.WriteLine("/////////////////////");

            TestandChrisA delTestChrisA = chr1.ChristeenA;
            delTestChrisA = delTestChrisA+chr2.ChristeenA+newF.ChristeenA+chr1.TestCommon+
                chr2.TestCommon+Fad1.TestCommon+Fad2.TestCommon+newF.TestCommon;
            delTestChrisA();
            Console.WriteLine("//////////////////////////////////////////////////////");

            FadChrist delFadChrist = newF.Christeen;
            delFadChrist += newF.Fadi;
            delFadChrist();

        }
    }
}
