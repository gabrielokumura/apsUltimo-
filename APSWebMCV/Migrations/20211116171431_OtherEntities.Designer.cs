// <auto-generated />
using System;
using APSWebMCV.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace APSWebMCV.Migrations
{
    [DbContext(typeof(APSWebMCVContext))]
    [Migration("20211116171431_OtherEntities")]
    partial class OtherEntities
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("APSWebMCV.Models.Assessment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<float>("FinalExamNote");

                    b.Property<int>("Frequency");

                    b.Property<float>("Note1");

                    b.Property<float>("Note2");

                    b.Property<int?>("ProfessorId");

                    b.HasKey("Id");

                    b.HasIndex("ProfessorId");

                    b.ToTable("Assessment");
                });

            modelBuilder.Entity("APSWebMCV.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Department");
                });

            modelBuilder.Entity("APSWebMCV.Models.Professor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Adm");

                    b.Property<string>("Adress");

                    b.Property<int?>("DepartmentId");

                    b.Property<string>("Name");

                    b.Property<string>("Phonenumber");

                    b.Property<string>("Titulation");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Professor");
                });

            modelBuilder.Entity("APSWebMCV.Models.Assessment", b =>
                {
                    b.HasOne("APSWebMCV.Models.Professor", "Professor")
                        .WithMany("Assessments")
                        .HasForeignKey("ProfessorId");
                });

            modelBuilder.Entity("APSWebMCV.Models.Professor", b =>
                {
                    b.HasOne("APSWebMCV.Models.Department", "Department")
                        .WithMany("Professors")
                        .HasForeignKey("DepartmentId");
                });
#pragma warning restore 612, 618
        }
    }
}
