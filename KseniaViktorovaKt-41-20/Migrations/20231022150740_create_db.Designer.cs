﻿// <auto-generated />
using System;
using KseniaViktorovaKt_41_20.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace KseniaViktorovaKt_41_20.Migrations
{
    [DbContext(typeof(RecordsContext))]
    [Migration("20231022150740_create_db")]
    partial class create_db
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("KseniaViktorovaKt_41_20.Models.Group", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id_group")
                        .HasComment("Идентификатор студента");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar")
                        .HasColumnName("group_name")
                        .HasComment("Название группы");

                    b.HasKey("Id")
                        .HasName("pk_(TAbleName)_id_group");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("KseniaViktorovaKt_41_20.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("student_id")
                        .HasComment("Идентификатор студента");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("IdGroup")
                        .IsRequired()
                        .HasColumnType("int")
                        .HasColumnName("id_group")
                        .HasComment("Идентификатор группы");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar")
                        .HasColumnName("student_name")
                        .HasComment("Имя студента");

                    b.Property<string>("Patronymic")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar")
                        .HasColumnName("student_patronymic")
                        .HasComment("Отчество студента");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar")
                        .HasColumnName("student_surname")
                        .HasComment("Фамилия студента");

                    b.HasKey("Id")
                        .HasName("pk_student_student_id");

                    b.HasIndex(new[] { "IdGroup" }, "idx_student_fk_group_id");

                    b.ToTable("student", (string)null);
                });

            modelBuilder.Entity("KseniaViktorovaKt_41_20.Models.Student", b =>
                {
                    b.HasOne("KseniaViktorovaKt_41_20.Models.Group", "Group")
                        .WithMany()
                        .HasForeignKey("IdGroup")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_group_id");

                    b.Navigation("Group");
                });
#pragma warning restore 612, 618
        }
    }
}
