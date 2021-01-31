using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskFadi_30_1.Interfaces
{
    public interface FadiChr:Fadi,Christeen
    {
        string Christeen();
        string Fadi();
        new void TestCommon(); // Intended Hiding
    }
}
