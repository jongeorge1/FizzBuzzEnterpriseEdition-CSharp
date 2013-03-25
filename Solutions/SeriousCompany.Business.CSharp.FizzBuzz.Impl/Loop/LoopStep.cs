// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LoopStep.cs" company="SeriousCompany">
// Copyright 2013 Serious Company
// </copyright>
// <summary>
//   Defines the BuzzStrategyFactory type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SeriousCompany.Business.CSharp.FizzBuzz.Impl.Loop
{
    /// <summary>
    /// The loop step.
    /// </summary>
    public class LoopStep
    {
        /// <summary>
        /// The loop increment value.
        /// </summary>
        public const int LoopIncrementValue = 1;

        /// <summary>
        /// The step loop.
        /// </summary>
        /// <param name="i">
        /// The i.
        /// </param>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        public int StepLoop(int i)
        {
            return i + LoopIncrementValue;
        }
    }
}