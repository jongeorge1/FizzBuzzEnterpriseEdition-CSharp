// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IStringStringReturner.cs" company="SeriousCompany">
// Copyright 2013 Serious Company
// </copyright>
// <summary>
//   Defines the IStringStringReturner type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SeriousCompany.Business.CSharp.FizzBuzz.Interfaces.StringReturners
{
    /// <summary>
    /// The StringStringReturner interface.
    /// </summary>
    public interface IStringStringReturner
    {
        /// <summary>
        /// The get return string.
        /// </summary>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        string GetReturnString();
    }
}