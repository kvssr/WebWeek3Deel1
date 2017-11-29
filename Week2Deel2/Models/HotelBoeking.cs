﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Week2Deel2.Models
{
    public class HotelBoeking
    {
        public int HotelBoekingId { get; set; }
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }
        public int AantalPersonen { get; set; }
        public DateTime Datum { get; set; }
    }
}
