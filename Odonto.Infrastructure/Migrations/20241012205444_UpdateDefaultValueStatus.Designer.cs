﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Odonto.Infrastructure.Persistence.Context;

#nullable disable

namespace Odonto.Infrastructure.Migrations
{
    [DbContext(typeof(OdontoContext))]
    [Migration("20241012205444_UpdateDefaultValueStatus")]
    partial class UpdateDefaultValueStatus
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseCollation("Modern_Spanish_CI_AS")
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Odonto.Domain.Entities.Services", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("SER_SERVICE_ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)")
                        .HasColumnName("SER_DESCRIPTION");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("SER_NAME");

                    b.Property<bool>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true)
                        .HasColumnName("SER_STATUS");

                    b.HasKey("Id");

                    b.ToTable("Services", (string)null);
                });

            modelBuilder.Entity("Odonto.Domain.Entities.Services", b =>
                {
                    b.OwnsOne("Odonto.Domain.Entities.Base.BaseAuditInfo", "AuditInfo", b1 =>
                        {
                            b1.Property<int>("ServicesId")
                                .HasColumnType("int");

                            b1.Property<DateTime>("CreateDate")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("datetime2")
                                .HasColumnName("SER_CREATE_DATE")
                                .HasDefaultValueSql("GETDATE()");

                            b1.Property<DateTime?>("DeleteDate")
                                .HasColumnType("datetime2")
                                .HasColumnName("SER_DELETE_DATE");

                            b1.Property<DateTime?>("UpdateDate")
                                .HasColumnType("datetime2")
                                .HasColumnName("SER_UPDATE_DATE");

                            b1.Property<int>("UserCreate")
                                .HasColumnType("int")
                                .HasColumnName("SER_USER_CREATE");

                            b1.Property<int?>("UserDelete")
                                .HasColumnType("int")
                                .HasColumnName("SER_USER_DELETE");

                            b1.Property<int?>("UserUpdate")
                                .HasColumnType("int")
                                .HasColumnName("SER_USER_UPDATE");

                            b1.HasKey("ServicesId");

                            b1.ToTable("Services");

                            b1.WithOwner()
                                .HasForeignKey("ServicesId");
                        });

                    b.Navigation("AuditInfo")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
