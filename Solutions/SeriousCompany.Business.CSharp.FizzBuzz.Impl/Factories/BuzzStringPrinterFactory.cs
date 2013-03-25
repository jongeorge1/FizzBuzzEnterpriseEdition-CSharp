// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BuzzStringPrinterFactory.cs" company="SeriousCompany">
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
    /// The buzz string printer factory.
    /// </summary>
    public class BuzzStringPrinterFactory : IStringPrinterFactory
    {
        /// <summary>
        /// The create string printer.
        /// </summary>
        /// <returns>
        /// The <see cref="IStringPrinter"/>.
        /// </returns>
        public IStringPrinter CreateStringPrinter()
        {
            var myBuzzStringPrinter = new BuzzStringPrinter();
            return myBuzzStringPrinter;
        }
    }
}