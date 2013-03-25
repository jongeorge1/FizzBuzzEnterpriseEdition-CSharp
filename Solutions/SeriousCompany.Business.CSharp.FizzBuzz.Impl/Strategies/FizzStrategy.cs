// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FizzStrategy.cs" company="SeriousCompany">
// Copyright 2013 Serious Company
// </copyright>
// <summary>
//   Defines the FizzStrategy type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SeriousCompany.Business.CSharp.FizzBuzz.Impl.Strategies
{
    using SeriousCompany.Business.CSharp.FizzBuzz.Interfaces.Strategies;

    /// <summary>
    /// The fizz strategy.
    /// </summary>
    public class FizzStrategy : IIsEvenlyDivisibleStrategy 
    {
        /// <summary>
        /// The is evenly divisible.
        /// </summary>
        /// <param name="i">
        /// The i.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public bool IsEvenlyDivisible(int i)
        {
            if (i / 3 * 3 == i)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}