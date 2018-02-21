﻿// <auto-generated />
using Dnn.vNext.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Dnn.vNext.Migrations
{
    [DbContext(typeof(DnnDbContext))]
    [Migration("20180221034235_MoreDnnTables")]
    partial class MoreDnnTables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Dnn.vNext.Data.Module", b =>
                {
                    b.Property<int>("ModuleID")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("AllTabs");

                    b.Property<int?>("ContentItemID");

                    b.Property<int?>("CreatedByUserID");

                    b.Property<DateTime?>("CreatedOnDate");

                    b.Property<DateTime?>("EndDate");

                    b.Property<string>("Icon");

                    b.Property<bool?>("InheritViewPermissions");

                    b.Property<bool>("IsDeleted");

                    b.Property<bool?>("IsShareable");

                    b.Property<bool?>("IsShareableViewOnly");

                    b.Property<DateTime?>("LastContentModifiedOnDate");

                    b.Property<int?>("LastModifiedByUserID");

                    b.Property<DateTime?>("LastModifiedOnDate");

                    b.Property<int>("ModuleDefID");

                    b.Property<string>("Name");

                    b.Property<string>("Path");

                    b.Property<int?>("PortalID");

                    b.Property<DateTime?>("StartDate");

                    b.HasKey("ModuleID");

                    b.ToTable("Modules");
                });

            modelBuilder.Entity("Dnn.vNext.Data.ModuleControl", b =>
                {
                    b.Property<int>("ModuleControlID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ControlKey");

                    b.Property<string>("ControlSrc");

                    b.Property<string>("ControlTitle");

                    b.Property<int>("ControlType");

                    b.Property<int?>("CreatedByUserID");

                    b.Property<DateTime?>("CreatedOnDate");

                    b.Property<string>("HelpUrl");

                    b.Property<string>("IconFile");

                    b.Property<int?>("LastModifiedByUserId");

                    b.Property<DateTime?>("LastModifiedOnDate");

                    b.Property<int>("ModuleDefID");

                    b.Property<bool>("SupportPopUps");

                    b.Property<bool>("SupportsPartialRendering");

                    b.Property<int?>("ViewOrder");

                    b.HasKey("ModuleControlID");

                    b.ToTable("ModuleControls");
                });

            modelBuilder.Entity("Dnn.vNext.Data.ModuleDefinition", b =>
                {
                    b.Property<int>("ModuleDefID")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CreatedByUserID");

                    b.Property<DateTime?>("CreatedOnDate");

                    b.Property<int>("DefaultCacheTime");

                    b.Property<string>("DefinitionName");

                    b.Property<int>("DesktopModuleID");

                    b.Property<string>("FriendlyName");

                    b.Property<int?>("LastModifiedByUserID");

                    b.Property<DateTime?>("LastModifiedOnDate");

                    b.HasKey("ModuleDefID");

                    b.ToTable("ModuleDefinitions");
                });

            modelBuilder.Entity("Dnn.vNext.Data.ModulePermission", b =>
                {
                    b.Property<int>("ModulePermissionID")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("AllowAccess");

                    b.Property<int?>("CreatedByUserID");

                    b.Property<DateTime?>("CreatedOnDate");

                    b.Property<int?>("LastModifiedByUserID");

                    b.Property<DateTime?>("LastModifiedOnDate");

                    b.Property<int>("ModuleID");

                    b.Property<int>("PermissionID");

                    b.Property<int>("PortalID");

                    b.Property<int?>("RoleID");

                    b.Property<int?>("UserID");

                    b.HasKey("ModulePermissionID");

                    b.ToTable("ModulePermissions");
                });

            modelBuilder.Entity("Dnn.vNext.Data.ModuleSetting", b =>
                {
                    b.Property<int>("ModuleID")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CreatedByUserID");

                    b.Property<DateTime?>("CreatedOnDate");

                    b.Property<int?>("LastModifiedByUserID");

                    b.Property<DateTime?>("LastModifiedOnDate");

                    b.Property<string>("SettingName");

                    b.HasKey("ModuleID");

                    b.ToTable("ModuleSettings");
                });

            modelBuilder.Entity("Dnn.vNext.Data.Tab", b =>
                {
                    b.Property<int>("TabID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ContainerSrc");

                    b.Property<int?>("ContentItemID");

                    b.Property<int?>("CreatedByUserID");

                    b.Property<DateTime?>("CreatedOnDate");

                    b.Property<string>("CultureCode");

                    b.Property<Guid>("DefaultLanguageGUID");

                    b.Property<string>("Description");

                    b.Property<bool>("DisableLink");

                    b.Property<DateTime?>("EndDate");

                    b.Property<bool>("HasBeenPublished");

                    b.Property<string>("IconFile");

                    b.Property<string>("IconFileLarge");

                    b.Property<bool>("IsDeleted");

                    b.Property<bool>("IsSecure");

                    b.Property<bool>("IsSystem");

                    b.Property<bool>("IsVisible");

                    b.Property<string>("Keywords");

                    b.Property<int?>("LastModifiedByUserID");

                    b.Property<DateTime?>("LastModifiedOnDate");

                    b.Property<int>("Level");

                    b.Property<Guid>("LocalizedVersionGUID");

                    b.Property<string>("Name");

                    b.Property<string>("PageHeadText");

                    b.Property<int?>("ParentId");

                    b.Property<bool>("PermanentRedirect");

                    b.Property<int?>("PortalID");

                    b.Property<int?>("RefreshInterval");

                    b.Property<float>("SiteMapPriority");

                    b.Property<string>("SkinSrc");

                    b.Property<DateTime?>("StartDate");

                    b.Property<string>("TabName");

                    b.Property<int>("TabOrder");

                    b.Property<string>("TabPath");

                    b.Property<string>("Title");

                    b.Property<Guid>("UniqueId");

                    b.Property<string>("Url");

                    b.Property<Guid>("VersionGUID");

                    b.HasKey("TabID");

                    b.ToTable("Tabs");
                });

            modelBuilder.Entity("Dnn.vNext.Data.TabModule", b =>
                {
                    b.Property<int>("TabModuleID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Alignment");

                    b.Property<string>("Border");

                    b.Property<string>("CacheMethod");

                    b.Property<int>("CacheTime");

                    b.Property<string>("Color");

                    b.Property<string>("ContainerSrc");

                    b.Property<int?>("CreatedByUserID");

                    b.Property<DateTime?>("CreatedOnDate");

                    b.Property<string>("CultureCode");

                    b.Property<Guid>("DefaultLanguageGUID");

                    b.Property<int>("DisplayPrint");

                    b.Property<int>("DisplaySyndicate");

                    b.Property<int>("DisplayTitle");

                    b.Property<string>("ElementId");

                    b.Property<string>("Footer");

                    b.Property<string>("Header");

                    b.Property<string>("IconFile");

                    b.Property<int>("IsDeleted");

                    b.Property<int>("IsWebSlice");

                    b.Property<int?>("LastModifiedByUserID");

                    b.Property<DateTime?>("LastModifiedOnDate");

                    b.Property<Guid>("LocalizedVersionGUID");

                    b.Property<int>("ModuleID");

                    b.Property<int>("ModuleOrder");

                    b.Property<string>("ModuleTitle");

                    b.Property<int>("Order");

                    b.Property<int>("PageId");

                    b.Property<string>("PaneName");

                    b.Property<int>("TabID");

                    b.Property<Guid>("UniqueId");

                    b.Property<Guid>("VersionGUID");

                    b.Property<int>("Visibility");

                    b.Property<DateTime?>("WebSliceExpiryDate");

                    b.Property<int?>("WebSliceTTL");

                    b.Property<string>("WebSliceTitle");

                    b.HasKey("TabModuleID");

                    b.HasIndex("ModuleID");

                    b.HasIndex("PageId");

                    b.ToTable("TabModules");
                });

            modelBuilder.Entity("Dnn.vNext.Data.TabModuleSetting", b =>
                {
                    b.Property<int>("TabModuleID")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CreatedByUserID");

                    b.Property<DateTime?>("CreatedOnDate");

                    b.Property<int?>("LastModifiedByUserID");

                    b.Property<DateTime?>("LastModifiedOnDate");

                    b.Property<string>("SettingName");

                    b.Property<string>("SetttingValue");

                    b.HasKey("TabModuleID");

                    b.ToTable("TabModuleSettings");
                });

            modelBuilder.Entity("Dnn.vNext.Data.TabModule", b =>
                {
                    b.HasOne("Dnn.vNext.Data.Module", "Module")
                        .WithMany()
                        .HasForeignKey("ModuleID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Dnn.vNext.Data.Tab", "Page")
                        .WithMany("TabModules")
                        .HasForeignKey("PageId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
