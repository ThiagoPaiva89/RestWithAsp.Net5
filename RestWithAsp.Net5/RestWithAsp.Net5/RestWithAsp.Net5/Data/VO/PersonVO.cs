using RestWithAsp.Net5.Hypermedia;
using RestWithAsp.Net5.Hypermedia.Abstract;
using System.Collections.Generic;

namespace RestWithAsp.Net5.Data.VO
{
    public class PersonVO : ISupportsHypermedia
    {
        public long Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public string Gender { get; set; }
        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();
    }
}
