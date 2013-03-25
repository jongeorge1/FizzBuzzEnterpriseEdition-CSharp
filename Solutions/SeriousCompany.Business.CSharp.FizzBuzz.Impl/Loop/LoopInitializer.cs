// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LoopInitializer.cs" company="SeriousCompany">
// Copyright 2013 Serious Company
// </copyright>
// <summary>
//   Defines the BuzzStrategyFactory type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SeriousCompany.Business.CSharp.FizzBuzz.Impl.Loop
{
    /// <summary>
    /// The loop initializer.
    /// </summary>
    public class LoopInitializer
    {
        /// <summary>
        /// The loop initial value
        /// </summary>
        public const int LoopInitValue = 1;

        /// <summary>
        /// The get loop initialization point.
        /// </summary>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        public int GetLoopInitializationPoint()
        {
            return LoopInitValue;
        }
    }
}