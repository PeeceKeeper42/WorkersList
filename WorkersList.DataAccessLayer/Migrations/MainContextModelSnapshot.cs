﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WorkersList.DataAccessLayer.Contexts;

#nullable disable

namespace WorkersList.DataAccessLayer.Migrations
{
    [DbContext(typeof(MainContext))]
    partial class MainContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ReviewWorker", b =>
                {
                    b.Property<int>("ReviewsId")
                        .HasColumnType("int");

                    b.Property<int>("WorkersId")
                        .HasColumnType("int");

                    b.HasKey("ReviewsId", "WorkersId");

                    b.HasIndex("WorkersId");

                    b.ToTable("WorkersReviews", (string)null);
                });

            modelBuilder.Entity("WorkersList.DataAccessLayer.Entities.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Disliked")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("LastModifyInfoDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetimeoffset")
                        .HasDefaultValueSql("getdate()");

                    b.Property<int>("Liked")
                        .HasColumnType("int");

                    b.Property<int?>("ParentCommentId")
                        .HasColumnType("int");

                    b.Property<int?>("ReviewId")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("WorkerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ParentCommentId");

                    b.HasIndex("ReviewId");

                    b.HasIndex("WorkerId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("WorkersList.DataAccessLayer.Entities.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("HeadOfDepartmentId")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("LastModifyInfoDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetimeoffset")
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ResponsibilityArea")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("WorkersList.DataAccessLayer.Entities.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<int>("Disliked")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("LastModifyInfoDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetimeoffset")
                        .HasDefaultValueSql("getdate()");

                    b.Property<int>("Liked")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)")
                        .HasDefaultValue("Text");

                    b.Property<string>("Title")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)")
                        .HasDefaultValue("Title");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("WorkersList.DataAccessLayer.Entities.Worker", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("DateOfEmployment")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetimeoffset")
                        .HasDefaultValueSql("getdate()");

                    b.Property<int?>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<string>("JobPosition")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("Janitor");

                    b.Property<DateTimeOffset>("LastModifyInfoDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetimeoffset")
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("Name")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)")
                        .HasDefaultValue("UserName");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("nvarchar(14)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)")
                        .HasDefaultValue("UserSurname");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Workers");
                });

            modelBuilder.Entity("WorkersList.DataAccessLayer.Entities.WorkerPassword", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("HashedPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Salt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("WorkerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("WorkerPasswords");
                });

            modelBuilder.Entity("ReviewWorker", b =>
                {
                    b.HasOne("WorkersList.DataAccessLayer.Entities.Review", null)
                        .WithMany()
                        .HasForeignKey("ReviewsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WorkersList.DataAccessLayer.Entities.Worker", null)
                        .WithMany()
                        .HasForeignKey("WorkersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WorkersList.DataAccessLayer.Entities.Comment", b =>
                {
                    b.HasOne("WorkersList.DataAccessLayer.Entities.Comment", "ParentComment")
                        .WithMany("Comments")
                        .HasForeignKey("ParentCommentId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("WorkersList.DataAccessLayer.Entities.Review", "Review")
                        .WithMany("Comments")
                        .HasForeignKey("ReviewId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("WorkersList.DataAccessLayer.Entities.Worker", "Worker")
                        .WithMany("Comments")
                        .HasForeignKey("WorkerId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("ParentComment");

                    b.Navigation("Review");

                    b.Navigation("Worker");
                });

            modelBuilder.Entity("WorkersList.DataAccessLayer.Entities.Review", b =>
                {
                    b.HasOne("WorkersList.DataAccessLayer.Entities.Department", "Department")
                        .WithMany("Reviews")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("WorkersList.DataAccessLayer.Entities.Worker", b =>
                {
                    b.HasOne("WorkersList.DataAccessLayer.Entities.Department", "Department")
                        .WithMany("Workers")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("WorkersList.DataAccessLayer.Entities.WorkerPassword", "WorkerPassword")
                        .WithOne("Worker")
                        .HasForeignKey("WorkersList.DataAccessLayer.Entities.Worker", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");

                    b.Navigation("WorkerPassword");
                });

            modelBuilder.Entity("WorkersList.DataAccessLayer.Entities.Comment", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("WorkersList.DataAccessLayer.Entities.Department", b =>
                {
                    b.Navigation("Reviews");

                    b.Navigation("Workers");
                });

            modelBuilder.Entity("WorkersList.DataAccessLayer.Entities.Review", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("WorkersList.DataAccessLayer.Entities.Worker", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("WorkersList.DataAccessLayer.Entities.WorkerPassword", b =>
                {
                    b.Navigation("Worker");
                });
#pragma warning restore 612, 618
        }
    }
}
