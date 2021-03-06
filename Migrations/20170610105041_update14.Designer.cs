﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Core.Data;

namespace Core.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20170610105041_update14")]
    partial class update14
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Core.Models.Address", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City");

                    b.Property<Guid>("CreatedUser");

                    b.Property<string>("FullAddress");

                    b.Property<bool>("Geocoded");

                    b.Property<string>("Name");

                    b.Property<string>("PhoneNumber");

                    b.Property<string>("PostalCode");

                    b.Property<string>("Province");

                    b.Property<string>("SpecialInstructions");

                    b.Property<int>("Status");

                    b.Property<string>("StreetName");

                    b.Property<string>("StreetNumber");

                    b.HasKey("ID");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("Core.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("City");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Country");

                    b.Property<string>("DeliveryAddress");

                    b.Property<DateTime>("DoB");

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<bool>("Mnp");

                    b.Property<Guid>("MnpGuid");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("PostalCode");

                    b.Property<string>("Province");

                    b.Property<string>("SecurityStamp");

                    b.Property<string>("StreetName");

                    b.Property<string>("StreetNumber");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.Property<int>("status");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("Core_User");
                });

            modelBuilder.Entity("Core.Models.Comment", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("CreatedBy");

                    b.Property<int>("DisLikes");

                    b.Property<int>("Likes");

                    b.Property<int>("Rating");

                    b.Property<int>("Status");

                    b.Property<string>("Text");

                    b.HasKey("ID");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("Core.Models.DeliveryArea", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("ClosedTime");

                    b.Property<Guid>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<bool>("Open");

                    b.Property<DateTime>("OpenTime");

                    b.Property<Guid>("Partner");

                    b.Property<string>("Points");

                    b.Property<int>("Status");

                    b.HasKey("ID");

                    b.ToTable("DeliveryArea");
                });

            modelBuilder.Entity("Core.Models.DeliveryAreaDriver", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("DeliverAreaIdID");

                    b.Property<int?>("DriverIdID");

                    b.HasKey("Id");

                    b.HasIndex("DeliverAreaIdID");

                    b.HasIndex("DriverIdID");

                    b.ToTable("DeliveryAreaDrivers");
                });

            modelBuilder.Entity("Core.Models.Driver", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address1");

                    b.Property<string>("Details");

                    b.Property<string>("GeocodedAddress");

                    b.Property<string>("LicenseNumber");

                    b.Property<string>("LicenseProvince");

                    b.Property<string>("PhoneNumber");

                    b.Property<string>("PostalCode");

                    b.Property<string>("SpecialInstructions");

                    b.Property<int>("Status");

                    b.Property<Guid>("UserGuid");

                    b.Property<int>("VehicleId");

                    b.HasKey("ID");

                    b.ToTable("Drivers");
                });

            modelBuilder.Entity("Core.Models.Franchise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("AppUser");

                    b.Property<string>("City");

                    b.Property<bool>("Consent");

                    b.Property<DateTime>("ContactDate");

                    b.Property<bool>("HasVehicle");

                    b.Property<DateTime>("StartDate");

                    b.Property<string>("VehicleType");

                    b.Property<int>("VehicleYear");

                    b.HasKey("Id");

                    b.ToTable("Franchise");
                });

            modelBuilder.Entity("Core.Models.Inventory", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("BestBefore");

                    b.Property<double>("CBDContent");

                    b.Property<double>("Cost");

                    b.Property<int>("CostPerGram");

                    b.Property<string>("Description");

                    b.Property<int>("Discount");

                    b.Property<string>("ImageFilePath");

                    b.Property<string>("Label");

                    b.Property<int>("Likes");

                    b.Property<string>("Notes");

                    b.Property<bool>("OnHand");

                    b.Property<DateTime>("OrderDate");

                    b.Property<int>("PartnerId");

                    b.Property<byte[]>("Photo");

                    b.Property<double>("Price");

                    b.Property<int>("PricePerGram");

                    b.Property<int>("PricePerOz");

                    b.Property<int>("PricePerQuarter");

                    b.Property<int>("PricePerhalf");

                    b.Property<string>("Qualities");

                    b.Property<double>("Quantity");

                    b.Property<int>("Status");

                    b.Property<string>("Supplier");

                    b.Property<double>("THCContent");

                    b.Property<string>("UPC");

                    b.Property<string>("catagory");

                    b.HasKey("ID");

                    b.ToTable("Inventorys");
                });

            modelBuilder.Entity("Core.Models.MnpForm", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Alergies");

                    b.Property<DateTime>("Date");

                    b.Property<string>("Dispencery");

                    b.Property<string>("Doctor");

                    b.Property<string>("DoctorCity");

                    b.Property<bool>("HasAlergies");

                    b.Property<byte[]>("Image");

                    b.Property<string>("ImageName");

                    b.Property<string>("LegalFirstName");

                    b.Property<string>("LegalLastName");

                    b.Property<bool>("MedCannabisUser");

                    b.Property<string>("MedConditions");

                    b.Property<bool>("MedConditionsExisting");

                    b.Property<string>("MedConditionsTreatment");

                    b.Property<bool>("PhotoId");

                    b.Property<bool>("RelievesCondition");

                    b.Property<bool>("Signature");

                    b.Property<byte[]>("SignatureFile");

                    b.Property<Guid>("UserId");

                    b.Property<bool>("WantRx");

                    b.Property<int>("YearsUsing");

                    b.HasKey("Id");

                    b.ToTable("MnpForms");
                });

            modelBuilder.Entity("Core.Models.Order", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("AppUser");

                    b.Property<int>("CustomerId");

                    b.Property<DateTime>("DeliveryDate");

                    b.Property<string>("Details");

                    b.Property<int>("DriverId");

                    b.Property<Guid>("GUID");

                    b.Property<string>("GeocodedAddress");

                    b.Property<DateTime>("OrderDate");

                    b.Property<int>("PaymentType");

                    b.Property<string>("PhoneNumber");

                    b.Property<string>("SpecialInstructions");

                    b.Property<int>("Status");

                    b.Property<decimal>("Total");

                    b.Property<decimal>("Weight");

                    b.HasKey("ID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Core.Models.Partner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City");

                    b.Property<string>("Company");

                    b.Property<int>("DeliveryArea");

                    b.Property<Guid>("GUID");

                    b.Property<string>("Name");

                    b.Property<string>("PhoneNumber");

                    b.Property<string>("PostalCode");

                    b.Property<string>("Province");

                    b.Property<string>("SMSNumber");

                    b.Property<string>("ShippingAddress");

                    b.Property<string>("SpecialInstructions");

                    b.Property<int>("Status");

                    b.Property<string>("StreetAddress");

                    b.Property<string>("TaxId");

                    b.HasKey("Id");

                    b.ToTable("Partners");
                });

            modelBuilder.Entity("Core.Models.SMS", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("AppUser");

                    b.Property<string>("DateRecieved");

                    b.Property<string>("DateSent");

                    b.Property<string>("SentFrom");

                    b.Property<string>("SentTo");

                    b.HasKey("Id");

                    b.ToTable("SMS");
                });

            modelBuilder.Entity("Core.Models.Vehicle", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Details");

                    b.Property<string>("InsurancePolicy");

                    b.Property<string>("LicensePlate");

                    b.Property<string>("Make");

                    b.Property<string>("Model");

                    b.Property<int>("Status");

                    b.Property<Guid>("UserGuid");

                    b.Property<int>("Year");

                    b.HasKey("ID");

                    b.ToTable("Vehicles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Core.Models.DeliveryAreaDriver", b =>
                {
                    b.HasOne("Core.Models.DeliveryArea", "DeliverAreaId")
                        .WithMany()
                        .HasForeignKey("DeliverAreaIdID");

                    b.HasOne("Core.Models.Driver", "DriverId")
                        .WithMany()
                        .HasForeignKey("DriverIdID");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole")
                        .WithMany("Claims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Core.Models.ApplicationUser")
                        .WithMany("Claims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Core.Models.ApplicationUser")
                        .WithMany("Logins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Core.Models.ApplicationUser")
                        .WithMany("Roles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
