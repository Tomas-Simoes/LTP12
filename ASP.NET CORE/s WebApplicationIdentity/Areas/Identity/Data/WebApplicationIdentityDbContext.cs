using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using s_WebApplicationIdentity.Areas.Identity.Data;

namespace s_WebApplicationIdentity.Areas.Identity.Data;

public class WebApplicationIdentityDbContext : IdentityDbContext<WebApplicationIdentityUser>
{
    public WebApplicationIdentityDbContext(DbContextOptions<WebApplicationIdentityDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
        builder.ApplyConfiguration(new WebApplicationIdentityUserEntityConfiguration());
    }
}

public class WebApplicationIdentityUserEntityConfiguration : IEntityTypeConfiguration<WebApplicationIdentityUser>
{
    public void Configure(EntityTypeBuilder<WebApplicationIdentityUser> builder)
    {
        builder.Property(u => u.Nome).HasMaxLength(255);
        builder.Property(u => u.Apelido).HasMaxLength(255);
    }
}
