using MateuszSliwkaLab7ZadDom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace MateuszSliwkaLab7ZadDom.Repositories
{
    public class DrivingSchoolGeneric<T> : IDrivingSchoolGeneric<T> where T : class //repozytorium dzialajace na bazie danych
    {
        private readonly DrivingSchoolContext _context;

        public DrivingSchoolGeneric() //konstruktor
        {
            var optionsBuilder = new DbContextOptionsBuilder<DrivingSchoolContext>();
            optionsBuilder.UseSqlServer("Server = DESKTOP-VV3H11R; Database=DrivingSchool; Trusted_Connection = True;MultipleActiveResultSets=true");
                _context = new DrivingSchoolContext(optionsBuilder.Options); //stworzneie nowego contextu, podanie jako argument connstringa
        }
        public void Create(T entity) //operacja tworzenia obiektu
        {
            _context.Set<T>().Add(entity); //doddawanie obiektu do kolkekcji w bazie danych
        }

        public void DeleteById(int id) //usuwanie
        {
            T entities = _context.Set<T>().Find(id); //pobranie z bazy na podst id
            _context.Set<T>().Remove(entities); //usuniecie
        }

        public IQueryable<T> Get() //pobranie query 
        {
            return _context.Set<T>().AsQueryable();
        }

        public List<T> GetAll() //pobranie wszystkich obiektow z bazy
        {
            return _context.Set<T>().ToList<T>();
        }

        public T GetById(int id) //pobranie obiektu o danyhm id
        {
            return _context.Set<T>().Find(id);
        }

        public void Save() //zapisanie zmian
        {
            _context.SaveChanges();
        }

        public void Update(T entity) //akutalizacja stnau bazy
        {
            _context.Entry(entity).CurrentValues.SetValues(entity);
            _context.SaveChanges();
        }
    }
}
