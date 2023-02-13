using System;
using System.Formats.Asn1;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Challenge03
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            var r = RomanNumber.Convert(1666);
            Console.WriteLine(r);
        }
    }

}