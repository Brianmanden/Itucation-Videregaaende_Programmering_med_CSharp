﻿// <auto-generated />
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
                    b.Property<int>("DocumentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DocumentId"));

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Heading")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TopicStrings")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DocumentId");

                    b.ToTable("Documents");

                    b.HasData(
                        new
                        {
                            DocumentId = 1,
                            Content = "Carry at least one Cutting Tool. Preferably more than one!",
                            Heading = "Cutting Tools - be sure to carry one",
                            Name = "First Document on Cutting Tools",
                            TopicStrings = "cutting tools,axes,saws"
                        },
                        new
                        {
                            DocumentId = 2,
                            Content = "A Shelter gives you a place to rest shielded against the elements of nature.",
                            Heading = "Shelters - shield yourself against the elements",
                            Name = "First Document on Shelters",
                            TopicStrings = "cover,shelter"
                        },
                        new
                        {
                            DocumentId = 3,
                            Content = "It´s important to keep an eye on Core Temperature when out in nature.",
                            Heading = "Core Temperature - always stay warm",
                            Name = "First Document on Core Temperature",
                            TopicStrings = "core temperature,cover"
                        });
                });

            modelBuilder.Entity("BushcraftBlog.Shared.Models.Tag", b =>
                {
                    b.Property<int>("TagId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TagId"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TagId");

                    b.ToTable("Tag");

                    b.HasData(
                        new
                        {
                            TagId = 1,
                            Description = "The 5 Cs of Survivability.",
                            Name = "5CS"
                        },
                        new
                        {
                            TagId = 2,
                            Description = "The 10 Cs of Survivability.",
                            Name = "10CS"
                        },
                        new
                        {
                            TagId = 3,
                            Description = "Cutting Tool for processing material in nature.",
                            Name = "Cutting Tool"
                        },
                        new
                        {
                            TagId = 4,
                            Description = "Combustion Device to start a fire to keep you warm and prepare food.",
                            Name = "Combustion Device"
                        },
                        new
                        {
                            TagId = 5,
                            Description = "Container for cooking food and carrying ressources ie. water.",
                            Name = "Container"
                        },
                        new
                        {
                            TagId = 6,
                            Description = "Cordage for helping in building a shelter.",
                            Name = "Cordage"
                        },
                        new
                        {
                            TagId = 7,
                            Description = "Shelter for protecting you against the elements of nature.",
                            Name = "Cover"
                        },
                        new
                        {
                            TagId = 8,
                            Description = "Core Temperature is important to keep an eye on.",
                            Name = "Core Temperatur"
                        });
                });

            modelBuilder.Entity("BushcraftBlog.Shared.Models.Topic", b =>
                {
                    b.Property<int>("TopicId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TopicId"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TopicId");

                    b.ToTable("Topic");

                    b.HasData(
                        new
                        {
                            TopicId = 1,
                            Description = "Cutting Tools as a topic in general.",
                            Name = "Cutting Tools"
                        },
                        new
                        {
                            TopicId = 2,
                            Description = "Shelters as a topic.",
                            Name = "Shelter"
                        },
                        new
                        {
                            TopicId = 3,
                            Description = "Core Temperature as a topic.",
                            Name = "Core Temperature"
                        },
                        new
                        {
                            TopicId = 4,
                            Description = "Saws as a topic",
                            Name = "Saws"
                        },
                        new
                        {
                            TopicId = 5,
                            Description = "Axes as a topic",
                            Name = "Axes"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}