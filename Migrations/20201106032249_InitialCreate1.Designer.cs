﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NTest.Data;

namespace NTest.Migrations
{
    [DbContext(typeof(MVCLidaContext))]
    [Migration("20201106032249_InitialCreate1")]
    partial class InitialCreate1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NTest.Models.LidaData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("GroudDist")
                        .HasColumnType("float");

                    b.Property<string>("ImageClock")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LidarClock")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PrependDist")
                        .HasColumnType("int");

                    b.Property<double>("SlopeAngle")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("LidaData");
                });
#pragma warning restore 612, 618
        }
    }
}
