// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace NguyenThiTrang573.Migrations
{
    [DbContext(typeof(MvcMovieContext))]
    [Migration("20211006005401_PersionNTT573")]
    partial class PersionNTT573
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.10");

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
