// --------------------------------------------------------------------------------------------------------------------
// <copyright file="NoFizzNoBuzzStrategyFactory.cs" company="SeriousCompany">
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
    /// The no fizz no buzz strategy factory.
    /// </summary>
    public class NoFizzNoBuzzStrategyFactory : IIsEvenlyDivisibleStrategyFactory
    {
        /// <summary>
        /// The create is evenly divisible strategy.
        /// </summary>
        /// <returns>
        /// The <see cref="IIsEvenlyDivisibleStrategy"/>.
        /// </returns>
        public IIsEvenlyDivisibleStrategy CreateIsEvenlyDivisibleStrategy()
        {
            var myNoFizzNoBuzzStrategy = new NoFizzNoBuzzStrategy();
            return myNoFizzNoBuzzStrategy;
        }
    }
}