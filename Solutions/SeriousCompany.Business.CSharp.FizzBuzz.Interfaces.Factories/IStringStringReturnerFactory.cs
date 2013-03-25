// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IStringStringReturnerFactory.cs" company="SeriousCompany">
// Copyright 2013 Serious Company
// </copyright>
// <summary>
//   Defines the IStringStringReturnerFactory type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SeriousCompany.Business.CSharp.FizzBuzz.Interfaces.Factories
{
    using SeriousCompany.Business.CSharp.FizzBuzz.Interfaces.StringReturners;

    /// <summary>
    /// The StringStringReturnerFactory interface.
    /// </summary>
    public interface IStringStringReturnerFactory
    {
        /// <summary>
        /// The create string string returner.
        /// </summary>
        /// <returns>
        /// The <see cref="IStringStringReturner"/>.
        /// </returns>
        IStringStringReturner CreateStringStringReturner();
    }
}