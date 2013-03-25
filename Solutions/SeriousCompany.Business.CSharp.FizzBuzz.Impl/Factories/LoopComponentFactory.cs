// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LoopComponentFactory.cs" company="SeriousCompany">
// Copyright 2013 Serious Company
// </copyright>
// <summary>
//   Defines the BuzzStrategyFactory type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SeriousCompany.Business.CSharp.FizzBuzz.Impl.Factories
{
    using SeriousCompany.Business.CSharp.FizzBuzz.Impl.Loop;

    /// <summary>
    /// The loop component factory.
    /// </summary>
    public class LoopComponentFactory
    {
        /// <summary>
        /// The create loop condition.
        /// </summary>
        /// <returns>
        /// The <see cref="LoopCondition"/>.
        /// </returns>
        public LoopCondition CreateLoopCondition()
        {
            var myLoopCondition = new LoopCondition();
            return myLoopCondition;
        }

        /// <summary>
        /// The create loop initializer.
        /// </summary>
        /// <returns>
        /// The <see cref="LoopInitializer"/>.
        /// </returns>
        public LoopInitializer CreateLoopInitializer()
        {
            var myLoopInitializer = new LoopInitializer();
            return myLoopInitializer;
        }

        /// <summary>
        /// The create loop step.
        /// </summary>
        /// <returns>
        /// The <see cref="LoopStep"/>.
        /// </returns>
        public LoopStep CreateLoopStep()
        {
            var myLoopStep = new LoopStep();
            return myLoopStep;
        }
    }
}