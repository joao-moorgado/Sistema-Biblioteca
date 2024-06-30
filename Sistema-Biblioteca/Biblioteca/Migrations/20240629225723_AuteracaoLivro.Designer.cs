﻿// <auto-generated />
using System;
using Biblioteca.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Biblioteca.Migrations
{
    [DbContext(typeof(AppDataContext))]
    [Migration("20240629225723_AuteracaoLivro")]
    partial class AuteracaoLivro
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.5");

            modelBuilder.Entity("Biblioteca.Models.Autor", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Autores");
                });

            modelBuilder.Entity("Biblioteca.Models.Emprestimo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("DataDevolucao")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DataEmprestimo")
                        .HasColumnType("TEXT");

                    b.Property<int?>("LivroId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LivroId1")
                        .HasColumnType("TEXT");

                    b.Property<int?>("UsuarioId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UsuarioId1")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("LivroId1");

                    b.HasIndex("UsuarioId1");

                    b.ToTable("Emprestimos");
                });

            modelBuilder.Entity("Biblioteca.Models.Genero", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Generos");
                });

            modelBuilder.Entity("Biblioteca.Models.Livro", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("AutorId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DataPublicacao")
                        .HasColumnType("TEXT");

                    b.Property<string>("Descricao")
                        .HasColumnType("TEXT");

                    b.Property<bool>("EstaEmprestado")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("EstaReservado")
                        .HasColumnType("INTEGER");

                    b.Property<string>("GeneroId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AutorId");

                    b.HasIndex("GeneroId");

                    b.ToTable("Livros");
                });

            modelBuilder.Entity("Biblioteca.Models.Reserva", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("DataReserva")
                        .HasColumnType("TEXT");

                    b.Property<int?>("EmprestimoId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("LivroId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LivroId1")
                        .HasColumnType("TEXT");

                    b.Property<int?>("UsuarioId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UsuarioId1")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("EmprestimoId");

                    b.HasIndex("LivroId1");

                    b.HasIndex("UsuarioId1");

                    b.ToTable("Reservas");
                });

            modelBuilder.Entity("Biblioteca.Models.Usuario", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Biblioteca.Models.Emprestimo", b =>
                {
                    b.HasOne("Biblioteca.Models.Livro", "Livro")
                        .WithMany()
                        .HasForeignKey("LivroId1");

                    b.HasOne("Biblioteca.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId1");

                    b.Navigation("Livro");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Biblioteca.Models.Livro", b =>
                {
                    b.HasOne("Biblioteca.Models.Autor", "Autor")
                        .WithMany()
                        .HasForeignKey("AutorId");

                    b.HasOne("Biblioteca.Models.Genero", "Genero")
                        .WithMany()
                        .HasForeignKey("GeneroId");

                    b.Navigation("Autor");

                    b.Navigation("Genero");
                });

            modelBuilder.Entity("Biblioteca.Models.Reserva", b =>
                {
                    b.HasOne("Biblioteca.Models.Emprestimo", "emprestimo")
                        .WithMany()
                        .HasForeignKey("EmprestimoId");

                    b.HasOne("Biblioteca.Models.Livro", "Livro")
                        .WithMany()
                        .HasForeignKey("LivroId1");

                    b.HasOne("Biblioteca.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId1");

                    b.Navigation("Livro");

                    b.Navigation("Usuario");

                    b.Navigation("emprestimo");
                });
#pragma warning restore 612, 618
        }
    }
}