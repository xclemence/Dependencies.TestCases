using Net.Cycle.Lib1;

namespace Net.Cycle.Lib3
{
    public class CycleLib3
    {
        public string Message() => $"Lib3 {new CycleLib1().Message()}";

    }
}
