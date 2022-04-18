# Lesson 1

#### [Click](https://replit.com/@thehbk/CLesson1) to try on Replit.

- [Example 1](#example-1):  Console.Write Command
- [Example 2](#example-2):  Console.WriteLine Command
- [Example 3](#example-3):  String, ToUpper, ToLower Commands
- [Example 4](#example-4):  Substring Command
- [Example 5](#example-5):  Combining Two Strings
- [Example 6](#example-6):  Char, Byte Variables and MinValue, MaxValue Commands
- [Example 7](#example-7):  Double Variable
- [Example 8](#example-8):  Float, Decimal and Boolean Variables
- [Example 9](#example-9):  DateTime Variables

## Example 1
    Console.Write("Hello World!");
    //We wrote Hello World! to console screen. However, because we used the "Write" command, it did not go to the bottom line.

    Console.Write("Hello World 2!");
    //When we rewrote the same code, they were written side by side.
#### Output:
    Hello World!Hello World 2!


## Example 2
    Console.WriteLine("Hello World!");
    Console WriteLine("Hello World 2!");
#### Output:
    Hello World!
    Hello World 2!


## Example 3
    String nameAndSurname = "Hasan Bahadir KOCA";
    Console.WriteLine(nameAndSurname);

    String upperCase = nameAndSurname.ToUpper();
    Console.WriteLine(upperCase);
    
    String lowerCase = nameAndSurname.ToLower();
    Console.WriteLine(lowerCase);
#### Output:
    Hasan Bahadir KOCA
    HASAN BAHADIR KOCA
    hasan bahadir koca
    
    
## Example 4
    String productName = "Apple iPhone 13";
    Console.WriteLine(productName);

    String partsOfTheName = productName.Substring(6,4);
    Console.WriteLine(partsOfTheName);
#### Output:
    Apple iPhone 13
    iPho


## Example 5
    String schoolName;
    schoolName = "Nisantasi University";
    String lessonName = "Visual Programming";

    Console.WriteLine("School Name: " + schoolName);
    Console.WriteLine(schoolName + " -> " + lessonName);
#### Output:
    School Name: Nisantasi University
    Nisantasi University -> Visual Programming


## Example 6
    char answer = 'A';
    Console.WriteLine("Answer is " + answer);

    byte minByte = byte.MinValue;
    Console.WriteLine("MinByte: " + minByte);

    byte maxByte = byte.MaxValue;
    Console.WriteLine("MaxByte: " + maxByte);
#### Output:
    Answer is A
    MinByte: 0
    MaxByte: 255


## Example 7
    double doubleExample = 2.30;
    Console.WriteLine(doubleExample);

    double doubleExample2 = 2;
    Console.WriteLine(doubleExample2);

    double doubleExample3 = 2.321;
    Console.WriteLine(doubleExample3);
#### Output:
    2.3
    2
    2.321


## Example 8
    float floatExample = 3.65F;
    Console.WriteLine(floatExample);

    decimal decimalExample = 4.32M;
    Console.WriteLine(decimalExample);

    bool trueOrFalse = false;
    Console.WriteLine(trueOrFalse);
#### Output:
    3.65
    4.32
    False


## Example 9
    DateTime today = DateTime.Now;
    Console.WriteLine(today);
#### Output:
    4/18/2022 4:19:48 AM
