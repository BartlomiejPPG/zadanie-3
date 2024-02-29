using System.IO;
using System;
using System.Text.RegularExpressions;
namespace baza
{
    class losowa
    {
        public static void Main(string[] args)
        {
            Random losowy = new Random();
            string[] imiona = { "Ania", "Kasia", "Basia", "Zofia" };
            string[] nazwiska = { "Kowalska", "Nowak" };
            string filePath = @"C:\Users\Praktyka\Desktop\praktyki3P2\Losowy\";
            StreamWriter sw = new StreamWriter(filePath + "users_" + DateTime.Now.ToString("yyyy_MM_ddhh_mm_ss") + ".txt");
            for (int i = 1; i <= 100; i++) 
            {   
                int a = losowy.Next(imiona.Length);
                int b = losowy.Next(nazwiska.Length);
                int c = losowy.Next(1990, 2001);
                sw.Write(i + ". " + imiona[a] + " " + nazwiska[b] + " " + c + '\n');
            }
            sw.Close();
            Console.WriteLine("Gotowe! Plik został zapisany w " + filePath);
        }
    }
}
