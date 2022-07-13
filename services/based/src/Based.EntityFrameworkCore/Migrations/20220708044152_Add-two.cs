using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Based.Migrations
{
    public partial class Addtwo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EasyAbpAbpDynamicEntityFieldDefinitions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    DisplayName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Type = table.Column<int>(type: "int", maxLength: 256, nullable: false),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EasyAbpAbpDynamicEntityFieldDefinitions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EasyAbpAbpDynamicEntityModelDefinitions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    DisplayName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Type = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    PermissionSet_Get = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PermissionSet_GetList = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PermissionSet_Create = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PermissionSet_Update = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PermissionSet_Delete = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PermissionSet_Manage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PermissionSet_AnonymousGet = table.Column<bool>(type: "bit", nullable: true),
                    PermissionSet_AnonymousGetList = table.Column<bool>(type: "bit", nullable: true),
                    PermissionSet_AnonymousCreate = table.Column<bool>(type: "bit", nullable: true),
                    PermissionSet_AnonymousUpdate = table.Column<bool>(type: "bit", nullable: true),
                    PermissionSet_AnonymousDelete = table.Column<bool>(type: "bit", nullable: true),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EasyAbpAbpDynamicEntityModelDefinitions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EasyAbpAbpDynamicEntityDynamicEntities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenantId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModelDefinitionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ExtraProperties = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EasyAbpAbpDynamicEntityDynamicEntities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EasyAbpAbpDynamicEntityDynamicEntities_EasyAbpAbpDynamicEntityModelDefinitions_ModelDefinitionId",
                        column: x => x.ModelDefinitionId,
                        principalTable: "EasyAbpAbpDynamicEntityModelDefinitions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "EasyAbpAbpDynamicEntityModelFields",
                columns: table => new
                {
                    ModelDefinitionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FieldDefinitionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Order = table.Column<int>(type: "int", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EasyAbpAbpDynamicEntityModelFields", x => new { x.FieldDefinitionId, x.ModelDefinitionId });
                    table.ForeignKey(
                        name: "FK_EasyAbpAbpDynamicEntityModelFields_EasyAbpAbpDynamicEntityFieldDefinitions_FieldDefinitionId",
                        column: x => x.FieldDefinitionId,
                        principalTable: "EasyAbpAbpDynamicEntityFieldDefinitions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EasyAbpAbpDynamicEntityModelFields_EasyAbpAbpDynamicEntityModelDefinitions_ModelDefinitionId",
                        column: x => x.ModelDefinitionId,
                        principalTable: "EasyAbpAbpDynamicEntityModelDefinitions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EasyAbpAbpDynamicEntityDynamicEntities_ExtraProperties",
                table: "EasyAbpAbpDynamicEntityDynamicEntities",
                column: "ExtraProperties");

            migrationBuilder.CreateIndex(
                name: "IX_EasyAbpAbpDynamicEntityDynamicEntities_ModelDefinitionId",
                table: "EasyAbpAbpDynamicEntityDynamicEntities",
                column: "ModelDefinitionId");

            migrationBuilder.CreateIndex(
                name: "IX_EasyAbpAbpDynamicEntityFieldDefinitions_Name",
                table: "EasyAbpAbpDynamicEntityFieldDefinitions",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_EasyAbpAbpDynamicEntityModelDefinitions_Name",
                table: "EasyAbpAbpDynamicEntityModelDefinitions",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_EasyAbpAbpDynamicEntityModelFields_ModelDefinitionId",
                table: "EasyAbpAbpDynamicEntityModelFields",
                column: "ModelDefinitionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EasyAbpAbpDynamicEntityDynamicEntities");

            migrationBuilder.DropTable(
                name: "EasyAbpAbpDynamicEntityModelFields");

            migrationBuilder.DropTable(
                name: "EasyAbpAbpDynamicEntityFieldDefinitions");

            migrationBuilder.DropTable(
                name: "EasyAbpAbpDynamicEntityModelDefinitions");
        }
    }
}
