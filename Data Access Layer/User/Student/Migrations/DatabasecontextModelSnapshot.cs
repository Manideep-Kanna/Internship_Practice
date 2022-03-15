﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Student;

#nullable disable

namespace Student.Migrations
{
    [DbContext(typeof(Databasecontext))]
    partial class DatabasecontextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Student.StudentClass", b =>
                {
                    b.Property<int>("Roll_No")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Roll_No"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Father_Name")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("StudentName")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("Roll_No");

                    b.ToTable("Student");
                });
#pragma warning restore 612, 618
        }
    }
}
