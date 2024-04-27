using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace StudentRecordManagement.Models
{
    public partial class StudentDbContext : DbContext
    {
        public StudentDbContext()
        {
        }

        public StudentDbContext(DbContextOptions<StudentDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Course> Courses { get; set; } = null!;
        public virtual DbSet<Grade> Grades { get; set; } = null!;
        public virtual DbSet<SCM> SCMs { get; set; } = null!;
        public virtual DbSet<Student> Students { get; set; } = null!;
        public virtual DbSet<Teacher> Teachers { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>(entity =>
            {
                entity.HasKey(e => e.Course_id);

                entity.Property(e => e.Course_id)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Course_Name) 
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Credit)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Grade>(entity =>
            {
                entity.HasKey(e => e.Grade_Id);

                entity.Property(e => e.Grade_Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<SCM>(entity =>
            {
                entity.HasKey(e => e.SCM_Id);

                entity.ToTable("SCM");

                entity.Property(e => e.SCM_Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey(e => e.Student_Id);

                entity.Property(e => e.Student_Id).ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Student_Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Teacher>(entity =>
            {
                entity.HasKey(e => e.Teacher_Id);

                entity.Property(e => e.Teacher_Id).ValueGeneratedNever();

                entity.Property(e => e.Teacher_Course).HasMaxLength(50);

                entity.Property(e => e.Teacher_Name).HasMaxLength(50);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.User_id);

                entity.Property(e => e.User_id).ValueGeneratedNever();

                entity.Property(e => e.Type)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
