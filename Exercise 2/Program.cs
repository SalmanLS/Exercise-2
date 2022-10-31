using System;
using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace Exercise
{
    class program
    {
        private int[] luthfi = new int[29];
        private int[] genap = new int[29];
        private int[] ganjil = new int[29];
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
        public void bubbleSort()
        {
            for (int i = 1; i < n; i++)
            {
                for (int sls = 0; sls < n; j++)
                {
                    if (luthfi[sls] > luthfi[sls+1])
                    {
                        int temp;
                        temp = luthfi[sls];
                        luthfi[sls] = luthfi[sls+1];
                        luthfi[sls+1] = temp;
                    }
                }
            }
        }

        public void mergeSort(int low, int high, int mid)
        {
            if (low >= high)
                return;
            
        }
        static void Main(string[] args)
        {
            program myList = new program();
            int p;
            Console.WriteLine("");
            Console.WriteLine("Selamat Datang");
            Console.WriteLine("==============");
            Console.WriteLine("");
            Console.WriteLine("Pilih metode dibawah ini!");
            Console.WriteLine("1. Bubble Sort");
            Console.WriteLine("2. Merge Sort");
            Console.WriteLine("Pilih(1/2)");
            string l = Console.ReadLine();
            p = Int32.Parse(l);
            if (p == 1)
            {
                Console.Clear();
                myList.inputData();
                myList.bubbleSort();
                myList.displayData();
            }
            else if (p == 2)
            {
                Console.Clear();
                myList.inputData();
                myList.mergeSort();
                myList.displayData();
            }



        }
    }
}