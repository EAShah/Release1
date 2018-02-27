/* 
	Description: This file contains the migrations and their configurations
                 for the  database model of the Probation Management System. 
	Author: Elaf Shah/ EAS
	Due date: 27/02/2018
*/

namespace Project._1.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Project._1.Models.ProbationManagementSystem>
    {
        // Configuring the migrations
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(Project._1.Models.ProbationManagementSystem context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
