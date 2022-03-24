using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine("Times Table\n");
    // [EN]  We printed the Times Table text and left a line space.
    // [TR]  Times Table metnini yazdırıp bir satır boşluk bıraktık.
    for (int x = 1; x <= 10; x++){
      // [EN]  We have defined the for loop that will print each row of the multiplication table.
      // [TR]  Çarpım tablosunun her bir satırını yazdıracak olan for döngüsünü tanımladık.
    
      for (int y = 1; y <= 10; y++) {
        // [EN]
        // [TR]
        
        Console.Write(x * y + ", ");
        // [EN]
        // [TR]
        
      }
      
      Console.WriteLine();
      // [EN]
      // [TR]
      
      
    }
  }
}
