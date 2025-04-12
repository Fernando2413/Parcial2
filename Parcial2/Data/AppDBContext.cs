using Microsoft.EntityFrameworkCore;
using Parcial2.Models;

namespace Parcial2.Data
{
    public class AppDBContext:DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext>options): base (options) 
        {

        }
        public DbSet<usuario> Usuario { get; set; }
        public DbSet<autor> Autor { get; set; }
        public DbSet<libro> Libro { get; set; }
        public DbSet<libro_autor> Libro_autor { get; set; }
        public DbSet<usuario> Prestamo { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<usuario>(tb =>
            {
                tb.HasKey(col => col.id_Usuario);
                tb.Property(col => col.id_Usuario)
                .UseIdentityColumn()
                .ValueGeneratedOnAdd();

                tb.Property(col => col.nombre).HasMaxLength(50);
                tb.Property(col => col.programa).HasMaxLength(50);
                tb.Property(col => col.fecha_Nacimiento);
                tb.Property(col => col.correo).HasMaxLength(50);
                tb.Property(col => col.password).HasMaxLength(50);

            });
            modelBuilder.Entity<usuario>().ToTable("usuario");

            modelBuilder.Entity<autor>(tb =>
            {
                tb.HasKey(col => col.id_Autor);
                tb.Property(col => col.id_Autor)
                .UseIdentityColumn()
                .ValueGeneratedOnAdd();

                tb.Property(col => col.nombre).HasMaxLength(50);
                tb.Property(col => col.nacionalidad).HasMaxLength(50);

            });
            modelBuilder.Entity<autor>().ToTable("autor");

            modelBuilder.Entity<libro>(tb =>
            {
                tb.HasKey(col => col.id_Libro);
                tb.Property(col => col.id_Libro)
                .UseIdentityColumn()
                .ValueGeneratedOnAdd();

                tb.Property(col => col.titulo).HasMaxLength(30);
                tb.Property(col => col.editorial).HasMaxLength(30);
                tb.Property(col => col.area).HasMaxLength(30);
                tb.Property(col => col.cover_Url).HasMaxLength(120);
                tb.Property(col => col.digital_Url).HasMaxLength(120);

            });
            modelBuilder.Entity<libro>().ToTable("libro");

            modelBuilder.Entity<libro_autor>(tb =>
            {
                tb.HasKey(col => col.id_Libro_Autor);
                tb.Property(col => col.id_Libro_Autor)
                .UseIdentityColumn()
                .ValueGeneratedOnAdd();

            });
            modelBuilder.Entity<libro_autor>().ToTable("libro_autor");

            modelBuilder.Entity<prestamo>(tb =>
            {
                tb.HasKey(col => col.id_Usuario);
                tb.Property(col => col.id_Usuario)
                .UseIdentityColumn()
                .ValueGeneratedOnAdd();

            });
            modelBuilder.Entity<prestamo>().ToTable("prestamo");
        }
    }
}
