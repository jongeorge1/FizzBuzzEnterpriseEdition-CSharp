// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FizzStrategyFactory.cs" company="SeriousCompany">
// Copyright 2013 Serious Company
// </copyright>
// <summary>
//   Defines the BuzzStrategyFactory type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SeriousCompany.Business.CSharp.FizzBuzz.Impl.Factories
{
    using SeriousCompany.Business.CSharp.FizzBuzz.Impl.Strategies;
    using SeriousCompany.Business.CSharp.FizzBuzz.Interfaces.Factories;
    using SeriousCompany.Business.CSharp.FizzBuzz.Interfaces.Strategies;

    /// <summary>
    /// The fizz strategy factory.
    /// </summary>
    public class FizzStrategyFactory : IIsEvenlyDivisibleStrategyFactory
    {
        /// <summary>
        /// The create is evenly divisible strategy.
        /// </summary>
        /// <returns>
        /// The <see cref="IIsEvenlyDivisibleStrategy"/>.
        /// </returns>
        public IIsEvenlyDivisibleStrategy CreateIsEvenlyDivisibleStrategy()
        {
            var myFizzStrategy = new FizzStrategy();
            return myFizzStrategy;
        }
    }
}