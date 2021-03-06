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
    [Migration("20180704121913_mig14")]
    partial class mig14
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

                    b.Property<string>("Name");

                    b.Property<long>("Population");

                    b.Property<double>("Sales");

                    b.HasKey("Id");

                    b.ToTable("Countrys");
                });

            modelBuilder.Entity("DynamicCharts.Models.Dashboard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Dashboards");
                });

            modelBuilder.Entity("DynamicCharts.Models.Data", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Title");

                    b.Property<string>("Url");

                    b.Property<string>("XAxis");

                    b.Property<string>("YAxis");

                    b.HasKey("Id");

                    b.ToTable("Datas");
                });

            modelBuilder.Entity("DynamicCharts.Models.PieChart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("DashboardId");

                    b.Property<string>("Detail");

                    b.Property<string>("Title");

                    b.Property<string>("Url");

                    b.Property<string>("XAxis");

                    b.Property<string>("YAxis");

                    b.Property<string>("filters");

                    b.Property<double>("high");

                    b.Property<string>("options");

                    b.Property<double>("width");

                    b.Property<double>("x");

                    b.Property<double>("y");

                    b.HasKey("Id");

                    b.HasIndex("DashboardId");

                    b.ToTable("PieCharts");
                });

            modelBuilder.Entity("DynamicCharts.Models.PieChart", b =>
                {
                    b.HasOne("DynamicCharts.Models.Dashboard", "Dashboard")
                        .WithMany("Piecharts")
                        .HasForeignKey("DashboardId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
