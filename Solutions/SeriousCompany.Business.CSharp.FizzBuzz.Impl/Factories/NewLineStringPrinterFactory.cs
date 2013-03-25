// --------------------------------------------------------------------------------------------------------------------
// <copyright file="NewLineStringPrinterFactory.cs" company="SeriousCompany">
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
    /// The new line string printer factory.
    /// </summary>
    public class NewLineStringPrinterFactory : IStringPrinterFactory
    {
        /// <summary>
        /// The create string printer.
        /// </summary>
        /// <returns>
        /// The <see cref="IStringPrinter"/>.
        /// </returns>
        public IStringPrinter CreateStringPrinter()
        {
            var myNewLineStringPrinter = new NewLineStringPrinter();
            return myNewLineStringPrinter;
        }
    }
}