using SingleInstanceExample.Interfaces;

namespace SingleInstanceExample;
internal class ClassA
{
    public readonly IInterfaceA InterfaceAInstance;

    public ClassA(IInterfaceA interfaceA)
    {
        InterfaceAInstance = interfaceA;
    }
}
