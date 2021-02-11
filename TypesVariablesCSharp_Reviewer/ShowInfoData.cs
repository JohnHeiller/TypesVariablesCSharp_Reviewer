using System;
using System.Collections.Generic;
using System.Text;

namespace TypesVariablesCSharp_Reviewer
{
    class ShowInfoData
    {
        public static void NumericTypes()
        {
            //List<dynamic> types = new List<dynamic>() { new byte(), new sbyte(), new int(), new long(), new float(), new short(), new ushort() }; 
            Console.WriteLine("Basic description for each type of numeric variables");
            //foreach (var type in types)
            //{
            //    Console.WriteLine(type.GetType().Name + ": has " + type.GetType().TypeHandle.Value + " Bytes, ");
            //    Console.WriteLine("with a MinValue = " + type.GetType().GetField("MinValue") + " and a MaxValue = " + type.GetType().GetField("MaxValue"));
            //}
            Console.WriteLine("byte or technically " + typeof(byte) + ": has " + sizeof(byte) + " Byte, ");
            Console.WriteLine("with a MinValue = " + byte.MinValue + " and a MaxValue = " + byte.MaxValue);
            Console.WriteLine("sbyte or technically " + typeof(sbyte) + ": has " + sizeof(sbyte) + " Byte, ");
            Console.WriteLine("with a MinValue = " + sbyte.MinValue + " and a MaxValue = " + sbyte.MaxValue);
            Console.WriteLine("int or technically " + typeof(int) + ": has " + sizeof(int) + " Bytes, ");
            Console.WriteLine("with a MinValue = " + int.MinValue + " and a MaxValue = " + int.MaxValue);
            Console.WriteLine("uint or technically " + typeof(uint) + ": has " + sizeof(uint) + " Bytes, ");
            Console.WriteLine("with a MinValue = " + uint.MinValue + " and a MaxValue = " + uint.MaxValue);
            Console.WriteLine("long or technically " + typeof(long) + ": has " + sizeof(long) + " Bytes, ");
            Console.WriteLine("with a MinValue = " + long.MinValue + " and a MaxValue = " + long.MaxValue);
            Console.WriteLine("ulong or technically " + typeof(ulong) + ": has " + sizeof(ulong) + " Bytes, ");
            Console.WriteLine("with a MinValue = " + ulong.MinValue + " and a MaxValue = " + ulong.MaxValue);
            Console.WriteLine("short or technically " + typeof(short) + ": has " + sizeof(short) + " Bytes, ");
            Console.WriteLine("with a MinValue = " + short.MinValue + " and a MaxValue = " + short.MaxValue);
            Console.WriteLine("ushort or technically " + typeof(ushort) + ": has " + sizeof(ushort) + " Bytes, ");
            Console.WriteLine("with a MinValue = " + ushort.MinValue + " and a MaxValue = " + ushort.MaxValue);
            Console.WriteLine("float or technically " + typeof(float) + ": has " + sizeof(float) + " Bytes, ");
            Console.WriteLine("with a MinValue = " + float.MinValue + " and a MaxValue = " + float.MaxValue);
            Console.WriteLine("double or technically " + typeof(double) + ": has " + sizeof(double) + " Bytes, ");
            Console.WriteLine("with a MinValue = " + double.MinValue + " and a MaxValue = " + double.MaxValue);
            Console.WriteLine("decimal or technically " + typeof(decimal) + ": has " + sizeof(decimal) + " Bytes, ");
            Console.WriteLine("with a MinValue = " + decimal.MinValue + " and a MaxValue = " + decimal.MaxValue);
        }

        public static void OtherTypes()
        {
            Console.WriteLine("Basic description for each type of other variables");
            Console.WriteLine("char or technically " + typeof(char) + ": has " + sizeof(char) + " Bytes, ");
            Console.WriteLine("with a MinValue = '" + char.MinValue + "' and a MaxValue = '" + char.MaxValue + "'");
            Console.WriteLine("bool or technically " + typeof(bool) + ": has " + sizeof(bool) + " Byte, ");
            Console.WriteLine("with a FirstValue = '" + bool.FalseString + "' and a SecondValue = '" + bool.TrueString + "'"); 
        }
    }
}
