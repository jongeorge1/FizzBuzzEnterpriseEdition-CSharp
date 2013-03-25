// --------------------------------------------------------------------------------------------------------------------
// <copyright file="NoFizzNoBuzzStrategy.cs" company="SeriousCompany">
// Copyright 2013 Serious Company
// </copyright>
// <summary>
//   Defines the NoFizzNoBuzzStrategy type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace SeriousCompany.Business.CSharp.FizzBuzz.Impl.Strategies
{
    using SeriousCompany.Business.CSharp.FizzBuzz.Interfaces.Strategies;

    /// <summary>
    /// The no fizz no buzz strategy.
    /// </summary>
    public class NoFizzNoBuzzStrategy : IIsEvenlyDivisibleStrategy
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
            if ((i / 3) * 3 != i)
            {
                if ((i / 5) * 5 != i)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if ((i / 5) * 5 != i)
            {
                if ((i / 3) * 3 != i)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}