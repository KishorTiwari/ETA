using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using ETA.Data.DAL;

namespace ETA.Data.Migrations
{
    [DbContext(typeof(ETAContext))]
    [Migration("20170410080228_intial")]
    partial class intial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ETA.Data.Models.Group", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateCreated");

                    b.Property<string>("GroupName")
                        .HasMaxLength(50);

                    b.Property<bool>("IsActive");

                    b.HasKey("Id");

                    b.ToTable("Group");
                });

            modelBuilder.Entity("ETA.Data.Models.Group_User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("GroupId");

                    b.Property<bool>("IsAdmin");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.HasIndex("UserId");

                    b.ToTable("Group_User");
                });

            modelBuilder.Entity("ETA.Data.Models.Transaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateOfEntry");

                    b.Property<DateTime>("DateOfPurchase");

                    b.Property<string>("Description")
                        .HasMaxLength(255);

                    b.Property<double>("Price");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Transaction");
                });

            modelBuilder.Entity("ETA.Data.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CurrentPassword");

                    b.Property<DateTime>("DateCreated");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<int?>("GroupId");

                    b.Property<bool>("IsActive");

                    b.Property<string>("LastName");

                    b.Property<string>("OldPassword");

                    b.Property<DateTime>("PasswordModified");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("ETA.Data.Models.Group_User", b =>
                {
                    b.HasOne("ETA.Data.Models.Group", "Group")
                        .WithMany()
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ETA.Data.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ETA.Data.Models.Transaction", b =>
                {
                    b.HasOne("ETA.Data.Models.User", "User")
                        .WithMany("Transactions")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ETA.Data.Models.User", b =>
                {
                    b.HasOne("ETA.Data.Models.Group", "Group")
                        .WithMany("Users")
                        .HasForeignKey("GroupId");
                });
        }
    }
}
