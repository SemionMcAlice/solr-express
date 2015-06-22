﻿using System;
using System.Linq.Expressions;

namespace SolrExpress.Core.Helper
{
    /// <summary>
    /// Helper class use to process arithmetic operations
    /// </summary>
    internal static class GenericHelper
    {
        /// <summary>
        /// Evaluates binary subtract (-) for the given type
        /// </summary>
        internal static T Addition<T>(T value1, T value2)
        {
            return GenericHelper.Addition<T, T>(value1, value2);
        }

        /// <summary>
        /// Evaluates binary subtract (-) for the given type
        /// </summary>
        internal static TResult Addition<TParameter, TResult>(TParameter value1, TParameter value2)
        {
            var left = Expression.Parameter(typeof(TParameter), "left");
            var right = Expression.Parameter(typeof(TParameter), "right");

            var exp = Expression.Lambda<Func<TParameter, TParameter, TResult>>(Expression.Add(left, right), left, right).Compile();

            return exp(value1, value2);
        }

        /// <summary>
        /// Evaluates binary subtract (-) for the given type
        /// </summary>
        internal static T Subtract<T>(T value1, T value2)
        {
            return GenericHelper.Subtract<T, T>(value1, value2);
        }

        /// <summary>
        /// Evaluates binary subtract (-) for the given type
        /// </summary>
        internal static TResult Subtract<TParameter, TResult>(TParameter value1, TParameter value2)
        {
            var left = Expression.Parameter(typeof(TParameter), "left");
            var right = Expression.Parameter(typeof(TParameter), "right");

            var exp = Expression.Lambda<Func<TParameter, TParameter, TResult>>(Expression.Subtract(left, right), left, right).Compile();

            return exp(value1, value2);
        }
    }
}
