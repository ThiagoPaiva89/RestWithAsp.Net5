using RestWithAsp.Net5.Data.VO;
using System.Collections.Generic;

namespace RestWithAsp.Net5.Business
{
    public interface IPersonBusiness
    {
        PersonVO Create(PersonVO person);
        PersonVO FindById(long id);
        List<PersonVO> FindAll();
        PersonVO Update(PersonVO person);
        void Delete(long id);
    }
}
