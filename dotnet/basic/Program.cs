


// struktur program c# 

// import library 
// using System;

// deklarasi class utama 
class program
{
    // entry point , kode point di jalankan 
    static void Main(){


        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");

        Console.WriteLine("**********");
        Console.WriteLine("Belajar C#");
        Console.WriteLine("**********");
        Console.WriteLine();
        Console.WriteLine("Pilih Menu : ");
        Console.WriteLine("*************");

        Console.WriteLine("1. variable dan type data");
        Console.WriteLine("2 input dari pengguna");
        Console.WriteLine("3. aritmatika");
        Console.WriteLine("4. percabangan");
        Console.WriteLine("5. perulangan");
        Console.WriteLine();


        Console.Write("Masukan Angka : ");
        int angka = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("angka : " + angka);
        if(angka == 1){
            Basic.VariableTypeData();
        } else if (angka == 2) {
            Basic.InputPengguna();
        } else if (angka == 3) {
            Basic.aritmatika();
        } else if (angka == 4) {
            Basic.percabangan();
        } else if (angka == 5) {
            Basic.perulangan();
        }
         else {
            Console.WriteLine("Pilihan Tidak Ada !!!");
        }

    }
}