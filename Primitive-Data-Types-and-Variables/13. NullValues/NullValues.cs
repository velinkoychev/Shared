using System;

class NullValues
{
    static void Main()
    {

        int? testIntegerValue = null;
        double? testDoubleValue = null;
        Console.WriteLine("Null Integer value =" + testIntegerValue);
        Console.WriteLine("Null Double value =" + testDoubleValue);
        testDoubleValue = 101.234;
        Console.WriteLine("Double value = " + testDoubleValue);
        testIntegerValue = 1203;
        Console.WriteLine("Integer value = " + testIntegerValue );
    }
}
