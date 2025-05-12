using CarrerCompass_Proyect.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace CarrerCompass_Proyect.Infrastucture.DbData
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Estudiante> Estudiantes { get; set; }
        public DbSet<TestVocacional> TestsVocacionales { get; set; }
        public DbSet<Carrera> Carreras { get; set; }
        public DbSet<CarreraSugerida> CarrerasSugeridas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Estudiante
            modelBuilder.Entity<Estudiante>(entity =>
            {
                entity.ToTable("Estudiante");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.NombreCompleto).IsRequired().HasMaxLength(100);
                entity.Property(e => e.CorreoElectronico).IsRequired().HasMaxLength(100);
                entity.Property(e => e.FechaNacimiento).IsRequired();

                entity.HasOne(e => e.ResultadoTest);
                entity.HasMany(e => e.CarrerasSugeridas);
            });

            // Test Vocacional
            modelBuilder.Entity<TestVocacional>(entity =>
            {
                entity.ToTable("TestVocacional");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.FechaRealizacion).IsRequired();
                entity.Property(e => e.Puntaje).IsRequired();
                entity.Property(e => e.CodigoResultado).IsRequired().HasMaxLength(50);
            });

            // Carrera
            modelBuilder.Entity<Carrera>(entity =>
            {
                entity.ToTable("Carrera");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Nombre).IsRequired().HasMaxLength(100);
                entity.Property(e => e.Descripcion);
                entity.Property(e => e.Area).HasMaxLength(50);
                entity.Property(e => e.SalarioPromedio).HasColumnType("decimal(10,2)");
            });

            // Carrera Sugerida
            modelBuilder.Entity<CarreraSugerida>(entity =>
            {
                entity.ToTable("CarreraSugerida");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Puntaje).IsRequired();

                entity.HasOne(cs => cs.Carrera);
            });
        }
    }
}
