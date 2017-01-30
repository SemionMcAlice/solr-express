﻿using SolrExpress.Search;
using SolrExpress.Search.Parameter;
using System;
using System.Collections.Generic;

namespace SolrExpress.Solr4.Search.Parameter
{
    public class LimitParameter<TDocument> : ILimitParameter<TDocument>, ISearchItemExecution<List<string>>
        where TDocument : IDocument
    {
        bool ISearchParameter.AllowMultipleInstances { get; set; }

        long ILimitParameter<TDocument>.Value { get; set; }

        void ISearchItemExecution<List<string>>.AddResultInContainer(List<string> container)
        {
            throw new NotImplementedException();
        }

        void ISearchItemExecution<List<string>>.Execute()
        {
            throw new NotImplementedException();
        }
    }
}