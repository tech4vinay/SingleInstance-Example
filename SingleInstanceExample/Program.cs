using Autofac;
using SingleInstanceExample;
using SingleInstanceExample.Interfaces;

var builder = new ContainerBuilder();

// Register MyClass as single instance
builder.RegisterType<MyClass>().As<IInterfaceA>().As<IInterfaceB>().SingleInstance();
builder.RegisterType<ClassA>().AsSelf();
builder.RegisterType<ClassB>().AsSelf();

var container = builder.Build();

// Resolve ClassA and ClassB from the container
var classA = container.Resolve<ClassA>();
var classB = container.Resolve<ClassB>();

// Check if both instances have the same instance and unique identifier
var isSameInstance = classA.InterfaceAInstance is MyClass myClassA &&
                     classB.InterfaceBInstance is MyClass myClassB &&
                     myClassA.InstanceIdentifier == myClassB.InstanceIdentifier;

Console.WriteLine("Do ClassA and ClassB share the same MyClass instance: " + isSameInstance);