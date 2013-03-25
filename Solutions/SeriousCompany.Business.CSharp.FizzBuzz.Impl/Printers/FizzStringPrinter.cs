// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FizzStringPrinter.cs" company="SeriousCompany">
// Copyright 2013 Serious Company
// </copyright>
// <summary>
//   The fizz printer.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SeriousCompany.Business.CSharp.FizzBuzz.Impl.Printers
{
    using System;

    using SeriousCompany.Business.CSharp.FizzBuzz.Impl.Factories;
    using SeriousCompany.Business.CSharp.FizzBuzz.Interfaces.Printers;
    using SeriousCompany.Business.CSharp.FizzBuzz.Interfaces.StringReturners;

    /// <summary>
    /// The fizz string printer.
    /// </summary>
    public class FizzStringPrinter : IStringPrinter
    {
        /// <summary>
        /// The print.
        /// </summary>
        public void Print()
        {
            var myFizzStringReturnerFactory = new FizzStringReturnerFactory();
            IStringStringReturner myFizzStringReturner = myFizzStringReturnerFactory.CreateStringStringReturner();
            Console.Write(myFizzStringReturner.GetReturnString());
        }
    }
}