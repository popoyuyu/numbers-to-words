using System;
using System.Collections.Generic;

namespace NumbersToWords.Models
{
  public class NumbersLogic
  {
    static Dictionary<int, string> onesPlace = new Dictionary<int, string>(){
      {1, "one"},
      {2, "two"},
      {3, "three"},
      {4, "four"},
      {5, "five"},
      {6, "six"},
      {7, "seven"},
      {8, "eight"},
      {9, "nine"}
    };
    static Dictionary<int, string> teens = new Dictionary<int, string>(){
      {11, "eleven"},
      {12, "twelve"},
      {13, "thirteen"},
      {14, "fourteen"},
      {15, "fifteen"},
      {16, "sixteen"},
      {17, "seventeen"},
      {18, "eighteen"},
      {19, "nineteen"}
    };
    static Dictionary<int, string> tens = new Dictionary<int, string>(){
      {10, "ten"},
      {20, "twenty"},
      {30, "thirty"},
      {40, "forty"},
      {50, "fifty"},
      {60, "sixty"},
      {70, "seventy"},
      {80, "eighty"},
      {90, "ninety"}
    };
    public static string ConvertNumber(int userInput)
    {
      string input = userInput.ToString();
      if (input.Length == 2 && input[input.Length - 1] == '0')
      {
        return tens[userInput];
      }
      else if (input.Length == 2)
      {
        return teens[userInput];
      }
      return onesPlace[userInput];
    }
    public static string hundreds(int userInput)
    {
      string output = "";
      string input = userInput.ToString();
      if (input.Length == 3)
      {
        output = ConvertNumber(int.Parse(input.Substring(0, 1))) + " hundred " + ConvertNumber(int.Parse(input.Substring(1)));
      }
      return output;
    }

  }

}

