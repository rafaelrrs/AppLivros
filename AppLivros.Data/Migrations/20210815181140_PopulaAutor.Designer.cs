﻿// <auto-generated />
using System;
using AppLivros.API.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AppLivros.API.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210815181140_PopulaAutor")]
    partial class PopulaAutor
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AppLivros.API.Models.Autor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<DateTime>("Nascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("UltimoNome")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.HasKey("Id");

                    b.ToTable("Autores");

                    b.HasData(
                        new
                        {
                            Id = new Guid("ed9a49bf-b047-4c17-9992-29a23ff68f5b"),
                            Email = "rafa@gmail.com",
                            Nascimento = new DateTime(2008, 5, 1, 8, 30, 52, 0, DateTimeKind.Unspecified),
                            Nome = "Rafael",
                            UltimoNome = "Silva"
                        },
                        new
                        {
                            Id = new Guid("86126adb-2038-4502-8227-a374d81b72ce"),
                            Email = "rafa@gmail.com",
                            Nascimento = new DateTime(2008, 5, 1, 8, 30, 52, 0, DateTimeKind.Unspecified),
                            Nome = "Rafaaa",
                            UltimoNome = "Silva"
                        },
                        new
                        {
                            Id = new Guid("6c441d4d-cb9b-4716-a607-ecc030c8456e"),
                            Email = "rafa@gmail.com",
                            Nascimento = new DateTime(2008, 5, 1, 8, 30, 52, 0, DateTimeKind.Unspecified),
                            Nome = "Leafar",
                            UltimoNome = "Silva"
                        });
                });

            modelBuilder.Entity("AppLivros.API.Models.Livro", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Ano")
                        .HasMaxLength(4)
                        .HasColumnType("int");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Livros");
                });
#pragma warning restore 612, 618
        }
    }
}
