﻿using System.ComponentModel.DataAnnotations;
using Core.DAL.Models;
using IPSTemplate.Dal.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Core.DALEF.ContextFactory;

public class Context : DbContext
{
    public Context(DbContextOptions<Context> options) : base(options)
    {
    }



    /// <summary>
    /// Gets the version of the current data schema.
    /// </summary>
    /// <value>The data schema version.</value>
    public static string DataSchemaVersion => "SchemaVersion.V1_0_0";

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // remove the pluralising convention that is by default attached to all model builders
        foreach (IMutableEntityType entityType in modelBuilder.Model.GetEntityTypes())
        {
            entityType.SetTableName(entityType.DisplayName());
        }

        // we don't need cascading delete, deleting children is done manually
        var cascadeFKs = modelBuilder.Model.GetEntityTypes()
                                           .SelectMany(t => t.GetForeignKeys())
                                           .Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Cascade);

        foreach (var fk in cascadeFKs)
        {
            fk.DeleteBehavior = DeleteBehavior.Restrict;
        }

        modelBuilder.ApplyUtcDateTimeConverter();
        modelBuilder.Seed();
    }

    // Validating entities on save.
    // Typically the validation is already done by the app and then re-checked by the database.
    // https://www.bricelam.net/2016/12/13/validation-in-efcore.html
    public override int SaveChanges()
    {
        var entities = from e in ChangeTracker.Entries()
                       where e.State == EntityState.Added
                           || e.State == EntityState.Modified
                       select e.Entity;

        foreach (var entity in entities)
        {
            var validationContext = new ValidationContext(entity);
            Validator.ValidateObject(entity, validationContext);
        }

        return base.SaveChanges();
    }

    #region Own models

    public DbSet<TEEntity> TEEntity { get; set; } = default!;
    public DbSet<TEGenre> TEGenre { get; set; }
    public DbSet<TEAuthor> TEAuthor { get; set; }
    public DbSet<TEPublisher> TEPublisher { get; set; }
    public DbSet<TEBookAuthor> TEBookAuthor { get; set; }
    public DbSet<TEBook> TEBook { get; set; }
    public DbSet<TEBookCopy> TEBookCopy { get; set; }


    #endregion

    #region Core.DAL models

    public DbSet<SYSetting> SYSetting { get; set; } = default!;
    //public DbSet<SYUser>? SYUser { get; set; }
    //public DbSet<SYUserRole>? SYUserRole { get; set; }

    #endregion
}
