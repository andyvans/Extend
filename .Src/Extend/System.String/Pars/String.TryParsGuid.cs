﻿#region Usings

using System;
using JetBrains.Annotations;

#endregion

namespace Extend
{
    public static partial class StringEx
    {
        /// <summary>
        ///     Converts the string representation of a GUID to the equivalent <see cref="Guid" /> structure.
        /// </summary>
        /// <param name="value">The GUID to convert.</param>
        /// <param name="outValue">
        ///     The structure that will contain the parsed value. If the method returns true,result contains a
        ///     valid <see cref="Guid" />. If the method returns false, result equals <see cref="Guid.Empty" />.
        /// </param>
        /// <returns>Returns true if the parse operation was successful; otherwise, false.</returns>
        [Pure]
        [PublicAPI]
        public static Boolean TryParsGuid( [CanBeNull] this String value, out Guid outValue )
            => Guid.TryParse( value, out outValue );
    }
}