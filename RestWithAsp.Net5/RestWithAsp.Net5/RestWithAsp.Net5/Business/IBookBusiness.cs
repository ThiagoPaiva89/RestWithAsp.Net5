using RestWithAsp.Net5.Data.VO;
using System.Collections.Generic;

namespace RestWithAsp.Net5.Business
{
    public interface IBookBusiness
    {
        BookVO Create(BookVO book);
        BookVO FindById(long id);
        List<BookVO> FindAll();
        BookVO Update(BookVO book);
        void Delete(long id);
    }
}
