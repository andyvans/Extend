﻿#region Usings

using System;
using JetBrains.Annotations;

#endregion

namespace Extend
{
    /// <summary>
    ///     Class containing some extension methods for <see cref="object" />.
    /// </summary>
    public static partial class ObjectEx
    {
        /// <summary>
        ///     Converts the value of the specified object to a 32-bit signed integer.
        /// </summary>
        /// <exception cref="FormatException">value is not in an appropriate format for an <see cref="Int32" /> type.</exception>
        /// <exception cref="InvalidCastException">
        ///     value does not implement the System.IConvertible interface.
        ///     Or the conversion is not supported.
        /// </exception>
        /// <exception cref="OverflowException">
        ///     value represents a number that is less than <see cref="Int32.MinValue" /> or greater than
        ///     <see cref="Int32.MaxValue" />.
        /// </exception>
        /// <param name="obj">An object that implements the System.IConvertible interface, or null.</param>
        /// <returns>A 32-bit signed integer that is equivalent to value, or zero if value is null.</returns>
        [Pure]
        [PublicAPI]
        public static Int32 ToInt32( [CanBeNull] this Object obj )
            => Convert.ToInt32( obj );

        /// <summary>
        ///     Converts the specified string representation of a number to an equivalent 32-bit signed integer, using the
        ///     specified culture-specific formatting information.
        /// </summary>
        /// <exception cref="FormatException">value is not in an appropriate format for an <see cref="Int32" /> type.</exception>
        /// <exception cref="InvalidCastException">
        ///     value does not implement the System.IConvertible interface.
        ///     Or the conversion is not supported.
        /// </exception>
        /// <exception cref="OverflowException">
        ///     value represents a number that is less than <see cref="Int32.MinValue" /> or greater than
        ///     <see cref="Int32.MaxValue" />.
        /// </exception>
        /// <param name="obj">An object that implements the System.IConvertible interface, or null.</param>
        /// <param name="formatProvider">The format provider.</param>
        /// <returns>A 32-bit signed integer that is equivalent to value, or zero if value is null.</returns>
        [Pure]
        [PublicAPI]
        public static Int32 ToInt32( [CanBeNull] this Object obj, [CanBeNull] IFormatProvider formatProvider )
            => Convert.ToInt32( obj, formatProvider );
    }
}