﻿// <auto-generated />
using System;
using LINGYUN.Abp.MessageService.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Volo.Abp.EntityFrameworkCore;

namespace LINGYUN.Abp.MessageService.Migrations
{
    [DbContext(typeof(MessageServiceHostMigrationsDbContext))]
    [Migration("20211111221335_Add-Field-Static-To-Chat-Friend")]
    partial class AddFieldStaticToChatFriend
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("_Abp_DatabaseProvider", EfCoreDatabaseProvider.MySql)
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.12");

            modelBuilder.Entity("LINGYUN.Abp.MessageService.Chat.UserChatCard", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("AvatarUrl")
                        .HasMaxLength(512)
                        .HasColumnType("varchar(512)");

                    b.Property<DateTime?>("Birthday")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40)")
                        .HasColumnName("ConcurrencyStamp");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("CreationTime");

                    b.Property<Guid?>("CreatorId")
                        .HasColumnType("char(36)")
                        .HasColumnName("CreatorId");

                    b.Property<string>("Description")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("ExtraProperties")
                        .HasColumnType("longtext")
                        .HasColumnName("ExtraProperties");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("LastModificationTime");

                    b.Property<Guid?>("LastModifierId")
                        .HasColumnType("char(36)")
                        .HasColumnName("LastModifierId");

                    b.Property<DateTime?>("LastOnlineTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NickName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<int>("Sex")
                        .HasColumnType("int");

                    b.Property<string>("Sign")
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<int>("State")
                        .HasColumnType("int");

                    b.Property<Guid?>("TenantId")
                        .HasColumnType("char(36)")
                        .HasColumnName("TenantId");

                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("TenantId", "UserId");

                    b.ToTable("AppUserChatCards");
                });

            modelBuilder.Entity("LINGYUN.Abp.MessageService.Chat.UserChatFriend", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<bool>("Black")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40)")
                        .HasColumnName("ConcurrencyStamp");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("CreationTime");

                    b.Property<Guid?>("CreatorId")
                        .HasColumnType("char(36)")
                        .HasColumnName("CreatorId");

                    b.Property<string>("Description")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<bool>("DontDisturb")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("ExtraProperties")
                        .HasColumnType("longtext")
                        .HasColumnName("ExtraProperties");

                    b.Property<Guid>("FrientId")
                        .HasColumnType("char(36)");

                    b.Property<bool>("IsStatic")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("RemarkName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<bool>("SpecialFocus")
                        .HasColumnType("tinyint(1)");

                    b.Property<byte>("Status")
                        .HasColumnType("tinyint unsigned");

                    b.Property<Guid?>("TenantId")
                        .HasColumnType("char(36)")
                        .HasColumnName("TenantId");

                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("TenantId", "UserId", "FrientId");

                    b.ToTable("AppUserChatFriends");
                });

            modelBuilder.Entity("LINGYUN.Abp.MessageService.Chat.UserChatSetting", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<bool>("AllowAddFriend")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("AllowAnonymous")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("AllowReceiveMessage")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("AllowSendMessage")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("RequireAddFriendValition")
                        .HasColumnType("tinyint(1)");

                    b.Property<Guid?>("TenantId")
                        .HasColumnType("char(36)")
                        .HasColumnName("TenantId");

                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("TenantId", "UserId");

                    b.ToTable("AppUserChatSettings");
                });

            modelBuilder.Entity("LINGYUN.Abp.MessageService.Chat.UserMessage", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40)")
                        .HasColumnName("ConcurrencyStamp");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(1048576)
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("CreationTime");

                    b.Property<Guid?>("CreatorId")
                        .HasColumnType("char(36)")
                        .HasColumnName("CreatorId");

                    b.Property<string>("ExtraProperties")
                        .HasColumnType("longtext")
                        .HasColumnName("ExtraProperties");

                    b.Property<long>("MessageId")
                        .HasColumnType("bigint");

                    b.Property<Guid>("ReceiveUserId")
                        .HasColumnType("char(36)");

                    b.Property<sbyte>("SendState")
                        .HasColumnType("tinyint");

                    b.Property<string>("SendUserName")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)");

                    b.Property<int>("Source")
                        .HasColumnType("int");

                    b.Property<Guid?>("TenantId")
                        .HasColumnType("char(36)")
                        .HasColumnName("TenantId");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TenantId", "ReceiveUserId");

                    b.ToTable("AppUserMessages");
                });

            modelBuilder.Entity("LINGYUN.Abp.MessageService.Groups.ChatGroup", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("Address")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<Guid>("AdminUserId")
                        .HasColumnType("char(36)");

                    b.Property<bool>("AllowAnonymous")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("AllowSendMessage")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("AvatarUrl")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("CreationTime");

                    b.Property<Guid?>("CreatorId")
                        .HasColumnType("char(36)")
                        .HasColumnName("CreatorId");

                    b.Property<string>("Description")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<long>("GroupId")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("LastModificationTime");

                    b.Property<Guid?>("LastModifierId")
                        .HasColumnType("char(36)")
                        .HasColumnName("LastModifierId");

                    b.Property<int>("MaxUserCount")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Notice")
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)");

                    b.Property<string>("Tag")
                        .HasMaxLength(512)
                        .HasColumnType("varchar(512)");

                    b.Property<Guid?>("TenantId")
                        .HasColumnType("char(36)")
                        .HasColumnName("TenantId");

                    b.HasKey("Id");

                    b.HasIndex("TenantId", "Name");

                    b.ToTable("AppChatGroups");
                });

            modelBuilder.Entity("LINGYUN.Abp.MessageService.Groups.GroupChatBlack", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("CreationTime");

                    b.Property<Guid?>("CreatorId")
                        .HasColumnType("char(36)")
                        .HasColumnName("CreatorId");

                    b.Property<long>("GroupId")
                        .HasColumnType("bigint");

                    b.Property<Guid>("ShieldUserId")
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("TenantId")
                        .HasColumnType("char(36)")
                        .HasColumnName("TenantId");

                    b.HasKey("Id");

                    b.HasIndex("TenantId", "GroupId");

                    b.ToTable("AppGroupChatBlacks");
                });

            modelBuilder.Entity("LINGYUN.Abp.MessageService.Groups.GroupMessage", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40)")
                        .HasColumnName("ConcurrencyStamp");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(1048576)
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("CreationTime");

                    b.Property<Guid?>("CreatorId")
                        .HasColumnType("char(36)")
                        .HasColumnName("CreatorId");

                    b.Property<string>("ExtraProperties")
                        .HasColumnType("longtext")
                        .HasColumnName("ExtraProperties");

                    b.Property<long>("GroupId")
                        .HasColumnType("bigint");

                    b.Property<long>("MessageId")
                        .HasColumnType("bigint");

                    b.Property<sbyte>("SendState")
                        .HasColumnType("tinyint");

                    b.Property<string>("SendUserName")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)");

                    b.Property<int>("Source")
                        .HasColumnType("int");

                    b.Property<Guid?>("TenantId")
                        .HasColumnType("char(36)")
                        .HasColumnName("TenantId");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TenantId", "GroupId");

                    b.ToTable("AppGroupMessages");
                });

            modelBuilder.Entity("LINGYUN.Abp.MessageService.Groups.UserChatGroup", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("CreationTime");

                    b.Property<Guid?>("CreatorId")
                        .HasColumnType("char(36)")
                        .HasColumnName("CreatorId");

                    b.Property<long>("GroupId")
                        .HasColumnType("bigint");

                    b.Property<Guid?>("TenantId")
                        .HasColumnType("char(36)")
                        .HasColumnName("TenantId");

                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("TenantId", "GroupId", "UserId");

                    b.ToTable("AppUserChatGroups");
                });

            modelBuilder.Entity("LINGYUN.Abp.MessageService.Groups.UserGroupCard", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40)")
                        .HasColumnName("ConcurrencyStamp");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("CreationTime");

                    b.Property<Guid?>("CreatorId")
                        .HasColumnType("char(36)")
                        .HasColumnName("CreatorId");

                    b.Property<string>("ExtraProperties")
                        .HasColumnType("longtext")
                        .HasColumnName("ExtraProperties");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("LastModificationTime");

                    b.Property<Guid?>("LastModifierId")
                        .HasColumnType("char(36)")
                        .HasColumnName("LastModifierId");

                    b.Property<string>("NickName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<DateTime?>("SilenceEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid?>("TenantId")
                        .HasColumnType("char(36)")
                        .HasColumnName("TenantId");

                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("TenantId", "UserId");

                    b.ToTable("AppUserGroupCards");
                });

            modelBuilder.Entity("LINGYUN.Abp.MessageService.Notifications.Notification", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("CreationTime");

                    b.Property<DateTime?>("ExpirationTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("ExtraProperties")
                        .HasColumnType("longtext")
                        .HasColumnName("ExtraProperties");

                    b.Property<long>("NotificationId")
                        .HasColumnType("bigint");

                    b.Property<string>("NotificationName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("NotificationTypeName")
                        .IsRequired()
                        .HasMaxLength(512)
                        .HasColumnType("varchar(512)");

                    b.Property<sbyte>("Severity")
                        .HasColumnType("tinyint");

                    b.Property<Guid?>("TenantId")
                        .HasColumnType("char(36)")
                        .HasColumnName("TenantId");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TenantId", "NotificationName");

                    b.ToTable("AppNotifications");
                });

            modelBuilder.Entity("LINGYUN.Abp.MessageService.Notifications.UserNotification", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<long>("NotificationId")
                        .HasColumnType("bigint");

                    b.Property<int>("ReadStatus")
                        .HasColumnType("int");

                    b.Property<Guid?>("TenantId")
                        .HasColumnType("char(36)")
                        .HasColumnName("TenantId");

                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("TenantId", "UserId", "NotificationId")
                        .HasDatabaseName("IX_Tenant_User_Notification_Id");

                    b.ToTable("AppUserNotifications");
                });

            modelBuilder.Entity("LINGYUN.Abp.MessageService.Subscriptions.UserSubscribe", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("CreationTime");

                    b.Property<string>("NotificationName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<Guid?>("TenantId")
                        .HasColumnType("char(36)")
                        .HasColumnName("TenantId");

                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)")
                        .HasDefaultValue("/");

                    b.HasKey("Id");

                    b.HasIndex("TenantId", "UserId", "NotificationName")
                        .IsUnique()
                        .HasDatabaseName("IX_Tenant_User_Notification_Name");

                    b.ToTable("AppUserSubscribes");
                });
#pragma warning restore 612, 618
        }
    }
}
