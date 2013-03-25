// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IIsEvenlyDivisibleStrategy.cs" company="SeriousCompany">
// Copyright 2013 Serious Company
// </copyright>
// <summary>
//   Defines the IIsEvenlyDivisibleStrategy type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SeriousCompany.Business.CSharp.FizzBuzz.Interfaces.Strategies
{
    /// <summary>
    /// The is evenly divisible strategy interface.
    /// </summary>
    public interface IIsEvenlyDivisibleStrategy
    {
        /// <summary>
        /// The is evenly divisible.
        /// </summary>
        /// <param name="i">
        /// The number.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        bool IsEvenlyDivisible(int i);
    }
}