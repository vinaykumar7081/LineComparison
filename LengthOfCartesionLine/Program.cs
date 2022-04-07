using System;
namespace LengthOfCartesionLine
{
    class Program
    {
        public static void Main(String[] args)
        {
            LengthOfLine lineComparison = new LengthOfLine(2, 5, 6, 8);
            lineComparison.calculateLength();
            LengthOfLine line1 = new LengthOfLine(2, 5, 6, 8);
            line1.calculateLength();
            LengthOfLine line2 = new LengthOfLine(2, 5, 6, 8);
            line2.calculateLength();
            if (line1.Equals(line2))
            {
                Console.WriteLine("Both Lines are equals ");
            }
            else
            {
                Console.WriteLine("Both Lines are not equals ");
            }
        }
    }
}
