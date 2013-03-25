// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BuzzStringPrinterFactory.cs" company="SeriousCompany">
// Copyright 2013 Serious Company
// </copyright>
// <summary>
//   Defines the BuzzStrategyFactory type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SeriousCompany.Business.CSharp.FizzBuzz.Impl.Factories
{
    using SeriousCompany.Business.CSharp.FizzBuzz.Impl.StringReturners;
    using SeriousCompany.Business.CSharp.FizzBuzz.Interfaces.Factories;
    using SeriousCompany.Business.CSharp.FizzBuzz.Interfaces.StringReturners;

    /// <summary>
    /// The integer integer string returner factory.
    /// </summary>
    public class IntegerIntegerStringReturnerFactory : IIntegerStringReturnerFactory 
    {
        /// <summary>
        /// The create integer string returner.
        /// </summary>
        /// <returns>
        /// The <see cref="IIntegerStringReturner"/>.
        /// </returns>
        public IIntegerStringReturner CreateIntegerStringReturner()
        {
            var myIntegerIntegerStringReturner = new IntegerIntegerStringReturner();
            return myIntegerIntegerStringReturner;
        }
    }
}