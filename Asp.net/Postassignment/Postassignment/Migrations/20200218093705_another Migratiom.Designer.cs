﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Postassignment.Models;

namespace Postassignment.Migrations
{
    [DbContext(typeof(Appdbcontext))]
    [Migration("20200218093705_another Migratiom")]
    partial class anotherMigratiom
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Postassignment.Models.post", b =>
                {
                    b.Property<int>("p_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("p_content")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("p_id");

                    b.ToTable("posttable");
                });
#pragma warning restore 612, 618
        }
    }
}
