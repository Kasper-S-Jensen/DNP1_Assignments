﻿// <auto-generated />
using System;
using Assignment02_WebAPI.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Assignment02_WebAPI.Migrations
{
    [DbContext(typeof(FamilyDBContext))]
    [Migration("20211111201311_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.11");

            modelBuilder.Entity("Assignment02_WebAPI.Models.Family", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("HouseNumber")
                        .HasColumnType("INTEGER");

                    b.Property<string>("StreetName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Families");
                });

            modelBuilder.Entity("Assignment02_WebAPI.Models.Interest", b =>
                {
                    b.Property<string>("Type")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Type");

                    b.ToTable("Interests");
                });

            modelBuilder.Entity("Assignment02_WebAPI.Models.Job", b =>
                {
                    b.Property<string>("JobTitle")
                        .HasColumnType("TEXT");

                    b.Property<int>("Salary")
                        .HasColumnType("INTEGER");

                    b.HasKey("JobTitle");

                    b.ToTable("Jobs");
                });

            modelBuilder.Entity("Assignment02_WebAPI.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("EyeColor")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("HairColor")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Height")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Sex")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<float>("Weight")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("Persons");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Person");
                });

            modelBuilder.Entity("Assignment02_WebAPI.Models.Pet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ChildId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("FamilyId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Species")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ChildId");

                    b.HasIndex("FamilyId");

                    b.ToTable("Pets");
                });

            modelBuilder.Entity("Assignment02_WebAPI.Models.User", b =>
                {
                    b.Property<string>("UserName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("SecurityLevel")
                        .HasColumnType("INTEGER");

                    b.HasKey("UserName");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ChildInterest", b =>
                {
                    b.Property<int>("ChildrenId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("InterestsType")
                        .HasColumnType("TEXT");

                    b.HasKey("ChildrenId", "InterestsType");

                    b.HasIndex("InterestsType");

                    b.ToTable("ChildInterest");
                });

            modelBuilder.Entity("Assignment02_WebAPI.Models.Adult", b =>
                {
                    b.HasBaseType("Assignment02_WebAPI.Models.Person");

                    b.Property<int?>("FamilyId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("Adult_FamilyId");

                    b.Property<string>("JobTitle1")
                        .HasColumnType("TEXT");

                    b.HasIndex("FamilyId");

                    b.HasIndex("JobTitle1");

                    b.HasDiscriminator().HasValue("Adult");
                });

            modelBuilder.Entity("Assignment02_WebAPI.Models.Child", b =>
                {
                    b.HasBaseType("Assignment02_WebAPI.Models.Person");

                    b.Property<int?>("FamilyId")
                        .HasColumnType("INTEGER");

                    b.HasIndex("FamilyId");

                    b.HasDiscriminator().HasValue("Child");
                });

            modelBuilder.Entity("Assignment02_WebAPI.Models.Pet", b =>
                {
                    b.HasOne("Assignment02_WebAPI.Models.Child", null)
                        .WithMany("Pets")
                        .HasForeignKey("ChildId");

                    b.HasOne("Assignment02_WebAPI.Models.Family", null)
                        .WithMany("Pets")
                        .HasForeignKey("FamilyId");
                });

            modelBuilder.Entity("ChildInterest", b =>
                {
                    b.HasOne("Assignment02_WebAPI.Models.Child", null)
                        .WithMany()
                        .HasForeignKey("ChildrenId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Assignment02_WebAPI.Models.Interest", null)
                        .WithMany()
                        .HasForeignKey("InterestsType")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Assignment02_WebAPI.Models.Adult", b =>
                {
                    b.HasOne("Assignment02_WebAPI.Models.Family", null)
                        .WithMany("Adults")
                        .HasForeignKey("FamilyId");

                    b.HasOne("Assignment02_WebAPI.Models.Job", "JobTitle")
                        .WithMany()
                        .HasForeignKey("JobTitle1");

                    b.Navigation("JobTitle");
                });

            modelBuilder.Entity("Assignment02_WebAPI.Models.Child", b =>
                {
                    b.HasOne("Assignment02_WebAPI.Models.Family", null)
                        .WithMany("Children")
                        .HasForeignKey("FamilyId");
                });

            modelBuilder.Entity("Assignment02_WebAPI.Models.Family", b =>
                {
                    b.Navigation("Adults");

                    b.Navigation("Children");

                    b.Navigation("Pets");
                });

            modelBuilder.Entity("Assignment02_WebAPI.Models.Child", b =>
                {
                    b.Navigation("Pets");
                });
#pragma warning restore 612, 618
        }
    }
}
