using System;
using System.Collections.Generic;
using Xunit;
using Palindromes.Objects;

namespace PalindromerizerTest
{
  public class PalindromeTestClass
  {
    [Fact]
    public void TestMyWords()
    {
      string wordInput = "tacocat";
      bool answer = true;
      bool testOutput = Palindromerizer.PalindromeMe(wordInput);
      Assert.Equal(answer, testOutput);
    }
  }
}
