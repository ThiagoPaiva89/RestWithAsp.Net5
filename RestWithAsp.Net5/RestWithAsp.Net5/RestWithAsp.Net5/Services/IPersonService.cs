using RestWithAsp.Net5.Model;
using System.Collections.Generic;

namespace RestWithAsp.Net5.Services
{
    public interface IPersonService
    {
        Person Create(Person person);
        Person FindById(long id);
        List<Person> FindAll();
        Person Update(Person person);
        void Delete(long id);
    }
}
