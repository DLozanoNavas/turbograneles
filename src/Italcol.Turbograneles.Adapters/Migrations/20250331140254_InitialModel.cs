using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Italcol.Turbograneles.Adapters.Migrations
{
    /// <inheritdoc />
    public partial class InitialModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppointmentStatus",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    CreateDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedByUserId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppointmentStatus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppointmentStatus_AspNetUsers_CreatedByUserId",
                        column: x => x.CreatedByUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Driver",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Driver", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Truck",
                columns: table => new
                {
                    Plate = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Truck", x => x.Plate);
                });

            migrationBuilder.CreateTable(
                name: "VoyageStatus",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    CreateDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedByUserId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VoyageStatus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VoyageStatus_AspNetUsers_CreatedByUserId",
                        column: x => x.CreatedByUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Voyage",
                columns: table => new
                {
                    VoyageId = table.Column<string>(type: "text", nullable: false),
                    VesselName = table.Column<string>(type: "text", nullable: false),
                    Eta = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Etd = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    BlNumber = table.Column<string>(type: "text", nullable: false),
                    Customer = table.Column<string>(type: "text", nullable: false),
                    Product = table.Column<string>(type: "text", nullable: false),
                    WeightBlStart = table.Column<long>(type: "bigint", nullable: false),
                    WeightBlEnd = table.Column<long>(type: "bigint", nullable: false),
                    StatusId = table.Column<string>(type: "text", nullable: false),
                    CreatedByUserId = table.Column<string>(type: "text", nullable: false),
                    UpdatedByUserId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Voyage", x => x.VoyageId);
                    table.ForeignKey(
                        name: "FK_Voyage_AspNetUsers_CreatedByUserId",
                        column: x => x.CreatedByUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Voyage_AspNetUsers_UpdatedByUserId",
                        column: x => x.UpdatedByUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Voyage_VoyageStatus_StatusId",
                        column: x => x.StatusId,
                        principalTable: "VoyageStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TruckAppointment",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    BlNumber = table.Column<string>(type: "text", nullable: false),
                    ProductId = table.Column<string>(type: "text", nullable: false),
                    MaxWeightPermitted = table.Column<long>(type: "bigint", nullable: false),
                    WeightRequired = table.Column<long>(type: "bigint", nullable: false),
                    ArriveWeight = table.Column<long>(type: "bigint", nullable: false),
                    CargoWeight = table.Column<long>(type: "bigint", nullable: false),
                    TruckGrossWeight = table.Column<long>(type: "bigint", nullable: false),
                    DestinationCode = table.Column<int>(type: "integer", nullable: false),
                    WeightingBridgeId = table.Column<int>(type: "integer", nullable: false),
                    TruckTransactionId = table.Column<int>(type: "integer", nullable: false),
                    TransportId = table.Column<string>(type: "text", nullable: false),
                    StartDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EndDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedAtDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAtDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ArriveDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DepartureDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    StatusId = table.Column<string>(type: "text", nullable: false),
                    DriverId = table.Column<string>(type: "text", nullable: false),
                    TruckId = table.Column<string>(type: "text", nullable: false),
                    VoyageId = table.Column<string>(type: "text", nullable: false),
                    CreatedByUserId = table.Column<string>(type: "text", nullable: false),
                    UpdatedByUserId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TruckAppointment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TruckAppointment_AppointmentStatus_StatusId",
                        column: x => x.StatusId,
                        principalTable: "AppointmentStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TruckAppointment_AspNetUsers_CreatedByUserId",
                        column: x => x.CreatedByUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TruckAppointment_AspNetUsers_UpdatedByUserId",
                        column: x => x.UpdatedByUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TruckAppointment_Driver_DriverId",
                        column: x => x.DriverId,
                        principalTable: "Driver",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TruckAppointment_Truck_TruckId",
                        column: x => x.TruckId,
                        principalTable: "Truck",
                        principalColumn: "Plate",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TruckAppointment_Voyage_VoyageId",
                        column: x => x.VoyageId,
                        principalTable: "Voyage",
                        principalColumn: "VoyageId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WeighingRecord",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    WeighingPitId = table.Column<int>(type: "integer", nullable: false),
                    Weight = table.Column<long>(type: "bigint", nullable: false),
                    VoyageId = table.Column<string>(type: "text", nullable: false),
                    DateTimeEnd = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedByUserId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeighingRecord", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WeighingRecord_AspNetUsers_CreatedByUserId",
                        column: x => x.CreatedByUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WeighingRecord_Voyage_VoyageId",
                        column: x => x.VoyageId,
                        principalTable: "Voyage",
                        principalColumn: "VoyageId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AppointmentStatus_CreatedByUserId",
                table: "AppointmentStatus",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_TruckAppointment_CreatedByUserId",
                table: "TruckAppointment",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_TruckAppointment_DriverId",
                table: "TruckAppointment",
                column: "DriverId");

            migrationBuilder.CreateIndex(
                name: "IX_TruckAppointment_StatusId",
                table: "TruckAppointment",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_TruckAppointment_TruckId",
                table: "TruckAppointment",
                column: "TruckId");

            migrationBuilder.CreateIndex(
                name: "IX_TruckAppointment_UpdatedByUserId",
                table: "TruckAppointment",
                column: "UpdatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_TruckAppointment_VoyageId",
                table: "TruckAppointment",
                column: "VoyageId");

            migrationBuilder.CreateIndex(
                name: "IX_Voyage_CreatedByUserId",
                table: "Voyage",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Voyage_StatusId",
                table: "Voyage",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Voyage_UpdatedByUserId",
                table: "Voyage",
                column: "UpdatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_VoyageStatus_CreatedByUserId",
                table: "VoyageStatus",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_WeighingRecord_CreatedByUserId",
                table: "WeighingRecord",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_WeighingRecord_VoyageId",
                table: "WeighingRecord",
                column: "VoyageId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TruckAppointment");

            migrationBuilder.DropTable(
                name: "WeighingRecord");

            migrationBuilder.DropTable(
                name: "AppointmentStatus");

            migrationBuilder.DropTable(
                name: "Driver");

            migrationBuilder.DropTable(
                name: "Truck");

            migrationBuilder.DropTable(
                name: "Voyage");

            migrationBuilder.DropTable(
                name: "VoyageStatus");
        }
    }
}
