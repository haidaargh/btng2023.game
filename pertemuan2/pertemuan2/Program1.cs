//1. STRUKTUR
using System;
using System.ComponentModel;
using System.Runtime.Serialization.Formatters;
using System.Security.Cryptography.X509Certificates;

namespace pertemuan2{

    class Program1{

        //2. Proh=gram Hello World
        //16. Function
        public static void Main(string[]args){
            Console.WriteLine("Halo");
        Console.WriteLine("==========================");

        //3. Variable
        String divisiDncc = "game";
            Console.WriteLine(divisiDncc);
        Console.WriteLine("==========================");

        //4. Komentar

        //5. Tipe Data
        int angka = 10;
        double angkaDouble = 3.14;
        float angkaFloat = 10.2f;
            Console.WriteLine(angka);
            Console.WriteLine(angkaDouble);
            Console.WriteLine(angkaFloat);

        string firstName;
        string lastName = "game";
        firstName = "divisi";
            Console.WriteLine(firstName);
            Console.WriteLine(lastName);

        firstName += lastName;
            Console.WriteLine(firstName);

        string hari ="senin \tselasa \trabu \tkamis";
        string bulan ="januari \rfebruari \rmaret \rmaret";
        string film ="\"loplep\"";
            Console.WriteLine(hari);
            Console.WriteLine(bulan);
            Console.WriteLine(film);

        string txt = "Ini Text.";
            Console.WriteLine(txt.ToLower());
            Console.WriteLine(txt.ToUpper());
            Console.WriteLine("Panjang string tersebut adalah " + txt.Length);
            Console.WriteLine(txt + " Yang digabungkan");

        string name ="Haidar";
        var date = DateTime.Now;
            Console.WriteLine($"Halo, {name}! Hari ini ada {date.DayOfWeek}, pukul {date:HH:mm} WIB.");

        bool benar = true;
        bool salah = false;
        if(benar== true){
            Console.WriteLine("Ini adalah pernyataan benar");
        }else{
            Console.WriteLine("Ini adalah pernyataan salah");
        }

        float first = 3.14f;
        int second = (int)first;
            Console.WriteLine(second);

        int angkaSatu = 10;
        float angkaDua = 20.7f;
            Console.WriteLine($"{angkaSatu.ToString()}{angkaDua.ToString()}");

        string pertama = "5";
        string kedua = "7";
        int sum = int.Parse(pertama) + int.Parse(kedua);
            Console.WriteLine(sum);
        Console.WriteLine("==========================");

        //6. Operator Aritmatika
        var hasil = 1+1;
        var hasil1 = 1-1;
        var hasil2 = -1;
        var hasil3 = 1*1;
        var hasil4 = 1/1;
        var hasil5 = 1%1;
            Console.WriteLine(hasil);
            Console.WriteLine(hasil1);
            Console.WriteLine(hasil2);
            Console.WriteLine(hasil3);
            Console.WriteLine(hasil4);
            Console.WriteLine(hasil5);
        Console.WriteLine("==========================");

        //7. Operator Penugasan
        int a =1;
            Console.WriteLine(a);
            Console.WriteLine(++a);
            Console.WriteLine(a);
        int b =1;
            Console.WriteLine(b);
            Console.WriteLine(b++);
            Console.WriteLine(b);

        int c =1;
            Console.WriteLine(c);
            Console.WriteLine(--c);
            Console.WriteLine(c);
        int d =1;
            Console.WriteLine(d);
            Console.WriteLine(d--);
            Console.WriteLine(d);
        Console.WriteLine("==========================");

        //8. Operator Perbandingan
        Console.WriteLine("==========================");

        //9. Operator Logika
        Console.WriteLine("==========================");

        //10. Array
        string[] divisi = {"web","mobile","game","mm","jaringan"};
            Console.WriteLine(divisi[0]);
            Console.WriteLine(divisi[1]);
            Console.WriteLine(divisi[2]);
            Console.WriteLine(divisi[3]);
            Console.WriteLine(divisi[4]);
        
        string[] names = new string[5];
        names[0] ="web";
        names[0] ="mobile";
        names[0] ="game";
        names[0] ="mm";
        names[0] ="jaringan";

        int[,] number = new int [2,3];
        int[,] numbers = {{1,2,3},{4,5,6}};
            Console.WriteLine(number[0,1]);
            Console.WriteLine(number[1,2]);
        Console.WriteLine("==========================");

        //11. List
        var listDncc = new List<string> {"game","mobile","web"};
        for (int i = 0; i < listDncc.Count; i++){
            Console.WriteLine(listDncc[i] + "");
        }

        List<int> angk4 = new List<int>();
        angk4.Add(1);
        angk4.Add(2);
        angk4.Add(3);
        angk4.AddRange(new int[3] {3,4,5});
        angk4.Remove(1);
        angk4.RemoveAt(0);
        angk4.IndexOf(3);
            Console.WriteLine(angk4.Contains(10));
            Console.WriteLine(angk4.Count());
        foreach(var aa in angk4){
            Console.WriteLine(aa + "");
        }
        Console.WriteLine("==========================");

        //12. Pengkondisian
        int g = 5;
        if(10>g){
            Console.WriteLine("Benar!");
        }else{
            Console.WriteLine("Salah!");
        }

        int nilai =75;
        if(nilai>=90){
            Console.WriteLine("Anda dapat A");
        }else if(nilai>=80){
            Console.WriteLine("Anda dapat B");
        }else if(nilai>=70){
            Console.WriteLine("Anda dapat C");
        }else{
            Console.WriteLine("Anda dapat D atau E");
        }

        int nila1 = 75;
        switch (nila1){
            case>95:
                Console.WriteLine("Memuaskan");
                break;
            case>80:
                Console.WriteLine("Baik");
                break;
            case>70:
                Console.WriteLine("Cukup");
                break;
            default:
                Console.WriteLine("Kurang");
                break;
        }
        Console.WriteLine("==========================");

        //13. Tenary Operator
        int an9k4 = 10;
        string has1l = (an9k4 % 2==0) ? "Genap":"Ganjil";
            Console.WriteLine(has1l);
        Console.WriteLine("==========================");

        //14. Perulangan
        for(int z=0; z<5; z++){
            Console.WriteLine("Perulangan ke " + z);
        }

        int x=0;
        while(x<5){
            Console.WriteLine("Perulangan ke " + x);
            x++;
        }

        int y=5;
        do{
            Console.WriteLine("Perulangan ke " + y);
            y++;
        } while(y<5);

        int v=0;
        int[] an9ka = new int [5] {1,2,3,4,5};
        foreach (int j in an9ka){
            Console.WriteLine("Ini adalah isi array urut dari indeks ke " + v++ + " yaitu " + j);
        }
        Console.WriteLine("==========================");

        //15. Break & Continue
        for(int m=0; m<10; m++){
            Console.WriteLine("Perulangan ke " + m);
            if(m==5){
                break;
            }
        }

        for(int n=0; n<10; n++){
            if(n % 2==0){
                continue;
            }
            Console.WriteLine(n);
        }
        Console.WriteLine("==========================");

        }


        


    }

}