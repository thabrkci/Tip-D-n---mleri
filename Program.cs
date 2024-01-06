using System;

namespace Typetransformations
{
    class Program
    {
        public static void Main(string[] args)
        {
            // İmplicit Conversion (Bilinçsiz Dönüşüm)
            Console.WriteLine("_-_İmplicit Conversion_-_");

            // Byte, sbyte, short türündeki değişkenlerin toplamı int'e atanabilir, çünkü daha büyük bir türdür.
            byte a = 5;
            sbyte b = 30;
            short c = 10;
            int d = a + b + c;
            Console.WriteLine("d:" + d);

            // Daha büyük bir tür olan long'a int değeri atanabilir.
            long h = d;
            Console.WriteLine("h:" + h);

            // Daha büyük bir tür olan float'a long değeri atanabilir.
            float i = h;
            Console.WriteLine("i:" + i);

            // String ve char ifadeleri ile int toplanarak object türüne atanabilir.
            string E = "Taha";
            char f = 'B';
            object g = E + f + d;
            Console.WriteLine("g:" + g);

            // Explicit Conversion (Bilinçli Dönüşüm)
            Console.WriteLine("_-_Explicit Conversion_-_");

            // Daha küçük bir tür olan int, byte türüne bilinçli bir şekilde dönüştürülebilir.
            int x = 4;
            byte y = (byte)x;
            Console.WriteLine("y:" + y);

            // Daha büyük bir tür olan int, byte türüne dönüştürülecekken veri kaybı olabilir.
            int z = 100;
            byte t = (byte)z;
            Console.WriteLine("t:" + t);

            // Ondalık kısmı kaybederek float türünden byte türüne dönüşüm yapılabilir.
            float w = 10.3f;
            byte v = (byte)w;
            Console.WriteLine("v:" + v);

            // To string Methodu
            Console.WriteLine("[To String Methodu]");

            // Bir int değeri string'e dönüştürülebilir.
            int xx = 6;
            string yy = xx.ToString();
            Console.WriteLine("yy:" + yy);

            // Bir float değeri string'e dönüştürülebilir.
            string zz = 12.5f.ToString();
            Console.WriteLine("zz:" + zz);

            // System Convert
            Console.WriteLine("[System Convert]");

            // Convert sınıfı kullanılarak string ifadeler int türüne dönüştürülebilir.
            string s1 = "10", s2 = "20";
            int sayi1, sayi2;
            int Toplam;

            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);

            // Dönüştürülen değerler toplanabilir.
            Toplam = sayi1 + sayi2;
            Console.WriteLine("Toplam:" + Toplam);

            // Parse Methodu
            Console.WriteLine("[Parse Methodu]");

            // Parse metodu ile string ifadeler sayısal türlere dönüştürülebilir.
            ParseMethod();

            static void ParseMethod()
            {
                string metin1 = "10";
                string metin2 = "20.35";
                int rakam1;
                double double32;

                // Parse metodu kullanılarak string ifade int türüne dönüştürülebilir.
                rakam1 = Int32.Parse(metin1);
                Console.WriteLine("rakam1 :" + rakam1);

                // Parse metodu kullanılarak string ifade double türüne dönüştürülebilir.
                double32 = Double.Parse(metin2);
                Console.WriteLine("double32 :" + double32);
            }
        }
    }
}
