﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using webapiproject.Model;

namespace webapiproject.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231019170520_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("webapiproject.Model.Leagues", b =>
                {
                    b.Property<int>("LeaguesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LeagueCountry")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LeagueName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MostChampTeam")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumbofTeams")
                        .HasColumnType("int");

                    b.HasKey("LeaguesId");

                    b.ToTable("Leaguess");
                });

            modelBuilder.Entity("webapiproject.Model.Managers", b =>
                {
                    b.Property<int>("ManagersId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Salary")
                        .HasColumnType("int");

                    b.Property<int>("TeamsId")
                        .HasColumnType("int");

                    b.HasKey("ManagersId");

                    b.HasIndex("TeamsId");

                    b.ToTable("Managerss");
                });

            modelBuilder.Entity("webapiproject.Model.Players", b =>
                {
                    b.Property<int>("PlayerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateofBirth")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("MarketValue")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Nationality")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlayerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("PlayerSalary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("TeamsId")
                        .HasColumnType("int");

                    b.HasKey("PlayerId");

                    b.HasIndex("TeamsId");

                    b.ToTable("Playerss");
                });

            modelBuilder.Entity("webapiproject.Model.Teams", b =>
                {
                    b.Property<int>("TeamId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("LeaguesId")
                        .HasColumnType("int");

                    b.Property<string>("TeamCountry")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TeamName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("TotalValue")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("TeamId");

                    b.HasIndex("LeaguesId");

                    b.ToTable("Teamss");
                });

            modelBuilder.Entity("webapiproject.Model.Managers", b =>
                {
                    b.HasOne("webapiproject.Model.Teams", "Teams")
                        .WithMany()
                        .HasForeignKey("TeamsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Teams");
                });

            modelBuilder.Entity("webapiproject.Model.Players", b =>
                {
                    b.HasOne("webapiproject.Model.Teams", "Teams")
                        .WithMany()
                        .HasForeignKey("TeamsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Teams");
                });

            modelBuilder.Entity("webapiproject.Model.Teams", b =>
                {
                    b.HasOne("webapiproject.Model.Leagues", "Leagues")
                        .WithMany()
                        .HasForeignKey("LeaguesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Leagues");
                });
#pragma warning restore 612, 618
        }
    }
}