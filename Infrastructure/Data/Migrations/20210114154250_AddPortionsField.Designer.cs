﻿// <auto-generated />
using System;
using Bakery.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Bakery.Infrastructure.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210114154250_AddPortionsField")]
    partial class AddPortionsField
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("Bakery.Domain.Aggregates.PieAggregate.Pie", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Pies");
                });

            modelBuilder.Entity("Bakery.Domain.Aggregates.PieAggregate.Pie", b =>
                {
                    b.OwnsOne("Bakery.Domain.Aggregates.PieAggregate.Portions", "Portions", b1 =>
                        {
                            b1.Property<Guid>("PieId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<int>("Maximum")
                                .HasColumnType("int");

                            b1.Property<int>("Minimum")
                                .HasColumnType("int");

                            b1.HasKey("PieId");

                            b1.ToTable("Pies");

                            b1.WithOwner()
                                .HasForeignKey("PieId");
                        });

                    b.Navigation("Portions");
                });
#pragma warning restore 612, 618
        }
    }
}
