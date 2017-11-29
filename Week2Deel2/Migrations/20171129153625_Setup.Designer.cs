using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Week2Deel2.Data;

namespace Week2Deel2.Migrations
{
    [DbContext(typeof(HotelBoekingContext))]
    [Migration("20171129153625_Setup")]
    partial class Setup
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Week2Deel2.Models.HotelBoeking", b =>
                {
                    b.Property<int>("HotelBoekingId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AantalPersonen");

                    b.Property<string>("Achternaam");

                    b.Property<DateTime>("Datum");

                    b.Property<string>("Voornaam");

                    b.HasKey("HotelBoekingId");

                    b.ToTable("HotelBoekingen");
                });
        }
    }
}
