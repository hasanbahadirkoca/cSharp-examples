using System;

namespace lesson_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lesson 10 \n");


            string[] arrayExample = new string[10];
            arrayExample[0] = "MacBook";
            arrayExample[1] = "iPad";
            arrayExample[2] = "iPhone";

            // [EN] Printing array elements with WriteLine.
            // [TR] Dizi elemanalrını WriteLine ile yazdırmak.

            /*
            Console.WriteLine(arrayExample[0]);
            Console.WriteLine(arrayExample[1]);
            Console.WriteLine(arrayExample[2]);
            */



            // [EN] Printing array elements with for loop.
            // [TR] Dizi elemanlarını for döngüsü ile yazdırmak.

            /*
            for (int i = 0; i < arrayExample.Length; i++)
            {
                Console.WriteLine(arrayExample[i]);
            }
            */



            // [EN] Printing array elements with foreach loop.
            // [TR] Dizi elemanlarını foreach döngüsü ile yazdırmak.

            /*
            foreach (var item in arrayExample)
            {
                Console.WriteLine(item);
            }
            */



            // [EN] A program that finds the average and sum of the entered values
            //      by creating an array of type int with a number of elements
            //      specified by the user.
            // [TR] Kullanıcı tarafından belirtilen sayıda elemanla int türünde
            //      bir dizi oluşturarak girilen değerlerin ortalamasını ve
            //      toplamını bulan bir program.

            /*
            int arrayExample2Sum = 0;
            Console.Write("Enter the array length: ");
            int arrayLength = int.Parse(Console.ReadLine());
            int[] arrayExample2 = new int[arrayLength];
            for (int i = 0; i < arrayExample2.Length; i++)
            {
                Console.Write("Enter the arrayExample[{0}] value: ", i);
                arrayExample2[i] = int.Parse(Console.ReadLine());
                arrayExample2Sum += arrayExample2[i];
            }

            Console.WriteLine("Length of the array: " + arrayExample2.Length);
            Console.WriteLine("Sum of the array values: " + arrayExample2Sum);
            Console.WriteLine("Average of the array values: " + arrayExample2Sum / arrayExample2.Length);
            */



            /* [EN] Define 3 arrays with 5 elements of data type int.
                    Let the elements of the first array be 1 - 5.
                    Let the elements of the second array be random from 1 to 20.
                    Let the elements of the third array be equal to the sum of
                    the equal indexes in 1 and 2.
            /* [TR] İnt veri türünde 5 elemanlı 3 tane dizi tanımlayın.
                    İlk dizinin elemanları 1-5 arası olsun.
                    İkinci dizinin elemanları 1-20 arasında rastgele gelsin.
                    Üçüncü dizinin elemanları 1 ve 2'deki eş indexlerin toplamına
                    eşit olsun.

            /*
            int[] arrayExample3 = new int[5] { 1, 2, 3, 4, 5 };
            int[] arrayExample4 = new int[5];
            int[] arrayExample5 = new int[5];

            Random rnd = new Random();
            for (int i = 0; i < arrayExample4.Length; i++)
            {
                arrayExample4[i] = rnd.Next(1, 20);
            }

            for (int i = 0; i < arrayExample5.Length; i++)
            {
                arrayExample5[i] = arrayExample3[i] + arrayExample4[i];

                Console.WriteLine("arrayExample3[{0}]: {0}", arrayExample3[i]);
                Console.WriteLine("arrayExample4[{0}]: {0}", arrayExample4[i]);
                Console.WriteLine("arrayExample5[{0}]: {0}", arrayExample5[i]);
                Console.WriteLine("------");
            }
            */


            string deneme = "Değer";
            Console.WriteLine(String.Compare(deneme, "DeğeR", false));




            // DÜZENLENECEK

            /*Elemanları klavyeden girilen 10 elemanlı
             * dizinin en büyük değerini bulan prg*/

            /*
            int[] dizi = new int[10];
            int EB;
            Console.Write("0. indexi giriniz:");
            dizi[0] = int.Parse(Console.ReadLine());
            EB = dizi[0];
            for (int i = 1; i < dizi.Length; i++)
            {
                Console.Write("{0}. indexi giriniz:", i);
                dizi[i] = int.Parse(Console.ReadLine());
                if (dizi[i] > EB)
                    EB = dizi[1];
            }
            Console.WriteLine("En büyük değer {0}", EB);
            */
            /*10 elemanlı, değerleri 1-100 arasında random gelen
             * dizinin en küçük elemanı*/


        }
    }
}
