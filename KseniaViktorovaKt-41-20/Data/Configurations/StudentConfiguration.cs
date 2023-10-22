using KseniaViktorovaKt_41_20.Data.Helpers;
using KseniaViktorovaKt_41_20.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using Microsoft.EntityFrameworkCore.Relational;

namespace KseniaViktorovaKt_41_20.Data.Configurations
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        private const string TableName = "student";

        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder
               .HasKey(p => p.Id)
               .HasName($"pk_" +
               $"" +
               $"{TableName}_student_id");

            builder.Property(p => p.Id)
                .ValueGeneratedOnAdd();

            builder.Property(p => p.Id)
                .HasColumnName("student_id")
                .HasComment("Идентификатор студента");

            builder.Property(p => p.Name)
                .IsRequired()
                .HasColumnName("student_name")
                .HasColumnType(ColumnType.String).HasMaxLength(200)
                .HasComment("Имя студента");

            builder.Property(p => p.Surname)
                .IsRequired()
                .HasColumnName("student_surname")
                .HasColumnType(ColumnType.String).HasMaxLength(200)
                .HasComment("Фамилия студента");

            builder.Property(p => p.Patronymic)
                .IsRequired()
                .HasColumnName("student_patronymic")
                .HasColumnType(ColumnType.String).HasMaxLength(200)
                .HasComment("Отчество студента");

            builder.Property(p => p.IdGroup)
                .IsRequired()
                .HasColumnName("id_group")
                .HasColumnType(ColumnType.Int)
                .HasComment("Идентификатор группы");

            builder.ToTable(TableName)
                .HasOne(p => p.Group)
                .WithMany()
                .HasForeignKey(p => p.IdGroup)
                .HasConstraintName("fk_group_id")
                .OnDelete(DeleteBehavior.Cascade);

            builder.ToTable(TableName)
                .HasIndex(p => p.IdGroup, $"idx_{TableName}_fk_group_id");

            builder.Navigation(p => p.Group)
                .AutoInclude();
        }

    }
}
