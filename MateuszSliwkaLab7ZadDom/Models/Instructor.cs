using System;
using System.ComponentModel.DataAnnotations;

namespace MateuszSliwkaLab7.Models
{
    public class Instructor
    {
        [Key]
        public int Id { get; set; }
        // public object tab { get; set; }
        public string FirstName{ get; set; }
        public string LastName { get; set; }
        public int CarId { get; set; }
        public virtual Car Car { get; set; }

    }
}
