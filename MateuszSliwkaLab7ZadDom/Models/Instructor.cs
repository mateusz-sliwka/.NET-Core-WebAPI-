using System;
using System.ComponentModel.DataAnnotations;

namespace MateuszSliwkaLab7ZadDom.Models
{
    public class Instructor //kalsa instruktora
    {
        [Key]
        public int Id { get; set; } //id
        // public object tab { get; set; }
        public string FirstName{ get; set; } //imie
        public string LastName { get; set; } //nazwisko
        public string Category { get; set; } //kategoria jakie obsluguje
    }
}
