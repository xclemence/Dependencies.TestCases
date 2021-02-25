using Net.Cycle.Lib3;
using System;

namespace Net.Cycle.Lib2
{
    public class CycleLib2
    {
        public string Message() => $"Lib2 -> { new CycleLib3().Message()}";
    }
}
