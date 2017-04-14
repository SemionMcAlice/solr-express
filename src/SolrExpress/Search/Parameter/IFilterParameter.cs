﻿using SolrExpress.Search.Query;

namespace SolrExpress.Search.Parameter
{
    /// <summary>
    /// Signatures to use in filter parameter
    /// </summary>
    public interface IFilterParameter<TDocument> : ISearchParameter
        where TDocument : IDocument
    {
        /// <summary>
        /// Value of filter
        /// </summary>
        ISearchQuery Query { get; set; }

        /// <summary>
        /// Tag name to use in facet excluding list
        /// </summary>
        string TagName { get; set; }
    }
}
