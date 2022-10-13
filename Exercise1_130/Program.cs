using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercisefurji
{
    class program
    {
        //Deklarasi array int dengan ukuran 50
        private int[] a = new int[50];

        //Deklarasi variabel int untuk menyimpan banyaknya data pada array
        private int n;

        // Fungsi / Method untuk menerima masukan
        public void read()
        {

            //menerima angka untuk menentukan banyaknya data yang disimpan pada
            while (true)
            {
                Console.Write("Masukkan Angka pada Array: ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 50)
 
                    break;
                else
                    Console.WriteLine("\nArray dapat mempunyai maksimal 50 elemen.\n");
            }
            Console.WriteLine("");
            Console.WriteLine("============================");
            Console.WriteLine(" Masukkan Data Elemen Array ");
            Console.WriteLine("============================");

            // Pengguna memasukkan elemen pada array
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("<" + (i + 1) + "> ");
                string s1 = Console.ReadLine();
                a[i] = Int32.Parse(s1);
            }
        }
        public void display()
        {
            //Menampilkan array yang tersusun
            Console.WriteLine("");
            Console.WriteLine("====================================");
            Console.WriteLine(" Element Array yang telah disusun ");
            Console.WriteLine("====================================");
            for (int fi = 0; fi < n; fi++)
            {
                Console.WriteLine(a[fi]);
            }
            Console.WriteLine("");

        }
        public void Mengurutkan()
        {
            for (int i = 0; i < a.Length; i++) // For n - 1 passes
            {
                // pada pass i, bandingkan n-1 elemen 1 pertama dengan elemen selanjutnya
                for (int fi = 0; fi < n - i; fi++)
                 
                {
                    if (a[fi] > a[fi + 1]) // Jika elemen tidak dalam urutan yang benar
                    {
                        // Tukar elemen
                        int temp = a[fi];
                        temp = a[fi];
                        a[fi] = a[fi + 1];
                        a[fi + 1] = temp;

                    }
                }

            }

        }
        static void Main(string[] args)
        {   // membuat object pada class mengurutkan
            program myList = new program();

            // Pemanggilann fungsi untuk menerima elemen array
            myList.read();
            // Pemanggilan funsi untuk mengurutkan array
            myList.Mengurutkan();
            // Pemanggilan fungsi untuk menampilkan array yang tersusun
            myList.display();
            // Exit
            Console.WriteLine("\n\nTekan Tombol Apa saja untuk keluar.");
            Console.WriteLine("Sekian Terimakasih, Sudah berusaha");
            Console.Read();
        }
    }
}
