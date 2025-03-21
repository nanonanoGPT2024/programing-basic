using System;

class Basic
{
    public static void VariableTypeData()
    {
        int angka = 10;
        double pi = 3.14;
        char huruf = 'A';
        string nama = "Keti";
        bool isActive = true;


        Console.WriteLine("angka pi : "+ pi);
        Console.WriteLine("angka : "+ angka);
        Console.WriteLine("huruf : "+ huruf);
        Console.WriteLine("nama : " + nama);
        Console.WriteLine("isActive : "+ isActive);
    }


    public static void InputPengguna()
    {
        Console.Write("Masukan Nama : ");
        string nama = Console.ReadLine();

        Console.Write("Hallo : " + nama);
    }

    public static void aritmatika()
    {
        int a = 10;
        int b = 5;

        Console.WriteLine("Penjumlahan : " + (a +b));
        Console.WriteLine("Pengurangan : " + (a-b));
        Console.WriteLine("Perkalian : " + (a*b));
        Console.WriteLine("Pembagian : " + (a/b));
        Console.WriteLine("Modulus :" + (a%b));
    }

    public static void percabangan()
    {
        Console.Write("Masukan Angka : ");
        int angka = Convert.ToInt32(Console.ReadLine());


        if(angka > 0)
        {
            Console.WriteLine("Angka Positif");
        } 
        else if(angka < 0)
        {
            Console.WriteLine("Angka Negatif");
        }
        else
        {
            Console.WriteLine("Angka 0");
        }
    }

    public static void perulangan()
    {
        for (int i = 0; i < length; i++)
        {
            Console.WriteLine("Iterasi ke - " + i);
            i++;
        }
    }
}