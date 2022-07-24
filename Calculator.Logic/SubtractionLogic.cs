using Calculator.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Logic
{
    public class SubtractionLogic
    {
        public double CreateSubtraction(SubtractionModel model)
        {
            double result = model.NumA - model.NumB;
            return result;
        }
    }
}
