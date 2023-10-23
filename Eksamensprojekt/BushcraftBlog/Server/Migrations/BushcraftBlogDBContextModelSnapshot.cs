﻿// <auto-generated />
using System;
using BushcraftBlog.Server.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BushcraftBlog.Server.Migrations
{
    [DbContext(typeof(BushcraftBlogDBContext))]
    partial class BushcraftBlogDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BushcraftBlog.Shared.Models.Document", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Heading")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Documents");
                });

            modelBuilder.Entity("BushcraftBlog.Shared.Models.Tag", b =>
                {
                    b.Property<int>("TagId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TagId"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DocumentId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TagId");

                    b.HasIndex("DocumentId");

                    b.ToTable("Tag");
                });

            modelBuilder.Entity("BushcraftBlog.Shared.Models.Topic", b =>
                {
                    b.Property<int>("TopicId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TopicId"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DocumentId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TopicId");

                    b.HasIndex("DocumentId");

                    b.ToTable("Topic");
                });

            modelBuilder.Entity("BushcraftBlog.Shared.Models.Tag", b =>
                {
                    b.HasOne("BushcraftBlog.Shared.Models.Document", null)
                        .WithMany("Tags")
                        .HasForeignKey("DocumentId");
                });

            modelBuilder.Entity("BushcraftBlog.Shared.Models.Topic", b =>
                {
                    b.HasOne("BushcraftBlog.Shared.Models.Document", null)
                        .WithMany("Topics")
                        .HasForeignKey("DocumentId");
                });

            modelBuilder.Entity("BushcraftBlog.Shared.Models.Document", b =>
                {
                    b.Navigation("Tags");

                    b.Navigation("Topics");
                });
#pragma warning restore 612, 618
        }
    }
}
