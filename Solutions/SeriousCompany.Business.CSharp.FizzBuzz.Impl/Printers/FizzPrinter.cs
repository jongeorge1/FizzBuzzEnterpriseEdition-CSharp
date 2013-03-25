// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FizzPrinter.cs" company="SeriousCompany">
// Copyright 2013 Serious Company
// </copyright>
// <summary>
//   The fizz printer.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SeriousCompany.Business.CSharp.FizzBuzz.Impl.Printers
{
    using System;

    using SeriousCompany.Business.CSharp.FizzBuzz.Impl.StringReturners;

    /// <summary>
    /// The fizz printer.
    /// </summary>
    public class FizzPrinter
    {
        /// <summary>
        /// The print fizz.
        /// </summary>
        public void PrintFizz()
        {
            var myFizzStringReturner = new FizzStringReturner();
            Console.Write(myFizzStringReturner.GetReturnString());
        }
    }
}