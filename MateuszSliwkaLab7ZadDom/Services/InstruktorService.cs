using MateuszSliwkaLab7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MateuszSliwkaLab7.Services
{
    public class InstructorService<T> : IService<T> where T:Instructor
    {
        private static List<T> objects = new List<T>();
        public bool Delete(int id)
        {

            var objectToDelete = objects.Where(x => x.Id.Equals(id)).SingleOrDefault();
            if (objectToDelete == null)
                return false;

            objects.Remove(objectToDelete);
            return true;
        }

        public List<T> GetAll()
        {
            return objects;
        }

        public int Post(T entity)
        {
            if (objects.Count() == 0)
                entity.Id = 0;
            else
                entity.Id = objects.Max(x => x.Id) + 1;
            objects.Add(entity);
            return entity.Id;
        }

        public bool Put(T entity, int Id)
        {
            var entityToUpdate = objects.Where(x => x.Id.Equals(Id)).SingleOrDefault();
            if (entityToUpdate == null)
                return false;

            entityToUpdate.FirstName = entity.FirstName;
            entityToUpdate.LastName = entity.LastName;
            return true;
        }
    }
}
