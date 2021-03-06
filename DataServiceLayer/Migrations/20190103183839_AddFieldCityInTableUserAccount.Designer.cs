﻿// <auto-generated />
using System;
using DataServiceLayer.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataServiceLayer.Migrations
{
    [DbContext(typeof(SecurityContext))]
    [Migration("20190103183839_AddFieldCityInTableUserAccount")]
    partial class AddFieldCityInTableUserAccount
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DataServiceInterfaces.Models.Roles", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id");

                    b.Property<string>("Name")
                        .HasColumnName("Name");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("DataServiceInterfaces.Models.UserAccounts", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id");

                    b.Property<bool>("Active")
                        .HasColumnName("Active");

                    b.Property<string>("City");

                    b.Property<string>("Email")
                        .HasColumnName("Email");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnName("PasswordHash");

                    b.Property<string>("PrefferedLanguage")
                        .HasColumnName("PrefferedLanguage");

                    b.Property<byte[]>("Salt")
                        .HasColumnName("Salt");

                    b.Property<string>("Username")
                        .HasColumnName("Username");

                    b.Property<Guid?>("VerificationToken")
                        .HasColumnName("VerificationToken");

                    b.HasKey("Id");

                    b.ToTable("UserAccount");
                });

            modelBuilder.Entity("DataServiceInterfaces.Models.UserRoles", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("DataServiceInterfaces.Models.UserRoles", b =>
                {
                    b.HasOne("DataServiceInterfaces.Models.Roles", "Rol")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DataServiceInterfaces.Models.UserAccounts", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
