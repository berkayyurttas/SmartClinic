using Microsoft.EntityFrameworkCore;
using SmartClinic.Patients;
using Volo.Abp.AuditLogging.EntityFrameworkCore;
using Volo.Abp.BackgroundJobs.EntityFrameworkCore;
using Volo.Abp.BlobStoring.Database.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Modeling;
using Volo.Abp.FeatureManagement.EntityFrameworkCore;
using Volo.Abp.Identity;
using Volo.Abp.Identity.EntityFrameworkCore;
using Volo.Abp.PermissionManagement.EntityFrameworkCore;
using Volo.Abp.SettingManagement.EntityFrameworkCore;
using Volo.Abp.OpenIddict.EntityFrameworkCore;
using Volo.Abp.TenantManagement;
using Volo.Abp.TenantManagement.EntityFrameworkCore;

namespace SmartClinic.EntityFrameworkCore;

[ReplaceDbContext(typeof(IIdentityDbContext))]
[ReplaceDbContext(typeof(ITenantManagementDbContext))]
[ConnectionStringName("Default")]
public class SmartClinicDbContext :
    AbpDbContext<SmartClinicDbContext>,
    ITenantManagementDbContext,
    IIdentityDbContext
{
    /* Kendi tablolarımızı buraya ekliyoruz */
    public DbSet<Patient> Patients { get; set; }

    #region Entities from the modules
    // Identity
    public DbSet<IdentityUser> Users { get; set; }
    public DbSet<IdentityRole> Roles { get; set; }
    public DbSet<IdentityClaimType> ClaimTypes { get; set; }
    public DbSet<OrganizationUnit> OrganizationUnits { get; set; }
    public DbSet<IdentitySecurityLog> SecurityLogs { get; set; }
    public DbSet<IdentityLinkUser> LinkUsers { get; set; }
    public DbSet<IdentityUserDelegation> UserDelegations { get; set; }
    public DbSet<IdentitySession> Sessions { get; set; }

    // Tenant Management
    public DbSet<Tenant> Tenants { get; set; }
    public DbSet<TenantConnectionString> TenantConnectionStrings { get; set; }
    #endregion

    public SmartClinicDbContext(DbContextOptions<SmartClinicDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        /* ABP Modül yapılandırmaları */
        builder.ConfigurePermissionManagement();
        builder.ConfigureSettingManagement();
        builder.ConfigureBackgroundJobs();
        builder.ConfigureAuditLogging();
        builder.ConfigureFeatureManagement();
        builder.ConfigureIdentity();
        builder.ConfigureOpenIddict();
        builder.ConfigureTenantManagement();
        builder.ConfigureBlobStoring();

        /* SmartClinic: Kendi tablo yapılandırmalarımız */
        builder.Entity<Patient>(b =>
        {
            b.ToTable(SmartClinicConsts.DbTablePrefix + "Patients", SmartClinicConsts.DbSchema);
            b.ConfigureByConvention(); // ABP'nin standart kolonlarını (CreationTime, IsDeleted vb.) ayarlar
            
            // Veri Tutarlılığı için kısıtlamalar
            b.Property(x => x.Name).IsRequired().HasMaxLength(128);
            b.Property(x => x.Surname).IsRequired().HasMaxLength(128);
            b.Property(x => x.Complaint).HasMaxLength(512);
            b.Property(x => x.Status).IsRequired(); // Triyaj durumu boş geçilemez
        });
    }
}