﻿using Nethereum.Hex.HexConvertors.Extensions;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Nethereum.BlockChainStore.Data
{
  public class Helpers
  {
    public void AddLog(LogType type, string message)
    {
      Console.WriteLine(Enum.GetName(typeof(LogType), type) + " : " + message + " - " + DateTime.Now);
    }

    public DateTime UnixTimeStampToDateTime(double unixTimeStamp)
    {
      System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
      dtDateTime = dtDateTime.AddSeconds(unixTimeStamp);
      return dtDateTime;
    }

    public string HextoString(string hex)
    {
      var c = BigInteger.Parse(hex.RemoveHexPrefix(), System.Globalization.NumberStyles.HexNumber).ToString();
      return c;
    }
  }

  public enum LogType { Info = 1, Process = 2, Success = 3, Failure = 9 }
}
