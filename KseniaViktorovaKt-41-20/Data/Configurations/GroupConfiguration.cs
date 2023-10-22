using KseniaViktorovaKt_41_20.Data.Helpers;
using KseniaViktorovaKt_41_20.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KseniaViktorovaKt_41_20.Data.Configurations
{
    public class GroupConfiguration : IEntityTypeConfiguration<Group>
    {
        private const string TableName = "group";

        public void Configure(EntityTypeBuilder<Group> builder)
        {
            builder
                 .HasKey(p => p.Id)
                 .HasName($"pk_(TAbleName)_id_group");

            builder.Property(p => p.Id)
                .ValueGeneratedOnAdd();

            builder.Property(p => p.Id)
                .HasColumnName("id_group")
                .HasComment("Идентификатор студента");

            builder.Property(p => p.Name)
                .IsRequired()
                .HasColumnName("group_name")
                .HasColumnType(ColumnType.String).HasMaxLength(200)
                .HasComment("Название группы");
        }

    }
}
