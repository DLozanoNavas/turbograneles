﻿// <auto-generated />
using System;
using Italcol.Turbograneles.Adapters.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Italcol.Turbograneles.Adapters.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20250331140254_InitialModel")]
    partial class InitialModel
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Italcol.Turbograneles.Domain.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Italcol.Turbograneles.Domain.AppointmentStatus", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreateDateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("CreatedByUserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CreatedByUserId");

                    b.ToTable("AppointmentStatus");
                });

            modelBuilder.Entity("Italcol.Turbograneles.Domain.Driver", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Driver");
                });

            modelBuilder.Entity("Italcol.Turbograneles.Domain.Truck", b =>
                {
                    b.Property<string>("Plate")
                        .HasColumnType("text");

                    b.HasKey("Plate");

                    b.ToTable("Truck");
                });

            modelBuilder.Entity("Italcol.Turbograneles.Domain.TruckAppointment", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<DateTime>("ArriveDateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long>("ArriveWeight")
                        .HasColumnType("bigint");

                    b.Property<string>("BlNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long>("CargoWeight")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedAtDateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("CreatedByUserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("DepartureDateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("DestinationCode")
                        .HasColumnType("integer");

                    b.Property<string>("DriverId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("EndDateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long>("MaxWeightPermitted")
                        .HasColumnType("bigint");

                    b.Property<string>("ProductId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("StartDateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("StatusId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("TransportId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long>("TruckGrossWeight")
                        .HasColumnType("bigint");

                    b.Property<string>("TruckId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("TruckTransactionId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("UpdatedAtDateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("UpdatedByUserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("VoyageId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long>("WeightRequired")
                        .HasColumnType("bigint");

                    b.Property<int>("WeightingBridgeId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CreatedByUserId");

                    b.HasIndex("DriverId");

                    b.HasIndex("StatusId");

                    b.HasIndex("TruckId");

                    b.HasIndex("UpdatedByUserId");

                    b.HasIndex("VoyageId");

                    b.ToTable("TruckAppointment");
                });

            modelBuilder.Entity("Italcol.Turbograneles.Domain.Voyage", b =>
                {
                    b.Property<string>("VoyageId")
                        .HasColumnType("text");

                    b.Property<string>("BlNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("CreatedByUserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Customer")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("Eta")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("Etd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Product")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("StatusId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("UpdatedByUserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("VesselName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long>("WeightBlEnd")
                        .HasColumnType("bigint");

                    b.Property<long>("WeightBlStart")
                        .HasColumnType("bigint");

                    b.HasKey("VoyageId");

                    b.HasIndex("CreatedByUserId");

                    b.HasIndex("StatusId");

                    b.HasIndex("UpdatedByUserId");

                    b.ToTable("Voyage");
                });

            modelBuilder.Entity("Italcol.Turbograneles.Domain.VoyageStatus", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreateDateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("CreatedByUserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CreatedByUserId");

                    b.ToTable("VoyageStatus");
                });

            modelBuilder.Entity("Italcol.Turbograneles.Domain.WeighingRecord", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("CreatedByUserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("DateTimeEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("VoyageId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("WeighingPitId")
                        .HasColumnType("integer");

                    b.Property<long>("Weight")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("CreatedByUserId");

                    b.HasIndex("VoyageId");

                    b.ToTable("WeighingRecord");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Italcol.Turbograneles.Domain.AppointmentStatus", b =>
                {
                    b.HasOne("Italcol.Turbograneles.Domain.ApplicationUser", "CreatedByUser")
                        .WithMany("CreatedAppointmentStatuses")
                        .HasForeignKey("CreatedByUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CreatedByUser");
                });

            modelBuilder.Entity("Italcol.Turbograneles.Domain.TruckAppointment", b =>
                {
                    b.HasOne("Italcol.Turbograneles.Domain.ApplicationUser", "CreatedByUser")
                        .WithMany("CreatedAppointments")
                        .HasForeignKey("CreatedByUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Italcol.Turbograneles.Domain.Driver", "Driver")
                        .WithMany("Appointments")
                        .HasForeignKey("DriverId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Italcol.Turbograneles.Domain.AppointmentStatus", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Italcol.Turbograneles.Domain.Truck", "Truck")
                        .WithMany("Appointments")
                        .HasForeignKey("TruckId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Italcol.Turbograneles.Domain.ApplicationUser", "UpdatedByUser")
                        .WithMany("UpdatedAppointments")
                        .HasForeignKey("UpdatedByUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Italcol.Turbograneles.Domain.Voyage", "Voyage")
                        .WithMany()
                        .HasForeignKey("VoyageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CreatedByUser");

                    b.Navigation("Driver");

                    b.Navigation("Status");

                    b.Navigation("Truck");

                    b.Navigation("UpdatedByUser");

                    b.Navigation("Voyage");
                });

            modelBuilder.Entity("Italcol.Turbograneles.Domain.Voyage", b =>
                {
                    b.HasOne("Italcol.Turbograneles.Domain.ApplicationUser", "CreatedByUser")
                        .WithMany("CreatedVoyages")
                        .HasForeignKey("CreatedByUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Italcol.Turbograneles.Domain.VoyageStatus", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Italcol.Turbograneles.Domain.ApplicationUser", "UpdatedByUser")
                        .WithMany("UpdatedVoyages")
                        .HasForeignKey("UpdatedByUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CreatedByUser");

                    b.Navigation("Status");

                    b.Navigation("UpdatedByUser");
                });

            modelBuilder.Entity("Italcol.Turbograneles.Domain.VoyageStatus", b =>
                {
                    b.HasOne("Italcol.Turbograneles.Domain.ApplicationUser", "CreatedByUser")
                        .WithMany("CreatedVoyagesStatus")
                        .HasForeignKey("CreatedByUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CreatedByUser");
                });

            modelBuilder.Entity("Italcol.Turbograneles.Domain.WeighingRecord", b =>
                {
                    b.HasOne("Italcol.Turbograneles.Domain.ApplicationUser", "CreatedByUser")
                        .WithMany("CreatedWeighingRecords")
                        .HasForeignKey("CreatedByUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Italcol.Turbograneles.Domain.Voyage", "Voyage")
                        .WithMany("WeighingRecords")
                        .HasForeignKey("VoyageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CreatedByUser");

                    b.Navigation("Voyage");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Italcol.Turbograneles.Domain.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Italcol.Turbograneles.Domain.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Italcol.Turbograneles.Domain.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Italcol.Turbograneles.Domain.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Italcol.Turbograneles.Domain.ApplicationUser", b =>
                {
                    b.Navigation("CreatedAppointmentStatuses");

                    b.Navigation("CreatedAppointments");

                    b.Navigation("CreatedVoyages");

                    b.Navigation("CreatedVoyagesStatus");

                    b.Navigation("CreatedWeighingRecords");

                    b.Navigation("UpdatedAppointments");

                    b.Navigation("UpdatedVoyages");
                });

            modelBuilder.Entity("Italcol.Turbograneles.Domain.Driver", b =>
                {
                    b.Navigation("Appointments");
                });

            modelBuilder.Entity("Italcol.Turbograneles.Domain.Truck", b =>
                {
                    b.Navigation("Appointments");
                });

            modelBuilder.Entity("Italcol.Turbograneles.Domain.Voyage", b =>
                {
                    b.Navigation("WeighingRecords");
                });
#pragma warning restore 612, 618
        }
    }
}
