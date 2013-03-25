// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IntegerIntegerStringReturner.cs" company="SeriousCompany">
// Copyright 2013 Serious Company
// </copyright>
// <summary>
//   Defines the IntegerIntegerStringReturner type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SeriousCompany.Business.CSharp.FizzBuzz.Impl.StringReturners
{
    using System.Text;

    using SeriousCompany.Business.CSharp.FizzBuzz.Interfaces.StringReturners;

    /// <summary>
    /// The integer integer string returner.
    /// </summary>
    public class IntegerIntegerStringReturner : IIntegerStringReturner
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
        public string GetIntegerReturnString(int i)
        {
            var myInteger = i;
            var myStringBuilder = new StringBuilder(myInteger.ToString());
            var myString = myStringBuilder.ToString();
            return myString;
        }
    }
}