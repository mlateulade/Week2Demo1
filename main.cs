using System;

class MainClass {
  public static void Main (string[] args) {
    //Identify if a number is odd or even
    //15/2 is there a remainder? if so then it is odd else even
    
    
    var input = Console.ReadLine();
    int nbr = Convert.ToInt32(input);

    //Arithmetic operators in C# (+, -, *, /, %)

    //Find the remainder
    int remainder = nbr % 2;
//if the remainder is 1 then it is odd, else it is even

    if(remainder == 1)
    {
      Console.WriteLine("Odd");
    }
    else
    {
      Console.WriteLine("Even");
    }
    
  }
}