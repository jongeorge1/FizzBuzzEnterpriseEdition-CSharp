// --------------------------------------------------------------------------------------------------------------------
// <copyright file="NewLinePrinter.cs" company="SeriousCompany">
// Copyright 2013 Serious Company
// </copyright>
// <summary>
//   Defines the IntegerIntegerStringReturner type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SeriousCompany.Business.CSharp.FizzBuzz.Impl.Printers
{
    using System;

    using SeriousCompany.Business.CSharp.FizzBuzz.Impl.StringReturners;

    /// <summary>
    /// The new line printer.
    /// </summary>
    public class NewLinePrinter
    {
        /// <summary>
        /// The print new line.
        /// </summary>
        public void PrintNewLine()
        {
            var myNewLineStringReturner = new NewLineStringReturner();
            var myNewLineString = myNewLineStringReturner.GetReturnString();
            Console.Write(myNewLineString);
        }
    }
}