// --------------------------------------------------------------------------------------------------------------------
// <copyright file="NewLineStringReturnerFactory.cs" company="SeriousCompany">
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
    /// The new line string returner factory.
    /// </summary>
    public class NewLineStringReturnerFactory : IStringStringReturnerFactory
    {
        /// <summary>
        /// The create string string returner.
        /// </summary>
        /// <returns>
        /// The <see cref="IStringStringReturner"/>.
        /// </returns>
        public IStringStringReturner CreateStringStringReturner()
        {
            var myNewLineStringReturner = new NewLineStringReturner();
            return myNewLineStringReturner;
        }
    }
}