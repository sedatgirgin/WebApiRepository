﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApi.Data;

namespace WebApi.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20200918182538_ContextData")]
    partial class ContextData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApi.Models.Variables", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AddressIn");

                    b.Property<int>("AddressOut");

                    b.Property<string>("Avalue");

                    b.Property<string>("Bit_position");

                    b.Property<string>("Buttonpath");

                    b.Property<string>("Bvalue");

                    b.Property<string>("Code");

                    b.Property<int>("Defaultvalue");

                    b.Property<int>("Delay");

                    b.Property<string>("Description");

                    b.Property<int>("Dimension");

                    b.Property<int>("Frequency");

                    b.Property<string>("Functioncode");

                    b.Property<int>("Grpcategory");

                    b.Property<int>("Idgroup");

                    b.Property<int>("Idhsvariable");

                    b.Property<string>("Idvariable");

                    b.Property<string>("Idvarmdl");

                    b.Property<int>("Rowid");

                    b.Property<string>("Type");

                    b.Property<string>("VId");

                    b.HasKey("Id");

                    b.ToTable("variables");
                });
#pragma warning restore 612, 618
        }
    }
}
