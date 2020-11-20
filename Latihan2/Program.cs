using System;

namespace Latihan2
{
    class Program
    {
        static void Main(string[] args)
        {
            float bilPertama,bilKedua,hasil;
            String pilihan;

            Console.WriteLine("Kalkulator Sederhana!");
            Console.Write("Masukkan Bilangan Pertama : ");
            bilPertama = float.Parse(Console.ReadLine());

            Console.Write("Masukkan Bilangan Kedua : ");
            bilKedua = float.Parse(Console.ReadLine());

            Console.WriteLine("Masukkan Pilihan Operasi : ");
            Console.WriteLine("(1) Pertambahan");
            Console.WriteLine("(2) Pengurangan");
            Console.WriteLine("(3) Pembagian");
            Console.WriteLine("(4) Perkalian");
            pilihan = Console.ReadLine();

            if (pilihan == "1")
            {
                hasil = bilPertama + bilKedua;
                Console.WriteLine("Hasil dari {0} + {1} = {2} ", bilPertama, bilKedua, hasil);
            }
            else if (pilihan == "2")
            {
                Console.WriteLine("Hasil dari {0} - {1} = {2} ", bilPertama, bilKedua, bilPertama - bilKedua);
            }
            else if (pilihan == "3")
            {
                Console.WriteLine("Hasil dari {0} : {1} = {2} ", bilPertama, bilKedua, bilPertama / bilKedua);
            }
            else if (pilihan == "4")
            {
                Console.WriteLine("Hasil dari {0} x {1} = {2} ", bilPertama, bilKedua, bilPertama * bilKedua);

            }


            Console.ReadLine();

            
        }
    }
}
