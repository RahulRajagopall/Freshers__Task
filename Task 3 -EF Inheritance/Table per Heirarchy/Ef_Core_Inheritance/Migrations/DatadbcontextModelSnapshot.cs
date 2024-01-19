﻿// <auto-generated />
using Ef_Core_Inheritance.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Ef_Core_Inheritance.Migrations
{
    [DbContext(typeof(Datadbcontext))]
    partial class DatadbcontextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Ef_Core_Inheritance.Models.Studentdetails", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(21)
                        .HasColumnType("nvarchar(21)");

                    b.Property<string>("Rollno")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Name");

                    b.ToTable("Details");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Studentdetails");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Ef_Core_Inheritance.Models.Address", b =>
                {
                    b.HasBaseType("Ef_Core_Inheritance.Models.Studentdetails");

                    b.Property<string>("Permanentaddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Address");
                });

            modelBuilder.Entity("Ef_Core_Inheritance.Models.Percentage", b =>
                {
                    b.HasBaseType("Ef_Core_Inheritance.Models.Studentdetails");

                    b.Property<string>("totalpercentage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Percentage");
                });
#pragma warning restore 612, 618
        }
    }
}