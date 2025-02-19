﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EpisodeApp.Data.MigrationsEpisodes
{
    public partial class seeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Episode",
                columns: new[] { "EpisodeId", "Date", "GuestName", "Title", "URL" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Claire Novotny", "All about Open Source and .NET", "https://www.youtube.com/watch?v=flj9MHrOU0k" },
                    { 2, new DateTime(2020, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Layla Porter", "Migrating ASP NET Identity to Azure AD B2C", "https://www.youtube.com/watch?v=lQlev9oRtXQ" },
                    { 3, new DateTime(2021, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Joonas Westlin", "Identity Crisis sidecar: Legacy software. Let's learn foxpro!", "https://www.youtube.com/watch?v=xCkS0e2voE8" },
                    { 4, new DateTime(2021, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Identity Crisis - Getting started with Identity", "https://www.youtube.com/watch?v=bniAj9q4s7c" },
                    { 5, new DateTime(2021, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sean Whitesell", "Secure DevOps with Pulumi and Azure AD", "https://www.youtube.com/watch?v=DdTJNAXZ1k4" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Episode",
                keyColumn: "EpisodeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Episode",
                keyColumn: "EpisodeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Episode",
                keyColumn: "EpisodeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Episode",
                keyColumn: "EpisodeId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Episode",
                keyColumn: "EpisodeId",
                keyValue: 5);
        }
    }
}
