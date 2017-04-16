﻿using SolrExpress.Core.Search.Parameter;
using SolrExpress.Search.Parameter;
using System;
using System.Linq.Expressions;

namespace SolrExpress.Extension
{
    /// <summary>
    /// Extensions to configure in spatial filter parameter
    /// </summary>
    public static class ISpatialFilterParameterExtension

    {
        /// <summary>
        /// Configure expression used to find field name
        /// </summary>
		/// <param name="parameter">Parameter to congigure</param>
        /// <param name="fieldExpression">Expression used to find field name</param>
        public static ISpatialFilterParameter<TDocument> FieldExpression<TDocument>(this ISpatialFilterParameter<TDocument> parameter, Expression<Func<TDocument, object>> fieldExpression)
            where TDocument : IDocument
        {
            parameter.FieldExpression = fieldExpression;

            return parameter;
        }

        /// <summary>
        /// Configure function used in spatial filter
        /// </summary>
		/// <param name="parameter">Parameter to congigure</param>
        /// <param name="functionType">Function used in spatial filter</param>
        public static ISpatialFilterParameter<TDocument> FunctionType<TDocument>(this ISpatialFilterParameter<TDocument> parameter, SpatialFunctionType functionType)
            where TDocument : IDocument
        {
            parameter.FunctionType = functionType;

            return parameter;
        }

        /// <summary>
        /// Configure center point to spatial filter
        /// </summary>
		/// <param name="parameter">Parameter to congigure</param>
        /// <param name="centerPoint">Center point to spatial filter</param>
        public static ISpatialFilterParameter<TDocument> CenterPoint<TDocument>(this ISpatialFilterParameter<TDocument> parameter, GeoCoordinate centerPoint)
            where TDocument : IDocument
        {
            parameter.CenterPoint = centerPoint;

            return parameter;
        }

        /// <summary>
        /// Configure distance from center point
        /// </summary>
		/// <param name="parameter">Parameter to congigure</param>
        /// <param name="distance">Distance from center point</param>
        public static ISpatialFilterParameter<TDocument> Distance<TDocument>(this ISpatialFilterParameter<TDocument> parameter, decimal distance)
            where TDocument : IDocument
        {
            parameter.Distance = distance;

            return parameter;
        }
    }
}