﻿// <auto-generated />
using System;
using LearningApp.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace WSBLearn.Dal.Migrations
{
    [DbContext(typeof(LearningAppDbContext))]
    [Migration("20230616195254_UpdateCategoryAndQuestionInheritUserContent")]
    partial class UpdateCategoryAndQuestionInheritUserContent
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AchievementUserProgress", b =>
                {
                    b.Property<int>("AchievementsId")
                        .HasColumnType("int");

                    b.Property<int>("UserProgressesId")
                        .HasColumnType("int");

                    b.HasKey("AchievementsId", "UserProgressesId");

                    b.HasIndex("UserProgressesId");

                    b.ToTable("AchievementUserProgress");
                });

            modelBuilder.Entity("CategoryCategoryGroup", b =>
                {
                    b.Property<int>("CategoriesId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryGroupsId")
                        .HasColumnType("int");

                    b.HasKey("CategoriesId", "CategoryGroupsId");

                    b.HasIndex("CategoryGroupsId");

                    b.ToTable("CategoryCategoryGroup");
                });

            modelBuilder.Entity("LearningApp.Domain.Entities.Achievement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Achievements");
                });

            modelBuilder.Entity("LearningApp.Domain.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CreatorId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IconUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(400)
                        .HasColumnType("nvarchar(400)");

                    b.Property<int>("QuestionsPerQuiz")
                        .HasColumnType("int");

                    b.Property<int>("QuizPerLevel")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("LearningApp.Domain.Entities.CategoryGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("IconUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(400)
                        .HasColumnType("nvarchar(400)");

                    b.HasKey("Id");

                    b.ToTable("CategoryGroups");
                });

            modelBuilder.Entity("LearningApp.Domain.Entities.CategoryProgress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("CategoryCompleted")
                        .HasColumnType("bit");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserProgressId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserProgressId");

                    b.ToTable("CategoryProgresses");
                });

            modelBuilder.Entity("LearningApp.Domain.Entities.LevelProgress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryProgressId")
                        .HasColumnType("int");

                    b.Property<int>("FinishedQuiz")
                        .HasColumnType("int");

                    b.Property<bool>("LevelCompleted")
                        .HasColumnType("bit");

                    b.Property<string>("LevelName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QuizToFinish")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryProgressId");

                    b.ToTable("LevelProgresses");
                });

            modelBuilder.Entity("LearningApp.Domain.Entities.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("A")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("B")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("C")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("CorrectAnswer")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<int?>("CreatorId")
                        .HasColumnType("int");

                    b.Property<string>("D")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<string>("QuestionContent")
                        .IsRequired()
                        .HasMaxLength(400)
                        .HasColumnType("nvarchar(400)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("LearningApp.Domain.Entities.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Admin"
                        },
                        new
                        {
                            Id = 2,
                            Name = "User"
                        });
                });

            modelBuilder.Entity("LearningApp.Domain.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfilePictureUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<int>("UserProgressId")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("LearningApp.Domain.Entities.UserProgress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ExperiencePoints")
                        .HasColumnType("int");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<int>("TotalCompletedCategory")
                        .HasColumnType("int");

                    b.Property<int>("TotalCompletedQuiz")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("UserProgresses");
                });

            modelBuilder.Entity("AchievementUserProgress", b =>
                {
                    b.HasOne("LearningApp.Domain.Entities.Achievement", null)
                        .WithMany()
                        .HasForeignKey("AchievementsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LearningApp.Domain.Entities.UserProgress", null)
                        .WithMany()
                        .HasForeignKey("UserProgressesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CategoryCategoryGroup", b =>
                {
                    b.HasOne("LearningApp.Domain.Entities.Category", null)
                        .WithMany()
                        .HasForeignKey("CategoriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LearningApp.Domain.Entities.CategoryGroup", null)
                        .WithMany()
                        .HasForeignKey("CategoryGroupsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LearningApp.Domain.Entities.CategoryProgress", b =>
                {
                    b.HasOne("LearningApp.Domain.Entities.UserProgress", "UserProgress")
                        .WithMany("CategoryProgress")
                        .HasForeignKey("UserProgressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserProgress");
                });

            modelBuilder.Entity("LearningApp.Domain.Entities.LevelProgress", b =>
                {
                    b.HasOne("LearningApp.Domain.Entities.CategoryProgress", "CategoryProgress")
                        .WithMany("LevelProgresses")
                        .HasForeignKey("CategoryProgressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CategoryProgress");
                });

            modelBuilder.Entity("LearningApp.Domain.Entities.Question", b =>
                {
                    b.HasOne("LearningApp.Domain.Entities.Category", "Category")
                        .WithMany("Questions")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("LearningApp.Domain.Entities.User", b =>
                {
                    b.HasOne("LearningApp.Domain.Entities.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("LearningApp.Domain.Entities.UserProgress", b =>
                {
                    b.HasOne("LearningApp.Domain.Entities.User", "User")
                        .WithOne("UserProgress")
                        .HasForeignKey("LearningApp.Domain.Entities.UserProgress", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("LearningApp.Domain.Entities.Category", b =>
                {
                    b.Navigation("Questions");
                });

            modelBuilder.Entity("LearningApp.Domain.Entities.CategoryProgress", b =>
                {
                    b.Navigation("LevelProgresses");
                });

            modelBuilder.Entity("LearningApp.Domain.Entities.User", b =>
                {
                    b.Navigation("UserProgress");
                });

            modelBuilder.Entity("LearningApp.Domain.Entities.UserProgress", b =>
                {
                    b.Navigation("CategoryProgress");
                });
#pragma warning restore 612, 618
        }
    }
}
