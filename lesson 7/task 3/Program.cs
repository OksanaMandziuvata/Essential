using System;

class MyClass
{
    public string change;
}

struct MyStruct
{
    public string change;
}

class Program
{
    static void ClassTaker(MyClass c)
    {
        c.change = "changed";
    }

    static void StructTaker(MyStruct s)
    {
        s.change = "changed";
    }

    static void Main()
    {
        MyClass testClass = new MyClass();
        MyStruct testStruct = new MyStruct();

        testClass.change = "not changed";
        testStruct.change = "not changed";

        ClassTaker(testClass);
        StructTaker(testStruct);

        Console.WriteLine("Class field = {0}", testClass.change);
        Console.WriteLine("Struct field = {0}", testStruct.change);

        Console.ReadKey();
    }
}
