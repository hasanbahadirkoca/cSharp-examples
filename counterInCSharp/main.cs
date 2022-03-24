using System;
using System.Threading;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Counter In C#\n");
    
    Console.Write("Enter time for counter: ");
    int count = Convert.ToInt32(Console.ReadLine());
    
    while (count > 0) {
      Console.WriteLine("> " + count);
      count --;
      
      Thread.Sleep(1000); // Sleep a second
    }

    Console.WriteLine("\nIts finished!");
  }
}
