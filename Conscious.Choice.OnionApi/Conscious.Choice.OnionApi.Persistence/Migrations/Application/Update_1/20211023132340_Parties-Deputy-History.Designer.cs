﻿// <auto-generated />
using System;
using Conscious.Choice.OnionApi.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Conscious.Choice.OnionApi.Persistence.Migrations.Application.Update_1
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20211023132340_Parties-Deputy-History")]
    partial class PartiesDeputyHistory
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Conscious.Choice.OnionApi.Domain.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Conscious.Choice.OnionApi.Domain.Entities.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fax")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Region")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Conscious.Choice.OnionApi.Domain.Entities.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("RequiredDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Conscious.Choice.OnionApi.Domain.Entities.OrderDetail", b =>
                {
                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("OrderId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderDetail");
                });

            modelBuilder.Entity("Conscious.Choice.OnionApi.Domain.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SupplierId")
                        .HasColumnType("int");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("money");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("SupplierId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Conscious.Choice.OnionApi.Domain.Entities.RDeputyPartyMovingsHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("EntranceDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdDeputy")
                        .HasColumnType("int");

                    b.Property<int>("IdParty")
                        .HasColumnType("int");

                    b.Property<bool>("IsCurrentParty")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("IdDeputy");

                    b.HasIndex("IdParty");

                    b.ToTable("DeputyPartyMovingsHistories");
                });

            modelBuilder.Entity("Conscious.Choice.OnionApi.Domain.Entities.RPartyConvocation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdConvocation")
                        .HasColumnType("int");

                    b.Property<int>("IdParty")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdConvocation");

                    b.HasIndex("IdParty");

                    b.ToTable("PartyConvocations");
                });

            modelBuilder.Entity("Conscious.Choice.OnionApi.Domain.Entities.Supplier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SupplierName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("Conscious.Choice.OnionApi.Domain.Entities.TConvocation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ConvocationNumber")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Convocations");
                });

            modelBuilder.Entity("Conscious.Choice.OnionApi.Domain.Entities.TDeputy", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsRealDeputy")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Deputies");
                });

            modelBuilder.Entity("Conscious.Choice.OnionApi.Domain.Entities.TLaw", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddInfo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Category")
                        .HasColumnType("int");

                    b.Property<DateTime>("LawDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LawName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LawNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Laws");
                });

            modelBuilder.Entity("Conscious.Choice.OnionApi.Domain.Entities.TLawsAmendment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AmendmentDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("LawId")
                        .HasColumnType("int");

                    b.Property<string>("LinkToLaw")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LinkToVotes")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("LawId");

                    b.ToTable("Amendments");
                });

            modelBuilder.Entity("Conscious.Choice.OnionApi.Domain.Entities.TParty", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("IdLeaderDeputy")
                        .HasColumnType("int");

                    b.Property<int?>("IdParentParty")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdLeaderDeputy");

                    b.HasIndex("IdParentParty");

                    b.ToTable("Parties");
                });

            modelBuilder.Entity("Conscious.Choice.OnionApi.Domain.Entities.TSetting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Settings");
                });

            modelBuilder.Entity("Conscious.Choice.OnionApi.Domain.Entities.TVote", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Decision")
                        .HasColumnType("int");

                    b.Property<int>("DeputyId")
                        .HasColumnType("int");

                    b.Property<int>("LawsAmendmentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DeputyId");

                    b.HasIndex("LawsAmendmentId");

                    b.ToTable("Votes");
                });

            modelBuilder.Entity("Conscious.Choice.OnionApi.Domain.Entities.Order", b =>
                {
                    b.HasOne("Conscious.Choice.OnionApi.Domain.Entities.Customer", "Customers")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customers");
                });

            modelBuilder.Entity("Conscious.Choice.OnionApi.Domain.Entities.OrderDetail", b =>
                {
                    b.HasOne("Conscious.Choice.OnionApi.Domain.Entities.Order", "Orders")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Conscious.Choice.OnionApi.Domain.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Orders");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Conscious.Choice.OnionApi.Domain.Entities.Product", b =>
                {
                    b.HasOne("Conscious.Choice.OnionApi.Domain.Entities.Category", null)
                        .WithMany("Products")
                        .HasForeignKey("CategoryId");

                    b.HasOne("Conscious.Choice.OnionApi.Domain.Entities.Supplier", null)
                        .WithMany("Products")
                        .HasForeignKey("SupplierId");
                });

            modelBuilder.Entity("Conscious.Choice.OnionApi.Domain.Entities.RDeputyPartyMovingsHistory", b =>
                {
                    b.HasOne("Conscious.Choice.OnionApi.Domain.Entities.TDeputy", "Deputy")
                        .WithMany("DeputyPartyMovingsHistory")
                        .HasForeignKey("IdDeputy")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Conscious.Choice.OnionApi.Domain.Entities.TParty", "Party")
                        .WithMany("DeputyPartyMovingsHistory")
                        .HasForeignKey("IdParty")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Deputy");

                    b.Navigation("Party");
                });

            modelBuilder.Entity("Conscious.Choice.OnionApi.Domain.Entities.RPartyConvocation", b =>
                {
                    b.HasOne("Conscious.Choice.OnionApi.Domain.Entities.TConvocation", "Convocation")
                        .WithMany("PartyConvocation")
                        .HasForeignKey("IdConvocation")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Conscious.Choice.OnionApi.Domain.Entities.TParty", "Party")
                        .WithMany("PartyConvocation")
                        .HasForeignKey("IdParty")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Convocation");

                    b.Navigation("Party");
                });

            modelBuilder.Entity("Conscious.Choice.OnionApi.Domain.Entities.TLawsAmendment", b =>
                {
                    b.HasOne("Conscious.Choice.OnionApi.Domain.Entities.TLaw", "Law")
                        .WithMany("Amendments")
                        .HasForeignKey("LawId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Law");
                });

            modelBuilder.Entity("Conscious.Choice.OnionApi.Domain.Entities.TParty", b =>
                {
                    b.HasOne("Conscious.Choice.OnionApi.Domain.Entities.TDeputy", "Leader")
                        .WithMany()
                        .HasForeignKey("IdLeaderDeputy");

                    b.HasOne("Conscious.Choice.OnionApi.Domain.Entities.TParty", "ParentParty")
                        .WithMany()
                        .HasForeignKey("IdParentParty");

                    b.Navigation("Leader");

                    b.Navigation("ParentParty");
                });

            modelBuilder.Entity("Conscious.Choice.OnionApi.Domain.Entities.TVote", b =>
                {
                    b.HasOne("Conscious.Choice.OnionApi.Domain.Entities.TDeputy", "Deputy")
                        .WithMany("Votes")
                        .HasForeignKey("DeputyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Conscious.Choice.OnionApi.Domain.Entities.TLawsAmendment", "LawsAmendment")
                        .WithMany("Votes")
                        .HasForeignKey("LawsAmendmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Deputy");

                    b.Navigation("LawsAmendment");
                });

            modelBuilder.Entity("Conscious.Choice.OnionApi.Domain.Entities.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Conscious.Choice.OnionApi.Domain.Entities.Customer", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Conscious.Choice.OnionApi.Domain.Entities.Order", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("Conscious.Choice.OnionApi.Domain.Entities.Supplier", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Conscious.Choice.OnionApi.Domain.Entities.TConvocation", b =>
                {
                    b.Navigation("PartyConvocation");
                });

            modelBuilder.Entity("Conscious.Choice.OnionApi.Domain.Entities.TDeputy", b =>
                {
                    b.Navigation("DeputyPartyMovingsHistory");

                    b.Navigation("Votes");
                });

            modelBuilder.Entity("Conscious.Choice.OnionApi.Domain.Entities.TLaw", b =>
                {
                    b.Navigation("Amendments");
                });

            modelBuilder.Entity("Conscious.Choice.OnionApi.Domain.Entities.TLawsAmendment", b =>
                {
                    b.Navigation("Votes");
                });

            modelBuilder.Entity("Conscious.Choice.OnionApi.Domain.Entities.TParty", b =>
                {
                    b.Navigation("DeputyPartyMovingsHistory");

                    b.Navigation("PartyConvocation");
                });
#pragma warning restore 612, 618
        }
    }
}