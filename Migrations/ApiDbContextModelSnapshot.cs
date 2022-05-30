﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MonkTechWebAPI.Data;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MonkTechWebAPI.Migrations
{
    [DbContext(typeof(ApiDbContext))]
    partial class ApiDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("MonkTechWebAPI.Models.Agenda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Dia")
                        .HasColumnType("Date");

                    b.Property<bool>("Disponivel")
                        .HasColumnType("boolean");

                    b.Property<string>("HoraFim")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("HoraInicio")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NomeDoCliente")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("SalaoId")
                        .HasColumnType("integer");

                    b.Property<string>("TelefoneDoCliente")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("SalaoId");

                    b.ToTable("Agendas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Dia = new DateTime(2022, 5, 30, 0, 0, 0, 0, DateTimeKind.Local),
                            Disponivel = false,
                            HoraFim = "14:00",
                            HoraInicio = "13:00",
                            NomeDoCliente = "Maria",
                            SalaoId = 1,
                            TelefoneDoCliente = "999998888"
                        },
                        new
                        {
                            Id = 2,
                            Dia = new DateTime(2022, 5, 30, 0, 0, 0, 0, DateTimeKind.Local),
                            Disponivel = false,
                            HoraFim = "12:30",
                            HoraInicio = "11:00",
                            NomeDoCliente = "Roberta",
                            SalaoId = 3,
                            TelefoneDoCliente = "911113333"
                        },
                        new
                        {
                            Id = 3,
                            Dia = new DateTime(2022, 5, 30, 0, 0, 0, 0, DateTimeKind.Local),
                            Disponivel = false,
                            HoraFim = "10:00",
                            HoraInicio = "08:20",
                            NomeDoCliente = "Carla",
                            SalaoId = 2,
                            TelefoneDoCliente = "977776666"
                        });
                });

            modelBuilder.Entity("MonkTechWebAPI.Models.Endereco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Numero")
                        .HasColumnType("text");

                    b.Property<string>("Pais")
                        .HasColumnType("text");

                    b.Property<string>("Rua")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("SalaoId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("SalaoId")
                        .IsUnique();

                    b.ToTable("Enderecos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Bairro = "Jardim da Penha",
                            Cep = "29000000",
                            Cidade = "Vitória",
                            Estado = "Espírito Santo",
                            Numero = "SN",
                            Rua = "Clotilde",
                            SalaoId = 1
                        },
                        new
                        {
                            Id = 2,
                            Bairro = "Cordoado",
                            Cep = "29555000",
                            Cidade = "Guarapari",
                            Estado = "Espírito Santo",
                            Numero = "22",
                            Rua = "America",
                            SalaoId = 2
                        },
                        new
                        {
                            Id = 3,
                            Bairro = "Laranjeiras",
                            Cep = "29888000",
                            Cidade = "Serra",
                            Estado = "Espírito Santo",
                            Numero = "1",
                            Rua = "Copacabana",
                            SalaoId = 3
                        });
                });

            modelBuilder.Entity("MonkTechWebAPI.Models.Salao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Cnpj")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("RazaoSocial")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Saloes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Cnpj = "01234567890123",
                            RazaoSocial = "Best"
                        },
                        new
                        {
                            Id = 2,
                            Cnpj = "09876543210987",
                            RazaoSocial = "Awesome"
                        },
                        new
                        {
                            Id = 3,
                            Cnpj = "13579123456789",
                            RazaoSocial = "Good"
                        });
                });

            modelBuilder.Entity("MonkTechWebAPI.Models.Agenda", b =>
                {
                    b.HasOne("MonkTechWebAPI.Models.Salao", null)
                        .WithMany("Agendas")
                        .HasForeignKey("SalaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MonkTechWebAPI.Models.Endereco", b =>
                {
                    b.HasOne("MonkTechWebAPI.Models.Salao", null)
                        .WithOne("Endereco")
                        .HasForeignKey("MonkTechWebAPI.Models.Endereco", "SalaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MonkTechWebAPI.Models.Salao", b =>
                {
                    b.Navigation("Agendas");

                    b.Navigation("Endereco");
                });
#pragma warning restore 612, 618
        }
    }
}
