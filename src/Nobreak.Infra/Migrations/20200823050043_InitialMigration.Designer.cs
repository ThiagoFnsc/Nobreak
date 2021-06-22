﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Nobreak.Infra.Context;

namespace Nobreak.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20200823050043_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Nobreak.Context.Entities.Account", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("Nobreak.Context.Entities.NobreakState", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<float>("BatteryVoltage")
                        .HasColumnType("float");

                    b.Property<byte>("Extras")
                        .HasColumnType("tinyint unsigned");

                    b.Property<float>("FrequencyHz")
                        .HasColumnType("float");

                    b.Property<byte>("LoadPercentage")
                        .HasColumnType("tinyint");

                    b.Property<float>("TemperatureC")
                        .HasColumnType("float");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("datetime");

                    b.Property<float>("VoltageIn")
                        .HasColumnType("float");

                    b.Property<float>("VoltageOut")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("NobreakStates");
                });

            modelBuilder.Entity("Nobreak.Context.Entities.NobreakStateChange", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<long>("NobreakStateId")
                        .HasColumnType("bigint");

                    b.Property<bool>("OnPurpose")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("NobreakStateId");

                    b.ToTable("NobreakStateChanges");
                });

            modelBuilder.Entity("Nobreak.Context.Entities.NobreakStateChange", b =>
                {
                    b.HasOne("Nobreak.Context.Entities.NobreakState", "NobreakState")
                        .WithMany()
                        .HasForeignKey("NobreakStateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
