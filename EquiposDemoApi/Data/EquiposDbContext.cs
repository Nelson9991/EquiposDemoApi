using System.Collections.Generic;
using EquiposDemoApi.Modelos;
using Microsoft.EntityFrameworkCore;

namespace EquiposDemoApi.Data;

public class EquiposDbContext : DbContext
{
    public EquiposDbContext(DbContextOptions options)
        : base(options) { }

    // Creamos la tabla CategoriasEquipos a partir del modelo CategoriaEquipo
    public DbSet<CategoriaEquipo> CategoriasEquipos { get; set; }

    // OnModelCreating sirve para manipular los modelos y cambiar configuraciones, y ademas agregar datos inciales.
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .Entity<CategoriaEquipo>()
            .HasData(
                new List<CategoriaEquipo>
                {
                    new CategoriaEquipo { Id = 1, NombreCategoria = "Electrodomesticos" },
                    new CategoriaEquipo { Id = 2, NombreCategoria = "Construccion", },
                    new CategoriaEquipo { Id = 3, NombreCategoria = "Utiles Medicos" }
                }
            );
    }
}
