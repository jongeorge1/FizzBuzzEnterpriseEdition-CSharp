// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FizzStringReturnerFactory.cs" company="SeriousCompany">
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
    /// The fizz string returner factory.
    /// </summary>
    public class FizzStringReturnerFactory : IStringStringReturnerFactory
    {
        /// <summary>
        /// The create string string returner.
        /// </summary>
        /// <returns>
        /// The <see cref="IStringStringReturner"/>.
        /// </returns>
        public IStringStringReturner CreateStringStringReturner()
        {
            var myFizzStringReturner = new FizzStringReturner();
            return myFizzStringReturner;
        }
    }
}