using Calculator.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Logic
{
    public class MultiplicationLogic
    {
        public double CreateMultiplication(MultiplicationModel model)
        {
            if (model.NumA == 0 || model.NumB == 0)
            {
                return 0;
            }
            else
            {
                var result = model.NumA * model.NumB;
                return result;
            }
        }
    }
}
