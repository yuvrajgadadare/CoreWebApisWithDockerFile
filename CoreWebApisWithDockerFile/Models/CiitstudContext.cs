using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CoreWebApisWithDockerFile.Models;

public partial class CiitstudContext : DbContext
{
    public CiitstudContext()
    {
    }

    public CiitstudContext(DbContextOptions<CiitstudContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Tblenquiry> Tblenquiries { get; set; }

    public virtual DbSet<TbltrainingCourse> TbltrainingCourses { get; set; }

    public virtual DbSet<TbltrainingTopic> TbltrainingTopics { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=115.124.106.98;Database=ciitstud_;User Id=ciituser;Password=CIIT#0908;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("ciituser");

        modelBuilder.Entity<Tblenquiry>(entity =>
        {
            entity.HasKey(e => e.EnquiryId).HasName("PK__tblenqui__57CC01B3BED7B890");

            entity.ToTable("tblenquiries", "dbo");

            entity.Property(e => e.EnquiryId).HasColumnName("enquiry_id");
            entity.Property(e => e.BirthDate)
                .HasColumnType("datetime")
                .HasColumnName("birth_date");
            entity.Property(e => e.BranchId).HasColumnName("branch_id");
            entity.Property(e => e.CandidateName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("candidate_name");
            entity.Property(e => e.EmailAddress)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("email_address");
            entity.Property(e => e.EnquiryDate)
                .HasColumnType("datetime")
                .HasColumnName("enquiry_date");
            entity.Property(e => e.EnquiryFors)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("enquiry_fors");
            entity.Property(e => e.Gender)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("gender");
            entity.Property(e => e.InterestedTopics)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("interested_topics");
            entity.Property(e => e.LeadSources)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("lead_sources");
            entity.Property(e => e.LocalAddress)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("local_address");
            entity.Property(e => e.MobileNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("mobile_number");
            entity.Property(e => e.Qualification)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("qualification");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("status");
        });

        modelBuilder.Entity<TbltrainingCourse>(entity =>
        {
            entity.HasKey(e => e.CourseId).HasName("PK__tbltrain__8F1EF7AE1D85AA59");

            entity.ToTable("tbltraining_courses", "dbo");

            entity.HasIndex(e => e.CourseName, "UQ__tbltrain__B5B2A66A32A9DDE1").IsUnique();

            entity.HasIndex(e => e.CourseName, "UQ__tbltrain__B5B2A66A81A18235").IsUnique();

            entity.HasIndex(e => e.CourseName, "UQ__tbltrain__B5B2A66AA5AA539C").IsUnique();

            entity.HasIndex(e => e.CourseName, "UQ__tbltrain__B5B2A66AB7509A00").IsUnique();

            entity.HasIndex(e => e.CourseName, "UQ__tbltrain__B5B2A66AC588406D").IsUnique();

            entity.HasIndex(e => e.CourseName, "UQ__tbltrain__B5B2A66ADA81FD7D").IsUnique();

            entity.Property(e => e.CourseId).HasColumnName("course_id");
            entity.Property(e => e.CourseName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("course_name");
            entity.Property(e => e.Flag)
                .HasDefaultValue(0)
                .HasColumnName("flag");
        });

        modelBuilder.Entity<TbltrainingTopic>(entity =>
        {
            entity.HasKey(e => e.TopicId).HasName("PK__tbltrain__D5DAA3E90815FAA8");

            entity.ToTable("tbltraining_topics", "dbo");

            entity.HasIndex(e => e.TopicName, "UQ__tbltrain__54BAE5EC5F6DA262").IsUnique();

            entity.HasIndex(e => e.TopicName, "UQ__tbltrain__54BAE5EC8541C815").IsUnique();

            entity.HasIndex(e => e.TopicName, "UQ__tbltrain__54BAE5EC987F6ABA").IsUnique();

            entity.HasIndex(e => e.TopicName, "UQ__tbltrain__54BAE5ECAC4BCA78").IsUnique();

            entity.HasIndex(e => e.TopicName, "UQ__tbltrain__54BAE5ECC0075B4E").IsUnique();

            entity.HasIndex(e => e.TopicName, "UQ__tbltrain__54BAE5ECE59FE9C7").IsUnique();

            entity.Property(e => e.TopicId).HasColumnName("topic_id");
            entity.Property(e => e.Flag)
                .HasDefaultValue(0)
                .HasColumnName("flag");
            entity.Property(e => e.Publicfolderid)
                .IsUnicode(false)
                .HasColumnName("publicfolderid");
            entity.Property(e => e.TopicName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("topic_name");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
