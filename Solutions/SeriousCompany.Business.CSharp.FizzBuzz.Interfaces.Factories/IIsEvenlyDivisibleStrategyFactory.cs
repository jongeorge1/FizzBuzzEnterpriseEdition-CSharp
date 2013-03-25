// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IIsEvenlyDivisibleStrategyFactory.cs" company="SeriousCompany">
// Copyright 2013 Serious Company
// </copyright>
// <summary>
//   The IntegerStringReturnerFactory interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SeriousCompany.Business.CSharp.FizzBuzz.Interfaces.Factories
{
    using SeriousCompany.Business.CSharp.FizzBuzz.Interfaces.Strategies;

    /// <summary>
    /// The IsEvenlyDivisibleStrategyFactory interface.
    /// </summary>
    public interface IIsEvenlyDivisibleStrategyFactory
    {
        /// <summary>
        /// The create is evenly divisible strategy.
        /// </summary>
        /// <returns>
        /// The <see cref="IIsEvenlyDivisibleStrategy"/>.
        /// </returns>
        IIsEvenlyDivisibleStrategy CreateIsEvenlyDivisibleStrategy();
    }
}