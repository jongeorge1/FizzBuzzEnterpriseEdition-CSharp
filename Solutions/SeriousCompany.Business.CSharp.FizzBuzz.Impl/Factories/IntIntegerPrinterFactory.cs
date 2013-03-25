// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IntIntegerPrinterFactory.cs" company="SeriousCompany">
// Copyright 2013 Serious Company
// </copyright>
// <summary>
//   Defines the BuzzStrategyFactory type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SeriousCompany.Business.CSharp.FizzBuzz.Impl.Factories
{
    using SeriousCompany.Business.CSharp.FizzBuzz.Impl.Printers;
    using SeriousCompany.Business.CSharp.FizzBuzz.Interfaces.Factories;
    using SeriousCompany.Business.CSharp.FizzBuzz.Interfaces.Printers;

    /// <summary>
    /// The integer integer printer factory.
    /// </summary>
    public class IntIntegerPrinterFactory : IIntegerPrinterFactory
    {
        /// <summary>
        /// The create printer.
        /// </summary>
        /// <returns>
        /// The <see cref="IIntegerPrinter"/>.
        /// </returns>
        public IIntegerPrinter CreatePrinter()
        {
            var myIntIntegerPrinter = new IntegerIntegerPrinter();
            return myIntIntegerPrinter;
        }
    }
}