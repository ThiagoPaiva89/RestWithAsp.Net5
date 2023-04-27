﻿using RestWithAsp.Net5.Model;
using System.Collections.Generic;

namespace RestWithAsp.Net5.Repository
{
    public interface IBookRepository
    {
        Book Create(Book book);
        Book FindById(long id);
        List<Book> FindAll();
        Book Update(Book book);
        void Delete(long id);
        bool Exists(long id);
    }
}