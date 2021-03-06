﻿using System;

namespace SolrExpress.Core.Search.Result
{
    /// <summary>
    /// Represents a Facet Range without knowledge of the type of the minumum and maximum values
    /// </summary>
    public abstract class FacetRange
    {
        /// <summary>
        /// Minimum value of the facet
        /// </summary>
        protected object InternalMinimumValue { get; set; }

        /// <summary>
        /// Maximum value of the facet
        /// </summary>
        protected object InternalMaximumValue { get; set; }

        /// <summary>
        /// Get the type of the generic member
        /// </summary>
        /// <returns>Type of the generic member</returns>
#if NET40
        public Type GetKeyType() => this.GetType().GetGenericArguments()[0];
#else
        public Type GetKeyType() => this.GetType().GenericTypeArguments[0];
#endif

        /// <summary>
        /// Get the value to the property MinimumValue without strong type
        /// </summary>
        /// <returns>Value to the property MinimumValue without strong type</returns>
        public object GetMinimumValue() => this.InternalMinimumValue;

        /// <summary>
        /// Get the value to the property MaximumValue without strong type
        /// </summary>
        /// <returns>Value to the property MaximumValue without strong type</returns>
        public object GetMaximumValue() => this.InternalMaximumValue;

        /// <summary>
        /// Set the value to the property MinimumValue without strong type
        /// </summary>
        /// <param name="value">Value to set</param>
        public void SetMinimumValue(object value)
        {
            this.InternalMinimumValue = value;
        }

        /// <summary>
        /// Set the value to the property MaximumValue without strong type
        /// </summary>
        /// <param name="value">Value to set</param>
        public void SetMaximumValue(object value)
        {
            this.InternalMaximumValue = value;
        }
    }

    /// <summary>
    /// Represents a Facet Range with knowledge of the type of the minumum and maximum values
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public sealed class FacetRange<T> : FacetRange
        where T : struct, IComparable
    {
        /// <summary>
        /// Minimum value of the facet
        /// </summary>
        public T? MinimumValue
        {
            get
            {
                return (T?)this.InternalMinimumValue;
            }
            set
            {
                this.InternalMinimumValue = value;
            }
        }

        /// <summary>
        /// Maximum value of the facet
        /// </summary>
        public T? MaximumValue
        {
            get
            {
                return (T?)this.InternalMaximumValue;
            }
            set
            {
                this.InternalMaximumValue = value;
            }
        }
    }
}
