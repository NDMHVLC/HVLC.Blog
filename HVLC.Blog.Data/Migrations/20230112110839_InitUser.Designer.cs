// <auto-generated />
using System;
using HVLC.Blog.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HVLC.Blog.Data.Migrations
{
    [DbContext(typeof(BlogAppDbContext))]
    [Migration("20230112110839_InitUser")]
    partial class InitUser
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HVLC.Blog.Entity.Entities.AppRole", b =>
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

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("66d926ed-02fb-47d8-8d89-ac4b74e61e0a"),
                            ConcurrencyStamp = "06996744-da91-4629-bffe-9663f641f390",
                            Name = "Superadmin",
                            NormalizedName = " SUPERADMIN"
                        },
                        new
                        {
                            Id = new Guid("9e503c0f-1158-4bd3-8dc6-807ead3b5d5c"),
                            ConcurrencyStamp = "d01d41c4-4e10-4fd4-b165-0959a59b0fb0",
                            Name = "Admin",
                            NormalizedName = " ADMIN"
                        },
                        new
                        {
                            Id = new Guid("2611333b-a652-40c5-a20f-99fd9514e50c"),
                            ConcurrencyStamp = "a8e4f8d1-6fb1-4dc9-aa93-b64317d6d9d9",
                            Name = "User",
                            NormalizedName = " USER"
                        });
                });

            modelBuilder.Entity("HVLC.Blog.Entity.Entities.AppRoleClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("HVLC.Blog.Entity.Entities.AppUser", b =>
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

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ImageId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

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

                    b.HasIndex("ImageId");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("b25a724b-e00b-4f00-8cac-5e3c6f5c9909"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "8cd64470-61b7-422c-94af-ce517c97d4ce",
                            Email = "superadmin@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Nedim",
                            ImageId = new Guid("f937cd07-2e0f-4792-a3aa-5493fe6d3597"),
                            LastName = "HAVLACI",
                            LockoutEnabled = false,
                            NormalizedEmail = "SUPERADMIN@GMAIL.COM",
                            NormalizedUserName = "SUPERADMIN@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAENV6rk3xcUgrMQ7tOlhfB12xKl24CJ7N6ZkPWNyuOp0THL5LPic2tfbpDDWFKnQOzQ==",
                            PhoneNumber = "+905076089730",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "65030270-77cc-4a95-a6ec-36163660525f",
                            TwoFactorEnabled = false,
                            UserName = "superadmin@gmail.com"
                        },
                        new
                        {
                            Id = new Guid("7e5db1e2-ac0b-4f86-ba50-080f744c2bdb"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "cc143280-7ca2-4d7a-a92a-c972113cfc17",
                            Email = "admin@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Ercan",
                            ImageId = new Guid("2f8bfbe5-5a3b-4124-9617-edba59927d75"),
                            LastName = "HAVLACI",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@GMAIL.COM",
                            NormalizedUserName = "ADMIN@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEJy1v7Q8VAaf8+v3XZCwjKO2BWaLPfjLhjm3hUUgftNDISMgb+syHMG6yOFbnS4LTg==",
                            PhoneNumber = "+905076089733",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "5bf0b816-a79a-4e4d-b6df-1f4a3590d0e3",
                            TwoFactorEnabled = false,
                            UserName = "admin@gmail.com"
                        });
                });

            modelBuilder.Entity("HVLC.Blog.Entity.Entities.AppUserClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("HVLC.Blog.Entity.Entities.AppUserLogin", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("HVLC.Blog.Entity.Entities.AppUserRole", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = new Guid("b25a724b-e00b-4f00-8cac-5e3c6f5c9909"),
                            RoleId = new Guid("66d926ed-02fb-47d8-8d89-ac4b74e61e0a")
                        },
                        new
                        {
                            UserId = new Guid("7e5db1e2-ac0b-4f86-ba50-080f744c2bdb"),
                            RoleId = new Guid("9e503c0f-1158-4bd3-8dc6-807ead3b5d5c")
                        });
                });

            modelBuilder.Entity("HVLC.Blog.Entity.Entities.AppUserToken", b =>
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

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("HVLC.Blog.Entity.Entities.Article", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("ImageId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("ViewCount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ImageId");

                    b.HasIndex("UserId");

                    b.ToTable("Articles");

                    b.HasData(
                        new
                        {
                            Id = new Guid("84093148-e77c-41a7-9fb9-67011dc554e8"),
                            CategoryId = new Guid("74fdc9db-59b2-4af3-a039-407fe415676b"),
                            Content = "C#; Microsoft tarafından .NET Teknolojisi için geliştirilen modern bir programlama dilidir. Sözdizimi C-like bir deneyim sunar. Microsoft tarafından geliştirilmiş olsa da ECMA ve ISO standartları altına alınmıştır. C programlama dilinde bir tam sayı değişkeni 1 artırmak için değişkenden sonra \"++\" eki kullanılır.",
                            CreatedBy = "Admin Test C#",
                            CreatedDate = new DateTime(2023, 1, 12, 14, 8, 39, 231, DateTimeKind.Local).AddTicks(4405),
                            ImageId = new Guid("f937cd07-2e0f-4792-a3aa-5493fe6d3597"),
                            IsDeleted = false,
                            Title = "C# deneme makalesi",
                            UserId = new Guid("b25a724b-e00b-4f00-8cac-5e3c6f5c9909"),
                            ViewCount = 1
                        },
                        new
                        {
                            Id = new Guid("6939bde3-8630-4bfd-a506-e1ac2df40497"),
                            CategoryId = new Guid("b6c4714c-d3af-4e01-a3da-322dc9f1e167"),
                            Content = "SQL, verileri yönetmek ve tasarlamak için kullanılan bir dildir. SQL, kendisi bir programlama dili olmamasına rağmen birçok kişi tarafından programlama dili olarak bilinir. SQL herhangi bir veri tabanı ortamında kullanılan bir alt dildir.",
                            CreatedBy = "Admin Test Sql",
                            CreatedDate = new DateTime(2023, 1, 12, 14, 8, 39, 231, DateTimeKind.Local).AddTicks(4411),
                            ImageId = new Guid("2f8bfbe5-5a3b-4124-9617-edba59927d75"),
                            IsDeleted = false,
                            Title = "Sql deneme makalesi",
                            UserId = new Guid("7e5db1e2-ac0b-4f86-ba50-080f744c2bdb"),
                            ViewCount = 1
                        });
                });

            modelBuilder.Entity("HVLC.Blog.Entity.Entities.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("74fdc9db-59b2-4af3-a039-407fe415676b"),
                            CreatedBy = "Admin Test C#",
                            CreatedDate = new DateTime(2023, 1, 12, 14, 8, 39, 231, DateTimeKind.Local).AddTicks(4638),
                            IsDeleted = false,
                            Name = "C#"
                        },
                        new
                        {
                            Id = new Guid("b6c4714c-d3af-4e01-a3da-322dc9f1e167"),
                            CreatedBy = "Admin Test Sql",
                            CreatedDate = new DateTime(2023, 1, 12, 14, 8, 39, 231, DateTimeKind.Local).AddTicks(4640),
                            IsDeleted = false,
                            Name = "Sql"
                        });
                });

            modelBuilder.Entity("HVLC.Blog.Entity.Entities.Image", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Images");

                    b.HasData(
                        new
                        {
                            Id = new Guid("f937cd07-2e0f-4792-a3aa-5493fe6d3597"),
                            CreatedBy = "Admin Test C#",
                            CreatedDate = new DateTime(2023, 1, 12, 14, 8, 39, 231, DateTimeKind.Local).AddTicks(4777),
                            FileName = "images/C#/testimage",
                            FileType = "jpg",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = new Guid("2f8bfbe5-5a3b-4124-9617-edba59927d75"),
                            CreatedBy = "Admin Test Sql",
                            CreatedDate = new DateTime(2023, 1, 12, 14, 8, 39, 231, DateTimeKind.Local).AddTicks(4779),
                            FileName = "images/Sql/testimage",
                            FileType = "jpg",
                            IsDeleted = false
                        });
                });

            modelBuilder.Entity("HVLC.Blog.Entity.Entities.AppRoleClaim", b =>
                {
                    b.HasOne("HVLC.Blog.Entity.Entities.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HVLC.Blog.Entity.Entities.AppUser", b =>
                {
                    b.HasOne("HVLC.Blog.Entity.Entities.Image", "Image")
                        .WithMany("Users")
                        .HasForeignKey("ImageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Image");
                });

            modelBuilder.Entity("HVLC.Blog.Entity.Entities.AppUserClaim", b =>
                {
                    b.HasOne("HVLC.Blog.Entity.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HVLC.Blog.Entity.Entities.AppUserLogin", b =>
                {
                    b.HasOne("HVLC.Blog.Entity.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HVLC.Blog.Entity.Entities.AppUserRole", b =>
                {
                    b.HasOne("HVLC.Blog.Entity.Entities.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HVLC.Blog.Entity.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HVLC.Blog.Entity.Entities.AppUserToken", b =>
                {
                    b.HasOne("HVLC.Blog.Entity.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HVLC.Blog.Entity.Entities.Article", b =>
                {
                    b.HasOne("HVLC.Blog.Entity.Entities.Category", "Category")
                        .WithMany("Articles")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HVLC.Blog.Entity.Entities.Image", "Image")
                        .WithMany("Articles")
                        .HasForeignKey("ImageId");

                    b.HasOne("HVLC.Blog.Entity.Entities.AppUser", "User")
                        .WithMany("Articles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Image");

                    b.Navigation("User");
                });

            modelBuilder.Entity("HVLC.Blog.Entity.Entities.AppUser", b =>
                {
                    b.Navigation("Articles");
                });

            modelBuilder.Entity("HVLC.Blog.Entity.Entities.Category", b =>
                {
                    b.Navigation("Articles");
                });

            modelBuilder.Entity("HVLC.Blog.Entity.Entities.Image", b =>
                {
                    b.Navigation("Articles");

                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
