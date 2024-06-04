using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace boba_API.Migrations
{
    /// <inheritdoc />
    public partial class Versionbeta11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Calendar_Status_dictionary_StatusId1",
                table: "Calendar");

            migrationBuilder.DropForeignKey(
                name: "FK_Mechaniks_WorkTypes_TypeId1",
                table: "Mechaniks");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Clients_ClientId1",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Status_dictionary_StatusId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_ClientId1",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Mechaniks_TypeId1",
                table: "Mechaniks");

            migrationBuilder.DropIndex(
                name: "IX_Calendar_StatusId1",
                table: "Calendar");

            migrationBuilder.DropColumn(
                name: "ClientId1",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "TypeId1",
                table: "Mechaniks");

            migrationBuilder.DropColumn(
                name: "StatusId1",
                table: "Calendar");

            migrationBuilder.RenameColumn(
                name: "booking_date",
                table: "Calendar",
                newName: "BookingDate");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "WorkTypes",
                type: "char(36)",
                nullable: false,
                collation: "ascii_general_ci",
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Status_dictionary",
                type: "char(36)",
                nullable: false,
                collation: "ascii_general_ci",
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<Guid>(
                name: "StatusId",
                table: "Orders",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<Guid>(
                name: "MechanicId",
                table: "Orders",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ClientId",
                table: "Orders",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ClientId",
                table: "Orders",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Mechaniks_TypeId",
                table: "Mechaniks",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Calendar_StatusId",
                table: "Calendar",
                column: "StatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Calendar_Status_dictionary_StatusId",
                table: "Calendar",
                column: "StatusId",
                principalTable: "Status_dictionary",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Mechaniks_WorkTypes_TypeId",
                table: "Mechaniks",
                column: "TypeId",
                principalTable: "WorkTypes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Clients_ClientId",
                table: "Orders",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Status_dictionary_StatusId",
                table: "Orders",
                column: "StatusId",
                principalTable: "Status_dictionary",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Calendar_Status_dictionary_StatusId",
                table: "Calendar");

            migrationBuilder.DropForeignKey(
                name: "FK_Mechaniks_WorkTypes_TypeId",
                table: "Mechaniks");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Clients_ClientId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Status_dictionary_StatusId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_ClientId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Mechaniks_TypeId",
                table: "Mechaniks");

            migrationBuilder.DropIndex(
                name: "IX_Calendar_StatusId",
                table: "Calendar");

            migrationBuilder.RenameColumn(
                name: "BookingDate",
                table: "Calendar",
                newName: "booking_date");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "WorkTypes",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "char(36)")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .OldAnnotation("Relational:Collation", "ascii_general_ci");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Status_dictionary",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "char(36)")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .OldAnnotation("Relational:Collation", "ascii_general_ci");

            migrationBuilder.AlterColumn<int>(
                name: "StatusId",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(Guid),
                oldType: "char(36)",
                oldNullable: true)
                .OldAnnotation("Relational:Collation", "ascii_general_ci");

            migrationBuilder.AlterColumn<int>(
                name: "MechanicId",
                table: "Orders",
                type: "int",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "char(36)",
                oldNullable: true)
                .OldAnnotation("Relational:Collation", "ascii_general_ci");

            migrationBuilder.AlterColumn<int>(
                name: "ClientId",
                table: "Orders",
                type: "int",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "char(36)",
                oldNullable: true)
                .OldAnnotation("Relational:Collation", "ascii_general_ci");

            migrationBuilder.AddColumn<Guid>(
                name: "ClientId1",
                table: "Orders",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                collation: "ascii_general_ci");

            migrationBuilder.AddColumn<int>(
                name: "TypeId1",
                table: "Mechaniks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StatusId1",
                table: "Calendar",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ClientId1",
                table: "Orders",
                column: "ClientId1");

            migrationBuilder.CreateIndex(
                name: "IX_Mechaniks_TypeId1",
                table: "Mechaniks",
                column: "TypeId1");

            migrationBuilder.CreateIndex(
                name: "IX_Calendar_StatusId1",
                table: "Calendar",
                column: "StatusId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Calendar_Status_dictionary_StatusId1",
                table: "Calendar",
                column: "StatusId1",
                principalTable: "Status_dictionary",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Mechaniks_WorkTypes_TypeId1",
                table: "Mechaniks",
                column: "TypeId1",
                principalTable: "WorkTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Clients_ClientId1",
                table: "Orders",
                column: "ClientId1",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Status_dictionary_StatusId",
                table: "Orders",
                column: "StatusId",
                principalTable: "Status_dictionary",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
