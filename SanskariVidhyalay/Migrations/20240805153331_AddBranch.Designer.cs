﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SanskariVidhyalay.Model;

#nullable disable

namespace SanskariVidhyalay.Migrations
{
    [DbContext(typeof(StudentEntriesDB))]
    [Migration("20240805153331_AddBranch")]
    partial class AddBranch
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SanskariVidhyalay.Models.StudentEntries", b =>
                {
                    b.Property<int>("StudentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentID"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("Varchar(50)");

                    b.Property<string>("AlternativeMobileNumber")
                        .IsRequired()
                        .HasColumnType("Varchar(15)")
                        .HasColumnName("Alternative Mobile Number");

                    b.Property<string>("Branch")
                        .IsRequired()
                        .HasColumnType("Varchar(50)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("Varchar(20)");

                    b.Property<string>("DateofBirth")
                        .IsRequired()
                        .HasColumnType("Varchar(15)")
                        .HasColumnName("Date of Birth");

                    b.Property<string>("Medium")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MobileNumber")
                        .IsRequired()
                        .HasColumnType("Varchar(12)")
                        .HasColumnName("Mobile Number");

                    b.Property<int>("PostalCode")
                        .HasColumnType("int")
                        .HasColumnName("Pin Code");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasColumnType("Varchar(15)");

                    b.Property<int>("Standard")
                        .HasColumnType("int");

                    b.Property<string>("StudentFirstName")
                        .IsRequired()
                        .HasColumnType("Varchar(15)")
                        .HasColumnName("First Name");

                    b.Property<string>("StudentLastName")
                        .IsRequired()
                        .HasColumnType("Varchar(15)")
                        .HasColumnName("Last Name");

                    b.HasKey("StudentID");

                    b.ToTable("StudentEntries");
                });
#pragma warning restore 612, 618
        }
    }
}
