using MateuszSliwkaLab7ZadDom.Models;
using System;
using System.Collections.Generic;


namespace MateuszSliwkaLab7ZadDom.Services
{
    public interface ICarService
    {
        List<Car> GetAll();
        int Post(Car entity);
        bool Put(Car entity, int Id);
        bool Delete(int id);
    }
}
