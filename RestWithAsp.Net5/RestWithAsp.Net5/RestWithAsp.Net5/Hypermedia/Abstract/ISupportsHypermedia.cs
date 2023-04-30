using System.Collections.Generic;

namespace RestWithAsp.Net5.Hypermedia.Abstract
{
    public interface ISupportsHypermedia
    {
        List<HyperMediaLink> Links { get; set; }
    }
}
