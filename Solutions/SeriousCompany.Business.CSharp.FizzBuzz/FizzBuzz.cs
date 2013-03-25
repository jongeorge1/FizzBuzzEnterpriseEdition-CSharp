// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FizzBuzz.cs" company="SeriousCompany">
// Copyright 2013 Serious Company
// </copyright>
// <summary>
//   Defines the BuzzStrategyFactory type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SeriousCompany.Business.CSharp.FizzBuzz
{
    using SeriousCompany.Business.CSharp.FizzBuzz.Impl.Factories;
    using SeriousCompany.Business.CSharp.FizzBuzz.Interfaces.Factories;

    /// <summary>
    /// The fizz buzz.
    /// </summary>
    public class FizzBuzz
    {
        /// <summary>
        /// The fizz buzz.
        /// </summary>
        /// <param name="n">
        /// The n.
        /// </param>
        public void Fizzbuzz(int n)
        {
            var myLoopComponentFactory = new LoopComponentFactory();
            var myLoopInitializer = myLoopComponentFactory.CreateLoopInitializer();
            var myLoopCondition = myLoopComponentFactory.CreateLoopCondition();
            var myLoopStep = myLoopComponentFactory.CreateLoopStep();

            IIsEvenlyDivisibleStrategyFactory myFizzStrategyFactory = new FizzStrategyFactory();
            var myFizzStrategy = myFizzStrategyFactory.CreateIsEvenlyDivisibleStrategy();
            IStringPrinterFactory myFizzStringPrinterFactory = new FizzStringPrinterFactory();
            var myFizzStringPrinter = myFizzStringPrinterFactory.CreateStringPrinter();

            IIsEvenlyDivisibleStrategyFactory myBuzzStrategyFactory = new BuzzStrategyFactory();
            var myBuzzStrategy = myBuzzStrategyFactory.CreateIsEvenlyDivisibleStrategy();
            IStringPrinterFactory myBuzzStringPrinterFactory = new BuzzStringPrinterFactory();
            var myBuzzStringPrinter = myBuzzStringPrinterFactory.CreateStringPrinter();

            IIsEvenlyDivisibleStrategyFactory myNoFizzNoBuzzStrategyFactory = new NoFizzNoBuzzStrategyFactory();
            var myNoFizzNoBuzzStrategy = myNoFizzNoBuzzStrategyFactory.CreateIsEvenlyDivisibleStrategy();
            IIntegerPrinterFactory myIntIntegerPrinterFactory = new IntIntegerPrinterFactory();
            var myIntIntegerPrinter = myIntIntegerPrinterFactory.CreatePrinter();

            IStringPrinterFactory myNewLineStringPrinterFactory = new NewLineStringPrinterFactory();
            var myNewLinePrinter = myNewLineStringPrinterFactory.CreateStringPrinter();

            for (var i = myLoopInitializer.GetLoopInitializationPoint();
                 myLoopCondition.EvaluateLoop(i, n);
                 i = myLoopStep.StepLoop(i))
            {
                if (myFizzStrategy.IsEvenlyDivisible(i))
                {
                    myFizzStringPrinter.Print();
                }

                if (myBuzzStrategy.IsEvenlyDivisible(i))
                {
                    myBuzzStringPrinter.Print();
                }

                if (myNoFizzNoBuzzStrategy.IsEvenlyDivisible(i))
                {
                    myIntIntegerPrinter.PrintInteger(i);
                }

                myNewLinePrinter.Print();
            }
        }
    }
}