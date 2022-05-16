using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace ef05_library.Models
{
    public partial class _14a_libraryContext : DbContext
    {
        public _14a_libraryContext()
        {
        }

        public _14a_libraryContext(DbContextOptions<_14a_libraryContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Borrow> Borrows { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Type> Types { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("server=localhost;database=14a_library;uid=root", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.4.21-mariadb"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasCharSet("utf8")
                .UseCollation("utf8_unicode_ci");

            modelBuilder.Entity<Author>(entity =>
            {
                entity.ToTable("authors");

                entity.Property(e => e.AuthorId)
                    .HasColumnType("int(11)")
                    .HasColumnName("authorId");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.Surname)
                    .HasMaxLength(70)
                    .HasColumnName("surname");
            });

            modelBuilder.Entity<Book>(entity =>
            {
                entity.ToTable("books");

                entity.HasIndex(e => e.AuthorId, "authorId");

                entity.HasIndex(e => e.TypeId, "typeId");

                entity.Property(e => e.BookId)
                    .HasColumnType("int(11)")
                    .HasColumnName("bookId");

                entity.Property(e => e.AuthorId)
                    .HasColumnType("int(11)")
                    .HasColumnName("authorId");

                entity.Property(e => e.Name)
                    .HasMaxLength(90)
                    .HasColumnName("name");

                entity.Property(e => e.Pagecount)
                    .HasColumnType("int(11)")
                    .HasColumnName("pagecount");

                entity.Property(e => e.Point)
                    .HasColumnType("int(11)")
                    .HasColumnName("point");

                entity.Property(e => e.TypeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("typeId");

                entity.HasOne(d => d.Author)
                    .WithMany(p => p.Books)
                    .HasForeignKey(d => d.AuthorId)
                    .HasConstraintName("books_ibfk_1");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.Books)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("books_type_1");
            });

            modelBuilder.Entity<Borrow>(entity =>
            {
                entity.ToTable("borrows");

                entity.HasIndex(e => e.BookId, "bookId");

                entity.HasIndex(e => e.StudentId, "studentId");

                entity.Property(e => e.BorrowId)
                    .HasColumnType("int(11)")
                    .HasColumnName("borrowId");

                entity.Property(e => e.BookId)
                    .HasColumnType("int(11)")
                    .HasColumnName("bookId");

                entity.Property(e => e.BroughtDate)
                    .HasColumnType("datetime(3)")
                    .HasColumnName("broughtDate");

                entity.Property(e => e.StudentId)
                    .HasColumnType("int(11)")
                    .HasColumnName("studentId");

                entity.Property(e => e.TakenDate)
                    .HasColumnType("datetime(3)")
                    .HasColumnName("takenDate");

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.Borrows)
                    .HasForeignKey(d => d.BookId)
                    .HasConstraintName("borrows_book_1");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.Borrows)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("borrows_student_1");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.ToTable("students");

                entity.Property(e => e.StudentId)
                    .HasColumnType("int(11)")
                    .HasColumnName("studentId");

                entity.Property(e => e.Birthdate)
                    .HasColumnType("date")
                    .HasColumnName("birthdate");

                entity.Property(e => e.Class)
                    .HasMaxLength(7)
                    .HasColumnName("class");

                entity.Property(e => e.Gender)
                    .HasMaxLength(10)
                    .HasColumnName("gender");

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .HasColumnName("name");

                entity.Property(e => e.Point)
                    .HasColumnType("int(11)")
                    .HasColumnName("point");

                entity.Property(e => e.Surname)
                    .HasMaxLength(20)
                    .HasColumnName("surname");
            });

            modelBuilder.Entity<Type>(entity =>
            {
                entity.ToTable("types");

                entity.Property(e => e.TypeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("typeId");

                entity.Property(e => e.Name)
                    .HasMaxLength(30)
                    .HasColumnName("name");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
