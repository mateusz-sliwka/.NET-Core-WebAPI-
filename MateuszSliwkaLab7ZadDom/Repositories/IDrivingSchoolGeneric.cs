using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MateuszSliwkaLab7ZadDom.Repositories
{
    interface IDrivingSchoolGeneric<T> where T : class
    {
        List<T> GetAll();
        IQueryable<T> Get();
        T GetById(int id);
        void DeleteById(int id);
        void Update(T entity);
        void Create(T entity);
        void Save();
    }
}
