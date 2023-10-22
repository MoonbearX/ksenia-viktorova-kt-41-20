//using KseniaViktorovaKt_41_20.Data.Helpers;
//using KseniaViktorovaKt_41_20.Models;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;

//namespace KseniaViktorovaKt_41_20.Data.Configurations
//{
//    public class SemesterConfiguration : IEntityTypeConfiguration<RecordsSemester>
//    {
//        private const string TableName = "record_semester";

//        private void Configure(EntityTypeBuilder<RecordsSemester> builder)
//        {
//            builder
//                .HasKey(p => p.Id)
//                .HasName($"pk_(TAbleName)_id_record_semester");

//            builder.Property(p => p.Id)
//                .ValueGeneratedOnAdd();

//            builder.Property(p => p.Id)
//                .HasColumnName("id_record_semester")
//                .HasComment("Идентификатор записи за семестр");

//            builder.Property(p => p.Grade)
//                .IsRequired()
//                .HasColumnName("grade")
//                .HasColumnType(ColumnType.Int)
//                .HasComment("Оценка");

//            builder.Property(p => p.Date)
//                .IsRequired()
//                .HasColumnName("date")
//                .HasColumnType(ColumnType.Date)
//                .HasComment("Дата");

//            builder.ToTable(TableName)
//               .HasOne(p => p.Subject)
//               .WithMany()
//               .HasForeignKey(p => p.IdSubject)
//               .HasConstraintName("fk_subject_id")
//               .OnDelete(DeleteBehavior.Cascade);

//            builder.ToTable(TableName)
//                .HasIndex(p => p.IdSubject, $"idx_{TableName}_fk_subject_id");

//            builder.Navigation(p => p.Subject)
//                .AutoInclude();

//            builder.ToTable(TableName)
//               .HasOne(p => p.Student)
//               .WithMany()
//               .HasForeignKey(p => p.NumberStudent)
//               .HasConstraintName("fk_number_student")
//               .OnDelete(DeleteBehavior.Cascade);

//            builder.ToTable(TableName)
//                .HasIndex(p => p.NumberStudent, $"idx_{TableName}_fk_number_student");

//            builder.Navigation(p => p.Student)
//                .AutoInclude();
//        }

//        void IEntityTypeConfiguration<RecordsSemester>.Configure(EntityTypeBuilder<RecordsSemester> builder)
//        {
//            throw new NotImplementedException();
//        }
//    }
//}
