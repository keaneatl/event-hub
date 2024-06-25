﻿// <auto-generated />
using System;
using EventHub.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EventHub.Migrations
{
    [DbContext(typeof(EventHubussyContext))]
    partial class EventHubussyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EventHub.Entities.Event", b =>
                {
                    b.Property<int>("EventId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("EventID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EventId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Event1")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Event");

                    b.Property<int>("EventTypeId")
                        .HasColumnType("int")
                        .HasColumnName("EventTypeID");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("Price")
                        .HasColumnType("money");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime");

                    b.HasKey("EventId");

                    b.HasIndex("EventTypeId");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("EventHub.Entities.EventType", b =>
                {
                    b.Property<int>("EventTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("EventTypeID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EventTypeId"));

                    b.Property<string>("EventType1")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("EventType");

                    b.HasKey("EventTypeId")
                        .HasName("PK_tblEventType");

                    b.ToTable("EventTypes");
                });

            modelBuilder.Entity("EventHub.Entities.Organizer", b =>
                {
                    b.Property<int>("OrganizerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("OrganizerID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrganizerId"));

                    b.Property<string>("BusinessContactNumber")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("BusinessEmail")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Headquarters")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Organizer1")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Organizer");

                    b.HasKey("OrganizerId");

                    b.ToTable("Organizers");
                });

            modelBuilder.Entity("EventHub.Entities.OrganizerEvent", b =>
                {
                    b.Property<int>("OrganizerEventId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("OrganizerEventID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrganizerEventId"));

                    b.Property<DateTime>("ApplicationDate")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("ApprovalDate")
                        .HasColumnType("datetime");

                    b.Property<bool?>("ApprovalStatus")
                        .HasColumnType("bit");

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<int>("EventId")
                        .HasColumnType("int")
                        .HasColumnName("EventID");

                    b.Property<int>("OrganizerId")
                        .HasColumnType("int")
                        .HasColumnName("OrganizerID");

                    b.HasKey("OrganizerEventId");

                    b.HasIndex("EventId");

                    b.HasIndex("OrganizerId");

                    b.ToTable("OrganizerEvents");
                });

            modelBuilder.Entity("EventHub.Entities.Ticket", b =>
                {
                    b.Property<int>("TicketId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("TicketID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TicketId"));

                    b.Property<int>("EventId")
                        .HasColumnType("int")
                        .HasColumnName("EventID");

                    b.Property<decimal>("Price")
                        .HasColumnType("money");

                    b.Property<string>("Ticket1")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Ticket");

                    b.HasKey("TicketId");

                    b.HasIndex("EventId");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("EventHub.Entities.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("UserID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("OrganizerId")
                        .HasColumnType("int")
                        .HasColumnName("OrganizerID");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("binary(64)")
                        .IsFixedLength();

                    b.Property<string>("Salt")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("UserInformationId")
                        .HasColumnType("int")
                        .HasColumnName("UserInformationID");

                    b.HasKey("UserId")
                        .HasName("PK_tblUsers");

                    b.HasIndex("OrganizerId");

                    b.HasIndex("UserInformationId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("EventHub.Entities.UserInformation", b =>
                {
                    b.Property<int>("UserInformationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("UserInformationID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserInformationId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ContactNumber")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("MiddleName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("UserInformationId");

                    b.ToTable("UserInformation", (string)null);
                });

            modelBuilder.Entity("EventHub.Entities.UserTicket", b =>
                {
                    b.Property<int>("UserTicketId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("UserTicketID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserTicketId"));

                    b.Property<string>("Description")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PaymentMethod")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("PurchaseDate")
                        .HasColumnType("datetime");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("TicketId")
                        .HasColumnType("int")
                        .HasColumnName("TicketID");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("UserID");

                    b.HasKey("UserTicketId");

                    b.HasIndex("UserId");

                    b.ToTable("UserTickets");
                });

            modelBuilder.Entity("EventHub.Entities.Event", b =>
                {
                    b.HasOne("EventHub.Entities.EventType", "EventType")
                        .WithMany("Events")
                        .HasForeignKey("EventTypeId")
                        .IsRequired()
                        .HasConstraintName("FK_Events_EventTypes");

                    b.Navigation("EventType");
                });

            modelBuilder.Entity("EventHub.Entities.OrganizerEvent", b =>
                {
                    b.HasOne("EventHub.Entities.Event", "Event")
                        .WithMany("OrganizerEvents")
                        .HasForeignKey("EventId")
                        .IsRequired()
                        .HasConstraintName("FK_OrganizerEvents_Events");

                    b.HasOne("EventHub.Entities.Organizer", "Organizer")
                        .WithMany("OrganizerEvents")
                        .HasForeignKey("OrganizerId")
                        .IsRequired()
                        .HasConstraintName("FK_OrganizerEvents_Organizers");

                    b.Navigation("Event");

                    b.Navigation("Organizer");
                });

            modelBuilder.Entity("EventHub.Entities.Ticket", b =>
                {
                    b.HasOne("EventHub.Entities.Event", "Event")
                        .WithMany("Tickets")
                        .HasForeignKey("EventId")
                        .IsRequired()
                        .HasConstraintName("FK_Tickets_Events");

                    b.Navigation("Event");
                });

            modelBuilder.Entity("EventHub.Entities.User", b =>
                {
                    b.HasOne("EventHub.Entities.Organizer", "Organizer")
                        .WithMany("Users")
                        .HasForeignKey("OrganizerId")
                        .HasConstraintName("FK_Users_Organizers");

                    b.HasOne("EventHub.Entities.UserInformation", "UserInformation")
                        .WithMany("Users")
                        .HasForeignKey("UserInformationId")
                        .IsRequired()
                        .HasConstraintName("FK_Users_UserInformation");

                    b.Navigation("Organizer");

                    b.Navigation("UserInformation");
                });

            modelBuilder.Entity("EventHub.Entities.UserTicket", b =>
                {
                    b.HasOne("EventHub.Entities.Ticket", "User")
                        .WithMany("UserTickets")
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("FK_UserTickets_Tickets");

                    b.HasOne("EventHub.Entities.User", "UserNavigation")
                        .WithMany("UserTickets")
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("FK_UserTickets_Users");

                    b.Navigation("User");

                    b.Navigation("UserNavigation");
                });

            modelBuilder.Entity("EventHub.Entities.Event", b =>
                {
                    b.Navigation("OrganizerEvents");

                    b.Navigation("Tickets");
                });

            modelBuilder.Entity("EventHub.Entities.EventType", b =>
                {
                    b.Navigation("Events");
                });

            modelBuilder.Entity("EventHub.Entities.Organizer", b =>
                {
                    b.Navigation("OrganizerEvents");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("EventHub.Entities.Ticket", b =>
                {
                    b.Navigation("UserTickets");
                });

            modelBuilder.Entity("EventHub.Entities.User", b =>
                {
                    b.Navigation("UserTickets");
                });

            modelBuilder.Entity("EventHub.Entities.UserInformation", b =>
                {
                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}