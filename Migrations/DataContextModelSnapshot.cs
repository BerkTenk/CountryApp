﻿// <auto-generated />
using CountryApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CountryApp.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.8");

            modelBuilder.Entity("CountryApp.Models.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CapitalImg")
                        .HasColumnType("TEXT");

                    b.Property<string>("CapitalName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CountryCode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CountryName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Flag")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("TelCode")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Countryler");
                });
#pragma warning restore 612, 618
        }
    }
}
