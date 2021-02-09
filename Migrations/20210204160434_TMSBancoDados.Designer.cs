﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TESTE01.Context;

namespace TESTE01.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210204160434_TMSBancoDados")]
    partial class TMSBancoDados
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TESTE01.Models.Motorista", b =>
                {
                    b.Property<int>("MotoristaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bairro")
                        .HasMaxLength(50);

                    b.Property<string>("CEP")
                        .HasMaxLength(10);

                    b.Property<string>("Cidade")
                        .HasMaxLength(50);

                    b.Property<string>("Complemento")
                        .HasMaxLength(50);

                    b.Property<string>("Endereco")
                        .HasMaxLength(100);

                    b.Property<string>("Estado")
                        .HasMaxLength(2);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<int>("Numero");

                    b.Property<string>("Pais")
                        .HasMaxLength(50);

                    b.Property<string>("Referencia")
                        .HasMaxLength(100);

                    b.Property<string>("SobreNome")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("VeiculoId");

                    b.HasKey("MotoristaId");

                    b.HasIndex("VeiculoId");

                    b.ToTable("Motoristas");
                });

            modelBuilder.Entity("TESTE01.Models.Veiculo", b =>
                {
                    b.Property<int>("VeiculoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Eixos");

                    b.Property<string>("Marca")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("Placa")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.HasKey("VeiculoId");

                    b.ToTable("Veiculos");
                });

            modelBuilder.Entity("TESTE01.Models.Motorista", b =>
                {
                    b.HasOne("TESTE01.Models.Veiculo", "Veiculo")
                        .WithMany("Motoristas")
                        .HasForeignKey("VeiculoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
