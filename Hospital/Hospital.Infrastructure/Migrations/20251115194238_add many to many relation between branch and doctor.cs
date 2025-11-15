using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hospital.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addmanytomanyrelationbetweenbranchanddoctor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_Branches_BranchId",
                table: "Doctors");

            migrationBuilder.DropIndex(
                name: "IX_Doctors_BranchId",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "BranchId",
                table: "Doctors");

            migrationBuilder.CreateTable(
                name: "DoctorBranches",
                columns: table => new
                {
                    BranchesBranchId = table.Column<int>(type: "int", nullable: false),
                    DoctorsDoctorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoctorBranches", x => new { x.BranchesBranchId, x.DoctorsDoctorId });
                    table.ForeignKey(
                        name: "FK_DoctorBranches_Branches_BranchesBranchId",
                        column: x => x.BranchesBranchId,
                        principalTable: "Branches",
                        principalColumn: "BranchId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DoctorBranches_Doctors_DoctorsDoctorId",
                        column: x => x.DoctorsDoctorId,
                        principalTable: "Doctors",
                        principalColumn: "DoctorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DoctorBranches_DoctorsDoctorId",
                table: "DoctorBranches",
                column: "DoctorsDoctorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DoctorBranches");

            migrationBuilder.AddColumn<int>(
                name: "BranchId",
                table: "Doctors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_BranchId",
                table: "Doctors",
                column: "BranchId");

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_Branches_BranchId",
                table: "Doctors",
                column: "BranchId",
                principalTable: "Branches",
                principalColumn: "BranchId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
