using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MateuszSliwkaLab7ZadDom.Models
{
    public class Car //klasa samochodu
    {
        [Key]
        public int Id { get; set; } //id obiektu

        public string Brand{ get; set; } //marka
        public string Model { get; set; } //model
        public int Mileage { get; set; } //przebieg
    
    }
}
