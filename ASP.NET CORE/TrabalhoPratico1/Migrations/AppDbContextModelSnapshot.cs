﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TrabalhoPratico1.Context;

#nullable disable

namespace TrabalhoPratico1.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TrabalhoPratico1.Models.Agencia", b =>
                {
                    b.Property<int>("AgenciaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AgenciaId"));

                    b.Property<string>("Morada")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.HasKey("AgenciaId");

                    b.ToTable("Agencias");
                });

            modelBuilder.Entity("TrabalhoPratico1.Models.Cliente", b =>
                {
                    b.Property<int>("ClienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClienteId"));

                    b.Property<string>("ClienteNome")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.Property<string>("Morada")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.HasKey("ClienteId");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("TrabalhoPratico1.Models.Conta", b =>
                {
                    b.Property<int>("ContaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ContaId"));

                    b.Property<int>("AgenciaId")
                        .HasColumnType("int");

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("ContaId");

                    b.HasIndex("AgenciaId");

                    b.HasIndex("ClienteId");

                    b.ToTable("Contas");
                });

            modelBuilder.Entity("TrabalhoPratico1.Models.Emprestimo", b =>
                {
                    b.Property<int>("EmprestimoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmprestimoId"));

                    b.Property<int?>("AgenciasAgenciaId")
                        .HasColumnType("int");

                    b.Property<int?>("ClientesClienteId")
                        .HasColumnType("int");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("EmprestimoId");

                    b.HasIndex("AgenciasAgenciaId");

                    b.HasIndex("ClientesClienteId");

                    b.ToTable("Emprestimos");
                });

            modelBuilder.Entity("TrabalhoPratico1.Models.Conta", b =>
                {
                    b.HasOne("TrabalhoPratico1.Models.Agencia", "Agencias")
                        .WithMany("Contas")
                        .HasForeignKey("AgenciaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TrabalhoPratico1.Models.Cliente", "Clientes")
                        .WithMany("Contas")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Agencias");

                    b.Navigation("Clientes");
                });

            modelBuilder.Entity("TrabalhoPratico1.Models.Emprestimo", b =>
                {
                    b.HasOne("TrabalhoPratico1.Models.Agencia", "Agencias")
                        .WithMany("Emprestimos")
                        .HasForeignKey("AgenciasAgenciaId");

                    b.HasOne("TrabalhoPratico1.Models.Cliente", "Clientes")
                        .WithMany("Emprestimos")
                        .HasForeignKey("ClientesClienteId");

                    b.Navigation("Agencias");

                    b.Navigation("Clientes");
                });

            modelBuilder.Entity("TrabalhoPratico1.Models.Agencia", b =>
                {
                    b.Navigation("Contas");

                    b.Navigation("Emprestimos");
                });

            modelBuilder.Entity("TrabalhoPratico1.Models.Cliente", b =>
                {
                    b.Navigation("Contas");

                    b.Navigation("Emprestimos");
                });
#pragma warning restore 612, 618
        }
    }
}
