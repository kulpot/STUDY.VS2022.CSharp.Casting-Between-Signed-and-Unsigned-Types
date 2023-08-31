using System;

//ref link:https://www.youtube.com/watch?v=622n70ceMSM&list=PLRwVmtr-pp07XP8UBiUJ0cyORVCmCgkdA&index=23
//

class MainClass
{       // requires binary knowledge -- sign or unsign
    static void Main()
    {   //- Human (TypeName)         - Compiler(UsingTypeName)
        byte b = 0;                 // System.Byte  -- 8bits -- unsigned type  -- efficient maximum needed for 255 values
        Console.WriteLine(byte.MaxValue);   // 255
        Console.WriteLine(byte.MinValue);   // 0


        //------------------ cast here-------------------
        byte numPeopleInFamily = 200;
        // signedVersion = numPeopleInFamily;  // error cant convert byte to sbyte
        sbyte signedVersion = (sbyte)numPeopleInFamily; // cast (sbyte) 
        Console.WriteLine(signedVersion);   // -56
        //-----------------------------------------------


        sbyte sb = 0;               // System.SByte   -- signed -- 255/2
        Console.WriteLine(sbyte.MaxValue);   // 127
        Console.WriteLine(sbyte.MinValue);   // -128

        short s = 0;                // System.Int16    -- short interpret as signed
        Console.WriteLine(short.MaxValue);   // 32767
        Console.WriteLine(short.MinValue);   // -32768


        ushort us = 0;              // System.UInt16 -- unsign version or unshort
        int i = 0;                  // System.Int32     -- 4 bytes -- 32bits    
        uint ui = 0;                // System.UInt32
        long l = 0;                 // System.Int64
        ulong ul = 0;               // System.UInt64
        float f = 0;                // System.Single
        double d = 0;               // System.Double
        char c = '\0';              // System.Char
        bool bl = false;            // System.Boolean
        string st = "";             // System.String
        decimal dc = 0;             // System.Decimal

        ///



        Console.WriteLine(short.MaxValue);   // 32767
        Console.WriteLine(ushort.MaxValue);   // 65535
        Console.WriteLine(int.MaxValue);   // 2147483647
        Console.WriteLine(uint.MaxValue);   // 4294967295
        Console.WriteLine(long.MaxValue);   // 9223372036854775807
        Console.WriteLine(ulong.MaxValue);   // 18446744073709551615
        Console.WriteLine(float.MaxValue);   // 3.4028235E+38
        Console.WriteLine(double.MaxValue);   // 1.7976931348623157E+308
        Console.WriteLine(char.MaxValue);   // ?

        Console.WriteLine(decimal.MaxValue);   // 79228162514264337593543950335
    }
}