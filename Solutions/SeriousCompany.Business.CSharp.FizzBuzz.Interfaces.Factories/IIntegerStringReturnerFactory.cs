// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IIntegerStringReturnerFactory.cs" company="SeriousCompany">
// Copyright 2013 Serious Company
// </copyright>
// <summary>
//   The IntegerStringReturnerFactory interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SeriousCompany.Business.CSharp.FizzBuzz.Interfaces.Factories
{
    using SeriousCompany.Business.CSharp.FizzBuzz.Interfaces.StringReturners;

    /// <summary>
    /// The IntegerStringReturnerFactory interface.
    /// </summary>
    public interface IIntegerStringReturnerFactory
    {
        /// <summary>
        /// The create integer string returner.
        /// </summary>
        /// <returns>
        /// The <see cref="IIntegerStringReturner"/>.
        /// </returns>
        IIntegerStringReturner CreateIntegerStringReturner();
    }
}