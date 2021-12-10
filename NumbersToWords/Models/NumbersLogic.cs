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
    static string[] places = { "thousand", "million", "billion", "trillion" };
    public static string ConvertNumber(int userInput)
    {
      string input = userInput.ToString();
      if (input.Length == 2 && input[1] == '0')
      {
        return tens[userInput];
      }
      else if (input.Length == 2 && input[0] == '1')
      {
        return teens[userInput];
      }
      else if (input.Length == 2 && input[0] != '1' && input[1] != '0')
      {
        return tens[int.Parse(input.Substring(0, 1) + "0")] + " " + onesPlace[int.Parse(input.Substring(1, 1))];
      }

      return onesPlace[userInput];
    }
    public static string hundreds(int userInput)
    {
      string output = "";
      string input = userInput.ToString();
      if (input != "0")
      {
        if (input.Length == 3 && input[0] != '0')
        {
          output = ConvertNumber(int.Parse(input.Substring(0, 1))) + " hundred " + ConvertNumber(int.Parse(input.Substring(1)));
        }
        else
        {
          output = output + ConvertNumber(int.Parse(input.Substring(1)));
        }
      }
      return output;
    }
    public static string bigNumbers(string userInput)
    {
      string output = "";
      List<string> sections = new List<string> { };
      string input = userInput;
      if (input.Length % 3 != 0)
      {
        sections.Add(ConvertNumber(int.Parse(input.Substring(0, (input.Length % 3)))));
        input = input.Substring(input.Length % 3);
        if ((input.Length / 3) > 0)
        {
          sections[sections.Count - 1] = sections[sections.Count - 1] + " " + places[(input.Length / 3) - 1] + " ";
        }
      }
      int x = ((input.Length) / 3);

      for (int i = 0; i < x; i++)
      {
        sections.Add(hundreds(int.Parse(input.Substring(0, 3))));
        input = input.Substring(3);
        if ((input.Length / 3) > 0)
        {
          sections[sections.Count - 1] = sections[sections.Count - 1] + " " + places[(input.Length / 3) - 1] + " ";
        }
      }
      string[] iSections = sections.ToArray();
      for (int j = 0; j < iSections.Length; j++)
      {
        output = output + iSections[j];
      }
      return output;
    }

  }

}