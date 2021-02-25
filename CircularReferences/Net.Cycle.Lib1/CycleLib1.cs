using Net.Cycle.Lib2;
using System;

namespace Net.Cycle.Lib1
{
    public class CycleLib1
    {
        public string Message() => $"Lib1 -> { new CycleLib2().Message()}";

    }
}
