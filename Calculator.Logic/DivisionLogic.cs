using Calculator.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Logic
{
    public class DivisionLogic
    {
        public double CreateDivision(DivisionModel model)
        {
            var result = model.NumC/model.NumD;
            return result;
        }
    }
}
