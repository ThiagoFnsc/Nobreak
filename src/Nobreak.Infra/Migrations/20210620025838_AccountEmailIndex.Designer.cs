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
    [Migration("20210620025838_AccountEmailIndex")]
    partial class AccountEmailIndex
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.7");

            modelBuilder.Entity("Nobreak.Context.Entities.Account", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(767)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.HasIndex("Email");

                    b.HasIndex("Timestamp");

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
                        .HasColumnType("tinyint unsigned");

                    b.Property<float>("TemperatureC")
                        .HasColumnType("float");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("datetime");

                    b.Property<float>("VoltageIn")
                        .HasColumnType("float");

                    b.Property<float>("VoltageOut")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("Timestamp");

                    b.ToTable("NobreakStates");
                });

            modelBuilder.Entity("Nobreak.Infra.Context.Entities.NobreakStateChange", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<long?>("NobreakStateId")
                        .HasColumnType("bigint");

                    b.Property<bool>("OnPurpose")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.HasIndex("NobreakStateId");

                    b.HasIndex("Timestamp");

                    b.ToTable("NobreakStateChanges");
                });

            modelBuilder.Entity("Nobreak.Infra.Context.Entities.NobreakStateChange", b =>
                {
                    b.HasOne("Nobreak.Context.Entities.NobreakState", "NobreakState")
                        .WithMany()
                        .HasForeignKey("NobreakStateId");

                    b.Navigation("NobreakState");
                });
#pragma warning restore 612, 618
        }
    }
}
