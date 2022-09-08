﻿// <auto-generated />
using System;
using CADPLIS.EntityFrameworkCore.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CADPLIS.EntityFrameworkCore.Migrations
{
    [DbContext(typeof(PlisDbcontext))]
    [Migration("20210812035706_BanBen1")]
    partial class BanBen1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CADPLIS.Domain.AuditInfos.AuditInfo", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(36)
                        .HasColumnType("nvarchar(36)");

                    b.Property<string>("ActionName")
                        .HasMaxLength(36)
                        .HasColumnType("nvarchar(36)");

                    b.Property<string>("Browser")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("Controller")
                        .HasMaxLength(36)
                        .HasColumnType("nvarchar(36)");

                    b.Property<string>("ErrorMsg")
                        .HasMaxLength(512)
                        .HasColumnType("nvarchar(512)");

                    b.Property<int>("ExecuteTime")
                        .HasColumnType("int");

                    b.Property<string>("IpAddress")
                        .HasMaxLength(36)
                        .HasColumnType("nvarchar(36)");

                    b.Property<string>("Method")
                        .HasMaxLength(18)
                        .HasColumnType("nvarchar(18)");

                    b.Property<string>("Operator")
                        .IsRequired()
                        .HasMaxLength(36)
                        .HasColumnType("nvarchar(36)");

                    b.Property<string>("RequestArguments")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AuditInfo");
                });

            modelBuilder.Entity("CADPLIS.Domain.Identity.ApplicationRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("CADPLIS.Domain.Identity.ApplicationUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("OtherName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("CADPLIS.Domain.NavMenus.NavMenu", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(36)
                        .HasColumnType("nvarchar(36)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Icon")
                        .HasMaxLength(36)
                        .HasColumnType("nvarchar(36)");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("MenuName")
                        .IsRequired()
                        .HasMaxLength(36)
                        .HasColumnType("nvarchar(36)");

                    b.Property<int>("OrderNo")
                        .HasColumnType("int");

                    b.Property<string>("ParentId")
                        .HasMaxLength(36)
                        .HasColumnType("nvarchar(36)");

                    b.Property<string>("Permission")
                        .HasMaxLength(36)
                        .HasColumnType("nvarchar(36)");

                    b.Property<string>("RouteUrl")
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("NavMenu");
                });

            modelBuilder.Entity("CADPLIS.Domain.Roles.RoleMenuRelationships", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(36)
                        .HasColumnType("nvarchar(36)");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("MenuId")
                        .IsRequired()
                        .HasMaxLength(36)
                        .HasColumnType("nvarchar(36)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasMaxLength(36)
                        .HasColumnType("nvarchar(36)");

                    b.Property<DateTime>("UpdateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("RoleMenuRelationships");
                });

            modelBuilder.Entity("CADPLIS.Domain.Roles.UserRoleRelationships", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(36)
                        .HasColumnType("nvarchar(36)");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasMaxLength(36)
                        .HasColumnType("nvarchar(36)");

                    b.Property<DateTime>("UpdateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasMaxLength(36)
                        .HasColumnType("nvarchar(36)");

                    b.HasKey("Id");

                    b.ToTable("UserRoleRelationships");
                });

            modelBuilder.Entity("CADPLIS.Domain.Roles.UserRoles", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(36)
                        .HasColumnType("nvarchar(36)");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("Remark")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasMaxLength(36)
                        .HasColumnType("nvarchar(36)");

                    b.Property<DateTime>("UpdateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("CADPLIS.Domain.Users.User", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(36)
                        .HasColumnType("nvarchar(36)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<DateTime?>("UpdateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(36)
                        .HasColumnType("nvarchar(36)");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("CADPLIS.Domain.WorkFlows.Document", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AuthorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ManagerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<int>("Number")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Point")
                        .HasColumnType("int");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(1024)
                        .HasColumnType("nvarchar(1024)");

                    b.Property<string>("StateName")
                        .HasMaxLength(1024)
                        .HasColumnType("nvarchar(1024)");

                    b.Property<decimal>("Sum")
                        .HasColumnType("money");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("ManagerId");

                    b.ToTable("Document");
                });

            modelBuilder.Entity("CADPLIS.Domain.WorkFlows.Employee", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsHead")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<Guid>("StructDivisionId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("StructDivisionId");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("CADPLIS.Domain.WorkFlows.EmployeeRole", b =>
                {
                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("EmployeeId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("RoleId", "EmployeeId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("EmployeeRole");
                });

            modelBuilder.Entity("CADPLIS.Domain.WorkFlows.Head", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("HeadId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("HeadName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("vHeads");
                });

            modelBuilder.Entity("CADPLIS.Domain.WorkFlows.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("CADPLIS.Domain.WorkFlows.StructDivision", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<Guid?>("ParentId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.ToTable("StructDivision");
                });

            modelBuilder.Entity("CADPLIS.Domain.WorkFlows.WorkflowScheme", b =>
                {
                    b.Property<string>("Code")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("Scheme")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Code");

                    b.ToTable("WorkflowScheme");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUserRole<Guid>");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("CADPLIS.Domain.Identity.ApplicationUserRole", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>");

                    b.Property<Guid?>("RoleId1")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("UserId1")
                        .HasColumnType("uniqueidentifier");

                    b.HasIndex("RoleId1");

                    b.HasIndex("UserId1");

                    b.HasDiscriminator().HasValue("ApplicationUserRole");
                });

            modelBuilder.Entity("CADPLIS.Domain.WorkFlows.Document", b =>
                {
                    b.HasOne("CADPLIS.Domain.WorkFlows.Employee", "Author")
                        .WithMany("Documents")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CADPLIS.Domain.WorkFlows.Employee", "Manager")
                        .WithMany("Documents1")
                        .HasForeignKey("ManagerId");

                    b.Navigation("Author");

                    b.Navigation("Manager");
                });

            modelBuilder.Entity("CADPLIS.Domain.WorkFlows.Employee", b =>
                {
                    b.HasOne("CADPLIS.Domain.WorkFlows.StructDivision", "StructDivision")
                        .WithMany("Employees")
                        .HasForeignKey("StructDivisionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("StructDivision");
                });

            modelBuilder.Entity("CADPLIS.Domain.WorkFlows.EmployeeRole", b =>
                {
                    b.HasOne("CADPLIS.Domain.WorkFlows.Employee", "Employee")
                        .WithMany("EmployeeRoles")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CADPLIS.Domain.WorkFlows.Role", "Role")
                        .WithMany("EmployeeRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("CADPLIS.Domain.WorkFlows.StructDivision", b =>
                {
                    b.HasOne("CADPLIS.Domain.WorkFlows.StructDivision", "StructDivision2")
                        .WithMany("StructDivision1")
                        .HasForeignKey("ParentId");

                    b.Navigation("StructDivision2");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("CADPLIS.Domain.Identity.ApplicationRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("CADPLIS.Domain.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("CADPLIS.Domain.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("CADPLIS.Domain.Identity.ApplicationRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CADPLIS.Domain.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("CADPLIS.Domain.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CADPLIS.Domain.Identity.ApplicationUserRole", b =>
                {
                    b.HasOne("CADPLIS.Domain.Identity.ApplicationRole", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId1");

                    b.HasOne("CADPLIS.Domain.Identity.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId1");

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("CADPLIS.Domain.Identity.ApplicationRole", b =>
                {
                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("CADPLIS.Domain.WorkFlows.Employee", b =>
                {
                    b.Navigation("Documents");

                    b.Navigation("Documents1");

                    b.Navigation("EmployeeRoles");
                });

            modelBuilder.Entity("CADPLIS.Domain.WorkFlows.Role", b =>
                {
                    b.Navigation("EmployeeRoles");
                });

            modelBuilder.Entity("CADPLIS.Domain.WorkFlows.StructDivision", b =>
                {
                    b.Navigation("Employees");

                    b.Navigation("StructDivision1");
                });
#pragma warning restore 612, 618
        }
    }
}
