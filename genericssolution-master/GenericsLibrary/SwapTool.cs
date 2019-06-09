using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsLibrary
{
  public class SwapTool
  {
    public void Swap(ref int value1, ref int value2)
    {
      int temp = value1;
      value1 = value2;
      value2 = temp;
    }

    public void Swap<T>(ref T value1, ref T value2)
    {
      T temp = value1;
      value1 = value2;
      value2 = temp;
    }

  }
}
