using System;
using System.Collections.Generic;

namespace Palindromes.Objects
{
  public class Palindromerizer
  {
    public static bool PalindromeMe(string word)
    {
      int counter = 0;
      char[] inputWord = word.ToCharArray();
      int wordLength = word.Length;

      System.Console.WriteLine(counter);

      for(int i=0; i < wordLength; i++)
      {
        if (inputWord[i] == inputWord[(wordLength - 1) - i])
        {
          counter++;
        }
      }

      System.Console.WriteLine(counter);
      if (counter == wordLength)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}
