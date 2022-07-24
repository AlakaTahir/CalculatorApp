using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Logic
{
    public class EvenLogic
    {
      public bool IsEven(int Firstnumber)
        {
            if (Firstnumber%2 == 0)
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
