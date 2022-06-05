﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MonkTechWebAPI.Configurations;
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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "f3dde8f3-d90d-45c2-b622-2c8c939ccc47",
                            ConcurrencyStamp = "0c746ce3-c812-4c73-8fd6-705d8cf77280",
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        },
                        new
                        {
                            Id = "fcb7621e-6289-449d-bad3-082cfc8a6153",
                            ConcurrencyStamp = "a3c295f3-94f3-41ed-b7f0-05468a306245",
                            Name = "User",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

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
                        .HasColumnType("text");

                    b.Property<int>("SalaoId")
                        .HasColumnType("integer");

                    b.Property<string>("TelefoneDoCliente")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("SalaoId");

                    b.ToTable("Agendas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Dia = new DateTime(2022, 6, 4, 0, 0, 0, 0, DateTimeKind.Local),
                            Disponivel = true,
                            HoraFim = "14:00",
                            HoraInicio = "13:00",
                            SalaoId = 1
                        },
                        new
                        {
                            Id = 2,
                            Dia = new DateTime(2022, 6, 4, 0, 0, 0, 0, DateTimeKind.Local),
                            Disponivel = true,
                            HoraFim = "12:30",
                            HoraInicio = "11:00",
                            SalaoId = 1
                        },
                        new
                        {
                            Id = 3,
                            Dia = new DateTime(2022, 6, 4, 0, 0, 0, 0, DateTimeKind.Local),
                            Disponivel = true,
                            HoraFim = "10:00",
                            HoraInicio = "08:20",
                            SalaoId = 2
                        },
                        new
                        {
                            Id = 4,
                            Dia = new DateTime(2022, 6, 4, 0, 0, 0, 0, DateTimeKind.Local),
                            Disponivel = true,
                            HoraFim = "09:00",
                            HoraInicio = "07:20",
                            SalaoId = 2
                        },
                        new
                        {
                            Id = 5,
                            Dia = new DateTime(2022, 6, 4, 0, 0, 0, 0, DateTimeKind.Local),
                            Disponivel = true,
                            HoraFim = "10:00",
                            HoraInicio = "08:20",
                            SalaoId = 3
                        },
                        new
                        {
                            Id = 6,
                            Dia = new DateTime(2022, 6, 4, 0, 0, 0, 0, DateTimeKind.Local),
                            Disponivel = true,
                            HoraFim = "10:00",
                            HoraInicio = "08:20",
                            SalaoId = 4
                        },
                        new
                        {
                            Id = 7,
                            Dia = new DateTime(2022, 6, 4, 0, 0, 0, 0, DateTimeKind.Local),
                            Disponivel = true,
                            HoraFim = "10:00",
                            HoraInicio = "08:20",
                            SalaoId = 5
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
                            Bairro = "Bairro 01",
                            Cep = "29000000",
                            Cidade = "Cidade 01",
                            Estado = "Estado 01",
                            Numero = "01",
                            Pais = "País 01",
                            Rua = "Rua 01",
                            SalaoId = 1
                        },
                        new
                        {
                            Id = 2,
                            Bairro = "Bairro 02",
                            Cep = "29200000",
                            Cidade = "Cidade 02",
                            Estado = "Estado 02",
                            Numero = "02",
                            Pais = "País 02",
                            Rua = "Rua 02",
                            SalaoId = 2
                        },
                        new
                        {
                            Id = 3,
                            Bairro = "Bairro 03",
                            Cep = "29300000",
                            Cidade = "Cidade 03",
                            Estado = "Estado 03",
                            Numero = "03",
                            Pais = "País 03",
                            Rua = "Rua 03",
                            SalaoId = 3
                        },
                        new
                        {
                            Id = 4,
                            Bairro = "Bairro 04",
                            Cep = "29400000",
                            Cidade = "Cidade 04",
                            Estado = "Estado 02",
                            Numero = "SN",
                            Pais = "País 02",
                            Rua = "Rua 04",
                            SalaoId = 4
                        },
                        new
                        {
                            Id = 5,
                            Bairro = "Bairro 04",
                            Cep = "29550000",
                            Cidade = "Cidade 03",
                            Estado = "Estado 03",
                            Numero = "05",
                            Pais = "País 03",
                            Rua = "Rua 03",
                            SalaoId = 5
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

                    b.HasIndex("Cnpj")
                        .IsUnique();

                    b.ToTable("Saloes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Cnpj = "00000000000000",
                            RazaoSocial = "Salão 01"
                        },
                        new
                        {
                            Id = 2,
                            Cnpj = "11111111111111",
                            RazaoSocial = "Salão 02"
                        },
                        new
                        {
                            Id = 3,
                            Cnpj = "22222222222222",
                            RazaoSocial = "Salão 03"
                        },
                        new
                        {
                            Id = 4,
                            Cnpj = "33333333333333",
                            RazaoSocial = "Salão 04"
                        },
                        new
                        {
                            Id = 5,
                            Cnpj = "44444444444444",
                            RazaoSocial = "Salão 05"
                        });
                });

            modelBuilder.Entity("MonkTechWebAPI.Models.Usuario", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<int>("SalaoId")
                        .HasColumnType("integer");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.HasIndex("SalaoId")
                        .IsUnique();

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("MonkTechWebAPI.Models.Usuario", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("MonkTechWebAPI.Models.Usuario", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MonkTechWebAPI.Models.Usuario", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("MonkTechWebAPI.Models.Usuario", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
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

            modelBuilder.Entity("MonkTechWebAPI.Models.Usuario", b =>
                {
                    b.HasOne("MonkTechWebAPI.Models.Salao", null)
                        .WithOne("Usuario")
                        .HasForeignKey("MonkTechWebAPI.Models.Usuario", "SalaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MonkTechWebAPI.Models.Salao", b =>
                {
                    b.Navigation("Agendas");

                    b.Navigation("Endereco");

                    b.Navigation("Usuario")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
