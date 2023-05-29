﻿// <auto-generated />
using System;
using Core.DALEF.ContextFactory;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Core.DALEF.ContextFactory.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20230526091521_Add_TEBookCopy")]
    partial class Add_TEBookCopy
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Core.DAL.Models.SYSetting", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime>("DateChanged")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateTimeValue")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("DecimalValue")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<string>("LevelValue")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Module")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<string>("StringValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserChangedID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserCreatedID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("SYSetting");

                    b.HasData(
                        new
                        {
                            Id = new Guid("d81229a0-cf63-46c0-87f4-59db2ee37256"),
                            Active = true,
                            DateChanged = new DateTime(1800, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateCreated = new DateTime(1800, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DecimalValue = 0m,
                            Level = 1,
                            Module = "SY",
                            Name = "DataSchemaVersion",
                            StringValue = "SchemaVersion.V1_0_0",
                            Type = "System.String",
                            UserChangedID = new Guid("89b87015-b687-4cad-a553-f911cf2e6fcf"),
                            UserCreatedID = new Guid("89b87015-b687-4cad-a553-f911cf2e6fcf")
                        });
                });

            modelBuilder.Entity("IPSTemplate.Dal.Models.TEAuthor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<int?>("BirthYear")
                        .HasColumnType("int");

                    b.Property<string>("Country")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("DateChanged")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DeathYear")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<Guid>("UserChangedID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserCreatedID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("TEAuthor");
                });

            modelBuilder.Entity("IPSTemplate.Dal.Models.TEBook", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime>("DateChanged")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("GenreID")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Language")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("PageAmount")
                        .HasColumnType("int");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<Guid>("UserChangedID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserCreatedID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("GenreID");

                    b.ToTable("TEBook");
                });

            modelBuilder.Entity("IPSTemplate.Dal.Models.TEBookAuthor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<Guid>("AuthorID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BookID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateChanged")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<Guid>("UserChangedID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserCreatedID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("AuthorID");

                    b.HasIndex("BookID");

                    b.ToTable("TEBookAuthor");
                });

            modelBuilder.Entity("IPSTemplate.Dal.Models.TEBookCopy", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<Guid?>("BookID")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateChanged")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("bit");

                    b.Property<int?>("PublishedYear")
                        .HasColumnType("int");

                    b.Property<Guid?>("PublisherID")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<Guid>("UserChangedID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserCreatedID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("BookID");

                    b.HasIndex("PublisherID");

                    b.ToTable("TEBookCopy");
                });

            modelBuilder.Entity("IPSTemplate.Dal.Models.TEEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Attribute1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateChanged")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<Guid>("UserChangedID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserCreatedID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("TEEntity");

                    b.HasData(
                        new
                        {
                            Id = new Guid("c041f416-41e6-419e-b832-7e67c6c35fda"),
                            Active = true,
                            Attribute1 = "This is a seed record.",
                            DateChanged = new DateTime(1800, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateCreated = new DateTime(1800, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserChangedID = new Guid("89b87015-b687-4cad-a553-f911cf2e6fcf"),
                            UserCreatedID = new Guid("89b87015-b687-4cad-a553-f911cf2e6fcf")
                        },
                        new
                        {
                            Id = new Guid("50366dd5-49e5-4cc4-a06d-5ec6f4c0805e"),
                            Active = true,
                            Attribute1 = "This is a dummy record.",
                            DateChanged = new DateTime(1800, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateCreated = new DateTime(1800, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserChangedID = new Guid("89b87015-b687-4cad-a553-f911cf2e6fcf"),
                            UserCreatedID = new Guid("89b87015-b687-4cad-a553-f911cf2e6fcf")
                        });
                });

            modelBuilder.Entity("IPSTemplate.Dal.Models.TEGenre", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime>("DateChanged")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<Guid>("UserChangedID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserCreatedID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("TEGenre");
                });

            modelBuilder.Entity("IPSTemplate.Dal.Models.TEPublisher", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Address")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("DateChanged")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<Guid>("UserChangedID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserCreatedID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("TEPublisher");
                });

            modelBuilder.Entity("IPSTemplate.Dal.Models.TEBook", b =>
                {
                    b.HasOne("IPSTemplate.Dal.Models.TEGenre", "Genre")
                        .WithMany()
                        .HasForeignKey("GenreID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("IPSTemplate.Dal.Models.TEBookAuthor", b =>
                {
                    b.HasOne("IPSTemplate.Dal.Models.TEAuthor", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("IPSTemplate.Dal.Models.TEBook", "Book")
                        .WithMany()
                        .HasForeignKey("BookID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Book");
                });

            modelBuilder.Entity("IPSTemplate.Dal.Models.TEBookCopy", b =>
                {
                    b.HasOne("IPSTemplate.Dal.Models.TEBook", "Book")
                        .WithMany()
                        .HasForeignKey("BookID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("IPSTemplate.Dal.Models.TEPublisher", "Publisher")
                        .WithMany()
                        .HasForeignKey("PublisherID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Publisher");
                });
#pragma warning restore 612, 618
        }
    }
}
