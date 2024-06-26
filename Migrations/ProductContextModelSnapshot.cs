﻿// <auto-generated />
using System;
using CRUDwithScaffoldTraining.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CRUDwithScaffoldTraining.Migrations
{
    [DbContext(typeof(ProductContext))]
    partial class ProductContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.3");

            modelBuilder.Entity("CRUDwithScaffoldTraining.Models.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Street_Number")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Unit")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Zipcode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("CRUDwithScaffoldTraining.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double?>("CostPrice")
                        .HasColumnType("REAL");

                    b.Property<double?>("CostPrice_Total")
                        .HasColumnType("REAL");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Maker")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("Qty_InStock")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Qty_Received")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SKU")
                        .HasColumnType("TEXT");

                    b.Property<double?>("UnitPrice")
                        .HasColumnType("REAL");

                    b.Property<double?>("UnitPrice_Total")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("CRUDwithScaffoldTraining.Models.PurchaseOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AddressIdId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Delivery_AddressId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Invoice")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Quote")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SalesRep_Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Supplier")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateOnly>("eTA")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AddressIdId");

                    b.HasIndex("Delivery_AddressId");

                    b.ToTable("PurchaseOrder");
                });

            modelBuilder.Entity("CRUDwithScaffoldTraining.Models.PurchaseOrder", b =>
                {
                    b.HasOne("CRUDwithScaffoldTraining.Models.Address", "AddressId")
                        .WithMany()
                        .HasForeignKey("AddressIdId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CRUDwithScaffoldTraining.Models.Address", "Delivery_Address")
                        .WithMany()
                        .HasForeignKey("Delivery_AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AddressId");

                    b.Navigation("Delivery_Address");
                });
#pragma warning restore 612, 618
        }
    }
}
