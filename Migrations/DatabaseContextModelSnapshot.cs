﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using blog.Models;

namespace blog.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("blog.Models.About", b =>
                {
                    b.Property<int>("AboutID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AboutContent");

                    b.HasKey("AboutID");

                    b.ToTable("About");
                });

            modelBuilder.Entity("blog.Models.AdminUser", b =>
                {
                    b.Property<int>("AdminUserID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("UserName");

                    b.Property<string>("UserPassword");

                    b.HasKey("AdminUserID");

                    b.ToTable("AdminUsers");
                });

            modelBuilder.Entity("blog.Models.Article", b =>
                {
                    b.Property<int>("ArticleID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ArticleAbstract");

                    b.Property<string>("ArticleContent");

                    b.Property<DateTime>("ArticleDate");

                    b.Property<string>("ArticleHead");

                    b.Property<string>("ArticleImage");

                    b.Property<int>("CategoryID");

                    b.HasKey("ArticleID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Articles");
                });

            modelBuilder.Entity("blog.Models.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName");

                    b.Property<int>("CategorySequance");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("blog.Models.Comment", b =>
                {
                    b.Property<int>("CommentID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ArticleID");

                    b.Property<string>("CommentContent");

                    b.Property<DateTime>("CommentDate");

                    b.Property<string>("CommentFullname");

                    b.Property<string>("CommentMail");

                    b.HasKey("CommentID");

                    b.HasIndex("ArticleID");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("blog.Models.Contact", b =>
                {
                    b.Property<int>("ContactID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("ContactCheck");

                    b.Property<DateTime>("ContactDate");

                    b.Property<string>("ContactFullName");

                    b.Property<string>("ContactMail");

                    b.Property<string>("ContactMessage");

                    b.HasKey("ContactID");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("blog.Models.Article", b =>
                {
                    b.HasOne("blog.Models.Category", "Category")
                        .WithMany("Article")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("blog.Models.Comment", b =>
                {
                    b.HasOne("blog.Models.Article", "Article")
                        .WithMany("Comment")
                        .HasForeignKey("ArticleID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
