using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using MyNodes.Repositories.EF.SQLite;

namespace WebController.Migrations
{
    [DbContext(typeof(MySensorsNodesDbContext))]
    [Migration("20160102134311_testMigration1")]
    partial class testMigration1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348");

            modelBuilder.Entity("MyNetSensors.LogicalNodes.LogicalLink", b =>
                {
                    b.Property<string>("Id");

                    b.Property<string>("InputId");

                    b.Property<string>("OutputId");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("MyNetSensors.Repositories.EF.SQLite.LogicalNodeSerialized", b =>
                {
                    b.Property<string>("Id");

                    b.Property<string>("JsonData");

                    b.HasKey("Id");
                });
        }
    }
}
