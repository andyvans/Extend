﻿#region Usings

using System;
using System.Linq;
using JetBrains.Annotations;

#endregion

namespace Extend
{
    public static partial class StringEx
    {
        /// <summary>
        ///     Checks if the string is alpha numeric.
        /// </summary>
        /// <exception cref="ArgumentNullException">The string can not be null.</exception>
        /// <param name="str">The string to check.</param>
        /// <returns>Returns true if the string is alpha numeric, otherwise false.</returns>
        [Pure]
        [PublicAPI]
        public static Boolean IsAlphaNumeric( [NotNull] this String str )
        {
            str.ThrowIfNull( nameof(str) );

            return str.ToCharArray()
                      .All( x => x.IsLetter() || x.IsNumber() );
        }
    }
}