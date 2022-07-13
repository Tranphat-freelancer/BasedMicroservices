using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Based.Migrations
{
    public partial class Addfour : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EasyAbpAbpEntityUiEntities",
                columns: table => new
                {
                    ModuleName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Namespace = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BelongsTo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Keys = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreationEnabled = table.Column<bool>(type: "bit", nullable: false),
                    CreationPermission = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EditEnabled = table.Column<bool>(type: "bit", nullable: false),
                    EditPermission = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletionEnabled = table.Column<bool>(type: "bit", nullable: false),
                    DeletionPermission = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DetailEnabled = table.Column<bool>(type: "bit", nullable: false),
                    DetailPermission = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContractsAssemblyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ListItemDtoTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DetailDtoTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreationDtoTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EditDtoTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GetListInputDtoTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KeyClassTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AppServiceInterfaceName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AppServiceGetListMethodName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AppServiceGetMethodName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AppServiceCreateMethodName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AppServiceUpdateMethodName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AppServiceDeleteMethodName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EasyAbpAbpEntityUiEntities", x => new { x.ModuleName, x.Name });
                });

            migrationBuilder.CreateTable(
                name: "EasyAbpAbpEntityUiModules",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LResourceTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LResourceTypeAssemblyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EasyAbpAbpEntityUiModules", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "EasyAbpAbpEntityUiProperties",
                columns: table => new
                {
                    EntityModuleName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    EntityName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IsEntityCollection = table.Column<bool>(type: "bit", nullable: false),
                    TypeOrEntityName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nullable = table.Column<bool>(type: "bit", nullable: false),
                    ShowIn_List = table.Column<bool>(type: "bit", nullable: true),
                    ShowIn_Detail = table.Column<bool>(type: "bit", nullable: true),
                    ShowIn_Creation = table.Column<bool>(type: "bit", nullable: true),
                    ShowIn_Edit = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EasyAbpAbpEntityUiProperties", x => new { x.EntityModuleName, x.EntityName, x.Name });
                    table.ForeignKey(
                        name: "FK_EasyAbpAbpEntityUiProperties_EasyAbpAbpEntityUiEntities_EntityModuleName_EntityName",
                        columns: x => new { x.EntityModuleName, x.EntityName },
                        principalTable: "EasyAbpAbpEntityUiEntities",
                        principalColumns: new[] { "ModuleName", "Name" },
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EasyAbpAbpEntityUiModules");

            migrationBuilder.DropTable(
                name: "EasyAbpAbpEntityUiProperties");

            migrationBuilder.DropTable(
                name: "EasyAbpAbpEntityUiEntities");
        }
    }
}
