using System.Security.Cryptography.X509Certificates;

namespace Tip_Dönüşümleri;

class Program
{
    public static void Main(string[] args)
    {
        ///İmplicit Conservion
        Console.WriteLine("_-_İmplicit Conservion_-_");

        byte a = 5;
        sbyte b = 30;
        short c = 10;

        int d = a+b+c;
        Console.WriteLine("d:" + d);

        long h = d;
        Console.WriteLine("h:" + h);

        float i = h;
        Console.WriteLine("i:" + i);

        string E= "Taha";
        char f='B';
        object g = E+f+d;
        Console.WriteLine("g:" + g);

        //Explicit Conservion(Bilinçli Dönüşüm)
        Console.WriteLine("_-_Explicit Conservion_-_");

        int x = 4;
        byte y = (byte)x;
        Console.WriteLine("y:" +y);

        int z = 100;
        byte t = (byte)z;
        Console.WriteLine("t:" +t);

        float w = 10.3f;
        byte v = (byte)w;
        Console.WriteLine("v:" +v);

        //To string Methodu
        Console.WriteLine("[To String Methodu]");
        int xx =6;
        string yy = xx.ToString();
        Console.WriteLine("yy:"+ yy);

        string zz = 12.5f.ToString();
        Console.WriteLine("zz:" +zz);

        //System Convert
        Console.WriteLine("[System Convert]");
        string s1 ="10" , s2="20";
        int sayi1, sayi2;
        int Toplam;

        sayi1 = Convert.ToInt32(s1);
        sayi2 = Convert.ToInt32(s2);

        Toplam = sayi1 + sayi2;
        Console.WriteLine("Toplam:" +Toplam);
        //Parse Methodu//
        Console.WriteLine("[Parse Methodu]");
        ParseMethod();
        
        
        static void ParseMethod()
        {
        string metin1 ="10";
        string metin2 ="20.35";
        int rakam1;
        double double32;

        rakam1 = Int32.Parse(metin1);
        double32 = Double.Parse(metin2);

        Console.WriteLine("rakam1 :" +rakam1);
        Console.WriteLine("double32 :" +double32);
        


        }
        






    }
}
