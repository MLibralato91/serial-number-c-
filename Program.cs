// Dato un numero intero restituisce XXYYXX con X in base lengthX (0-9A-Z) e Y base lengthY. Ovviamente univoco e sequenziale

using System;

namespace NewProject
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine(SerialNumber("1"));
    }

    static string SerialNumber(string serial)
    {
      int q = 30;
      int w = 35;
      int e = 9;
      int r = 9;
      int t = 35;
      int i = 1;
      string result = "";
      string x = "0123456789abcdefghijklmnopqrstuvwxyz";
      string y = "0123456789";

      int lengthX = x.Length - 1;
      int lengthY = y.Length - 1;

      if (q >= lengthX && w >= lengthX && e >= lengthY && r >= lengthY && t >= lengthX && i >= lengthX)
      {
        Console.WriteLine("Non hai più numeri seriali disponibili");
      }
      else if (q >= lengthX && w >= lengthX && e >= lengthY && r >= lengthY && t >= lengthX)
      {
        q = 0;
        w = 0;
        e = 0;
        r = 0;
        t = 0;
        i++;

      }
      else if (q >= lengthX && w >= lengthX && e >= lengthY && r >= lengthY)
      {
        q = 0;
        w = 0;
        e = 0;
        r = 0;
        t++;

      }
      else if (q >= lengthX && w >= lengthX && e >= lengthY)
      {
        q = 0;
        w = 0;
        e = 0;
        r++;

      }
      else if (q >= lengthX && w >= lengthX)
      {
        q = 0;
        w = 0;
        e++;

      }
      else if (q >= lengthX)
      {
        q = 0;
        w++;
        if (w >= lengthX)
        {
          w = 0;
          e++;
          if (e >= lengthY)
          {
            e = 0;
            r++;
            if (r >= lengthY)
            {
              r = 0;
              t++;
              if (t >= lengthX)
              {
                t = 0;
                i++;
                if (i >= lengthX)
                {
                  Console.WriteLine("Non hai più numeri seriali disponibili");

                }
              }
            }
          }
        }

      }
      else
      {
        q++;
      }
      result = x[q].ToString() + x[w].ToString() + y[e].ToString() + y[r].ToString() + x[t].ToString() + x[i].ToString();

      return result;

    }


  }
}



