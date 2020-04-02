using Microsoft.EntityFrameworkCore.Migrations;

namespace Demo4.Web.Migrations
{
    // DEMO 4 PART 2
    public partial class AddView : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Adds into DB

            migrationBuilder.Sql(
                @"CREATE OR ALTER VIEW [dbo].[EmployeesWithTotalHours]
                  AS
                  SELECT
                      e.Id,
                      e.Name,
                      e.Surname,
                      SUM(te.HoursWorked) AS TotalHoursWorked
                  FROM
                      dbo.Employees as e
                  INNER JOIN
                      dbo.TimeEntries te ON e.Id = te.EmployeeId
                  GROUP BY
                      e.Name, e.Surname, e.Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Removes from DB

            migrationBuilder.Sql("DROP VIEW [dbo].[EmployeesWithTotalHours]");
        }
    }
}
