using MateuszSliwkaLab7ZadDom.Models;
using System;
using System.Collections.Generic;


namespace MateuszSliwkaLab7ZadDom.Services
{
    public interface IInstructorService
    {
        List<Instructor> GetAll();
        int Post(Instructor entity);
        bool Put(Instructor entity, int Id);
        bool Delete(int id);
    }
}
