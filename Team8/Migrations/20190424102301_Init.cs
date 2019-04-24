using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Team8.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Degree",
                columns: table => new
                {
                    DegreeId = table.Column<int>(nullable: false),
                    DegreeAbbrev = table.Column<string>(maxLength: 10, nullable: false),
                    DegreeName = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Degree", x => x.DegreeId);
                });

            migrationBuilder.CreateTable(
                name: "DegreeStatus",
                columns: table => new
                {
                    DegreeStatusId = table.Column<int>(nullable: false),
                    Status = table.Column<string>(maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DegreeStatus", x => x.DegreeStatusId);
                });

            migrationBuilder.CreateTable(
                name: "RequirementStatus",
                columns: table => new
                {
                    RequirementStatusId = table.Column<int>(nullable: false),
                    Status = table.Column<string>(maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequirementStatus", x => x.RequirementStatusId);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    StudentId = table.Column<int>(nullable: false),
                    GivenName = table.Column<string>(maxLength: 50, nullable: false),
                    FamilyName = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.StudentId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DegreeRequirement",
                columns: table => new
                {
                    DegreeRequirementId = table.Column<int>(nullable: false),
                    DegreeId = table.Column<int>(nullable: false),
                    RequirementNumber = table.Column<int>(nullable: false),
                    RequirementAbbrev = table.Column<string>(maxLength: 10, nullable: false),
                    RequirementName = table.Column<string>(maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DegreeRequirement", x => x.DegreeRequirementId);
                    table.ForeignKey(
                        name: "FK_DegreeRequirement_Degree_DegreeId",
                        column: x => x.DegreeId,
                        principalTable: "Degree",
                        principalColumn: "DegreeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentDegreePlan",
                columns: table => new
                {
                    StudentDegreePlanId = table.Column<int>(nullable: false),
                    StudentId = table.Column<int>(nullable: false),
                    DegreeId = table.Column<int>(nullable: false),
                    PlanNumber = table.Column<int>(nullable: false),
                    PlanAbbrev = table.Column<string>(maxLength: 20, nullable: false),
                    PlanName = table.Column<string>(maxLength: 50, nullable: false),
                    DegreeStatusId = table.Column<int>(nullable: false),
                    IncludesInternship = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentDegreePlan", x => x.StudentDegreePlanId);
                    table.ForeignKey(
                        name: "FK_StudentDegreePlan_Degree_DegreeId",
                        column: x => x.DegreeId,
                        principalTable: "Degree",
                        principalColumn: "DegreeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentDegreePlan_DegreeStatus_DegreeStatusId",
                        column: x => x.DegreeStatusId,
                        principalTable: "DegreeStatus",
                        principalColumn: "DegreeStatusId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentDegreePlan_Student_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Student",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlanTerm",
                columns: table => new
                {
                    PlanTermId = table.Column<int>(nullable: false),
                    StudentDegreePlanId = table.Column<int>(nullable: false),
                    TermNumber = table.Column<int>(nullable: false),
                    TermAbbrev = table.Column<string>(maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlanTerm", x => x.PlanTermId);
                    table.ForeignKey(
                        name: "FK_PlanTerm_StudentDegreePlan_StudentDegreePlanId",
                        column: x => x.StudentDegreePlanId,
                        principalTable: "StudentDegreePlan",
                        principalColumn: "StudentDegreePlanId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlanTermRequirement",
                columns: table => new
                {
                    PlanTermRequirementId = table.Column<int>(nullable: false),
                    PlanTermId = table.Column<int>(nullable: false),
                    DegreeRequirementId = table.Column<int>(nullable: false),
                    RequirementStatusId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlanTermRequirement", x => x.PlanTermRequirementId);
                    table.ForeignKey(
                        name: "FK_PlanTermRequirement_DegreeRequirement_DegreeRequirementId",
                        column: x => x.DegreeRequirementId,
                        principalTable: "DegreeRequirement",
                        principalColumn: "DegreeRequirementId");
                    table.ForeignKey(
                        name: "FK_PlanTermRequirement_PlanTerm_PlanTermId",
                        column: x => x.PlanTermId,
                        principalTable: "PlanTerm",
                        principalColumn: "PlanTermId");
                    table.ForeignKey(
                        name: "FK_PlanTermRequirement_RequirementStatus_RequirementStatusId",
                        column: x => x.RequirementStatusId,
                        principalTable: "RequirementStatus",
                        principalColumn: "RequirementStatusId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DegreeRequirement_DegreeId",
                table: "DegreeRequirement",
                column: "DegreeId");

            migrationBuilder.CreateIndex(
                name: "IX_PlanTerm_StudentDegreePlanId",
                table: "PlanTerm",
                column: "StudentDegreePlanId");

            migrationBuilder.CreateIndex(
                name: "IX_PlanTermRequirement_DegreeRequirementId",
                table: "PlanTermRequirement",
                column: "DegreeRequirementId");

            migrationBuilder.CreateIndex(
                name: "IX_PlanTermRequirement_PlanTermId",
                table: "PlanTermRequirement",
                column: "PlanTermId");

            migrationBuilder.CreateIndex(
                name: "IX_PlanTermRequirement_RequirementStatusId",
                table: "PlanTermRequirement",
                column: "RequirementStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentDegreePlan_DegreeId",
                table: "StudentDegreePlan",
                column: "DegreeId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentDegreePlan_DegreeStatusId",
                table: "StudentDegreePlan",
                column: "DegreeStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentDegreePlan_StudentId",
                table: "StudentDegreePlan",
                column: "StudentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "PlanTermRequirement");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "DegreeRequirement");

            migrationBuilder.DropTable(
                name: "PlanTerm");

            migrationBuilder.DropTable(
                name: "RequirementStatus");

            migrationBuilder.DropTable(
                name: "StudentDegreePlan");

            migrationBuilder.DropTable(
                name: "Degree");

            migrationBuilder.DropTable(
                name: "DegreeStatus");

            migrationBuilder.DropTable(
                name: "Student");
        }
    }
}
