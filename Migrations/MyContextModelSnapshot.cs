﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OtterTravels.Models;

namespace OtterTravels.Migrations
{
    [DbContext(typeof(MyContext))]
    partial class MyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("OtterTravels.Models.Otter", b =>
                {
                    b.Property<int>("OtterId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Birthday");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<bool>("HasKids");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Type")
                        .IsRequired();

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("OtterId");

                    b.ToTable("Otters");
                });

            modelBuilder.Entity("OtterTravels.Models.Vacation", b =>
                {
                    b.Property<int>("VacationId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Destination")
                        .IsRequired();

                    b.Property<string>("ImgUrl")
                        .IsRequired();

                    b.Property<int>("NumberDays");

                    b.Property<int>("OtterId");

                    b.Property<DateTime>("StartDate");

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("VacationId");

                    b.HasIndex("OtterId");

                    b.ToTable("Vacations");
                });

            modelBuilder.Entity("OtterTravels.Models.Vacation", b =>
                {
                    b.HasOne("OtterTravels.Models.Otter", "Planner")
                        .WithMany("PlannedVacations")
                        .HasForeignKey("OtterId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
