// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FizzStringPrinterFactory.cs" company="SeriousCompany">
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
    /// The fizz string printer factory.
    /// </summary>
    public class FizzStringPrinterFactory : IStringPrinterFactory
    {
        /// <summary>
        /// The create string printer.
        /// </summary>
        /// <returns>
        /// The <see cref="IStringPrinter"/>.
        /// </returns>
        public IStringPrinter CreateStringPrinter()
        {
            var myFizzStringPrinter = new FizzStringPrinter();
            return myFizzStringPrinter;
        }
    }
}