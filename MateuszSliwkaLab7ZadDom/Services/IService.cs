using System;
using System.Collections.Generic;
using MateuszSliwkaLab7.Models;

namespace MateuszSliwkaLab7.Services
{
    public interface IService <T> where  T:class
    {
        List<T> GetAll();
        int Post(T entity);
        bool Put(T entity, int Id);
        bool Delete(int id);
    }
}
