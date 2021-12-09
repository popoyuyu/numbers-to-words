using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumbersToWords.Models;
using System;

namespace NumbersToWords.Tests
{
  [TestClass]
  public class NumbersLogicTests
  {

    [TestMethod]
    public void ConvertWord_ReturnOne_String()
    {
      Assert.AreEqual("one", NumbersLogic.ConvertNumber(1));
    }

    [TestMethod]
    public void CheckForTeenNumber_ReturnCorrespondingTeenWord_String()
    {
      Assert.AreEqual("fifteen", NumbersLogic.ConvertNumber(15));
    }

    [TestMethod]
    public void CheckForTens_ReturnCorrespondingTensWord_String()
    {
      Assert.AreEqual("twenty", NumbersLogic.ConvertNumber(20));
    }
    [TestMethod]
    public void CheckForHundreds_ReturnCorrespondingTensWord_String()
    {
      Assert.AreEqual("one hundred fifteen", NumbersLogic.hundreds(115));
    }



  }
}



