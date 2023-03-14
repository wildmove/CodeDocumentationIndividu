using System;
using System.Globalization;

namespace Exe1_ASD
{
    class Program
    {

        /// <summary>
        /// Deklarasi input array dengan nama <c>wildan</c> dengan jumlah maksimal 110
        /// </summary>
        private int[] wildan = new int[110];

        /// <summary>
        /// Deklarasi variabel int <c>n</c> untuk menyimpan banyaknya data pada array
        /// </summary>
        private int n;

        /// <summary>
        /// Method ini digunakan untuk menyimpan elemen array yang telah diinput
        /// <example>
        /// <br></br>
        /// Contoh:
        /// Masukkan banyaknya elemen pada Array: 20
        /// <br></br>
        /// Maka anda dapat menginputkan sebanyak 20 array
        /// </example>
        /// </summary>
        public void read()
        {
            while (true)
            {
                Console.Write("Masukkan banyaknya elemen pada Array: ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 110)
                    break;
                else
                    Console.WriteLine("\nArray dapat mempunyai maksimal 20 elemen.\n");
            }
            Console.WriteLine("");
            Console.WriteLine("-----------------------");
            Console.WriteLine(" Masukkan elemen array ");
            Console.WriteLine("-----------------------");



            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + "> ");
                string s1 = Console.ReadLine();
                wildan[i] = Int32.Parse(s1);
            }
        }

        /// <summary>
        /// Method yang digunakan untuk sortir Array menggunakan selection sort
        /// </summary>
        /// <returns>
        /// 1, 2, 3
        /// </returns>
        public void SortArray()
        {
            int min_index;
            int temp;

            for (int MA = 0; MA < n - 2; MA++) //step 1
            {
                min_index = MA;
                for (int i = MA + 1; i < n - 1; i++)
                {
                    if (wildan[i] < wildan[min_index]) //Jika elemen tidak dalam urutan yang benar
                    {
                        min_index = i;
                    }
                }
                //Tukar Elemen
                temp = wildan[min_index];
                wildan[min_index] = wildan[MA];
                wildan[MA] = temp;
            }
        }


        /// <summary>
        /// Method untuk menampilkan seluruh array yang telah di sortir dengan menggunakan looping
        /// <br></br>
        /// <example>
        /// Elemen Array sebelum di sortir : 3, 1, 2
        /// </example>
        /// </summary>
        /// <returns>
        /// 1, 2, 3
        /// </returns>
        public void display()
        {
            // Menampilkan array yang tersusun
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine(" Element array yang telah tersusun ");
            Console.WriteLine("-----------------------------------");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(wildan[i]);
            }
            Console.WriteLine("");
        }

        static void Main(String[] args)
        {
            // Creating the object of the BubbleSort class
            Program listKu = new Program();

            // Pemanggilan fungsi untuk menerima elemen array
            listKu.read();
            // Pemanggilan fungsi untuk mengurutkan array
            listKu.SortArray();
            // Pemanggilan fungsi untuk menampilkan array yang tersusun
            listKu.display();
            //Exit
            Console.WriteLine("\n\nTekan Tombol apa Saja Untuk Keluar.");
            Console.Read();
        }
    }

}

