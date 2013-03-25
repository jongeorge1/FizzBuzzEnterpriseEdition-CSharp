// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LoopCondition.cs" company="SeriousCompany">
// Copyright 2013 Serious Company
// </copyright>
// <summary>
//   Defines the BuzzStrategyFactory type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SeriousCompany.Business.CSharp.FizzBuzz.Impl.Loop
{
    /// <summary>
    /// The loop condition.
    /// </summary>
    public class LoopCondition 
    {
        /// <summary>
        /// The evaluate loop.
        /// </summary>
        /// <param name="i">
        /// The i.
        /// </param>
        /// <param name="n">
        /// The n.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public bool EvaluateLoop(int i, int n)
        {
            if (i < n)
            {
                return true;
            }
            else if (i == n)
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