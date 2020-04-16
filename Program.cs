using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CP1
{
    class Program
    {
        public static void HexaDecimals(ref string Final, double value)
        {
            char[] HexaDecimals = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            int[] Values = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };


            for (int i = 0; i < Values.Length; i++)
            {
                if (value == Values[i])
                    Final += HexaDecimals[i];
            }

        }

        public static string Rgb(int r, int g, int b)
        {
            if(r > 255) { r = 255; }
            else if(r < 0) { r = 0; }
            if (g > 255) { g = 255; }
            else if (g < 0) { g = 0; }
            if (b > 255) { b = 255; }
            else if (b < 0) { b = 0; }

            double newR = (double)r / 16;
            newR = System.Math.Round(newR, 2);
            double R2 = System.Math.Round((newR - System.Math.Truncate(newR)) * 16,0);
            double R1 = System.Math.Truncate(newR);

            double newG = (double)g / 16;
            newG = System.Math.Round(newG, 2);
            double G2 = System.Math.Round((newG - System.Math.Truncate(newG)) * 16, 0);
            double G1 = System.Math.Truncate(newG);

            double newB = (double)b / 16;
            newB = System.Math.Round(newB, 2);
            double B2 = System.Math.Round((newB - System.Math.Truncate(newB)) * 16, 0);
            double B1 = System.Math.Truncate(newB);

            string Final = "";
            HexaDecimals(ref Final,R1);
            HexaDecimals(ref Final, R2);
            HexaDecimals(ref Final, G1);
            HexaDecimals(ref Final, G2);
            HexaDecimals(ref Final, B1);
            HexaDecimals(ref Final, B2);

            return Final;

        }

        static void Main(string[] args)
        {
            string resp;
            int R, G, B;
            Console.Write("R: ");
            R = int.Parse(Console.ReadLine());
            Console.Write("G: ");
            G = int.Parse(Console.ReadLine());
            Console.Write("B: ");
            B = int.Parse(Console.ReadLine());
            resp = Rgb(R, G, B);


            Console.WriteLine("\nHexCode: #" + resp);
            Console.ReadKey();
        }
    }
}
