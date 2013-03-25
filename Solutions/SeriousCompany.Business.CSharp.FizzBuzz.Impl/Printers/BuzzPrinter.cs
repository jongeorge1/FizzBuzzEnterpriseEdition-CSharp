// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BuzzPrinter.cs" company="SeriousCompany">
// Copyright 2013 Serious Company
// </copyright>
// <summary>
//   The buzz printer.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SeriousCompany.Business.CSharp.FizzBuzz.Impl.Printers
{
    using System;

    using SeriousCompany.Business.CSharp.FizzBuzz.Impl.StringReturners;

    /// <summary>
    /// The buzz printer.
    /// </summary>
    public class BuzzPrinter
    {
        /// <summary>
        /// The print buzz.
        /// </summary>
        public void PrintBuzz()
        {
            var myBuzzStringReturner = new BuzzStringReturner();
            Console.Write(myBuzzStringReturner.GetReturnString());
        }
    }
}