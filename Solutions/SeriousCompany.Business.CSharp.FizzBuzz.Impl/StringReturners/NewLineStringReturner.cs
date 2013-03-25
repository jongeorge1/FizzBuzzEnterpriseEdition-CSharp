// --------------------------------------------------------------------------------------------------------------------
// <copyright file="NewLineStringReturner.cs" company="SeriousCompany">
// Copyright 2013 Serious Company
// </copyright>
// <summary>
//   Defines the NewLineStringReturner type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SeriousCompany.Business.CSharp.FizzBuzz.Impl.StringReturners
{
    using System.Configuration;
    using System.Text;

    using SeriousCompany.Business.CSharp.FizzBuzz.Interfaces.StringReturners;

    /// <summary>
    /// The new line string returner.
    /// </summary>
    public class NewLineStringReturner : IStringStringReturner
    {
        /// <summary>
        /// The get return string.
        /// </summary>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public string GetReturnString()
        {
            var systemDefaultNewLineString = ConfigurationManager.AppSettings["line.separator"];
            var myStringBuilder = new StringBuilder(systemDefaultNewLineString);
            var myString = myStringBuilder.ToString();
            return myString;
        }
    }
}