﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using ShtikLive.Questions.Data;
using System;

namespace ShtikLive.Questions.Migrate.Migrations
{
    [DbContext(typeof(QuestionContext))]
    partial class QuestionContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452");

            modelBuilder.Entity("ShtikLive.Questions.Data.Answer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("QuestionId");

                    b.Property<string>("Text");

                    b.Property<DateTimeOffset>("Time");

                    b.Property<string>("User")
                        .HasMaxLength(16);

                    b.HasKey("Id");

                    b.HasIndex("QuestionId");

                    b.ToTable("Answers");
                });

            modelBuilder.Entity("ShtikLive.Questions.Data.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Show")
                        .HasMaxLength(256);

                    b.Property<int>("Slide");

                    b.Property<string>("Text");

                    b.Property<DateTimeOffset>("Time");

                    b.Property<string>("User")
                        .HasMaxLength(16);

                    b.Property<string>("Uuid")
                        .HasMaxLength(40);

                    b.HasKey("Id");

                    b.HasIndex("Show");

                    b.HasIndex("Uuid")
                        .IsUnique();

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("ShtikLive.Questions.Data.Answer", b =>
                {
                    b.HasOne("ShtikLive.Questions.Data.Question", "Question")
                        .WithMany("Answers")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
