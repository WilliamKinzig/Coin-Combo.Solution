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
  }
}
