using System.Collections.Generic;

namespace RestWithAsp.Net5.Data.Converter.Contract
{
    public interface IParser<Origin, Destiny>
    {
        Destiny Parse(Origin origin);
        List<Destiny> Parse(List<Origin> origin);
    }
}
