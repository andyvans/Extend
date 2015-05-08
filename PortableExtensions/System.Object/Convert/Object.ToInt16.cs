﻿#region Usings

using System;
using System.Globalization;

#endregion

namespace PortableExtensions
{
    /// <summary>
    ///     Class containing some extension methods for <see cref="object" />.
    /// </summary>
    public static partial class ObjectEx
    {
        /// <summary>
        ///     Converts the given object to a Int16.
        /// </summary>
        /// <exception cref="ArgumentNullException">The object can not be null.</exception>
        /// <param name="obj">The object to convert.</param>
        /// <returns>The Int16.</returns>
        public static Int16 ToInt16( this Object obj )
        {
            obj.ThrowIfNull( () => obj );

            return Convert.ToInt16( obj, CultureInfo.CurrentCulture );
        }

        /// <summary>
        ///     Converts the given object to a Int16.
        /// </summary>
        /// <exception cref="ArgumentNullException">The object can not be null.</exception>
        /// <exception cref="ArgumentNullException">The format provider can not be null.</exception>
        /// <param name="obj">The object to convert.</param>
        /// <param name="formatProvider">The format provider.</param>
        /// <returns>The Int16.</returns>
        public static Int16 ToInt16( this Object obj, IFormatProvider formatProvider )
        {
            obj.ThrowIfNull( () => obj );
            formatProvider.ThrowIfNull( () => formatProvider );

            return Convert.ToInt16( obj, formatProvider );
        }
    }
}