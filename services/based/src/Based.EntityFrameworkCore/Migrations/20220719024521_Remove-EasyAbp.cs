using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Based.Migrations
{
    public partial class RemoveEasyAbp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EasyAbpAbpDynamicEntityDynamicEntities");

            migrationBuilder.DropTable(
                name: "EasyAbpAbpDynamicEntityModelFields");

            migrationBuilder.DropTable(
                name: "EasyAbpAbpDynamicMenuMenuItems");

            migrationBuilder.DropTable(
                name: "EasyAbpAbpDynamicPermissionPermissionDefinitions");

            migrationBuilder.DropTable(
                name: "EasyAbpAbpEntityUiModules");

            migrationBuilder.DropTable(
                name: "EasyAbpAbpEntityUiProperties");

            migrationBuilder.DropTable(
                name: "EasyAbpAbpDynamicEntityFieldDefinitions");

            migrationBuilder.DropTable(
                name: "EasyAbpAbpDynamicEntityModelDefinitions");

            migrationBuilder.DropTable(
                name: "EasyAbpAbpEntityUiEntities");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EasyAbpAbpDynamicEntityFieldDefinitions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeleterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DisplayName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Type = table.Column<int>(type: "int", maxLength: 256, nullable: false)
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
                    PermissionSet_AnonymousCreate = table.Column<bool>(type: "bit", nullable: true),
                    PermissionSet_AnonymousDelete = table.Column<bool>(type: "bit", nullable: true),
                    PermissionSet_AnonymousGet = table.Column<bool>(type: "bit", nullable: true),
                    PermissionSet_AnonymousGetList = table.Column<bool>(type: "bit", nullable: true),
                    PermissionSet_AnonymousUpdate = table.Column<bool>(type: "bit", nullable: true),
                    PermissionSet_Create = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PermissionSet_Delete = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PermissionSet_Get = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PermissionSet_GetList = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PermissionSet_Manage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PermissionSet_Update = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeleterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DisplayName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Type = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EasyAbpAbpDynamicEntityModelDefinitions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EasyAbpAbpDynamicMenuMenuItems",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    DisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LResourceTypeAssemblyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LResourceTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParentName = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Permission = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UrlAngular = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UrlBlazor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UrlMvc = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EasyAbpAbpDynamicMenuMenuItems", x => x.Name);
                    table.ForeignKey(
                        name: "FK_EasyAbpAbpDynamicMenuMenuItems_EasyAbpAbpDynamicMenuMenuItems_ParentName",
                        column: x => x.ParentName,
                        principalTable: "EasyAbpAbpDynamicMenuMenuItems",
                        principalColumn: "Name");
                });

            migrationBuilder.CreateTable(
                name: "EasyAbpAbpDynamicPermissionPermissionDefinitions",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsPublic = table.Column<bool>(type: "bit", nullable: false),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EasyAbpAbpDynamicPermissionPermissionDefinitions", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "EasyAbpAbpEntityUiEntities",
                columns: table => new
                {
                    ModuleName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AppServiceCreateMethodName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AppServiceDeleteMethodName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AppServiceGetListMethodName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AppServiceGetMethodName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AppServiceInterfaceName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AppServiceUpdateMethodName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BelongsTo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    ContractsAssemblyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreationDtoTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreationEnabled = table.Column<bool>(type: "bit", nullable: false),
                    CreationPermission = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletionEnabled = table.Column<bool>(type: "bit", nullable: false),
                    DeletionPermission = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DetailDtoTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DetailEnabled = table.Column<bool>(type: "bit", nullable: false),
                    DetailPermission = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EditDtoTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EditEnabled = table.Column<bool>(type: "bit", nullable: false),
                    EditPermission = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GetListInputDtoTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KeyClassTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Keys = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ListItemDtoTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Namespace = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProviderName = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LResourceTypeAssemblyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LResourceTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EasyAbpAbpEntityUiModules", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "EasyAbpAbpDynamicEntityDynamicEntities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModelDefinitionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeleterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ExtraProperties = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TenantId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
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
                    FieldDefinitionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModelDefinitionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Order = table.Column<int>(type: "int", nullable: false)
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

            migrationBuilder.CreateTable(
                name: "EasyAbpAbpEntityUiProperties",
                columns: table => new
                {
                    EntityModuleName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    EntityName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ShowIn_Creation = table.Column<bool>(type: "bit", nullable: true),
                    ShowIn_Detail = table.Column<bool>(type: "bit", nullable: true),
                    ShowIn_Edit = table.Column<bool>(type: "bit", nullable: true),
                    ShowIn_List = table.Column<bool>(type: "bit", nullable: true),
                    IsEntityCollection = table.Column<bool>(type: "bit", nullable: false),
                    Nullable = table.Column<bool>(type: "bit", nullable: false),
                    TypeOrEntityName = table.Column<string>(type: "nvarchar(max)", nullable: true)
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

            migrationBuilder.CreateIndex(
                name: "IX_EasyAbpAbpDynamicMenuMenuItems_ParentName",
                table: "EasyAbpAbpDynamicMenuMenuItems",
                column: "ParentName");
        }
    }
}
