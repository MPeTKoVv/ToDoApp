﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ToDoApp.Data;

#nullable disable

namespace ToDoApp.Data.Migrations
{
    [DbContext(typeof(ToDoAppDbContext))]
    [Migration("20240330193136_ConfigureCategories")]
    partial class ConfigureCategories
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ToDoApp.Data.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ImageUrl = "https://thenounproject.com/icon/personal-task-396627/",
                            Name = "Personal"
                        },
                        new
                        {
                            Id = 2,
                            ImageUrl = "https://thenounproject.com/icon/job-4080118/",
                            Name = "Work"
                        },
                        new
                        {
                            Id = 3,
                            ImageUrl = "https://thenounproject.com/icon/task-home-2676056/",
                            Name = "Home"
                        },
                        new
                        {
                            Id = 4,
                            ImageUrl = "https://thenounproject.com/icon/clipboard-3990469/",
                            Name = "Personal"
                        },
                        new
                        {
                            Id = 5,
                            ImageUrl = "https://thenounproject.com/icon/financial-report-5974043/",
                            Name = "Financial"
                        },
                        new
                        {
                            Id = 6,
                            ImageUrl = "https://thenounproject.com/icon/share-task-396661/",
                            Name = "Social"
                        },
                        new
                        {
                            Id = 7,
                            ImageUrl = "https://thenounproject.com/icon/assignment-4027357/",
                            Name = "Educational"
                        });
                });

            modelBuilder.Entity("ToDoApp.Data.Models.ToDo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Deadline")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<bool>("IsDone")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Tasks");
                });

            modelBuilder.Entity("ToDoApp.Data.Models.ToDo", b =>
                {
                    b.HasOne("ToDoApp.Data.Models.Category", "Category")
                        .WithMany("Tasks")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("ToDoApp.Data.Models.Category", b =>
                {
                    b.Navigation("Tasks");
                });
#pragma warning restore 612, 618
        }
    }
}
