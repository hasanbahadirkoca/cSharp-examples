using System;

class Program {
  public static void Main (string[] args) {
    
    //Example 1
    Console.Write("\n\n----- Example 1 -----\n");

      Console.Write("Hello World!");
      //[EN]  We wrote Hello World! to console screen. However, because we used the "Write" command, it did not go to the bottom line.
      //[TR]  Konsol ekranına Hello World! yazdırdık. Ancak "write" komutunu kullandığımız için alt satıra geçmedi.
  
      Console.Write("Hello World 2!");
      //[EN]  When we rewrote the same code, they were written side by side.
      //[TR]  Aynı kodu tekrar yazdığımızda yan yana yazılmış oldular.

    //Example 2
    Console.Write("\n\n----- Example 2 -----\n");
      //[EN]  We used "\n" to move to the bottom line.
      //[TR]  Alt satıra geçmek için "\n" kullandık.
      
      Console.WriteLine("Hello World!");
      //[TR]  "WriteLine" komutu kullandığımızda çıktı sonunda alt satıra geçmek için "\n" kodunu kullanmamıza gerek kalmaz.
  
      Console.WriteLine("Hello World 2!");

    //Example 3
    Console.Write("\n----- Example 3 -----\n");
  
      String nameAndSurname = "Hasan Bahadir KOCA";
      Console.WriteLine(nameAndSurname);
  
      String upperCase = nameAndSurname.ToUpper();
      Console.WriteLine(upperCase);
      
      String lowerCase = nameAndSurname.ToLower();
      Console.WriteLine(lowerCase);

    //Example 4
    Console.Write("\n----- Example 4 -----\n");

      String productName = "Apple iPhone 13";
      Console.WriteLine(productName);

      String partsOfTheName = productName.Substring(6,4);
      Console.WriteLine(partsOfTheName);

    //Example 5
    Console.Write("\n----- Example 5 -----\n");

      String schoolName;
      schoolName = "Nisantasi University";
      String lessonName = "Visual Programming";

      Console.WriteLine("School Name: " + schoolName);
      Console.WriteLine(schoolName + " -> " + lessonName);

    //Example 6
    Console.Write("\n----- Example 6 -----\n");

      char answer = 'A';
      Console.WriteLine("Answer is " + answer);

      byte minByte = byte.MinValue;
      Console.WriteLine("MinByte: " + minByte);
      byte maxByte = byte.MaxValue;
      Console.WriteLine("MaxByte: " + maxByte);

      byte minInt = byte.MinValue;
      Console.WriteLine("MinInt: " + minInt);
      byte maxInt = byte.MaxValue;
      Console.WriteLine("MaxInt: " + maxInt);
    
    //Example 7
    Console.Write("\n----- Example 7 -----\n");

      double doubleExample = 2.30;
      Console.WriteLine(doubleExample);

      double doubleExample2 = 2;
      Console.WriteLine(doubleExample2);

      double doubleExample3 = 2.321;
      Console.WriteLine(doubleExample3);

    
    //Example 8
    Console.Write("\n----- Example 8 -----\n");

      float floatExample = 3.65F;
      Console.WriteLine(floatExample);

      decimal decimalExample = 4.32M;
      Console.WriteLine(decimalExample);

      bool trueOrFalse = false;
      Console.WriteLine(trueOrFalse);

    
    //Example 9
    Console.Write("\n----- Example 9 -----\n");

      DateTime today = DateTime.Now;
      Console.WriteLine(today);
  }
}
