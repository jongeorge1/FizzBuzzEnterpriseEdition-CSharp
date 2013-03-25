// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IIntegerPrinterFactory.cs" company="SeriousCompany">
// Copyright 2013 Serious Company
// </copyright>
// <summary>
//   The IntegerPrinterFactory interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SeriousCompany.Business.CSharp.FizzBuzz.Interfaces.Factories
{
    using SeriousCompany.Business.CSharp.FizzBuzz.Interfaces.Printers;

    /// <summary>
    /// The IntegerPrinterFactory interface.
    /// </summary>
    public interface IIntegerPrinterFactory
    {
        /// <summary>
        /// Creates the printer.
        /// </summary>
        /// <returns>
        /// The <see cref="IIntegerPrinter"/>.
        /// </returns>
        IIntegerPrinter CreatePrinter();
    }
}