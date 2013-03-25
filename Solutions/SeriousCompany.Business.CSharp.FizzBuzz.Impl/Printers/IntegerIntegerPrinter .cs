// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IntegerIntegerPrinter.cs" company="SeriousCompany">
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
    using SeriousCompany.Business.CSharp.FizzBuzz.Interfaces.Printers;
    using SeriousCompany.Business.CSharp.FizzBuzz.Interfaces.StringReturners;

    /// <summary>
    /// The integer integer printer.
    /// </summary>
    public class IntegerIntegerPrinter : IIntegerPrinter
    {
        /// <summary>
        /// The print integer.
        /// </summary>
        /// <param name="i">
        /// The i.
        /// </param>
        public void PrintInteger(int i)
        {
            var myIntegerIntegerStringReturnerFactory = new IntegerIntegerStringReturnerFactory();
            IIntegerStringReturner myIntegerStringReturner =
                myIntegerIntegerStringReturnerFactory.CreateIntegerStringReturner();
            var myIntegerString = myIntegerStringReturner.GetIntegerReturnString(i);
            Console.Write(myIntegerString);
        }
    }
}