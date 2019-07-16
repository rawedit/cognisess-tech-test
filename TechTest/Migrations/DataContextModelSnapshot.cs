﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TechTest.Data;

namespace TechTest.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity("TechTest.Modals.TestItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Input");

                    b.Property<string>("Num");

                    b.Property<string>("Status");

                    b.Property<int>("Time");

                    b.HasKey("Id");

                    b.ToTable("TestItems");
                });

            modelBuilder.Entity("TechTest.Modals.TestResult", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Correct");

                    b.Property<int>("Score");

                    b.Property<int>("Total");

                    b.HasKey("Id");

                    b.ToTable("TestResults");
                });
#pragma warning restore 612, 618
        }
    }
}
