﻿// <auto-generated />
using System;
using MessageBoard.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MessageBoard.Migrations
{
    [DbContext(typeof(MessageBoardContext))]
    [Migration("20200818175344_MoreSeeds")]
    partial class MoreSeeds
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("MessageBoard.Models.Board", b =>
                {
                    b.Property<int>("BoardId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Title");

                    b.HasKey("BoardId");

                    b.ToTable("Boards");

                    b.HasData(
                        new
                        {
                            BoardId = 1,
                            Title = "Politics"
                        },
                        new
                        {
                            BoardId = 2,
                            Title = "Religions"
                        },
                        new
                        {
                            BoardId = 3,
                            Title = "Objectively Best Music Genres"
                        });
                });

            modelBuilder.Entity("MessageBoard.Models.Post", b =>
                {
                    b.Property<int>("PostId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationDate");

                    b.Property<int>("ParentThreadId");

                    b.Property<string>("PostBody");

                    b.Property<string>("Title");

                    b.Property<int>("UserId");

                    b.HasKey("PostId");

                    b.HasIndex("ParentThreadId");

                    b.HasIndex("UserId");

                    b.ToTable("Posts");

                    b.HasData(
                        new
                        {
                            PostId = 1,
                            CreationDate = new DateTime(2020, 8, 18, 10, 53, 43, 610, DateTimeKind.Local).AddTicks(1970),
                            ParentThreadId = 1,
                            PostBody = "Lorem Ipsum",
                            Title = "Test Message",
                            UserId = 1
                        });
                });

            modelBuilder.Entity("MessageBoard.Models.Thread", b =>
                {
                    b.Property<int>("ThreadId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationDate");

                    b.Property<int>("ParentBoardId");

                    b.Property<string>("Title");

                    b.Property<int>("UserId");

                    b.HasKey("ThreadId");

                    b.HasIndex("ParentBoardId");

                    b.HasIndex("UserId");

                    b.ToTable("Threads");

                    b.HasData(
                        new
                        {
                            ThreadId = 1,
                            CreationDate = new DateTime(2020, 8, 18, 10, 53, 43, 606, DateTimeKind.Local).AddTicks(1400),
                            ParentBoardId = 1,
                            Title = "Test Message",
                            UserId = 1
                        },
                        new
                        {
                            ThreadId = 2,
                            CreationDate = new DateTime(2020, 8, 18, 10, 53, 43, 609, DateTimeKind.Local).AddTicks(5090),
                            ParentBoardId = 1,
                            Title = "Test Message",
                            UserId = 1
                        },
                        new
                        {
                            ThreadId = 3,
                            CreationDate = new DateTime(2020, 8, 18, 10, 53, 43, 609, DateTimeKind.Local).AddTicks(5120),
                            ParentBoardId = 1,
                            Title = "Test Message",
                            UserId = 1
                        },
                        new
                        {
                            ThreadId = 4,
                            CreationDate = new DateTime(2020, 8, 18, 10, 53, 43, 609, DateTimeKind.Local).AddTicks(5120),
                            ParentBoardId = 1,
                            Title = "Test Message",
                            UserId = 1
                        },
                        new
                        {
                            ThreadId = 5,
                            CreationDate = new DateTime(2020, 8, 18, 10, 53, 43, 609, DateTimeKind.Local).AddTicks(5130),
                            ParentBoardId = 1,
                            Title = "Test Message",
                            UserId = 1
                        },
                        new
                        {
                            ThreadId = 6,
                            CreationDate = new DateTime(2020, 8, 18, 10, 53, 43, 609, DateTimeKind.Local).AddTicks(5130),
                            ParentBoardId = 1,
                            Title = "Test Message",
                            UserId = 1
                        },
                        new
                        {
                            ThreadId = 7,
                            CreationDate = new DateTime(2020, 8, 18, 10, 53, 43, 609, DateTimeKind.Local).AddTicks(5140),
                            ParentBoardId = 1,
                            Title = "Test Message",
                            UserId = 1
                        },
                        new
                        {
                            ThreadId = 8,
                            CreationDate = new DateTime(2020, 8, 18, 10, 53, 43, 609, DateTimeKind.Local).AddTicks(5140),
                            ParentBoardId = 1,
                            Title = "Test Message",
                            UserId = 1
                        },
                        new
                        {
                            ThreadId = 9,
                            CreationDate = new DateTime(2020, 8, 18, 10, 53, 43, 609, DateTimeKind.Local).AddTicks(5150),
                            ParentBoardId = 1,
                            Title = "Test Message",
                            UserId = 1
                        },
                        new
                        {
                            ThreadId = 10,
                            CreationDate = new DateTime(2020, 8, 18, 10, 53, 43, 609, DateTimeKind.Local).AddTicks(5150),
                            ParentBoardId = 1,
                            Title = "Test Message",
                            UserId = 1
                        },
                        new
                        {
                            ThreadId = 11,
                            CreationDate = new DateTime(2020, 8, 18, 10, 53, 43, 609, DateTimeKind.Local).AddTicks(5160),
                            ParentBoardId = 1,
                            Title = "Test Message",
                            UserId = 1
                        },
                        new
                        {
                            ThreadId = 12,
                            CreationDate = new DateTime(2020, 8, 18, 10, 53, 43, 609, DateTimeKind.Local).AddTicks(5160),
                            ParentBoardId = 1,
                            Title = "Test Message",
                            UserId = 1
                        },
                        new
                        {
                            ThreadId = 13,
                            CreationDate = new DateTime(2020, 8, 18, 10, 53, 43, 609, DateTimeKind.Local).AddTicks(5160),
                            ParentBoardId = 1,
                            Title = "Test Message",
                            UserId = 1
                        },
                        new
                        {
                            ThreadId = 14,
                            CreationDate = new DateTime(2020, 8, 18, 10, 53, 43, 609, DateTimeKind.Local).AddTicks(5170),
                            ParentBoardId = 1,
                            Title = "Test Message",
                            UserId = 1
                        },
                        new
                        {
                            ThreadId = 15,
                            CreationDate = new DateTime(2020, 8, 18, 10, 53, 43, 609, DateTimeKind.Local).AddTicks(5170),
                            ParentBoardId = 1,
                            Title = "Test Message",
                            UserId = 1
                        },
                        new
                        {
                            ThreadId = 16,
                            CreationDate = new DateTime(2020, 8, 18, 10, 53, 43, 609, DateTimeKind.Local).AddTicks(5180),
                            ParentBoardId = 1,
                            Title = "Test Message",
                            UserId = 1
                        },
                        new
                        {
                            ThreadId = 17,
                            CreationDate = new DateTime(2020, 8, 18, 10, 53, 43, 609, DateTimeKind.Local).AddTicks(5180),
                            ParentBoardId = 1,
                            Title = "Test Message",
                            UserId = 1
                        },
                        new
                        {
                            ThreadId = 18,
                            CreationDate = new DateTime(2020, 8, 18, 10, 53, 43, 609, DateTimeKind.Local).AddTicks(5180),
                            ParentBoardId = 1,
                            Title = "Test Message",
                            UserId = 1
                        },
                        new
                        {
                            ThreadId = 19,
                            CreationDate = new DateTime(2020, 8, 18, 10, 53, 43, 609, DateTimeKind.Local).AddTicks(5190),
                            ParentBoardId = 1,
                            Title = "Test Message",
                            UserId = 1
                        },
                        new
                        {
                            ThreadId = 20,
                            CreationDate = new DateTime(2020, 8, 18, 10, 53, 43, 609, DateTimeKind.Local).AddTicks(5190),
                            ParentBoardId = 1,
                            Title = "Test Message",
                            UserId = 1
                        },
                        new
                        {
                            ThreadId = 21,
                            CreationDate = new DateTime(2020, 8, 18, 10, 53, 43, 609, DateTimeKind.Local).AddTicks(5200),
                            ParentBoardId = 1,
                            Title = "Test Message",
                            UserId = 1
                        },
                        new
                        {
                            ThreadId = 22,
                            CreationDate = new DateTime(2020, 8, 18, 10, 53, 43, 609, DateTimeKind.Local).AddTicks(5200),
                            ParentBoardId = 1,
                            Title = "Test Message",
                            UserId = 1
                        },
                        new
                        {
                            ThreadId = 23,
                            CreationDate = new DateTime(2020, 8, 18, 10, 53, 43, 609, DateTimeKind.Local).AddTicks(5200),
                            ParentBoardId = 1,
                            Title = "Test Message",
                            UserId = 1
                        },
                        new
                        {
                            ThreadId = 24,
                            CreationDate = new DateTime(2020, 8, 18, 10, 53, 43, 609, DateTimeKind.Local).AddTicks(5210),
                            ParentBoardId = 1,
                            Title = "Test Message",
                            UserId = 1
                        },
                        new
                        {
                            ThreadId = 25,
                            CreationDate = new DateTime(2020, 8, 18, 10, 53, 43, 609, DateTimeKind.Local).AddTicks(5210),
                            ParentBoardId = 1,
                            Title = "Test Message",
                            UserId = 1
                        });
                });

            modelBuilder.Entity("MessageBoard.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("UserName");

                    b.HasKey("UserId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            CreationDate = new DateTime(2020, 8, 18, 10, 53, 43, 610, DateTimeKind.Local).AddTicks(8010),
                            UserName = "TestName"
                        });
                });

            modelBuilder.Entity("MessageBoard.Models.Post", b =>
                {
                    b.HasOne("MessageBoard.Models.Thread", "ParentThread")
                        .WithMany("Posts")
                        .HasForeignKey("ParentThreadId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MessageBoard.Models.User", "User")
                        .WithMany("UserPosts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MessageBoard.Models.Thread", b =>
                {
                    b.HasOne("MessageBoard.Models.Board", "ParentBoard")
                        .WithMany("Threads")
                        .HasForeignKey("ParentBoardId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MessageBoard.Models.User", "User")
                        .WithMany("UserThreads")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
