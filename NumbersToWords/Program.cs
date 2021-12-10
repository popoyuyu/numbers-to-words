using System;
using NumbersToWords.Models;
using System.Collections.Generic;

namespace NumbersToWords
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter a whole number between 0 and 1 trillion");
      string intNumber = Console.ReadLine();
      Console.WriteLine(NumbersLogic.bigNumbers(intNumber));
    }
  }
}