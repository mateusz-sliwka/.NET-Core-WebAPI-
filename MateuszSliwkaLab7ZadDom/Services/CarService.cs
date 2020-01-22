using MateuszSliwkaLab7ZadDom.Models;
using MateuszSliwkaLab7ZadDom.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
namespace MateuszSliwkaLab7ZadDom.Services
{
    public class CarService<T> : ICarService //klasa przekierowujaca zadanie do wykonanaia w bazie
    {
        private  static IDrivingSchoolGeneric<Car> _cars; 

        public CarService() //konstruktor
        {
            _cars = new DrivingSchoolGeneric<Car>(); //przypisanie wartosci nowego generica
        }

        public bool Delete(int id)
        {
            var objectToDelete = _cars.GetAll().Where(x => x.Id.Equals(id)).SingleOrDefault(); //pobranie obiektu do usuniecia
            if (objectToDelete == null) //sprawdzenie czy wgl go znaleziono
                return false; //jezeli brak to zwracamy false
            _cars.DeleteById(id); //jezeli jest to usuwamy
            _cars.Save(); //zapisujemy zmiany w db
            return true; //zwracamy true
        }

        public int Post(Car entity) //wstawianie auta
        {
            _cars.Create(entity); //wykonuejmy poelceneie stworzenia obiektu w bazie
            _cars.Save(); //zapisujemy
            return entity.Id; //zwracamy id utworzonego obiektu
        }

        public bool Put(Car entity, int Id) //aktualziowanie auta
        {
            var entityToUpdate = _cars.GetById(Id); //pobranie auta o zadanym id
            if (entityToUpdate == null) //sprawdzenie czy istnieje
                return false;
            entityToUpdate.Brand = entity.Brand; //zaktualizowanie jego pol
            entityToUpdate.Model = entity.Model;
            entityToUpdate.Mileage = entity.Mileage;
            _cars.Update(entityToUpdate); //przekazanie do zupdatowania w bazie
            _cars.Save(); //zapisanie zmian
            return true; //zwrocenie prawdy
        }

        List<Car> ICarService.GetAll() //pobranie wszystkich aut 
        {
            return _cars.GetAll();
        }
    }
}
