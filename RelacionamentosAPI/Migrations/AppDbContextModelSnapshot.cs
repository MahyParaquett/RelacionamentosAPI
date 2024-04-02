﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RelacionamentosAPI.Data;

#nullable disable

namespace RelacionamentosAPI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CasaModelMoradorModel", b =>
                {
                    b.Property<int>("CasaId")
                        .HasColumnType("int");

                    b.Property<int>("MoradorId")
                        .HasColumnType("int");

                    b.HasKey("CasaId", "MoradorId");

                    b.HasIndex("MoradorId");

                    b.ToTable("CasaModelMoradorModel");
                });

            modelBuilder.Entity("RelacionamentosAPI.Models.CasaModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Casas");
                });

            modelBuilder.Entity("RelacionamentosAPI.Models.EnderecoModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CasaId")
                        .HasColumnType("int");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<string>("Rua")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CasaId")
                        .IsUnique();

                    b.ToTable("Enderecos");
                });

            modelBuilder.Entity("RelacionamentosAPI.Models.MoradorModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Moradores");
                });

            modelBuilder.Entity("RelacionamentosAPI.Models.QuartoModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CasaId")
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CasaId");

                    b.ToTable("QuartoModel");
                });

            modelBuilder.Entity("CasaModelMoradorModel", b =>
                {
                    b.HasOne("RelacionamentosAPI.Models.CasaModel", null)
                        .WithMany()
                        .HasForeignKey("CasaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RelacionamentosAPI.Models.MoradorModel", null)
                        .WithMany()
                        .HasForeignKey("MoradorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RelacionamentosAPI.Models.EnderecoModel", b =>
                {
                    b.HasOne("RelacionamentosAPI.Models.CasaModel", "Casa")
                        .WithOne("Endereco")
                        .HasForeignKey("RelacionamentosAPI.Models.EnderecoModel", "CasaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Casa");
                });

            modelBuilder.Entity("RelacionamentosAPI.Models.QuartoModel", b =>
                {
                    b.HasOne("RelacionamentosAPI.Models.CasaModel", "Casa")
                        .WithMany("Quartos")
                        .HasForeignKey("CasaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Casa");
                });

            modelBuilder.Entity("RelacionamentosAPI.Models.CasaModel", b =>
                {
                    b.Navigation("Endereco")
                        .IsRequired();

                    b.Navigation("Quartos");
                });
#pragma warning restore 612, 618
        }
    }
}
