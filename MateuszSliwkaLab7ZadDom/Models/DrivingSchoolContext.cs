using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MateuszSliwkaLab7.Models;
using Microsoft.EntityFrameworkCore;

namespace MateuszSliwkaLab7ZadDom.Models
{
    public class DrivingSchoolContext : DbContext
    {
        public DrivingSchoolContext(DbContextOptions<DrivingSchoolContext> options) : base("AppContext")
        {

        }

        public virtual DbSet<Car> Cars{ get; set; }
        public virtual DbSet<Instructor> Instructors { get; set; }
      
    
}
}
