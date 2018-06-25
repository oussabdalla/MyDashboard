﻿// <auto-generated />
using DynamicCharts.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace DynamicCharts.Migrations
{
    [DbContext(typeof(dbcontext))]
    [Migration("20180615192518_ouss")]
    partial class ouss
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DynamicCharts.Models.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("nom");

                    b.Property<long>("population");

                    b.Property<double>("sales");

                    b.HasKey("Id");

                    b.ToTable("Countrys");
                });

            modelBuilder.Entity("DynamicCharts.Models.PieChart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Detail");

                    b.Property<string>("Title");

                    b.Property<string>("Url");

                    b.Property<string>("XAxis");

                    b.Property<string>("YAxis");

                    b.HasKey("Id");

                    b.ToTable("PieCharts");
                });
#pragma warning restore 612, 618
        }
    }
}