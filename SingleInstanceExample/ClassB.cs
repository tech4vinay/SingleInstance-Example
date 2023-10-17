using SingleInstanceExample.Interfaces;

namespace SingleInstanceExample;
internal class ClassB
{
    public readonly IInterfaceB InterfaceBInstance;

    public ClassB(IInterfaceB interfaceB)
    {
        InterfaceBInstance = interfaceB;
    }
}
