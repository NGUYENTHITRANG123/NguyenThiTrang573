﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace NguyenThiTrang573.Migrations
{
    [DbContext(typeof(MvcMovieContext))]
    partial class MvcMovieContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.10");

            modelBuilder.Entity("NguyenThiTrang573.Models.NTT0573", b =>
                {
                    b.Property<int>("NTTId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("NTTGender")
                        .HasColumnType("TEXT");

                    b.Property<string>("NTTName")
                        .HasColumnType("TEXT");

                    b.HasKey("NTTId");

                    b.ToTable("NTT0573");
                });

            modelBuilder.Entity("NguyenThiTrang573.Models.PersionNTT573", b =>
                {
                    b.Property<int>("PersionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("PersionName")
                        .HasColumnType("TEXT");

                    b.HasKey("PersionId");

                    b.ToTable("PersionNTT573");
                });
#pragma warning restore 612, 618
        }
    }
}
