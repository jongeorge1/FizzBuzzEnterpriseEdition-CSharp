// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BuzzStrategy.cs" company="SeriousCompany">
// Copyright 2013 Serious Company
// </copyright>
// <summary>
//   The buzz strategy.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SeriousCompany.Business.CSharp.FizzBuzz.Impl.Strategies
{
    using SeriousCompany.Business.CSharp.FizzBuzz.Interfaces.Strategies;

    /// <summary>
    /// The buzz strategy.
    /// </summary>
    public class BuzzStrategy : IIsEvenlyDivisibleStrategy 
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
            if (i / 5 * 5 == i)
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