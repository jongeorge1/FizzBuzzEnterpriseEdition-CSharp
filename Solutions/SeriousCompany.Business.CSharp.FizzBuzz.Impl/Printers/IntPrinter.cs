// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IntPrinter.cs" company="SeriousCompany">
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
    using SeriousCompany.Business.CSharp.FizzBuzz.Interfaces.StringReturners;

    /// <summary>
    /// The integer printer.
    /// </summary>
    public class IntPrinter
    {
        /// <summary>
        /// The print integer.
        /// </summary>
        /// <param name="i">
        /// The i.
        /// </param>
        public void PrintInteger(int i)
        {
            IIntegerStringReturner myIntegerIntegerStringReturner = new IntegerIntegerStringReturner();
            var myIntegerString = myIntegerIntegerStringReturner.GetIntegerReturnString(i);
            Console.Write(myIntegerString);
        }
    }
}