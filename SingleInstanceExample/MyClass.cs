using SingleInstanceExample.Interfaces;

namespace SingleInstanceExample;
internal class MyClass : IInterfaceA, IInterfaceB
{
    public Guid InstanceIdentifier { get; }

    public MyClass()
    {
        InstanceIdentifier = Guid.NewGuid();
    }

    public void DoThingA()
    {
        throw new NotImplementedException();
    }

    public void DoThingB()
    {
        throw new NotImplementedException();
    }
}
