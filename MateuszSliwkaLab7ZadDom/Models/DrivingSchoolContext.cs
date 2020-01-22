using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

namespace MateuszSliwkaLab7ZadDom.Models
{
    public class DrivingSchoolContext : DbContext
    {
        public DrivingSchoolContext(DbContextOptions<DrivingSchoolContext> options) : base(options) //konstruktor przyjmujacy opcje po to zeby wczytaj connStringa z appsetings
        {
        }
        public virtual DbSet<Car> Cars{ get; set; } //stworzenie setu samochdowo w bazie na podstawie klasy Car
        public virtual DbSet<Instructor> Instructors { get; set; } //to co wyzej tyle z z isntruktorami
    }
}
