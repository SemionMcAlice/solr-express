# Release Notes

Notes about releases

## [4.2.6] - 2017-07-13

### Enhancement

* Updated NewtonSoft.Json and Flurl (tks [@Baklap4](https://github.com/baklap4))

## [4.2.5] - 2017-04-25

### Bug fix
- Updating/inserting a document fails ([#211](https://github.com/solr-express/solr-express/issues/211)) (tks [@Baklap4](https://github.com/baklap4))

---

## [4.2.4] - 2017-03-19

### Enhancement
- Implements #203 in .Net 4.5 framework ([#204](https://github.com/solr-express/solr-express/issues/204))

---

## [4.2.3] - 2017-03-19

### Enhancement
- Implements #203 in .Net 4.5 framework ([#204](https://github.com/solr-express/solr-express/issues/204))

---

## [4.2.2] - 2017-03-19

### Bug fix
- Error 501 when use SolrCloud  ([#199](https://github.com/solr-express/solr-express/issues/197), [#203](https://github.com/solr-express/solr-express/issues/203))

---

## [4.2.1] - 2017-01-31

### Bug fix
* Wrong variable used in result Interceptors execution ([#197](https://github.com/solr-express/solr-express/issues/197))

---

## [4.2.0] - 2017-01-20

### Enhancement
* Authentication system ([#181](https://github.com/solr-express/solr-express/issues/181))

**NOTE** Basic Auth & Kerberos plugins and Rule-based Authorization plugin was added in 5.3

---

## [4.1.2] - 2017-01-19

### Bug fix
* Wrong facets exclude tags semantics ([#194](https://github.com/solr-express/solr-express/issues/194))

---

## [4.1.1] - 2017-01-16

### Bug fix
* DI bugs in full .NET framework ([#186](https://github.com/solr-express/solr-express/issues/186))

---

## [4.1.0] - 2017-01-13

### Enhancement
* Better way to find Minimum/Maximum in range facet result in SOLR 5.0 ([#131](https://github.com/solr-express/solr-express/issues/131))
* Improve performance ([#132](https://github.com/solr-express/solr-express/issues/132) and [#167](https://github.com/solr-express/solr-express/issues/167))
* Create unit tests to Checker class ([#168](https://github.com/solr-express/solr-express/issues/168))
* QueryAll in extension class ([#169](https://github.com/solr-express/solr-express/issues/169))
* Review package references in .Net Standard 1.6 ([#178](https://github.com/solr-express/solr-express/issues/178)) - closes ([#177](https://github.com/solr-express/solr-express/issues/177))
* Filter using AnyValue in extension class ([#183](https://github.com/solr-express/solr-express/issues/183))
* Option to not calculate facet range before and after ([#184](https://github.com/solr-express/solr-express/issues/184)) - closes ([#180](https://github.com/solr-express/solr-express/issues/180))

---

## [4.0.7] - 2016-12-14

### Bug fix
* Default parameters conflit with configued parameters ([#175](https://github.com/solr-express/solr-express/issues/175))

---

## [4.0.6] - 2016-12-13

### Bug fix
* Wrong dependency injection ([#173](https://github.com/solr-express/solr-express/issues/173))

---

## [4.0.5] - 2016-12-13

### Bug fix
* Inaccessible internal services when configure multiple Documents ([#172](https://github.com/solr-express/solr-express/issues/172))

---

## [4.0.4] - 2016-12-02

### Enhancement
* Create tag property in Facet itens ([#166](https://github.com/solr-express/solr-express/issues/166))

---

## [4.0.3] - 2016-12-01

### Enhancement
* Create tag property in Facet itens ([#165](https://github.com/solr-express/solr-express/issues/165))

---

## [4.0.2] - 2016-09-26

### Bug fix
* SearchResult.Info.PageNumber not equal to StartParameter.Value ([#157](https://github.com/solr-express/solr-express/issues/157))

### Enhancement
* Create validation when use SolrExpress.Core.Update.AtomicDelete with 0 documentIds ([#149](https://github.com/solr-express/solr-express/issues/149))

---

## [4.0.1] - 2016-09-14

### Bug fix
* ISearchParameterBuilder.Filter, parameters 'from' and 'to' must be default null ([#152](https://github.com/solr-express/solr-express/issues/152))
* Unable to resolve service for type 'IEngine' while attempting to activate 'SearchParameterBuilder` ([#154](https://github.com/solr-express/solr-express/issues/154))

### Enhancement
* SolrExpress.Core.Search.ISolrSearch.Add methods must return itself instance ([#150](https://github.com/solr-express/solr-express/issues/150))
* ISolrSearch must accept AddRange ([#153](https://github.com/solr-express/solr-express/issues/153))

---

## [4.0.0] - 2016-09-14
### Bug fix
* Friendly assembly wont work ([#122](https://github.com/solr-express/solr-express/issues/122))
* Check if parameter called "parameters" is null in result processors ([#142](https://github.com/solr-express/solr-express/issues/142))
* Invalid cast when a facet range is created using a field of long type ([#143](https://github.com/solr-express/solr-express/issues/143))
* Wrong query when using SpatialFilter ([#148](https://github.com/solr-express/solr-express/issues/148)) 

### Enhancement
* Cleanup in package.json files ([#138](https://github.com/solr-express/solr-express/issues/138))
* Create benchmarks ([#139](https://github.com/solr-express/solr-express/issues/139))
* Create interface to be used in DocumentCollection, SolrQueryable e SolrAtomicUpdate classes ([#140](https://github.com/solr-express/solr-express/issues/140))
* DI review ([#141](https://github.com/solr-express/solr-express/issues/141))
* Code review ([#147](https://github.com/solr-express/solr-express/issues/147))

> **PAY ATTENTION**
> 
> Issues ([#141](https://github.com/solr-express/solr-express/issues/141)) and ([#147](https://github.com/solr-express/solr-express/issues/147)) causes BREAKING CHANGES 

### **BREAKING CHANGES**

* To use DocumentCollection

Before

```
var provider = new Provider("http://localhost:8983/solr/techproducts");
var resolver = new SimpleResolver().Configure();
var configuration = new Configuration();
var techProducts = new DocumentCollection<TechProduct>(provider, resolver, configuration);
```

After

```
Using Net.Core
serviceCollection.AddSolrExpress<TechProduct>(builder => builder
    .UseHostAddress("http://localhost:8983/solr/techproducts")
    .UseOptions(/*options instance*/) // Optionally
    .UseSolr5()); // Or UserSolr4()

In some controller/service/however
public ClassConstructor(IDocumentCollection<TechProduct> techProducts)
{
    //...
}

Using Net4 or Net4.5
techProducts = new DocumentCollectionBuilder<TechProduct>()
    .AddSolrExpress()
    .UseHostAddress("http://localhost:8983/solr/techproducts")
    .UseOptions(/*options instance*/) // Optionally
    .UseSolr5()  // Or UserSolr4()
    .Create();
```

* To create a new parameter without using ISolrSearch

Before

```
var parameter = new QueryParameter<TechProductDocument>().Configure(new QueryAll());
```

After

```
Using Net.Core
In some controller/service/however
public ClassConstructor(ISearchParameterBuilder<TDocument> parameterBuilder)
{
    var parameter = parameterBuilder.Query(new QueryAll());
}

Using Net4 or Net4.5
Sorry bro... continues using the old way :/
```

---

## [3.1.2] - 2016-07-30
### Enhancement
* Add default parameters ([#125](https://github.com/solr-express/solr-express/issues/125))
* Create unit test to test validations methods ([#129](https://github.com/solr-express/solr-express/issues/129))
* Organize changelogs in CHANGELOG.md file ([#133](https://github.com/solr-express/solr-express/issues/133))
* Change projects dependencies ([#136](https://github.com/solr-express/solr-express/issues/136))

---

## [3.1.1] - 2016-07-19
### Bug fix
* Create mincount using solr field name rather than POCO property name ([#128](https://github.com/solr-express/solr-express/issues/128))
* In sort validation, must use "index" property rather than "stored" property ([#127](https://github.com/solr-express/solr-express/issues/127))
* Need encode parameters in FacetRange ([#123](https://github.com/solr-express/solr-express/issues/123))

### Enhancement
* Change all properties in SolrExpress.Core.Query.ParameterValue.* classes to public {get; private set;} ([#130](https://github.com/solr-express/solr-express/issues/130))
* Use List< IParameter > parameters to calculate gaps and discovery facet types ([#46](https://github.com/solr-express/solr-express/issues/46))
* Recode Core.Query.ParameterValue.Range<> ([#126](https://github.com/solr-express/solr-express/issues/126))
* Use min.count = 1 ([#50](https://github.com/solr-express/solr-express/issues/50))

---

## [3.1.0] - 2016-07-12
### Bug fix
* Wrong default namespace in xprojs ([#121](https://github.com/solr-express/solr-express/issues/121))
* Create wrong parameter when use BoostType.Boost ([#117](https://github.com/solr-express/solr-express/issues/117))

### Enhancement
* Ignore list ([#118](https://github.com/solr-express/solr-express/issues/118), [#120](https://github.com/solr-express/solr-express/issues/120))
* Change base version to 4.0 and add support to 4.5 rather than 4.5.1 ([#119](https://github.com/solr-express/solr-express/issues/119))
* Rename class Statistic to Info ([#116](https://github.com/solr-express/solr-express/issues/116))
* Implements random sort ([#110](https://github.com/solr-express/solr-express/issues/110))

---

## [3.0.0] - 2016-07-07
### Enhancement
* Support to .Net Core 1.0 ([#109](https://github.com/solr-express/solr-express/issues/109))
* Interceptors (Query and Result) and Parameters in global form ([#114](https://github.com/solr-express/solr-express/issues/114))
* Create handler parameter to avoid string in Execute method ([#115](https://github.com/solr-express/solr-express/issues/115))

> **NOTES**
> All projects are signed by default (no more *.Signed packages)

---

## [2.1.0] - 2016-05-13
### Bug fix
1. In Solr 5.5, when 2 sorts parameters are added, a bad format is created and Solr don't process the request ([#101](https://github.com/solr-express/solr-express/issues/101))
2. Description of exception InvalidParameterTypeException is bad formatted ([#100](https://github.com/solr-express/solr-express/issues/100))

### Enhancement
1. Extensions ([#99](https://github.com/solr-express/solr-express/issues/99), [#103](https://github.com/solr-express/solr-express/issues/103))
2. Atomic update ([#106](https://github.com/solr-express/solr-express/issues/106))
3. Simple interceptions ([#104](https://github.com/solr-express/solr-express/issues/104), [#105](https://github.com/solr-express/solr-express/issues/105))
3. Boost parameter ([#102](https://github.com/solr-express/solr-express/issues/102))
4. Exception description ([#98](https://github.com/solr-express/solr-express/issues/98))

---

## [2.0.0] - 2016-05-05
### Bug fix
* Fix hyperlink to samples in readme.md ([#93](https://github.com/solr-express/solr-express/issues/93))

### Enhancement
* Code cleanup and reorganization
* Improves in DI
* Atomic update ([#94](https://github.com/solr-express/solr-express/issues/94))

---

## [1.2.0.1] - 2016-01-06
### Bug fix
* NuGet mistakes ([#86](https://github.com/solr-express/solr-express/issues/86))
* Unit test fix ([#89](https://github.com/solr-express/solr-express/issues/89))

### Enhancement
* Rename ParameterValue classes removing "Value" suffix ([#90](https://github.com/solr-express/solr-express/issues/90))
* Create SpatialFilterParamaterValue ([#91](https://github.com/solr-express/solr-express/issues/91))
* Docs updat ([#85](https://github.com/solr-express/solr-express/issues/85))
* Create a better way to discovery field type in facet ranges ([#53](https://github.com/solr-express/solr-express/issues/53))
* Create FreeParameter ([#83](https://github.com/solr-express/solr-express/issues/83))
* ThrowHelper ([#88](https://github.com/solr-express/solr-express/issues/88))
* Create option to choose request handler ([#82](https://github.com/solr-express/solr-express/issues/82))
* Fluent language ([#87](https://github.com/solr-express/solr-express/issues/87))

---

## [1.1.0.2] - 2015-12-15
* NuGet mistakes

---

## [1.1.0.1] - 2015-12-10
* NuGet mistakes

---

## [1.1.0] - 2015-12-10
### Bug fix
* Wrong query when use MultiValue and SolrQueryConditionType ([#76](https://github.com/solr-express/solr-express/issues/76))

### Changes
* Change namespace of class IDocument ([#78](https://github.com/solr-express/solr-express/issues/78))
* Migrate Fluent Api to core project ([#66](https://github.com/solr-express/solr-express/issues/66))
* StatisticResultBuilder must result a class ([#77](https://github.com/solr-express/solr-express/issues/77))
* Update to C# 6.0 ([#38](https://github.com/solr-express/solr-express/issues/38))

### Enhancement
* Signed package enhancement ([#65](https://github.com/solr-express/solr-express/issues/65))
* Globalization ([#42](https://github.com/solr-express/solr-express/issues/42))

---

## [1.0.01] - 2015-08-27

All Is Said And Done :)

Read the documentation and if you have some question or find some error, please, contact me