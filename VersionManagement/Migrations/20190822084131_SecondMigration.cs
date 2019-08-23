using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VersionManagement.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "Version",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "Version",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "CreatedDate",
                table: "Version",
                nullable: false,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTimeOffset));

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Version",
                nullable: false,
                defaultValueSql: "newid()",
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "PublishActivity",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "PublishActivity",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "CreatedDate",
                table: "PublishActivity",
                nullable: false,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTimeOffset));

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "PublishActivity",
                nullable: false,
                defaultValueSql: "newid()",
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "Product",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "Product",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "CreatedDate",
                table: "Product",
                nullable: false,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTimeOffset));

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Product",
                nullable: false,
                defaultValueSql: "newid()",
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "CustomerProduct",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "CustomerProduct",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "CreatedDate",
                table: "CustomerProduct",
                nullable: false,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTimeOffset));

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "CustomerProduct",
                nullable: false,
                defaultValueSql: "newid()",
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "Customer",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "Customer",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "CreatedDate",
                table: "Customer",
                nullable: false,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTimeOffset));

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Customer",
                nullable: false,
                defaultValueSql: "newid()",
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "Component",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "Component",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "CreatedDate",
                table: "Component",
                nullable: false,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTimeOffset));

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Component",
                nullable: false,
                defaultValueSql: "newid()",
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "ChangeLogType",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "ChangeLogType",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "CreatedDate",
                table: "ChangeLogType",
                nullable: false,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTimeOffset));

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "ChangeLogType",
                nullable: false,
                defaultValueSql: "newid()",
                oldClrType: typeof(Guid));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "Version",
                nullable: false,
                oldClrType: typeof(bool),
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "Version",
                nullable: false,
                oldClrType: typeof(bool),
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "CreatedDate",
                table: "Version",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldDefaultValueSql: "getdate()");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Version",
                nullable: false,
                oldClrType: typeof(Guid),
                oldDefaultValueSql: "newid()");

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "PublishActivity",
                nullable: false,
                oldClrType: typeof(bool),
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "PublishActivity",
                nullable: false,
                oldClrType: typeof(bool),
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "CreatedDate",
                table: "PublishActivity",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldDefaultValueSql: "getdate()");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "PublishActivity",
                nullable: false,
                oldClrType: typeof(Guid),
                oldDefaultValueSql: "newid()");

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "Product",
                nullable: false,
                oldClrType: typeof(bool),
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "Product",
                nullable: false,
                oldClrType: typeof(bool),
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "CreatedDate",
                table: "Product",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldDefaultValueSql: "getdate()");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Product",
                nullable: false,
                oldClrType: typeof(Guid),
                oldDefaultValueSql: "newid()");

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "CustomerProduct",
                nullable: false,
                oldClrType: typeof(bool),
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "CustomerProduct",
                nullable: false,
                oldClrType: typeof(bool),
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "CreatedDate",
                table: "CustomerProduct",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldDefaultValueSql: "getdate()");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "CustomerProduct",
                nullable: false,
                oldClrType: typeof(Guid),
                oldDefaultValueSql: "newid()");

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "Customer",
                nullable: false,
                oldClrType: typeof(bool),
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "Customer",
                nullable: false,
                oldClrType: typeof(bool),
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "CreatedDate",
                table: "Customer",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldDefaultValueSql: "getdate()");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Customer",
                nullable: false,
                oldClrType: typeof(Guid),
                oldDefaultValueSql: "newid()");

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "Component",
                nullable: false,
                oldClrType: typeof(bool),
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "Component",
                nullable: false,
                oldClrType: typeof(bool),
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "CreatedDate",
                table: "Component",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldDefaultValueSql: "getdate()");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Component",
                nullable: false,
                oldClrType: typeof(Guid),
                oldDefaultValueSql: "newid()");

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "ChangeLogType",
                nullable: false,
                oldClrType: typeof(bool),
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "ChangeLogType",
                nullable: false,
                oldClrType: typeof(bool),
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "CreatedDate",
                table: "ChangeLogType",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldDefaultValueSql: "getdate()");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "ChangeLogType",
                nullable: false,
                oldClrType: typeof(Guid),
                oldDefaultValueSql: "newid()");
        }
    }
}
