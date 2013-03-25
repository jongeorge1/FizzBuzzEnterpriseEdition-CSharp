// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IIntegerStringReturner.cs" company="SeriousCompany">
// Copyright 2013 Serious Company
// </copyright>
// <summary>
//   The IntegerStringReturner interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SeriousCompany.Business.CSharp.FizzBuzz.Interfaces.StringReturners
{
    /// <summary>
    /// The IntegerStringReturner interface.
    /// </summary>
    public interface IIntegerStringReturner
    {
        /// <summary>
        /// The get integer return string.
        /// </summary>
        /// <param name="i">
        /// The i.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        string GetIntegerReturnString(int i);
    }
}