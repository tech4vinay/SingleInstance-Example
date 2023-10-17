using SingleInstanceExample.Interfaces;

namespace SingleInstanceExample;
internal class MyClass : IInterfaceA, IInterfaceB
{
    public int InstanceIdentifier { get; }

    public MyClass()
    {
        InstanceIdentifier = Guid.NewGuid().GetHashCode();
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
