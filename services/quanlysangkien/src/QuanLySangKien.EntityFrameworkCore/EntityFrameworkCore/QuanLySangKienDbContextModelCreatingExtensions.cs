using Microsoft.EntityFrameworkCore;
using QuanLySangKien.Entities;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace QuanLySangKien.EntityFrameworkCore;

public static class QuanLySangKienDbContextModelCreatingExtensions
{
    public static void ConfigureQuanLySangKien(
        this ModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));

        //Configure all entities here. Example:

        builder.Entity<Field>(b =>
        {
            //Configure table & schema name
            b.ToTable(IdeaManagementDbProperties.DbTablePrefix + "Fields", IdeaManagementDbProperties.DbSchema);

            b.ConfigureByConvention();

            //Properties
            //b.Property(q => q.Title).IsRequired().HasMaxLength(QuestionConsts.MaxTitleLength);

            ////Relations
            //b.HasMany(question => question.Tags).WithOne().HasForeignKey(qt => qt.QuestionId);

            //Indexes
            //b.HasIndex(q => q.CreationTime);
        });
        builder.Entity<Unit>(b =>
        {
            //Configure table & schema name
            b.ToTable(IdeaManagementDbProperties.DbTablePrefix + "Units", IdeaManagementDbProperties.DbSchema);
            b.ConfigureByConvention();
        });
    }
}
