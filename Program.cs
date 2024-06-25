using System;
using System.Runtime.InteropServices;

namespace _02UnderstandingTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Part 1: Output the number of bytes, min, and max values for each type
            Console.WriteLine("{0,-10} {1,-20} {2,-30} {3,-30}", "Type", "Bytes", "Min Value", "Max Value");
            PrintTypeInfo<sbyte>("sbyte");
            PrintTypeInfo<byte>("byte");
            PrintTypeInfo<short>("short");
            PrintTypeInfo<ushort>("ushort");
            PrintTypeInfo<int>("int");
            PrintTypeInfo<uint>("uint");
            PrintTypeInfo<long>("long");
            PrintTypeInfo<ulong>("ulong");
            PrintTypeInfo<float>("float");
            PrintTypeInfo<double>("double");
            PrintTypeInfo<decimal>("decimal");

            // Part 2: Convert centuries to various time units
            Console.Write("Enter number of centuries: ");
            int centuries;
            if (int.TryParse(Console.ReadLine(), out centuries))
            {
                ConvertCenturies(centuries);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter an integer.");
            }
        }

        static void PrintTypeInfo<T>(string typeName) where T : struct, IComparable, IFormattable, IConvertible
        {
            Console.WriteLine("{0,-10} {1,-20} {2,-20} {3,-20}", typeName, Marshal.SizeOf(typeof(T)), Convert.ToString(GetMinValue<T>()), Convert.ToString(GetMaxValue<T>()));
        }

        static T GetMinValue<T>() where T : struct, IComparable, IFormattable, IConvertible
        {
            return (T)typeof(T).GetField("MinValue").GetValue(null);
        }

        static T GetMaxValue<T>() where T : struct, IComparable, IFormattable, IConvertible
        {
            return (T)typeof(T).GetField("MaxValue").GetValue(null);
        }

        static void ConvertCenturies(int centuries)
        {
            int years = centuries * 100;
            int days = (int)(years * 365.24); // average including leap years
            int hours = days * 24;
            long minutes = hours * 60L;
            long seconds = minutes * 60L;
            long milliseconds = seconds * 1000L;
            long microseconds = milliseconds * 1000L;
            long nanoseconds = microseconds * 1000L;

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
        }
    }
}
