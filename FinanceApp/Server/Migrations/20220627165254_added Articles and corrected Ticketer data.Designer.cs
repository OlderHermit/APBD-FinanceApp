﻿// <auto-generated />
using System;
using FinanceApp.Server.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FinanceApp.Server.Migrations
{
    [DbContext(typeof(FinanceDbContext))]
    [Migration("20220627165254_added Articles and corrected Ticketer data")]
    partial class addedArticlesandcorrectedTicketerdata
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("FinanceApp.Server.Models.ArticleToDb", b =>
                {
                    b.Property<int>("TicketerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("published_utc")
                        .HasColumnType("datetime2");

                    b.Property<string>("article_url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TicketerId", "published_utc");

                    b.ToTable("Article", (string)null);
                });

            modelBuilder.Entity("FinanceApp.Server.Models.TicketerDataToDb", b =>
                {
                    b.Property<int>("TicketerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<double>("Close")
                        .HasColumnType("float");

                    b.Property<double>("Highest")
                        .HasColumnType("float");

                    b.Property<double>("Lowest")
                        .HasColumnType("float");

                    b.Property<double>("NumberOfTransactons")
                        .HasColumnType("float");

                    b.Property<bool>("OTC")
                        .HasColumnType("bit");

                    b.Property<double>("Open")
                        .HasColumnType("float");

                    b.Property<int>("Timestamp")
                        .HasColumnType("int");

                    b.Property<double>("Volume")
                        .HasColumnType("float");

                    b.Property<double>("VolumeWeighted")
                        .HasColumnType("float");

                    b.HasKey("TicketerId", "Date");

                    b.ToTable("TicketerData", (string)null);
                });

            modelBuilder.Entity("FinanceApp.Server.Models.TicketerToDb", b =>
                {
                    b.Property<int>("TicketerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TicketerId"), 1L, 1);

                    b.Property<string>("CEO")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("Logo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Sector")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Symbol")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("TicketerId");

                    b.ToTable("Ticketer", (string)null);

                    b.HasData(
                        new
                        {
                            TicketerId = 1,
                            CEO = "Jeffrey Storey",
                            Country = "US",
                            Logo = "https://s24.q4cdn.com/287068338/files/design/lumen-logo-blue-black.png",
                            Name = "Lumen Technologies, Inc.",
                            Sector = "fiber infrastructure",
                            Symbol = "LUMN"
                        },
                        new
                        {
                            TicketerId = 2,
                            CEO = "Alan S. Armstrong",
                            Country = "US",
                            Logo = "https://g.foolcdn.com/art/companylogos/medium/WMB.png",
                            Name = "Williams Companies Inc.",
                            Sector = "Utilities",
                            Symbol = "WMB"
                        },
                        new
                        {
                            TicketerId = 3,
                            CEO = "Walter Schalka",
                            Country = "US",
                            Logo = "https://suzano-site.s3-sa-east-1.amazonaws.com/assets/img/logo-suzano-rodape.png",
                            Name = "Suzano S.A.",
                            Sector = "bio-based materials",
                            Symbol = "SUZ"
                        },
                        new
                        {
                            TicketerId = 4,
                            CEO = "Sasan K. Goodarzi",
                            Country = "US",
                            Logo = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/ae/Intuit_Logo.svg/1200px-Intuit_Logo.svg.png",
                            Name = "Intuit Inc",
                            Sector = "financial management",
                            Symbol = "INTU"
                        },
                        new
                        {
                            TicketerId = 5,
                            CEO = "Dave Lougee",
                            Country = "US",
                            Logo = "https://res.cloudinary.com/etoro/image/fetch/w_1.5/https://etoro-cdn.etorostatic.com/market-avatars/6873/150x150.png",
                            Name = "TEGNA Inc.",
                            Sector = "media provider",
                            Symbol = "TGNA"
                        },
                        new
                        {
                            TicketerId = 6,
                            CEO = "Michael Williams",
                            Country = "US",
                            Logo = "https://www.timkensteel.com/img/timkenSteelShare.jpg",
                            Name = "TIMKENSTEEL CORPORATION",
                            Sector = "basic materials",
                            Symbol = "TMST"
                        },
                        new
                        {
                            TicketerId = 7,
                            CEO = "Elon Musk",
                            Country = "US",
                            Logo = "https://upload.wikimedia.org/wikipedia/commons/e/e8/Tesla_logo.png",
                            Name = "Tesla, Inc.",
                            Sector = "Automotive, Energy Generation",
                            Symbol = "TSLA"
                        },
                        new
                        {
                            TicketerId = 8,
                            CEO = "Randy Neely",
                            Country = "US",
                            Logo = "https://s24.q4cdn.com/107256193/files/design/transglobe-logo.svg",
                            Name = "Transglobe Energy Corp",
                            Sector = "oil exploration",
                            Symbol = "TGA"
                        },
                        new
                        {
                            TicketerId = 9,
                            CEO = "David Feller",
                            Country = "US",
                            Logo = "https://static.seekingalpha.com/uploads/2020/1/13/22464021-15789554209817338.jpg",
                            Name = "Mogo Inc.",
                            Sector = "information",
                            Symbol = "MOGO"
                        },
                        new
                        {
                            TicketerId = 10,
                            CEO = "Paul J. O'Shea",
                            Country = "US",
                            Logo = "https://s3-symbol-logo.tradingview.com/enstar-group--600.png",
                            Name = "Enstar Group",
                            Sector = "insurance",
                            Symbol = "ESGRO"
                        });
                });

            modelBuilder.Entity("FinanceApp.Server.Models.UserToDb", b =>
                {
                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Email");

                    b.ToTable("User", (string)null);
                });

            modelBuilder.Entity("FinanceApp.Server.Models.WatchList", b =>
                {
                    b.Property<int>("WatchListId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WatchListId"), 1L, 1);

                    b.Property<string>("UserEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("WatchListId");

                    b.HasIndex("UserEmail");

                    b.ToTable("WatchList", (string)null);
                });

            modelBuilder.Entity("FinanceApp.Server.Models.WatchList_Ticketer", b =>
                {
                    b.Property<int>("TicketerId")
                        .HasColumnType("int");

                    b.Property<int>("WatchListId")
                        .HasColumnType("int");

                    b.HasKey("TicketerId", "WatchListId");

                    b.HasIndex("WatchListId");

                    b.ToTable("WatchList_Ticketer", (string)null);
                });

            modelBuilder.Entity("FinanceApp.Server.Models.ArticleToDb", b =>
                {
                    b.HasOne("FinanceApp.Server.Models.TicketerToDb", "Ticketer")
                        .WithMany("Articles")
                        .HasForeignKey("TicketerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ticketer");
                });

            modelBuilder.Entity("FinanceApp.Server.Models.TicketerDataToDb", b =>
                {
                    b.HasOne("FinanceApp.Server.Models.TicketerToDb", "Ticketer")
                        .WithMany("TicketerDatas")
                        .HasForeignKey("TicketerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ticketer");
                });

            modelBuilder.Entity("FinanceApp.Server.Models.WatchList", b =>
                {
                    b.HasOne("FinanceApp.Server.Models.UserToDb", "User")
                        .WithMany("WatchLists")
                        .HasForeignKey("UserEmail")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("FinanceApp.Server.Models.WatchList_Ticketer", b =>
                {
                    b.HasOne("FinanceApp.Server.Models.TicketerToDb", "Ticketer")
                        .WithMany("WatchList_Ticketers")
                        .HasForeignKey("TicketerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FinanceApp.Server.Models.WatchList", "WatchList")
                        .WithMany("WatchList_Ticketers")
                        .HasForeignKey("WatchListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ticketer");

                    b.Navigation("WatchList");
                });

            modelBuilder.Entity("FinanceApp.Server.Models.TicketerToDb", b =>
                {
                    b.Navigation("Articles");

                    b.Navigation("TicketerDatas");

                    b.Navigation("WatchList_Ticketers");
                });

            modelBuilder.Entity("FinanceApp.Server.Models.UserToDb", b =>
                {
                    b.Navigation("WatchLists");
                });

            modelBuilder.Entity("FinanceApp.Server.Models.WatchList", b =>
                {
                    b.Navigation("WatchList_Ticketers");
                });
#pragma warning restore 612, 618
        }
    }
}
