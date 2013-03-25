// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FizzStringReturner.cs" company="SeriousCompany">
// Copyright 2013 Serious Company
// </copyright>
// <summary>
//   The Fizz string returner.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SeriousCompany.Business.CSharp.FizzBuzz.Impl.StringReturners
{
    using System.Text;

    using SeriousCompany.Business.CSharp.FizzBuzz.Interfaces.StringReturners;

    /// <summary>
    /// The Fizz string returner.
    /// </summary>
    public class FizzStringReturner : IStringStringReturner
    {
        /// <summary>
        /// The get return string.
        /// </summary>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public string GetReturnString()
        {
            var myStringBuilder = new StringBuilder("Fizz");
            var myString = myStringBuilder.ToString();
            return myString;
        }
    }
}