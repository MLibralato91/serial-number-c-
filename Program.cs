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
      int q = 0;
      int w = 36;
      int e = 0;
      int r = 0;
      int t = 0;
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
      else if(q >= lengthX && w >= lengthX && e >= lengthY && r >= lengthY && t >= lengthX)
      {
        q= 0;
        w= 0;
        e = 0;
        r = 0;
        t = 0;
        i++;
        result = x[q].ToString() + x[w].ToString() + y[e].ToString() + y[r].ToString() + x[t].ToString() + x[i].ToString();

      }else if(q >= lengthX && w >= lengthX && e >= lengthY && r >= lengthY)
      {
        q= 0;
        w= 0;
        e = 0;
        r = 0;
        t++;
        result = x[q].ToString() + x[w].ToString() + y[e].ToString() + y[r].ToString() + x[t].ToString() + x[i].ToString();

      }else if(q >= lengthX && w >= lengthX && e >= lengthY)
      {
        q= 0;
        w= 0;
        e = 0;
        r++;
        result = x[q].ToString() + x[w].ToString() + y[e].ToString() + y[r].ToString() + x[t].ToString() + x[i].ToString();

      }else if(q >= lengthX && w >= lengthX)
      {
        q= 0;
        w= 0;
        e++;
        result = x[q].ToString() + x[w].ToString() + y[e].ToString() + y[r].ToString() + x[t].ToString() + x[i].ToString();

      }else if(q >= lengthX)
      {
        q = 0;
        w++;
        result = x[q].ToString() + x[w].ToString() + y[e].ToString() + y[r].ToString() + x[t].ToString() + x[i].ToString();
      }else {
        q++;
        result = x[q].ToString() + x[w].ToString() + y[e].ToString() + y[r].ToString() + x[t].ToString() + x[i].ToString();
      }

      return result;

    }


  }
}



