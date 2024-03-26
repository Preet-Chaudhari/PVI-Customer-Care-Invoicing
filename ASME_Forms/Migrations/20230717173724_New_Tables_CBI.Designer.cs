﻿// <auto-generated />
using System;
using ASME_Forms.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ASME_Forms.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230717173724_New_Tables_CBI")]
    partial class New_Tables_CBI
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0-preview.5.23280.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ASME_Forms.Models.ASME_CBI", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("AI_HYDRO_TEST_DATE")
                        .HasColumnType("datetime2");

                    b.Property<int?>("AI_HYDRO_TEST_WELDER")
                        .HasColumnType("int");

                    b.Property<string>("ATTACHMENTS_LOT_NUMBER")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ATTACHMENTS_MFG")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ATTACHMENTS_WELDER")
                        .HasColumnType("int");

                    b.Property<string>("BASE_CLEAT_MFG")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("BASE_CLEAT_WELDER")
                        .HasColumnType("int");

                    b.Property<string>("BASIC_TANK_NUMBER")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BOTTOM_HEAD_MFG")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("BOTTOM_HEAD_WELDER")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CAPTURE_DATE")
                        .HasColumnType("datetime2");

                    b.Property<string>("CHAMBER_HEAD_MFG")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CHAMBER_HEAD_WELDER")
                        .HasColumnType("int");

                    b.Property<string>("CHAMBER_SHELL_MFG")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CHAMBER_SHELL_WELDER")
                        .HasColumnType("int");

                    b.Property<string>("CONDENSATE_PAN_MFG")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CONDENSATE_PAN_WELDER")
                        .HasColumnType("int");

                    b.Property<string>("DESCRIPTION")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DWG_NUMBER")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EMP_NUMBER")
                        .HasColumnType("int");

                    b.Property<string>("ERW_STUD_MFG")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ERW_STUD_WELDER")
                        .HasColumnType("int");

                    b.Property<string>("FLUE_ASSEMBLY_MFG")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("FLUE_ASSEMBLY_WELDER")
                        .HasColumnType("int");

                    b.Property<string>("HX_NUMBER")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("JOB_TRAVELER_NUMBER")
                        .HasColumnType("int");

                    b.Property<string>("JOGGLE_MFG")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("JOGGLE_WELDER")
                        .HasColumnType("int");

                    b.Property<string>("LONGSEAM_WELD_MFG")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("LONGSEAM_WELD_WELDER")
                        .HasColumnType("int");

                    b.Property<DateTime?>("MFG_FINAL_INSP_DATE")
                        .HasColumnType("datetime2");

                    b.Property<int?>("MFG_FINAL_INSP_WELDER")
                        .HasColumnType("int");

                    b.Property<DateTime?>("MFG_HYDRO_TEST_DATE")
                        .HasColumnType("datetime2");

                    b.Property<int?>("MFG_HYDRO_TEST_WELDER")
                        .HasColumnType("int");

                    b.Property<DateTime?>("MFG_NATL_BD_NUMBER_DATE")
                        .HasColumnType("datetime2");

                    b.Property<int?>("MFG_NATL_BD_NUMBER_WELDER")
                        .HasColumnType("int");

                    b.Property<string>("MVP_NUMBER")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NATL_BD_NUMBER")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PART_NUMBER")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PLATE_ROLLS_LOT_NUMBER_1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PLATE_ROLLS_LOT_NUMBER_2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PLATE_ROLLS_MFG_1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PLATE_ROLLS_MFG_2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PLATE_ROLLS_WELDER_1")
                        .HasColumnType("int");

                    b.Property<int?>("PLATE_ROLLS_WELDER_2")
                        .HasColumnType("int");

                    b.Property<byte[]>("PRODUCT_NUMBER")
                        .HasColumnType("varbinary(max)");

                    b.Property<DateTime?>("QA_HYDRO_TEST_DATE")
                        .HasColumnType("datetime2");

                    b.Property<int?>("QA_HYDRO_TEST_GAUGE")
                        .HasColumnType("int");

                    b.Property<int?>("QA_HYDRO_TEST_PSI")
                        .HasColumnType("int");

                    b.Property<int?>("QA_HYDRO_TEST_WELDER")
                        .HasColumnType("int");

                    b.Property<DateTime?>("QA_NATL_BD_NUMBER_DATE")
                        .HasColumnType("datetime2");

                    b.Property<int?>("QA_NATL_BD_NUMBER_WELDER")
                        .HasColumnType("int");

                    b.Property<string>("TOP_HEAD_LOT_NUMBER")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TOP_HEAD_MFG")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TOP_HEAD_WELDER")
                        .HasColumnType("int");

                    b.Property<string>("TUBE_VERIFICATION_HX_INSTALLATION_MFG")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TUBE_VERIFICATION_HX_INSTALLATION_WELDER")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ASME_CBI");
                });

            modelBuilder.Entity("ASME_Forms.Models.ASME_CBI_HX", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("BOTTOM_HEAD_FITUP_EMP_NUMBER")
                        .HasColumnType("int");

                    b.Property<string>("BOTTOM_HEAD_PVI_LOT_MFG")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BOTTOM_HEAD_PVI_LOT_NUMBER")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CBI_HX_NOTES")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CHAMBER_HEAD_FITUP_EMP_NUMBER")
                        .HasColumnType("int");

                    b.Property<string>("CHAMBER_HEAD_MFG")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CHAMBER_SHELL_FITUP_EMP_NUMBER")
                        .HasColumnType("int");

                    b.Property<string>("CHAMBER_SHELL_PVI_LOT_NUMBER")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CHAMBER_SHELL_PVI_MFG")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CHAMBER_SHELL_WELD_ID")
                        .HasColumnType("int");

                    b.Property<string>("CHAMER_HEAD_PVI_LOT_NUMBER")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DESCRIPTION_HX")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DWG_NUMBER_HX")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HX_NUMBER_HX")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("JOB_TRAVELER_NUMBER_HX")
                        .HasColumnType("int");

                    b.Property<string>("MVP_NUMBER_HX")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PART_NUMBER_HX")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("QA_FINAL_INSP_DATE")
                        .HasColumnType("datetime2");

                    b.Property<int?>("QA_FINAL_INSP_FITUP_EMP_NUMBER")
                        .HasColumnType("int");

                    b.Property<int?>("ROBOT_TUBE_WELD_FITUP_EMP_NUMBER")
                        .HasColumnType("int");

                    b.Property<string>("ROBOT_TUBE_WELD_MFG")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ROBOT_TUBE_WELD_WELD_ID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TUBE_INSTALL_FITUP_EMP_NUMBER")
                        .HasColumnType("int");

                    b.Property<string>("TUBE_INSTALL_MFG")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TUBE_ROLL_FITUP_EMP_NUMBER")
                        .HasColumnType("int");

                    b.Property<string>("TUBE_ROLL_MFG")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TUBE_TACK_WELD_FITUP_EMP_NUMBER")
                        .HasColumnType("int");

                    b.Property<string>("TUBE_TACK_WELD_MFG")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TUBE_VERIFICATION_1_FITUP_EMP_NUMBER")
                        .HasColumnType("int");

                    b.Property<string>("TUBE_VERIFICATION_1_MFG")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TUBE_VERIFICATION_2_FITUP_EMP_NUMBER")
                        .HasColumnType("int");

                    b.Property<string>("TUBE_VERIFICATION_2_MFG")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ASME_CBI_HX");
                });
#pragma warning restore 612, 618
        }
    }
}
