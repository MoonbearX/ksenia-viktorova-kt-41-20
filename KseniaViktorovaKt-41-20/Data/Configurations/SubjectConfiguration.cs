//using KseniaViktorovaKt_41_20.Data.Helpers;
//using KseniaViktorovaKt_41_20.Models;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;

//namespace KseniaViktorovaKt_41_20.Data.Configurations
//{
//    public class SubjectConfiguration : IEntityTypeConfiguration<Subjects>
//    {
//        private const string TableName = "subjects";

//        private void Configure(EntityTypeBuilder<Subjects> builder)
//        {
//            builder
//                .HasKey(p => p.Id)
//                .HasName($"pk_(TAbleName)_id_subject");

//            builder.Property(p => p.Id)
//                .ValueGeneratedOnAdd();

//            builder.Property(p => p.Id)
//                .HasColumnName("id_group")
//                .HasComment("Идентификатор дисциплины");

//            builder.Property(p => p.Title)
//                .IsRequired()
//                .HasColumnName("subject_title")
//                .HasColumnType(ColumnType.String).HasMaxLength(200)
//                .HasComment("Название дисциплины");

//            builder.ToTable(TableName)
//               .HasOne(p => p.Group)
//               .WithMany()
//               .HasForeignKey(p => p.IdGroup)
//               .HasConstraintName("fk_group_id")
//               .OnDelete(DeleteBehavior.Cascade);

//            builder.ToTable(TableName)
//                .HasIndex(p => p.IdGroup, $"idx_{TableName}_fk_group_id");

//            builder.Navigation(p => p.Group)
//                .AutoInclude();
//        }

//        void IEntityTypeConfiguration<Subjects>.Configure(EntityTypeBuilder<Subjects> builder)
//        {
//            throw new NotImplementedException();
//        }
//    }
//}
