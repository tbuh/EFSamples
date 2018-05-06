using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace EFSamples.Migrations
{
    public partial class AddTestData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
INSERT INTO [dbo].[Organizations]
           ([Date]
           ,[Name])
     VALUES
           ('01/02/2010'
           ,'Test Org1')

INSERT INTO [dbo].[Users]
           ([Name]
           ,[OrganizationId])
     VALUES
           ('Test User1'
           ,SCOPE_IDENTITY() )

INSERT INTO [dbo].[Organizations]
           ([Date]
           ,[Name])
     VALUES
           ('01/02/2010'
           ,'Test Org2')

INSERT INTO [dbo].[Users]
           ([Name]
           ,[OrganizationId])
     VALUES
           ('Test User2'
           ,SCOPE_IDENTITY() )
");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
