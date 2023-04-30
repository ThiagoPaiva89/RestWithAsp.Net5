using RestWithAsp.Net5.Hypermedia.Abstract;
using System.Collections.Generic;

namespace RestWithAsp.Net5.Hypermedia.Filters
{
    public class HyperMediaFilterOptions
    {
        public List<IResponseEnricher> ContentResponseEnricherList { get; set; } = new List<IResponseEnricher>();
    }
}
