using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Week2Deel2.Models;

namespace Week2Deel2.Data
{
    public class HotelBoekingContext : DbContext
    {
        public HotelBoekingContext(DbContextOptions<HotelBoekingContext> options) : base(options) { }
        public DbSet<HotelBoeking> HotelBoekingen { get; set; }
    }
}
