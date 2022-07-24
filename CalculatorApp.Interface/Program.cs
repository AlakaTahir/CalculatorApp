using Calculator.Logic;
using Calculator.Model;
using System;

namespace CalculatorApp.Interface
{
    public class Program
    {
        private static object SubtrationModel;

        static void Main(string[] args)
        {
            //creating instance of a class 
            // AdditonLogic _additionLogic = new AdditonLogic();

            //AdditionModel model = new AdditionModel
            //{
                //NumA = 10,
                // NumB = 4
            //};

            //var result = _additionLogic.CreateAddition(model);
            //Console.WriteLine(result);
            DivisionLogic _divisionLogic = new DivisionLogic();

            DivisionModel model = new DivisionModel();
            model.NumC = 12;
            model.NumD = 3;


            var result = _divisionLogic.CreateDivision(model);
            Console.WriteLine(result);

            //imlemetation to call multiplication

            //Implementation to call substraction
            MultiplicationLogic _multiplicationLogic = new MultiplicationLogic();

            MultiplicationModel mulmodel = new MultiplicationModel();
            mulmodel.NumA = 4;
            mulmodel.NumB = 5;

            var resulting = _multiplicationLogic.CreateMultiplication(mulmodel);
            Console.WriteLine(resulting);


            SubtractionLogic _subtractionLogic  = new SubtractionLogic();
            SubtractionModel submodel = new SubtractionModel();
            submodel.NumA = 10;
            submodel.NumB = 5;
            
            var resultof = _subtractionLogic.CreateSubtraction(submodel);
            Console.WriteLine(resultof);


        }
    }
}

