using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ormc.DataFirst.Models;

public partial class Context : DbContext
{
    public Context()
    {
    }

    public Context(DbContextOptions<Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Driver> Driver { get; set; }

    public virtual DbSet<Race> Race { get; set; }

    public virtual DbSet<RaceResult> RaceResult { get; set; }

    public virtual DbSet<Track> Track { get; set; }

    public virtual DbSet<TrackType> TrackType { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost;Database=ormc-local;Integrated Security=SSPI;Application Name=ormc;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Driver>(entity =>
        {
            entity.HasKey(e => e.DriverId).HasName("pk_ormc_Driver");
        });

        modelBuilder.Entity<Race>(entity =>
        {
            entity.HasKey(e => new { e.RaceSeason, e.RaceNumber }).HasName("pk_ormc_Race");
        });

        modelBuilder.Entity<RaceResult>(entity =>
        {
            entity.HasKey(e => new { e.RaceSeason, e.RaceNumber }).HasName("pk_ormc_RaceResult");
        });

        modelBuilder.Entity<Track>(entity =>
        {
            entity.HasKey(e => e.TrackId).HasName("pk_ormc_Track");
        });

        modelBuilder.Entity<TrackType>(entity =>
        {
            entity.HasKey(e => e.TrackTypeId).HasName("pk_ormc_TrackType");

            entity.Property(e => e.TrackTypeId).ValueGeneratedNever();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
