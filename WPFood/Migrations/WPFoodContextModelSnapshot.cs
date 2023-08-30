﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WPFood.Outils;

#nullable disable

namespace WPFood.Migrations
{
    [DbContext(typeof(WPFoodContext))]
    partial class WPFoodContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("WPFood.Modeles.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("EstPasse")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("IdTable")
                        .HasColumnType("int");

                    b.Property<int>("NumTable")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("WPFood.Modeles.CommandeClient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("EstPaye")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("EstTermine")
                        .HasColumnType("tinyint(1)");

                    b.Property<int?>("FactureId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("FactureId");

                    b.ToTable("CommandesClients");
                });

            modelBuilder.Entity("WPFood.Modeles.CommandeClientItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CommandeClientId")
                        .HasColumnType("int");

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Quantite")
                        .HasColumnType("int");

                    b.Property<int>("itemId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CommandeClientId");

                    b.HasIndex("itemId");

                    b.ToTable("CommandesClientsItems");
                });

            modelBuilder.Entity("WPFood.Modeles.CommandeFournisseur", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCommande")
                        .HasColumnType("date");

                    b.Property<float>("PrixTotal")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("CommandesFournisseurs");
                });

            modelBuilder.Entity("WPFood.Modeles.CommandeFournisseurItems", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CommandeFournisseurId")
                        .HasColumnType("int");

                    b.Property<int>("QuantiteItem")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CommandeFournisseurId");

                    b.ToTable("CommandesFournisseursItems");
                });

            modelBuilder.Entity("WPFood.Modeles.Commentaire", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CommentaireClient")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("DateCommentaire")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("EstRecommende")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("NomClient")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("NomServeur")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Commentaires");
                });

            modelBuilder.Entity("WPFood.Modeles.Employe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DateNaissance")
                        .HasColumnType("date");

                    b.Property<string>("Fonction")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Identifiant")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)");

                    b.Property<string>("MotDePasse")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Employes");
                });

            modelBuilder.Entity("WPFood.Modeles.Facture", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DatePaiement")
                        .HasColumnType("datetime(6)");

                    b.Property<double>("MontantTPS")
                        .HasColumnType("double");

                    b.Property<double>("MontantTVQ")
                        .HasColumnType("double");

                    b.Property<double>("SousTotal")
                        .HasColumnType("double");

                    b.Property<double>("Total")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.ToTable("Factures");
                });

            modelBuilder.Entity("WPFood.Modeles.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Categorie")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<double>("Prix")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("WPFood.Modeles.Menu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Categorie")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("varchar(25)");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("varchar(25)");

                    b.Property<string>("Saison")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("varchar(25)");

                    b.HasKey("Id");

                    b.ToTable("Menu");
                });

            modelBuilder.Entity("WPFood.Modeles.MenuItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.Property<int>("MenuId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ItemId");

                    b.HasIndex("MenuId");

                    b.ToTable("MenusItems");
                });

            modelBuilder.Entity("WPFood.Modeles.Reservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DateReservation")
                        .HasColumnType("datetime");

                    b.Property<int>("NbClientAttendu")
                        .HasColumnType("int");

                    b.Property<string>("NomClient")
                        .IsRequired()
                        .HasMaxLength(75)
                        .HasColumnType("varchar(75)");

                    b.Property<string>("NumeroTelephone")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<int>("TableId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TableId");

                    b.ToTable("Reservation");
                });

            modelBuilder.Entity("WPFood.Modeles.Service", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DateDebut")
                        .HasColumnType("date");

                    b.Property<DateTime>("DateFin")
                        .HasColumnType("date");

                    b.Property<int>("EmployeId")
                        .HasColumnType("int");

                    b.Property<int>("TableId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EmployeId");

                    b.HasIndex("TableId");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("WPFood.Modeles.Table", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Etat")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("NbClients")
                        .HasColumnType("int");

                    b.Property<int>("NbPlacesMax")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Tables");
                });

            modelBuilder.Entity("WPFood.Modeles.CommandeClient", b =>
                {
                    b.HasOne("WPFood.Modeles.Client", "Client")
                        .WithMany("CommandesClients")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WPFood.Modeles.Facture", null)
                        .WithMany("CommandesClients")
                        .HasForeignKey("FactureId");

                    b.Navigation("Client");
                });

            modelBuilder.Entity("WPFood.Modeles.CommandeClientItem", b =>
                {
                    b.HasOne("WPFood.Modeles.CommandeClient", "CommandeClient")
                        .WithMany("CommandeClientItems")
                        .HasForeignKey("CommandeClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WPFood.Modeles.Item", "item")
                        .WithMany("CommandeClientsItem")
                        .HasForeignKey("itemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CommandeClient");

                    b.Navigation("item");
                });

            modelBuilder.Entity("WPFood.Modeles.CommandeFournisseurItems", b =>
                {
                    b.HasOne("WPFood.Modeles.CommandeFournisseur", "CommandeFournisseur")
                        .WithMany("CommandesFournisseursItems")
                        .HasForeignKey("CommandeFournisseurId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CommandeFournisseur");
                });

            modelBuilder.Entity("WPFood.Modeles.MenuItem", b =>
                {
                    b.HasOne("WPFood.Modeles.Item", "Item")
                        .WithMany()
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WPFood.Modeles.Menu", "Menu")
                        .WithMany("MenusItems")
                        .HasForeignKey("MenuId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Item");

                    b.Navigation("Menu");
                });

            modelBuilder.Entity("WPFood.Modeles.Reservation", b =>
                {
                    b.HasOne("WPFood.Modeles.Table", "Table")
                        .WithMany()
                        .HasForeignKey("TableId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Table");
                });

            modelBuilder.Entity("WPFood.Modeles.Service", b =>
                {
                    b.HasOne("WPFood.Modeles.Employe", "Employe")
                        .WithMany("Services")
                        .HasForeignKey("EmployeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WPFood.Modeles.Table", "Table")
                        .WithMany("Services")
                        .HasForeignKey("TableId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employe");

                    b.Navigation("Table");
                });

            modelBuilder.Entity("WPFood.Modeles.Client", b =>
                {
                    b.Navigation("CommandesClients");
                });

            modelBuilder.Entity("WPFood.Modeles.CommandeClient", b =>
                {
                    b.Navigation("CommandeClientItems");
                });

            modelBuilder.Entity("WPFood.Modeles.CommandeFournisseur", b =>
                {
                    b.Navigation("CommandesFournisseursItems");
                });

            modelBuilder.Entity("WPFood.Modeles.Employe", b =>
                {
                    b.Navigation("Services");
                });

            modelBuilder.Entity("WPFood.Modeles.Facture", b =>
                {
                    b.Navigation("CommandesClients");
                });

            modelBuilder.Entity("WPFood.Modeles.Item", b =>
                {
                    b.Navigation("CommandeClientsItem");
                });

            modelBuilder.Entity("WPFood.Modeles.Menu", b =>
                {
                    b.Navigation("MenusItems");
                });

            modelBuilder.Entity("WPFood.Modeles.Table", b =>
                {
                    b.Navigation("Services");
                });
#pragma warning restore 612, 618
        }
    }
}
