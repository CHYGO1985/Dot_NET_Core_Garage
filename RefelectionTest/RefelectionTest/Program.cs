using System;
using System.Reflection;
using CarLibrary;

/**
 * 
 * @author jingjiejiang
 * @history Nov 5, 2021
 * 1. test reflection
 * https://www.c-sharpcorner.com/blogs/setting-and-getting-private-variable-of-a-class-without-properties
 * 
 */
namespace RefelectionTest
{
    class Program
    {
        static void Main(string[] args)
        {

            Car c = new Car();
            Type typ = typeof(Car);
            FieldInfo type = typ.GetField("prvtVariable", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            var value = type.GetValue(c);
            Console.WriteLine(value);
        }
    }
}
