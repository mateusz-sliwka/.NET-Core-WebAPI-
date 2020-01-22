
using MateuszSliwkaLab7ZadDom.Models;
using MateuszSliwkaLab7ZadDom.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MateuszSliwkaLab7ZadDom.Services
{
    public class InstructorService<T> : IInstructorService //klasa dziala identycnzie jak CarService, rozni sie tylko modelem na jakim bazuje (instructor)
    {
        private readonly IDrivingSchoolGeneric<Instructor> _Instructors;
        public InstructorService()
        {
            _Instructors = new DrivingSchoolGeneric<Instructor>();
        }

        internal IDrivingSchoolGeneric<Instructor> Instructors => _Instructors;

        public bool Delete(int id)
        {
            var objectToDelete = _Instructors.GetAll().Where(x => x.Id.Equals(id)).SingleOrDefault();
            if (objectToDelete == null)
                return false;

            _Instructors.DeleteById(id);
            _Instructors.Save();
            return true;
        }

        public int Post(Instructor entity)
        {
            _Instructors.Create(entity);
            _Instructors.Save();
            return entity.Id;
        }

        public bool Put(Instructor entity, int Id)
        {
            var entityToUpdate = _Instructors.GetById(Id);
            if (entityToUpdate == null)
                return false;
            entityToUpdate.FirstName = entity.FirstName;
            entityToUpdate.LastName= entity.LastName;
            entityToUpdate.Category = entity.Category;
            _Instructors.Update(entityToUpdate);
            _Instructors.Save();
            return true;
        }


        List<Instructor> IInstructorService.GetAll()
        {
            return _Instructors.GetAll();
        }
    }
}
