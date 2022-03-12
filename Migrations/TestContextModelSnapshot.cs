﻿// <auto-generated />
using EntityFramework_class;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace p1.Migrations
{
    [DbContext(typeof(TestContext))]
    partial class TestContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.2");

            modelBuilder.Entity("EntityFramework_class.GRAFICOS_DADOS", b =>
                {
                    b.Property<int>("IndexID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<float>("Carga")
                        .HasColumnType("REAL");

                    b.Property<float>("Deslocamento")
                        .HasColumnType("REAL");

                    b.Property<int>("GraficoForeingKey")
                        .HasColumnType("INTEGER");

                    b.HasKey("IndexID");

                    b.HasIndex("GraficoForeingKey");

                    b.ToTable("Dados");
                });

            modelBuilder.Entity("EntityFramework_class.GRAFICOS_ID", b =>
                {
                    b.Property<int>("GraficoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Material")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Registro")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("GraficoID");

                    b.ToTable("Grafico");
                });

            modelBuilder.Entity("EntityFramework_class.GRAFICOS_DADOS", b =>
                {
                    b.HasOne("EntityFramework_class.GRAFICOS_ID", "GRAFICOS_ID")
                        .WithMany("Dados")
                        .HasForeignKey("GraficoForeingKey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GRAFICOS_ID");
                });

            modelBuilder.Entity("EntityFramework_class.GRAFICOS_ID", b =>
                {
                    b.Navigation("Dados");
                });
#pragma warning restore 612, 618
        }
    }
}
