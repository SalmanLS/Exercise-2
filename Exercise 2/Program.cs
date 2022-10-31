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

            }
        }
    }
}