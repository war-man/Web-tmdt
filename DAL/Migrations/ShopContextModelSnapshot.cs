﻿// <auto-generated />
using Common.Enum.Log;
using Common.Enum.PM;
using Common.Enum.SM;
using DAL.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace DAL.Migrations
{
    [DbContext(typeof(ShopContext))]
    partial class ShopContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DAL.Model.CM.CM_Customer", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("CMNN");

                    b.Property<string>("ConcurrencyStamp");

                    b.Property<string>("ConfirmCode");

                    b.Property<string>("CustomerName");

                    b.Property<string>("CustomerPhone");

                    b.Property<int>("CustomerStateEnum");

                    b.Property<string>("Email");

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail");

                    b.Property<string>("NormalizedUserName");

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<int>("Prestige");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<int>("TypeCustomerEnum");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.ToTable("CM_Customer");
                });

            modelBuilder.Entity("DAL.Model.ErrorLogs", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedTime");

                    b.Property<string>("ErrorLog");

                    b.Property<string>("FunctionName");

                    b.Property<string>("ModuleName");

                    b.Property<string>("TableName");

                    b.HasKey("ID");

                    b.ToTable("ErrorLogs");
                });

            modelBuilder.Entity("DAL.Model.Log.ImageUploadLog", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedTime");

                    b.Property<string>("CreatedUser");

                    b.Property<string>("Erros");

                    b.Property<string>("IdImage");

                    b.Property<int>("ImageUploadEnum");

                    b.Property<string>("IsSuccess");

                    b.HasKey("ID");

                    b.ToTable("ImageUploadLog");
                });

            modelBuilder.Entity("DAL.Model.PM.Brand", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedTime");

                    b.Property<string>("CreatedUser");

                    b.Property<string>("DefaultImage");

                    b.Property<DateTime>("DeletedDate");

                    b.Property<string>("DeletedUser");

                    b.Property<string>("Description");

                    b.Property<DateTime>("EditedDate");

                    b.Property<string>("EditedUser");

                    b.Property<string>("MetaDescription");

                    b.Property<string>("MetaKey");

                    b.Property<string>("MetaTitle");

                    b.Property<string>("Name");

                    b.Property<string>("UrlFriendly");

                    b.Property<bool>("isDeleted");

                    b.HasKey("ID");

                    b.HasIndex("UrlFriendly")
                        .IsUnique()
                        .HasFilter("[UrlFriendly] IS NOT NULL");

                    b.ToTable("Brand");
                });

            modelBuilder.Entity("DAL.Model.PM.Category", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedTime");

                    b.Property<string>("CreatedUser");

                    b.Property<string>("DefaultImage");

                    b.Property<DateTime>("DeletedDate");

                    b.Property<string>("DeletedUser");

                    b.Property<string>("Description");

                    b.Property<DateTime>("EditedDate");

                    b.Property<string>("EditedUser");

                    b.Property<string>("MetaDescription");

                    b.Property<string>("MetaKey");

                    b.Property<string>("MetaTitle");

                    b.Property<string>("Name");

                    b.Property<string>("UrlFriendly");

                    b.Property<bool>("isDeleted");

                    b.HasKey("ID");

                    b.HasIndex("UrlFriendly")
                        .IsUnique()
                        .HasFilter("[UrlFriendly] IS NOT NULL");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("DAL.Model.PM.Discout", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedTime");

                    b.Property<string>("CreatedUser");

                    b.Property<DateTime>("DeletedDate");

                    b.Property<string>("DeletedUser");

                    b.Property<int>("DiscoutRate");

                    b.Property<DateTime>("EditedDate");

                    b.Property<string>("EditedUser");

                    b.Property<DateTime>("EndTime");

                    b.Property<bool>("IsUsed");

                    b.Property<string>("ProductID");

                    b.Property<DateTime>("StartTime");

                    b.Property<bool>("isDeleted");

                    b.HasKey("ID");

                    b.HasIndex("ProductID");

                    b.ToTable("Discout");
                });

            modelBuilder.Entity("DAL.Model.PM.District", b =>
                {
                    b.Property<string>("DistrictID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<string>("ProvinceID");

                    b.Property<string>("location");

                    b.Property<string>("type");

                    b.HasKey("DistrictID");

                    b.HasIndex("ProvinceID");

                    b.ToTable("District");
                });

            modelBuilder.Entity("DAL.Model.PM.HomeCarousel", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedTime");

                    b.Property<string>("CreatedUser");

                    b.Property<DateTime>("DeletedDate");

                    b.Property<string>("DeletedUser");

                    b.Property<string>("Description");

                    b.Property<DateTime>("EditedDate");

                    b.Property<string>("EditedUser");

                    b.Property<string>("ImagePath");

                    b.Property<bool>("IsHiding");

                    b.Property<int>("OrderIndex");

                    b.Property<bool>("isDeleted");

                    b.HasKey("ID");

                    b.ToTable("HomeCarousel");
                });

            modelBuilder.Entity("DAL.Model.PM.HomeSlider", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedTime");

                    b.Property<string>("CreatedUser");

                    b.Property<DateTime>("DeletedDate");

                    b.Property<string>("DeletedUser");

                    b.Property<string>("Description");

                    b.Property<DateTime>("EditedDate");

                    b.Property<string>("EditedUser");

                    b.Property<string>("ImagePath");

                    b.Property<int>("OrderIndex");

                    b.Property<bool>("isDeleted");

                    b.HasKey("ID");

                    b.ToTable("HomeSlider");
                });

            modelBuilder.Entity("DAL.Model.PM.MainGroup", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedTime");

                    b.Property<string>("CreatedUser");

                    b.Property<string>("DefaultImage");

                    b.Property<DateTime>("DeletedDate");

                    b.Property<string>("DeletedUser");

                    b.Property<string>("Description");

                    b.Property<DateTime>("EditedDate");

                    b.Property<string>("EditedUser");

                    b.Property<string>("MetaDescription");

                    b.Property<string>("MetaKey");

                    b.Property<string>("MetaTitle");

                    b.Property<string>("Name");

                    b.Property<int>("TypeSex");

                    b.Property<string>("UrlFriendly");

                    b.Property<bool>("isDeleted");

                    b.HasKey("ID");

                    b.HasIndex("Name")
                        .IsUnique()
                        .HasFilter("[Name] IS NOT NULL");

                    b.ToTable("MainGroup");
                });

            modelBuilder.Entity("DAL.Model.PM.Product", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BrandID");

                    b.Property<string>("CategoryID");

                    b.Property<string>("CommentArea");

                    b.Property<DateTime>("CreatedTime");

                    b.Property<string>("CreatedUser");

                    b.Property<string>("DefaultImage");

                    b.Property<DateTime>("DeletedDate");

                    b.Property<string>("DeletedUser");

                    b.Property<string>("Details");

                    b.Property<DateTime>("EditedDate");

                    b.Property<string>("EditedUser");

                    b.Property<bool>("IsAllowComment");

                    b.Property<string>("LadingPage");

                    b.Property<string>("MetaDescription");

                    b.Property<string>("MetaKey");

                    b.Property<string>("MetaTitle");

                    b.Property<string>("Model");

                    b.Property<decimal>("Price");

                    b.Property<string>("Specification");

                    b.Property<int>("StockMin");

                    b.Property<string>("SubGroupID");

                    b.Property<string>("UrlFriendly");

                    b.Property<bool>("isDeleted");

                    b.Property<bool>("isOnlineOnly");

                    b.HasKey("ID");

                    b.HasIndex("BrandID");

                    b.HasIndex("CategoryID");

                    b.HasIndex("SubGroupID");

                    b.HasIndex("UrlFriendly")
                        .IsUnique()
                        .HasFilter("[UrlFriendly] IS NOT NULL");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("DAL.Model.PM.ProductDetails", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedTime");

                    b.Property<string>("CreatedUser");

                    b.Property<string>("DefaultImage");

                    b.Property<DateTime>("DeletedDate");

                    b.Property<string>("DeletedUser");

                    b.Property<DateTime>("EditedDate");

                    b.Property<string>("EditedUser");

                    b.Property<int>("MaxQuantityBuy");

                    b.Property<string>("Note");

                    b.Property<decimal>("Price");

                    b.Property<string>("ProductID");

                    b.Property<int>("Quantity");

                    b.Property<int>("Size");

                    b.Property<string>("Specification");

                    b.Property<int>("StockMin");

                    b.Property<int>("TypeColor");

                    b.Property<bool>("isDeleted");

                    b.Property<string>("listImages");

                    b.HasKey("ID");

                    b.HasIndex("ProductID");

                    b.ToTable("ProductDetails");
                });

            modelBuilder.Entity("DAL.Model.PM.Province", b =>
                {
                    b.Property<string>("ProvinceID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<string>("type");

                    b.HasKey("ProvinceID");

                    b.ToTable("Province");
                });

            modelBuilder.Entity("DAL.Model.PM.Store", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<DateTime>("CreatedTime");

                    b.Property<string>("CreatedUser");

                    b.Property<string>("DefaultImage");

                    b.Property<DateTime>("DeletedDate");

                    b.Property<string>("DeletedUser");

                    b.Property<string>("Description");

                    b.Property<string>("DistrictID");

                    b.Property<DateTime>("EditedDate");

                    b.Property<string>("EditedUser");

                    b.Property<string>("FAX");

                    b.Property<float>("Lat");

                    b.Property<float>("Lng");

                    b.Property<string>("MetaDescription");

                    b.Property<string>("MetaKey");

                    b.Property<string>("MetaTitle");

                    b.Property<string>("NameStore");

                    b.Property<string>("UrlFriendly");

                    b.Property<bool>("isDeleted");

                    b.HasKey("ID");

                    b.HasIndex("DistrictID");

                    b.ToTable("Store");
                });

            modelBuilder.Entity("DAL.Model.PM.SubGroup", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedTime");

                    b.Property<string>("CreatedUser");

                    b.Property<string>("DefaultImage");

                    b.Property<DateTime>("DeletedDate");

                    b.Property<string>("DeletedUser");

                    b.Property<string>("Description");

                    b.Property<DateTime>("EditedDate");

                    b.Property<string>("EditedUser");

                    b.Property<string>("MainGroupID");

                    b.Property<string>("MetaDescription");

                    b.Property<string>("MetaKey");

                    b.Property<string>("MetaTitle");

                    b.Property<string>("Name");

                    b.Property<int>("TypeSex");

                    b.Property<string>("UrlFriendly");

                    b.Property<bool>("isDeleted");

                    b.HasKey("ID");

                    b.HasIndex("MainGroupID");

                    b.HasIndex("UrlFriendly")
                        .IsUnique()
                        .HasFilter("[UrlFriendly] IS NOT NULL");

                    b.ToTable("SubGroup");
                });

            modelBuilder.Entity("DAL.Model.PM.SubscribeEmail", b =>
                {
                    b.Property<string>("Email")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateTime");

                    b.HasKey("Email");

                    b.ToTable("SubscribeEmail");
                });

            modelBuilder.Entity("DAL.Model.PM.TransportPrice", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedTime");

                    b.Property<string>("CreatedUser");

                    b.Property<DateTime>("DeletedDate");

                    b.Property<string>("DeletedUser");

                    b.Property<string>("DistrictID");

                    b.Property<DateTime>("EditedDate");

                    b.Property<string>("EditedUser");

                    b.Property<decimal>("Price");

                    b.Property<string>("TransportTypeID");

                    b.Property<bool>("isDeleted");

                    b.HasKey("ID");

                    b.HasIndex("DistrictID");

                    b.HasIndex("TransportTypeID");

                    b.ToTable("TransportPrice");
                });

            modelBuilder.Entity("DAL.Model.PM.TransportType", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedTime");

                    b.Property<string>("CreatedUser");

                    b.Property<DateTime>("DeletedDate");

                    b.Property<string>("DeletedUser");

                    b.Property<DateTime>("EditedDate");

                    b.Property<string>("EditedUser");

                    b.Property<string>("Name");

                    b.Property<string>("Note");

                    b.Property<int>("Prestige");

                    b.Property<decimal>("Price");

                    b.Property<bool>("isDeleted");

                    b.HasKey("ID");

                    b.ToTable("TransportType");
                });

            modelBuilder.Entity("DAL.Model.PM.Voucher", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedTime");

                    b.Property<string>("CreatedUser");

                    b.Property<DateTime>("DeletedDate");

                    b.Property<string>("DeletedUser");

                    b.Property<int>("DiscoutRate");

                    b.Property<DateTime>("EditedDate");

                    b.Property<string>("EditedUser");

                    b.Property<DateTime>("ExperiedTime");

                    b.Property<int>("UniqueCode")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("isDeleted");

                    b.HasKey("ID");

                    b.ToTable("Voucher");
                });

            modelBuilder.Entity("DAL.Model.SM.SaleOrder", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AuthenticationMethodGuid");

                    b.Property<DateTime>("CreatedTime");

                    b.Property<string>("CreatedUser");

                    b.Property<decimal>("CurrentTransportPrice");

                    b.Property<string>("CustomerID");

                    b.Property<DateTime>("DeletedDate");

                    b.Property<string>("DeletedUser");

                    b.Property<DateTime>("EditedDate");

                    b.Property<string>("EditedUser");

                    b.Property<bool>("IsPay");

                    b.Property<int>("PaymentMethod");

                    b.Property<string>("ReviewBy");

                    b.Property<DateTime>("ReviewDate");

                    b.Property<int>("State");

                    b.Property<decimal>("TotalPrice");

                    b.Property<string>("TransportPriceID");

                    b.Property<decimal>("TransportTypePrice");

                    b.Property<int>("VAT");

                    b.Property<string>("VoucherID");

                    b.Property<bool>("isDeleted");

                    b.HasKey("ID");

                    b.HasIndex("CustomerID");

                    b.HasIndex("TransportPriceID");

                    b.HasIndex("VoucherID");

                    b.ToTable("SaleOrder");
                });

            modelBuilder.Entity("DAL.Model.SM.SaleOrderDetail", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedTime");

                    b.Property<string>("CreatedUser");

                    b.Property<DateTime>("DeletedDate");

                    b.Property<string>("DeletedUser");

                    b.Property<string>("DiscoutID");

                    b.Property<DateTime>("EditedDate");

                    b.Property<string>("EditedUser");

                    b.Property<string>("Note");

                    b.Property<decimal>("Price");

                    b.Property<string>("ProductID");

                    b.Property<int>("Quality");

                    b.Property<string>("SaleOrderID");

                    b.Property<bool>("isDeleted");

                    b.HasKey("ID");

                    b.HasIndex("DiscoutID");

                    b.HasIndex("ProductID");

                    b.HasIndex("SaleOrderID");

                    b.ToTable("SaleOrderDetail");
                });

            modelBuilder.Entity("DAL.Model.System.System_Permission", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedTime");

                    b.Property<string>("CreatedUser");

                    b.Property<DateTime>("DeletedDate");

                    b.Property<string>("DeletedUser");

                    b.Property<DateTime>("EditedDate");

                    b.Property<string>("EditedUser");

                    b.Property<string>("PermissionCode")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("PermissionName");

                    b.Property<bool>("isDeleted");

                    b.HasKey("ID");

                    b.HasIndex("PermissionName")
                        .IsUnique()
                        .HasFilter("[PermissionName] IS NOT NULL");

                    b.ToTable("System_Permission");
                });

            modelBuilder.Entity("DAL.Model.System.System_Policy", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedTime");

                    b.Property<string>("CreatedUser");

                    b.Property<DateTime>("DeletedDate");

                    b.Property<string>("DeletedUser");

                    b.Property<DateTime>("EditedDate");

                    b.Property<string>("EditedUser");

                    b.Property<DateTime>("ReviewDate");

                    b.Property<string>("ReviewUserID");

                    b.Property<string>("System_PositionID");

                    b.Property<string>("System_Position_Policy");

                    b.Property<string>("System_Position_Policy_Value");

                    b.Property<bool>("isDeleted");

                    b.HasKey("ID");

                    b.HasIndex("ReviewUserID");

                    b.HasIndex("System_PositionID");

                    b.ToTable("System_Policy");
                });

            modelBuilder.Entity("DAL.Model.System.System_Position", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedTime");

                    b.Property<string>("CreatedUser");

                    b.Property<DateTime>("DeletedDate");

                    b.Property<string>("DeletedUser");

                    b.Property<string>("Description");

                    b.Property<DateTime>("EditedDate");

                    b.Property<string>("EditedUser");

                    b.Property<string>("ImagePath");

                    b.Property<string>("NamePosition");

                    b.Property<bool>("isDeleted");

                    b.HasKey("ID");

                    b.ToTable("System_Position");
                });

            modelBuilder.Entity("DAL.Model.System.System_User_Permission", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedTime");

                    b.Property<string>("CreatedUser");

                    b.Property<DateTime>("DeletedDate");

                    b.Property<string>("DeletedUser");

                    b.Property<DateTime>("EditedDate");

                    b.Property<string>("EditedUser");

                    b.Property<DateTime>("ReviewDate");

                    b.Property<string>("ReviewUserName");

                    b.Property<string>("System_PermissionID");

                    b.Property<string>("UserName");

                    b.Property<bool>("isDeleted");

                    b.HasKey("ID");

                    b.HasIndex("System_PermissionID");

                    b.ToTable("Systemm_User_Permission");
                });

            modelBuilder.Entity("DAL.Model.System_User", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("CMND");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("PositionID");

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

                    b.HasIndex("PositionID");

                    b.ToTable("System_User");
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
                        .ValueGeneratedOnAdd();

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
                        .ValueGeneratedOnAdd();

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
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

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

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("DAL.Model.PM.Discout", b =>
                {
                    b.HasOne("DAL.Model.PM.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductID");
                });

            modelBuilder.Entity("DAL.Model.PM.District", b =>
                {
                    b.HasOne("DAL.Model.PM.Province", "Province")
                        .WithMany("Districts")
                        .HasForeignKey("ProvinceID");
                });

            modelBuilder.Entity("DAL.Model.PM.Product", b =>
                {
                    b.HasOne("DAL.Model.PM.Brand", "Brand")
                        .WithMany("Products")
                        .HasForeignKey("BrandID")
                        .HasConstraintName("FK_Brand_Products");

                    b.HasOne("DAL.Model.PM.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryID")
                        .HasConstraintName("FK_Category_Products");

                    b.HasOne("DAL.Model.PM.SubGroup", "SubGroup")
                        .WithMany()
                        .HasForeignKey("SubGroupID");
                });

            modelBuilder.Entity("DAL.Model.PM.ProductDetails", b =>
                {
                    b.HasOne("DAL.Model.PM.Product", "Product")
                        .WithMany("ListProductDetails")
                        .HasForeignKey("ProductID")
                        .HasConstraintName("FK_Product_ProductDetails");
                });

            modelBuilder.Entity("DAL.Model.PM.Store", b =>
                {
                    b.HasOne("DAL.Model.PM.District", "District")
                        .WithMany("Stores")
                        .HasForeignKey("DistrictID")
                        .HasConstraintName("FK_Store_District");
                });

            modelBuilder.Entity("DAL.Model.PM.SubGroup", b =>
                {
                    b.HasOne("DAL.Model.PM.MainGroup", "MainGroup")
                        .WithMany("SubGroups")
                        .HasForeignKey("MainGroupID")
                        .HasConstraintName("FK_SubGroup_MainGroup");
                });

            modelBuilder.Entity("DAL.Model.PM.TransportPrice", b =>
                {
                    b.HasOne("DAL.Model.PM.District", "District")
                        .WithMany()
                        .HasForeignKey("DistrictID");

                    b.HasOne("DAL.Model.PM.TransportType", "TransportType")
                        .WithMany("TransportPrices")
                        .HasForeignKey("TransportTypeID")
                        .HasConstraintName("FK_TransportType_TransportPrice");
                });

            modelBuilder.Entity("DAL.Model.SM.SaleOrder", b =>
                {
                    b.HasOne("DAL.Model.CM.CM_Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerID");

                    b.HasOne("DAL.Model.PM.TransportType", "TransportPrice")
                        .WithMany()
                        .HasForeignKey("TransportPriceID");

                    b.HasOne("DAL.Model.PM.Voucher", "Voucher")
                        .WithMany("SaleOrders")
                        .HasForeignKey("VoucherID")
                        .HasConstraintName("FK_Voucher_SaleOrders");
                });

            modelBuilder.Entity("DAL.Model.SM.SaleOrderDetail", b =>
                {
                    b.HasOne("DAL.Model.PM.Discout", "Discout")
                        .WithMany("SaleOrderDetails")
                        .HasForeignKey("DiscoutID")
                        .HasConstraintName("FK_Discout_SaleOrderDetails");

                    b.HasOne("DAL.Model.PM.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductID");

                    b.HasOne("DAL.Model.SM.SaleOrder", "SaleOrder")
                        .WithMany("ListSaleOrderDetails")
                        .HasForeignKey("SaleOrderID");
                });

            modelBuilder.Entity("DAL.Model.System.System_Policy", b =>
                {
                    b.HasOne("DAL.Model.System_User", "ReviewUser")
                        .WithMany()
                        .HasForeignKey("ReviewUserID");

                    b.HasOne("DAL.Model.System.System_Position", "System_Position")
                        .WithMany("List_System_Policies")
                        .HasForeignKey("System_PositionID")
                        .HasConstraintName("FK_System_Position_Policies");
                });

            modelBuilder.Entity("DAL.Model.System.System_User_Permission", b =>
                {
                    b.HasOne("DAL.Model.System.System_Permission", "System_Permission")
                        .WithMany("System_User_Permissions")
                        .HasForeignKey("System_PermissionID")
                        .HasConstraintName("FK_UserPermission_SystemPermission");
                });

            modelBuilder.Entity("DAL.Model.System_User", b =>
                {
                    b.HasOne("DAL.Model.System.System_Position", "Position")
                        .WithMany("List_Position_Users")
                        .HasForeignKey("PositionID")
                        .HasConstraintName("FK_Position_Users");
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
                    b.HasOne("DAL.Model.System_User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("DAL.Model.System_User")
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

                    b.HasOne("DAL.Model.System_User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("DAL.Model.System_User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
