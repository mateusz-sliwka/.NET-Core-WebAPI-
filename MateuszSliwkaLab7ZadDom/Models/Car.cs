using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MateuszSliwkaLab7.Models
{
    public class Car
    {
        [Key]
        public int Id { get; set; }
        // public object tab { get; set; }
        public string Brand{ get; set; }
        public string Model { get; set; }
        public virtual ICollection<Instructor> Instructors { get; set; }
      

    }
}
