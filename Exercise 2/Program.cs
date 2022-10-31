using System;
using System.Security.Cryptography.X509Certificates;

namespace Exercise
{
    class program
    {
        private int[] luthfi = new int[29];
        private int n;

        public void inputData()
        {
            while (true)
            {


                Console.WriteLine("Masukkan jumlah data pada array: ");
                string s = Console.ReadLine();
                n = int.Parse(s);
                if (n <= 29)
                    break;
                else
                    Console.WriteLine("\n Maksimal elemen pada array adalah 29 \n");
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"Masukkan elemen array ke-{i+1} :");
                    string s2 = Console.ReadLine();
                    luthfi[i] = int.Parse(s2);
                }
            }
        }
        public void displayData()
        {
            Console.WriteLine("");
            Console.WriteLine("=================================");
            Console.WriteLine("Elemen array yang telah tersusun:");
            Console.WriteLine("=================================");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{i}. {luthfi[i]}");
            }
            Console.WriteLine("");
        }
    }
}