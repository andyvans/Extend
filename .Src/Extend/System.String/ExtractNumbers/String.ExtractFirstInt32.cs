﻿#region Usings

using System;
using JetBrains.Annotations;

#endregion

namespace Extend
{
    public static partial class StringEx
    {
        /// <summary>
        ///     Extracts the first Int32 from the given string.
        /// </summary>
        /// <exception cref="ArgumentNullException">The value can not be null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Invalid start index.</exception>
        /// <param name="value">The string to extract the decimal from.</param>
        /// <param name="startIndex">The start index of the string.</param>
        /// <returns>The extracted Int32.</returns>
        [Pure]
        [PublicAPI]
        public static Int32 ExtractFirstInt32( [NotNull] this String value, Int32 startIndex = 0 )
            => ExtractNumber( value, startIndex )
                .ToInt32();
    }
}