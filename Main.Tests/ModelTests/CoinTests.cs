using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using CoinCombo.Models;

namespace CoinCombo.Tests
{
  [TestClass]
  public class WordTest
  {
    private bool test = false;
    [TestInitialize]
    public void TestInit()
    {
      test = true;
    }
    [TestMethod]
    public void Return_True()
    {
      Coin objectTest = new Coin();
      Assert.AreEqual(test,objectTest.Default());
    }
    [TestMethod]
    public void Return_Amount()
    {
      Coin objectTest = new Coin(4.00);
      Assert.AreEqual(16,objectTest.CoinAmount(25));
    }
    [TestMethod]
    public void Return_Array_Quarters_True()
    {
      Coin objectTest = new Coin(4.36);
      int[] tempArray = objectTest.Calculate();
      Assert.AreEqual(17,tempArray[0]);
      Assert.AreEqual(1,tempArray[1]);
      Assert.AreEqual(0,tempArray[2]);
      Assert.AreEqual(1,tempArray[3]);
    }
  }
}
