using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodinGame_WA
{
    public class HeritageA
    {
    }

    public class HeritageB: HeritageA
    {
    }

    public class Example
    {
        HeritageA a = new HeritageA();
        HeritageA b = new HeritageB();
    }
}
