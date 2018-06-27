using System;
using System.Collections.Generic;

namespace CoinCombo.Models
{
  public class Coin
  {
    private int _funds;
    private int _leftovers;
    private int[] _coins;
    public Coin()
    {
      _funds = 0;
      _leftovers = 0;
      _coins = new int[4];
    }

    public Coin(double funds)
    {
      _funds = (int)(funds*100);
      _leftovers = _funds;
      _coins = new int[4];
    }

    public void SetFunds(double funds)
    {
      _funds = (int)(funds*100);
      _leftovers = _funds;
    }

    public int GetFunds()
    {
      return _funds;
    }

    public void Clear()
    {
      _funds = 0;
      _leftovers = 0;
      _coins = new int[4];
    }

    public int[] Calculate()
    {
      int[] coinTypes = {25,10,5,1};
      int count = 0;
      while(_leftovers!=0)
      {
        _coins[count] = CoinAmount(coinTypes[count]);
        count++;
      }
      return _coins;
    }

    public int CoinAmount(int coinType)
    {
      int remainder = (_leftovers%coinType);
      int coinAmount = (_leftovers-remainder);
      _leftovers -= coinAmount;
      coinAmount /= coinType;
      return coinAmount;
    }

    //Check if Unit Test setup correctly
    public bool Default()
    {
      return true;
    }
  }
}
