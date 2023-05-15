﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace backend_pet_travel_guide.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230507080427_nume")]
    partial class nume
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Invitation", b =>
                {
                    b.Property<int>("InvitationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("InvitationId"));

                    b.Property<int?>("CreatedById")
                        .HasColumnType("integer");

                    b.Property<string>("InvitationCode")
                        .HasColumnType("text");

                    b.HasKey("InvitationId");

                    b.HasIndex("CreatedById");

                    b.ToTable("Invitations");
                });

            modelBuilder.Entity("Location", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("Category")
                        .HasColumnType("text")
                        .HasColumnName("category");

                    b.Property<string>("city")
                        .HasColumnType("text");

                    b.Property<string>("country")
                        .HasColumnType("text");

                    b.Property<string>("county")
                        .HasColumnType("text")
                        .HasColumnName("county");

                    b.Property<string>("filename")
                        .HasColumnType("text");

                    b.Property<int>("fivestar")
                        .HasColumnType("integer");

                    b.Property<int>("fourstar")
                        .HasColumnType("integer");

                    b.Property<string>("ispetfriendly")
                        .HasColumnType("text");

                    b.Property<decimal>("latitude")
                        .HasColumnType("numeric");

                    b.Property<decimal>("longitude")
                        .HasColumnType("numeric");

                    b.Property<string>("name")
                        .HasColumnType("text");

                    b.Property<int>("onestar")
                        .HasColumnType("integer");

                    b.Property<string>("phone")
                        .HasColumnType("text");

                    b.Property<string>("postalcode")
                        .HasColumnType("text");

                    b.Property<decimal>("rating")
                        .HasColumnType("numeric");

                    b.Property<string>("street")
                        .HasColumnType("text");

                    b.Property<string>("streetnumber")
                        .HasColumnType("text");

                    b.Property<int>("threestar")
                        .HasColumnType("integer");

                    b.Property<int>("twostar")
                        .HasColumnType("integer");

                    b.Property<int>("userratingstotal")
                        .HasColumnType("integer");

                    b.Property<string>("website")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("locations");
                });

            modelBuilder.Entity("Pet", b =>
                {
                    b.Property<int>("PetId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("PetId"));

                    b.Property<DateTime>("AddedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Age")
                        .HasColumnType("integer");

                    b.Property<string>("Color")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Species")
                        .HasColumnType("text");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("PetId");

                    b.HasIndex("UserId");

                    b.ToTable("Pets");
                });

            modelBuilder.Entity("Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("RoleId"));

                    b.Property<string>("RoleName")
                        .HasColumnType("text");

                    b.HasKey("RoleId");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            RoleId = 1,
                            RoleName = "Admin"
                        },
                        new
                        {
                            RoleId = 2,
                            RoleName = "User"
                        },
                        new
                        {
                            RoleId = 3,
                            RoleName = "Moderator"
                        });
                });

            modelBuilder.Entity("User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("UserId"));

                    b.Property<DateTime>("AddedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("EditedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsModerator")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsUser")
                        .HasColumnType("boolean");

                    b.Property<string>("NrTelefon")
                        .HasColumnType("text");

                    b.Property<string>("Nume")
                        .HasColumnType("text");

                    b.Property<string>("Parola")
                        .HasColumnType("text");

                    b.Property<string>("PasswordResetCode")
                        .HasColumnType("text");

                    b.Property<DateTime?>("PasswordResetCodeExpirationDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Prenume")
                        .HasColumnType("text");

                    b.HasKey("UserId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            AddedAt = new DateTime(2023, 5, 7, 8, 4, 27, 655, DateTimeKind.Utc).AddTicks(8370),
                            Email = "admin@example.com",
                            IsAdmin = true,
                            IsModerator = false,
                            IsUser = false,
                            NrTelefon = "123456789",
                            Nume = "Admin",
                            Parola = "5e884898da28047151d0e56f8dc6292773603d0d6aabbdd62a11ef721d1542d8",
                            Prenume = "Admin"
                        });
                });

            modelBuilder.Entity("UserInvitation", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.Property<int>("InvitationId")
                        .HasColumnType("integer");

                    b.HasKey("UserId", "InvitationId");

                    b.HasIndex("InvitationId");

                    b.ToTable("UserInvitations");
                });

            modelBuilder.Entity("UserRole", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.Property<int>("RoleId")
                        .HasColumnType("integer");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            RoleId = 1
                        });
                });

            modelBuilder.Entity("Invitation", b =>
                {
                    b.HasOne("User", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedById");

                    b.Navigation("CreatedBy");
                });

            modelBuilder.Entity("Pet", b =>
                {
                    b.HasOne("User", "User")
                        .WithMany("Pets")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("UserInvitation", b =>
                {
                    b.HasOne("Invitation", "Invitation")
                        .WithMany("UserInvitations")
                        .HasForeignKey("InvitationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("User", "User")
                        .WithMany("UserInvitations")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Invitation");

                    b.Navigation("User");
                });

            modelBuilder.Entity("UserRole", b =>
                {
                    b.HasOne("Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Invitation", b =>
                {
                    b.Navigation("UserInvitations");
                });

            modelBuilder.Entity("Role", b =>
                {
                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("User", b =>
                {
                    b.Navigation("Pets");

                    b.Navigation("UserInvitations");

                    b.Navigation("UserRoles");
                });
#pragma warning restore 612, 618
        }
    }
}
