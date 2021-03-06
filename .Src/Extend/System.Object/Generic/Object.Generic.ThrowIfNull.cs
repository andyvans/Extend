﻿#region Usings

using System;
using System.Diagnostics;
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
        ///     Throws a <see cref="ArgumentNullException" /> exception if <paramref name="obj" /> is null.
        /// </summary>
        /// <remarks>
        ///     If <paramref name="errorMessage" /> is null, this method will use the following default message:
        ///     "{object name} can not be null."
        /// </remarks>
        /// <typeparam name="TObject">The type <paramref name="obj" />.</typeparam>
        /// <param name="obj">The object to check.</param>
        /// <param name="parameterName">The name of <paramref name="obj" />.</param>
        /// <param name="errorMessage">
        ///     The text used as exception message if <paramref name="obj" /> is null.
        /// </param>
        [PublicAPI]
        [DebuggerStepThrough]
        public static void ThrowIfNull<TObject>( [NoEnumeration] [CanBeNull] this TObject obj,
                                                 [NotNull] String parameterName,
                                                 [CanBeNull] String errorMessage = null )
        {
            if ( obj != null )
                return;

            throw new ArgumentNullException( parameterName,
                                             errorMessage ?? $"{parameterName} can not be null." );
        }
    }
}