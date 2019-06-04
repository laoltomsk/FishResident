﻿// <auto-generated />
using System;
using FishResident.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FishResident.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20190604061514_AddCostAndArea")]
    partial class AddCostAndArea
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FishResident.Models.Agreement", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.Property<string>("OwnerId")
                        .IsRequired();

                    b.Property<Guid>("ResidenceId");

                    b.Property<string>("ResidentId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.HasIndex("ResidenceId");

                    b.HasIndex("ResidentId");

                    b.ToTable("Agreements");
                });

            modelBuilder.Entity("FishResident.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("CellPhone");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Contacts");

                    b.Property<string>("DirectOfficePhone");

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("GeneralOfficePhone");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("OfficePhoneExtension");

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecondaryEmail");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("FishResident.Models.Feature", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AdditionalInfo");

                    b.Property<Guid?>("FeatureTypeId");

                    b.Property<Guid?>("LinkedFeatureId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("FeatureTypeId");

                    b.HasIndex("LinkedFeatureId");

                    b.ToTable("Features");
                });

            modelBuilder.Entity("FishResident.Models.FeatureAllowedValue", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("FeatureId");

                    b.Property<string>("Value");

                    b.HasKey("Id");

                    b.HasIndex("FeatureId");

                    b.ToTable("FeatureAllowedValues");
                });

            modelBuilder.Entity("FishResident.Models.FeatureRequest", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("FeatureId");

                    b.Property<Guid>("SearchRequestId");

                    b.Property<string>("Value");

                    b.HasKey("Id");

                    b.HasIndex("FeatureId");

                    b.HasIndex("SearchRequestId");

                    b.ToTable("FeatureRequests");
                });

            modelBuilder.Entity("FishResident.Models.FeatureType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("FeatureTypes");
                });

            modelBuilder.Entity("FishResident.Models.Residence", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<double>("Area");

                    b.Property<double>("Cost");

                    b.Property<string>("OwnerId")
                        .IsRequired();

                    b.Property<Guid?>("SearchRequestId");

                    b.Property<Guid>("TypeId");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.HasIndex("SearchRequestId");

                    b.HasIndex("TypeId");

                    b.ToTable("Residences");
                });

            modelBuilder.Entity("FishResident.Models.ResidenceType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("ResidenceTypes");
                });

            modelBuilder.Entity("FishResident.Models.SearchRequest", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("SearchRequests");
                });

            modelBuilder.Entity("FishResident.Models.Subscription", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("PaymentAmount");

                    b.Property<DateTime>("PaymentDate");

                    b.Property<string>("SubscriberId")
                        .IsRequired();

                    b.Property<string>("TimePeriod");

                    b.Property<int>("Type");

                    b.HasKey("Id");

                    b.HasIndex("SubscriberId");

                    b.ToTable("Subscriptions");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
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
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("FishResident.Models.Agreement", b =>
                {
                    b.HasOne("FishResident.Models.ApplicationUser", "Owner")
                        .WithMany("AgreementsOwner")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FishResident.Models.Residence", "Residence")
                        .WithMany("Agreements")
                        .HasForeignKey("ResidenceId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FishResident.Models.ApplicationUser", "Resident")
                        .WithMany("AgreementsResident")
                        .HasForeignKey("ResidentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FishResident.Models.Feature", b =>
                {
                    b.HasOne("FishResident.Models.FeatureType", "FeatureType")
                        .WithMany()
                        .HasForeignKey("FeatureTypeId");

                    b.HasOne("FishResident.Models.Feature", "LinkedFeature")
                        .WithMany()
                        .HasForeignKey("LinkedFeatureId");
                });

            modelBuilder.Entity("FishResident.Models.FeatureAllowedValue", b =>
                {
                    b.HasOne("FishResident.Models.Feature", "Feature")
                        .WithMany("AllowedValues")
                        .HasForeignKey("FeatureId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FishResident.Models.FeatureRequest", b =>
                {
                    b.HasOne("FishResident.Models.Feature", "Feature")
                        .WithMany()
                        .HasForeignKey("FeatureId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FishResident.Models.SearchRequest", "SearchRequest")
                        .WithMany("FeatureRequests")
                        .HasForeignKey("SearchRequestId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FishResident.Models.Residence", b =>
                {
                    b.HasOne("FishResident.Models.ApplicationUser", "Owner")
                        .WithMany("Residences")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FishResident.Models.SearchRequest")
                        .WithMany("Results")
                        .HasForeignKey("SearchRequestId");

                    b.HasOne("FishResident.Models.ResidenceType", "Type")
                        .WithMany()
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FishResident.Models.SearchRequest", b =>
                {
                    b.HasOne("FishResident.Models.ApplicationUser", "User")
                        .WithMany("SearchRequests")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FishResident.Models.Subscription", b =>
                {
                    b.HasOne("FishResident.Models.ApplicationUser", "Subscriber")
                        .WithMany("Subscriptions")
                        .HasForeignKey("SubscriberId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("FishResident.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("FishResident.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FishResident.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("FishResident.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
