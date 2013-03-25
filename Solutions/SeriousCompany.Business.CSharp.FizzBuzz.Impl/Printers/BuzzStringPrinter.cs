// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BuzzStringPrinter.cs" company="">
//   
// </copyright>
// <summary>
//   The buzz string printer.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SeriousCompany.Business.CSharp.FizzBuzz.Impl.Printers
{
    using System;

    using SeriousCompany.Business.CSharp.FizzBuzz.Impl.Factories;
    using SeriousCompany.Business.CSharp.FizzBuzz.Interfaces.Factories;
    using SeriousCompany.Business.CSharp.FizzBuzz.Interfaces.Printers;
    using SeriousCompany.Business.CSharp.FizzBuzz.Interfaces.StringReturners;

    /// <summary>
    /// The buzz string printer.
    /// </summary>
    public class BuzzStringPrinter : IStringPrinter
    {
        /// <summary>
        /// The print.
        /// </summary>
        public void Print()
        {
            IStringStringReturnerFactory myBuzzStringReturnerFactory = new BuzzStringReturnerFactory();
		    IStringStringReturner myBuzzStringReturner = myBuzzStringReturnerFactory.CreateStringStringReturner();
		    Console.Write(myBuzzStringReturner.GetReturnString());
        }
    }
}