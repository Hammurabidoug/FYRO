using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FYRO.Data.SqlServer.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Competitions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Scope = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Competitions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DufferCondos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CondoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DufferCondos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DufferEntityEventEntity",
                columns: table => new
                {
                    DuffersId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EventsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DufferEntityEventEntity", x => new { x.DuffersId, x.EventsId });
                });

            migrationBuilder.CreateTable(
                name: "Duffers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CondoEntityId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AddressId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Duffers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EventLodgings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EventId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LodgingId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventLodgings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AddressEntity",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Address1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    County = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LodgingId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    EventLodgingEntityId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Latitude = table.Column<double>(type: "float", nullable: true),
                    Longitude = table.Column<double>(type: "float", nullable: true),
                    Number = table.Column<int>(type: "int", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EventEntity_LodgingId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddressEntity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AddressEntity_AddressEntity_EventEntity_LodgingId",
                        column: x => x.EventEntity_LodgingId,
                        principalTable: "AddressEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AddressEntity_AddressEntity_LodgingId",
                        column: x => x.LodgingId,
                        principalTable: "AddressEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AddressEntity_EventLodgings_EventLodgingEntityId",
                        column: x => x.EventLodgingEntityId,
                        principalTable: "EventLodgings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Golfs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CourseId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    EventId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    WinnerId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AddressId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Golfs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Golfs_AddressEntity_AddressId",
                        column: x => x.AddressId,
                        principalTable: "AddressEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Golfs_AddressEntity_CourseId",
                        column: x => x.CourseId,
                        principalTable: "AddressEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Golfs_AddressEntity_EventId",
                        column: x => x.EventId,
                        principalTable: "AddressEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Holes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GolfId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Number = table.Column<int>(type: "int", nullable: false),
                    Par = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Holes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Holes_Golfs_GolfId",
                        column: x => x.GolfId,
                        principalTable: "Golfs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pairings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Order = table.Column<int>(type: "int", nullable: false),
                    GolfId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pairings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pairings_Golfs_GolfId",
                        column: x => x.GolfId,
                        principalTable: "Golfs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DufferEntityPairingEntity",
                columns: table => new
                {
                    DuffersId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PairingsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DufferEntityPairingEntity", x => new { x.DuffersId, x.PairingsId });
                    table.ForeignKey(
                        name: "FK_DufferEntityPairingEntity_Duffers_DuffersId",
                        column: x => x.DuffersId,
                        principalTable: "Duffers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DufferEntityPairingEntity_Pairings_PairingsId",
                        column: x => x.PairingsId,
                        principalTable: "Pairings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HoleScores",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PairingId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Score = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoleScores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HoleScores_Pairings_PairingId",
                        column: x => x.PairingId,
                        principalTable: "Pairings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PairingAwards",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PairingId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CompetitionEntityId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DufferEntityId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PairingAwards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PairingAwards_Competitions_CompetitionEntityId",
                        column: x => x.CompetitionEntityId,
                        principalTable: "Competitions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PairingAwards_Duffers_DufferEntityId",
                        column: x => x.DufferEntityId,
                        principalTable: "Duffers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PairingAwards_Pairings_PairingId",
                        column: x => x.PairingId,
                        principalTable: "Pairings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GolfAwards",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GolfId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PairingAwardId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GolfAwards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GolfAwards_Golfs_GolfId",
                        column: x => x.GolfId,
                        principalTable: "Golfs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GolfAwards_PairingAwards_PairingAwardId",
                        column: x => x.PairingAwardId,
                        principalTable: "PairingAwards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "IndividualAwards",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DufferId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CompetitionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    EventEntityId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    GolfAwardEntityId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IndividualAwards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IndividualAwards_AddressEntity_EventEntityId",
                        column: x => x.EventEntityId,
                        principalTable: "AddressEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IndividualAwards_Competitions_CompetitionId",
                        column: x => x.CompetitionId,
                        principalTable: "Competitions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IndividualAwards_Duffers_DufferId",
                        column: x => x.DufferId,
                        principalTable: "Duffers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IndividualAwards_GolfAwards_GolfAwardEntityId",
                        column: x => x.GolfAwardEntityId,
                        principalTable: "GolfAwards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AddressEntity_EventEntity_LodgingId",
                table: "AddressEntity",
                column: "EventEntity_LodgingId");

            migrationBuilder.CreateIndex(
                name: "IX_AddressEntity_EventLodgingEntityId",
                table: "AddressEntity",
                column: "EventLodgingEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_AddressEntity_LodgingId",
                table: "AddressEntity",
                column: "LodgingId");

            migrationBuilder.CreateIndex(
                name: "IX_DufferCondos_CondoId",
                table: "DufferCondos",
                column: "CondoId");

            migrationBuilder.CreateIndex(
                name: "IX_DufferEntityEventEntity_EventsId",
                table: "DufferEntityEventEntity",
                column: "EventsId");

            migrationBuilder.CreateIndex(
                name: "IX_DufferEntityPairingEntity_PairingsId",
                table: "DufferEntityPairingEntity",
                column: "PairingsId");

            migrationBuilder.CreateIndex(
                name: "IX_Duffers_AddressId",
                table: "Duffers",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Duffers_CondoEntityId",
                table: "Duffers",
                column: "CondoEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_EventLodgings_EventId",
                table: "EventLodgings",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_EventLodgings_LodgingId",
                table: "EventLodgings",
                column: "LodgingId");

            migrationBuilder.CreateIndex(
                name: "IX_GolfAwards_GolfId",
                table: "GolfAwards",
                column: "GolfId");

            migrationBuilder.CreateIndex(
                name: "IX_GolfAwards_PairingAwardId",
                table: "GolfAwards",
                column: "PairingAwardId");

            migrationBuilder.CreateIndex(
                name: "IX_Golfs_AddressId",
                table: "Golfs",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Golfs_CourseId",
                table: "Golfs",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Golfs_EventId",
                table: "Golfs",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_Golfs_WinnerId",
                table: "Golfs",
                column: "WinnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Holes_GolfId",
                table: "Holes",
                column: "GolfId");

            migrationBuilder.CreateIndex(
                name: "IX_HoleScores_PairingId",
                table: "HoleScores",
                column: "PairingId");

            migrationBuilder.CreateIndex(
                name: "IX_IndividualAwards_CompetitionId",
                table: "IndividualAwards",
                column: "CompetitionId");

            migrationBuilder.CreateIndex(
                name: "IX_IndividualAwards_DufferId",
                table: "IndividualAwards",
                column: "DufferId");

            migrationBuilder.CreateIndex(
                name: "IX_IndividualAwards_EventEntityId",
                table: "IndividualAwards",
                column: "EventEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_IndividualAwards_GolfAwardEntityId",
                table: "IndividualAwards",
                column: "GolfAwardEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_PairingAwards_CompetitionEntityId",
                table: "PairingAwards",
                column: "CompetitionEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_PairingAwards_DufferEntityId",
                table: "PairingAwards",
                column: "DufferEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_PairingAwards_PairingId",
                table: "PairingAwards",
                column: "PairingId");

            migrationBuilder.CreateIndex(
                name: "IX_Pairings_GolfId",
                table: "Pairings",
                column: "GolfId");

            migrationBuilder.AddForeignKey(
                name: "FK_DufferCondos_AddressEntity_CondoId",
                table: "DufferCondos",
                column: "CondoId",
                principalTable: "AddressEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DufferEntityEventEntity_AddressEntity_EventsId",
                table: "DufferEntityEventEntity",
                column: "EventsId",
                principalTable: "AddressEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DufferEntityEventEntity_Duffers_DuffersId",
                table: "DufferEntityEventEntity",
                column: "DuffersId",
                principalTable: "Duffers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Duffers_AddressEntity_AddressId",
                table: "Duffers",
                column: "AddressId",
                principalTable: "AddressEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Duffers_AddressEntity_CondoEntityId",
                table: "Duffers",
                column: "CondoEntityId",
                principalTable: "AddressEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EventLodgings_AddressEntity_EventId",
                table: "EventLodgings",
                column: "EventId",
                principalTable: "AddressEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EventLodgings_AddressEntity_LodgingId",
                table: "EventLodgings",
                column: "LodgingId",
                principalTable: "AddressEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Golfs_Pairings_WinnerId",
                table: "Golfs",
                column: "WinnerId",
                principalTable: "Pairings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AddressEntity_EventLodgings_EventLodgingEntityId",
                table: "AddressEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_Golfs_AddressEntity_AddressId",
                table: "Golfs");

            migrationBuilder.DropForeignKey(
                name: "FK_Golfs_AddressEntity_CourseId",
                table: "Golfs");

            migrationBuilder.DropForeignKey(
                name: "FK_Golfs_AddressEntity_EventId",
                table: "Golfs");

            migrationBuilder.DropForeignKey(
                name: "FK_Golfs_Pairings_WinnerId",
                table: "Golfs");

            migrationBuilder.DropTable(
                name: "DufferCondos");

            migrationBuilder.DropTable(
                name: "DufferEntityEventEntity");

            migrationBuilder.DropTable(
                name: "DufferEntityPairingEntity");

            migrationBuilder.DropTable(
                name: "Holes");

            migrationBuilder.DropTable(
                name: "HoleScores");

            migrationBuilder.DropTable(
                name: "IndividualAwards");

            migrationBuilder.DropTable(
                name: "GolfAwards");

            migrationBuilder.DropTable(
                name: "PairingAwards");

            migrationBuilder.DropTable(
                name: "Competitions");

            migrationBuilder.DropTable(
                name: "Duffers");

            migrationBuilder.DropTable(
                name: "EventLodgings");

            migrationBuilder.DropTable(
                name: "AddressEntity");

            migrationBuilder.DropTable(
                name: "Pairings");

            migrationBuilder.DropTable(
                name: "Golfs");
        }
    }
}
