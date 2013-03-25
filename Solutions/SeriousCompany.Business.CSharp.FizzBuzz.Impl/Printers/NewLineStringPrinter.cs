// --------------------------------------------------------------------------------------------------------------------
// <copyright file="NewLineStringPrinter.cs" company="SeriousCompany">
// Copyright 2013 Serious Company
// </copyright>
// <summary>
//   Defines the IntegerIntegerStringReturner type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SeriousCompany.Business.CSharp.FizzBuzz.Impl.Printers
{
    using System;

    using SeriousCompany.Business.CSharp.FizzBuzz.Impl.Factories;
    using SeriousCompany.Business.CSharp.FizzBuzz.Interfaces.Factories;
    using SeriousCompany.Business.CSharp.FizzBuzz.Interfaces.Printers;

    /// <summary>
    /// The new line string printer.
    /// </summary>
    public class NewLineStringPrinter : IStringPrinter
    {
        /// <summary>
        /// The print.
        /// </summary>
        public void Print()
        {
            IStringStringReturnerFactory myNewLineStringReturnerFactory = new NewLineStringReturnerFactory();
            var myNewLineStringReturner = myNewLineStringReturnerFactory.CreateStringStringReturner();
            var myNewLineString = myNewLineStringReturner.GetReturnString();
            Console.Write(myNewLineString);
        }
    }
}