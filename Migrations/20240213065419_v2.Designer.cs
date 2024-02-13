﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SKIV.Components.DataBase;

#nullable disable

namespace SKIV.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20240213065419_v2")]
    partial class v2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.1");

            modelBuilder.Entity("SKIV.Components.Models.Measure", b =>
                {
                    b.Property<int>("IdMeasure")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<string>("ContactEmail")
                        .HasColumnType("TEXT");

                    b.Property<string>("ContactFullName")
                        .HasColumnType("TEXT");

                    b.Property<int?>("ContactPhoneNumber")
                        .HasColumnType("INTEGER");

                    b.Property<string>("DobroRu")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("TEXT");

                    b.Property<bool>("LP")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("LR")
                        .HasColumnType("INTEGER");

                    b.Property<string>("MeasureName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Organizer")
                        .HasColumnType("TEXT");

                    b.Property<string>("Place")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("Time")
                        .HasColumnType("TEXT");

                    b.Property<int>("TotalParticipants")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TotalVolunteers")
                        .HasColumnType("INTEGER");

                    b.Property<int>("VolunteersWithDisabilities")
                        .HasColumnType("INTEGER");

                    b.HasKey("IdMeasure");

                    b.ToTable("Measures");
                });

            modelBuilder.Entity("SKIV.Components.Models.Participation", b =>
                {
                    b.Property<int>("IdParticipation")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Measure")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Volunteer")
                        .HasColumnType("INTEGER");

                    b.HasKey("IdParticipation");

                    b.HasIndex("Measure");

                    b.HasIndex("Volunteer");

                    b.ToTable("Participations");
                });

            modelBuilder.Entity("SKIV.Components.Models.Volunteer", b =>
                {
                    b.Property<int>("IdVolunteer")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("BirthDay")
                        .HasColumnType("TEXT");

                    b.Property<int>("ClothingSize")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Disability")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("MiddleName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Patronymic")
                        .HasColumnType("TEXT");

                    b.Property<int?>("Rating")
                        .HasColumnType("INTEGER");

                    b.Property<string>("VK")
                        .HasColumnType("TEXT");

                    b.HasKey("IdVolunteer");

                    b.ToTable("Volunteers");
                });

            modelBuilder.Entity("SKIV.Components.Models.Participation", b =>
                {
                    b.HasOne("SKIV.Components.Models.Measure", "IdMeasure")
                        .WithMany()
                        .HasForeignKey("Measure")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SKIV.Components.Models.Volunteer", "IdVolunteer")
                        .WithMany()
                        .HasForeignKey("Volunteer")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IdMeasure");

                    b.Navigation("IdVolunteer");
                });
#pragma warning restore 612, 618
        }
    }
}