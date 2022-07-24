using Calculator.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Logic
{
    public class AdditonLogic
    {
        public double CreateAddition(AdditionModel model)
        {
            if(model.NumA == 0)
            {
                return model.NumB;
            }
            else if(model.NumB == 0)
            {
                return model.NumA;
            }
            else
            {
                var result = model.NumA + model.NumB;
                return result;
            }         
        }
    }
}
