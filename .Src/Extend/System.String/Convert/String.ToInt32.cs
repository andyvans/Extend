﻿#region Usings

using System;
using JetBrains.Annotations;

#endregion

namespace Extend
{
    public static partial class StringEx
    {
        /// <summary>
        ///     Converts the given string to a Int32.
        /// </summary>
        /// <exception cref="ArgumentNullException">The value can not be null.</exception>
        /// <exception cref="FormatException">value  s not in the correct format.</exception>
        /// <exception cref="OverflowException">
        ///     value represents a number less than <see cref="Int32.MinValue" /> or greater than
        ///     <see cref="Int32.MaxValue" />.
        /// </exception>
        /// <param name="value">The string to convert.</param>
        /// <returns>Returns the converted Int32.</returns>
        [Pure]
        [PublicAPI]
        public static Int32 ToInt32( [NotNull] this String value )
        {
            value.ThrowIfNull( nameof(value) );

            return Int32.Parse( value );
        }

        /// <summary>
        ///     Converts the given string to a Int32.
        /// </summary>
        /// <exception cref="ArgumentNullException">The value can not be null.</exception>
        /// <exception cref="ArgumentNullException">The format provider can not be null.</exception>
        /// <exception cref="FormatException">value  s not in the correct format.</exception>
        /// <exception cref="OverflowException">
        ///     value represents a number less than <see cref="Int32.MinValue" /> or greater than
        ///     <see cref="Int32.MaxValue" />.
        /// </exception>
        /// <param name="value">The string to convert.</param>
        /// <param name="formatProvider">The format provider.</param>
        /// <returns>Returns the converted Int32.</returns>
        [Pure]
        [PublicAPI]
        public static Int32 ToInt32( [NotNull] this String value, [NotNull] IFormatProvider formatProvider )
        {
            value.ThrowIfNull( nameof(value) );
            formatProvider.ThrowIfNull( nameof(formatProvider) );

            return Int32.Parse( value, formatProvider );
        }
    }
}