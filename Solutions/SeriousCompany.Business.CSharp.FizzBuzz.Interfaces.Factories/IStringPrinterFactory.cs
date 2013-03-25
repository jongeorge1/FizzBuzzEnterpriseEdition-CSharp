// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IStringPrinterFactory.cs" company="SeriousCompany">
// Copyright 2013 Serious Company
// </copyright>
// <summary>
//   Defines the IStringPrinterFactory type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace SeriousCompany.Business.CSharp.FizzBuzz.Interfaces.Factories
{
    using SeriousCompany.Business.CSharp.FizzBuzz.Interfaces.Printers;

    /// <summary>
    /// The StringPrinterFactory interface.
    /// </summary>
    public interface IStringPrinterFactory
    {
        /// <summary>
        /// The create string printer.
        /// </summary>
        /// <returns>
        /// The <see cref="IStringPrinter"/>.
        /// </returns>
        IStringPrinter CreateStringPrinter();
    }
}