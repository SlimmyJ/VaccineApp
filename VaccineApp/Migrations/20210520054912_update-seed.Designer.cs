﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VaccineApp;

namespace VaccineApp.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20210520054912_update-seed")]
    partial class updateseed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("VaccineApp.Entities.Appointment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("LocationId")
                        .HasColumnType("int");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("VaccinationId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LocationId");

                    b.HasIndex("StatusId");

                    b.HasIndex("UserId");

                    b.HasIndex("VaccinationId");

                    b.ToTable("Appointments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Date = new DateTime(2021, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LocationId = 1,
                            StatusId = 1,
                            UserId = 1,
                            VaccinationId = 1
                        });
                });

            modelBuilder.Entity("VaccineApp.Entities.AppointmentStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Status")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("AppointmentStatuses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Status = "Approved"
                        },
                        new
                        {
                            Id = 2,
                            Status = "Canceled"
                        },
                        new
                        {
                            Id = 3,
                            Status = "Administered"
                        });
                });

            modelBuilder.Entity("VaccineApp.Entities.BodyPart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("BodyParts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Eyes"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Nose"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Mouth"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Ears"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Left Arm"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Right Arm"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Torso"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Legs"
                        });
                });

            modelBuilder.Entity("VaccineApp.Entities.Login", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("varbinary(max)");

                    b.HasKey("Id");

                    b.ToTable("Logins");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "test",
                            PasswordHash = new byte[] { 98, 237, 55, 191, 198, 115, 79, 209, 128, 53, 215, 212, 160, 48, 183, 82, 200, 215, 153, 145, 163, 25, 100, 98, 118, 125, 240, 230, 100, 99, 216, 245, 106, 169, 187, 53, 189, 212, 205, 65, 107, 123, 236, 92, 21, 27, 130, 186, 191, 198, 255, 162, 160, 49, 127, 96, 186, 216, 17, 144, 16, 200, 73, 46 },
                            PasswordSalt = new byte[] { 20, 96, 59, 5, 93, 61, 15, 214, 207, 117, 33, 98, 157, 168, 17, 45, 210, 4, 50, 81, 50, 222, 25, 154, 69, 196, 161, 118, 175, 103, 83, 228, 191, 147, 131, 106, 219, 110, 80, 54, 225, 242, 126, 254, 194, 216, 216, 172, 175, 6, 73, 54, 174, 95, 235, 224, 217, 208, 194, 193, 66, 199, 165, 100, 201, 159, 246, 160, 85, 234, 123, 84, 177, 82, 242, 163, 89, 19, 129, 148, 40, 163, 112, 120, 225, 185, 218, 92, 37, 181, 7, 253, 64, 186, 111, 224, 10, 230, 126, 45, 40, 2, 189, 42, 247, 32, 238, 203, 249, 144, 249, 154, 57, 203, 140, 214, 122, 50, 178, 135, 10, 174, 53, 94, 41, 108, 51, 143 }
                        });
                });

            modelBuilder.Entity("VaccineApp.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("LoginId")
                        .HasColumnType("int");

                    b.Property<string>("Surname")
                        .HasMaxLength(55)
                        .HasColumnType("nvarchar(55)");

                    b.HasKey("Id");

                    b.HasIndex("LoginId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Koekoekstraat 70, 9090 Melle",
                            BirthDate = new DateTime(1940, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Bond",
                            LoginId = 1,
                            Surname = "James"
                        });
                });

            modelBuilder.Entity("VaccineApp.Entities.VaccinationCenter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("VaccinationCenters");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Location = "1083 Brussel",
                            Name = "Basilik of Koekelmountain"
                        },
                        new
                        {
                            Id = 2,
                            Location = "Sint-Veerleplein 11, 9000 Gent",
                            Name = "Dukestones Center"
                        },
                        new
                        {
                            Id = 3,
                            Location = "Schijnpoortweg 119, 2170 Antwerpen",
                            Name = "Sportpalace"
                        },
                        new
                        {
                            Id = 4,
                            Location = "Wijnzakstraat 2, 8000 Brugge",
                            Name = "Chocostory Center"
                        },
                        new
                        {
                            Id = 5,
                            Location = "Kursaal-Oosthelling 12, 8400 Oostende",
                            Name = "Casino Center"
                        },
                        new
                        {
                            Id = 6,
                            Location = "Rue Basse Commène, 6940 Barvaux-sur-Ourthe",
                            Name = "Barvaux Labyrint"
                        },
                        new
                        {
                            Id = 7,
                            Location = "Route Merveilleuse 64, 5000 Namur",
                            Name = "Citadel Center"
                        },
                        new
                        {
                            Id = 8,
                            Location = "Allée Frédéric Chopin, 4020 Liège",
                            Name = "Boverie Castle Center"
                        },
                        new
                        {
                            Id = 9,
                            Location = "Zwin, Knokke-Heist",
                            Name = "Zwin Center"
                        },
                        new
                        {
                            Id = 10,
                            Location = "Mariakerkeplein, 9030 Mariakerke",
                            Name = "OLV Center"
                        },
                        new
                        {
                            Id = 11,
                            Location = "Kasteel van Poeke, 9880 Aalter",
                            Name = "Central Castle of Poeke"
                        },
                        new
                        {
                            Id = 12,
                            Location = "Nieuwelaan 38, 1860 Meise",
                            Name = "Green Meise Garden"
                        },
                        new
                        {
                            Id = 13,
                            Location = "Technologielaan 1, 2800 Mechelen",
                            Name = "Technopolis Center"
                        });
                });

            modelBuilder.Entity("VaccineApp.Entities.Vaccine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BodyPartId")
                        .HasColumnType("int");

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("BodyPartId");

                    b.HasIndex("CompanyId");

                    b.ToTable("Vaccines");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BodyPartId = 1,
                            CompanyId = 2,
                            Description = "eases ability to track traces (cfr. Sniff with eyes)",
                            Name = "Eyetraxx"
                        },
                        new
                        {
                            Id = 2,
                            BodyPartId = 2,
                            CompanyId = 4,
                            Description = "improves detection of  smell and automatchmaking with scent library; library not included",
                            Name = "Smell ID Vaxx"
                        },
                        new
                        {
                            Id = 3,
                            BodyPartId = 3,
                            CompanyId = 6,
                            Description = "increases strength of bite to digest food more and faster",
                            Name = "Bitexx"
                        },
                        new
                        {
                            Id = 4,
                            BodyPartId = 4,
                            CompanyId = 8,
                            Description = "creates ability to mute sound selectively",
                            Name = "Pluginixx"
                        },
                        new
                        {
                            Id = 5,
                            BodyPartId = 5,
                            CompanyId = 1,
                            Description = "accumulates body hair and increases vertical strength in left arm",
                            Name = "Scottish Tree Vaxx (L)"
                        },
                        new
                        {
                            Id = 6,
                            BodyPartId = 6,
                            CompanyId = 3,
                            Description = "accumulates body hair and increases vertical strength in right arm",
                            Name = "Scottish Tree Vaxx (R) "
                        },
                        new
                        {
                            Id = 7,
                            BodyPartId = 7,
                            CompanyId = 5,
                            Description = "absorbes scars, marks and heals wounds",
                            Name = "Tattoo e-Way"
                        },
                        new
                        {
                            Id = 8,
                            BodyPartId = 8,
                            CompanyId = 7,
                            Description = "regulates hairgrow and smoothness",
                            Name = "Shave & Sound Vaxx"
                        },
                        new
                        {
                            Id = 9,
                            BodyPartId = 1,
                            CompanyId = 2,
                            Description = "improves eyesight in distance and sharpness (cfr. Hawkview)",
                            Name = "LaserPixx"
                        },
                        new
                        {
                            Id = 10,
                            BodyPartId = 2,
                            CompanyId = 4,
                            Description = "creates ability to personalize filters in type of smells;  extendable with extern scent library",
                            Name = "Filter Vaxx"
                        },
                        new
                        {
                            Id = 11,
                            BodyPartId = 3,
                            CompanyId = 6,
                            Description = "increases size and strength of tongue; premedical advice required",
                            Name = "Tasteroni XXL"
                        },
                        new
                        {
                            Id = 12,
                            BodyPartId = 4,
                            CompanyId = 8,
                            Description = "improves detection of  sound and automatchmaking with sound library; library not included",
                            Name = "Smart Sound ID Vaxx"
                        },
                        new
                        {
                            Id = 13,
                            BodyPartId = 5,
                            CompanyId = 1,
                            Description = "increases horizontal strength in left arm including titanium grip",
                            Name = "Truck Trixx (L)"
                        },
                        new
                        {
                            Id = 14,
                            BodyPartId = 6,
                            CompanyId = 3,
                            Description = "increases horizontal strength in right arm including titanium grip",
                            Name = "Truck Trixx (R)"
                        },
                        new
                        {
                            Id = 15,
                            BodyPartId = 7,
                            CompanyId = 5,
                            Description = "regulates hairgrow",
                            Name = "Clean Skinnex"
                        },
                        new
                        {
                            Id = 16,
                            BodyPartId = 8,
                            CompanyId = 7,
                            Description = "boosts  energy supply and coordinates physical waste for legmuscles",
                            Name = "Bolt Lightning Vaxx"
                        },
                        new
                        {
                            Id = 17,
                            BodyPartId = 1,
                            CompanyId = 2,
                            Description = "muscles of eyeballs soften and become flexible and trainable using eyes seperately (cfr. The Cameleon Effect)",
                            Name = "IO2 Vaxx"
                        },
                        new
                        {
                            Id = 18,
                            BodyPartId = 2,
                            CompanyId = 4,
                            Description = "manipulates nostrils to lower or increase volume",
                            Name = "Trump Vaxx"
                        },
                        new
                        {
                            Id = 19,
                            BodyPartId = 3,
                            CompanyId = 6,
                            Description = "ionizes production of saliva creating a more delicate substance usable for handy to industrial purposes",
                            Name = "Fluo Secretional"
                        },
                        new
                        {
                            Id = 20,
                            BodyPartId = 4,
                            CompanyId = 8,
                            Description = "ionizes earmembrane and earwax to manipulate soundwaves and add soundeffects",
                            Name = "Soundmaxx 5.0"
                        },
                        new
                        {
                            Id = 21,
                            BodyPartId = 5,
                            CompanyId = 1,
                            Description = "recalibrates muscle tension and joint pressure for optimal wrestling condition in left arm",
                            Name = "WWE Arms (L)"
                        },
                        new
                        {
                            Id = 22,
                            BodyPartId = 6,
                            CompanyId = 3,
                            Description = "recalibrates muscle tension and joint pressure for optimal wrestling condition in right arm",
                            Name = "WWE Arms (R)"
                        },
                        new
                        {
                            Id = 23,
                            BodyPartId = 7,
                            CompanyId = 5,
                            Description = "manipulates various aspects of skin colour",
                            Name = "Rainbow Vaxx"
                        },
                        new
                        {
                            Id = 24,
                            BodyPartId = 8,
                            CompanyId = 7,
                            Description = "manipulates connectivity from nervesystem with brains; link to satellite not yet included",
                            Name = "Smart Geographical Cruiser"
                        },
                        new
                        {
                            Id = 25,
                            BodyPartId = 1,
                            CompanyId = 2,
                            Description = "stimulates the rapid-eye-movement in order to heal faster and improve transition from short-term to long-term memory",
                            Name = "REMEXX"
                        },
                        new
                        {
                            Id = 26,
                            BodyPartId = 2,
                            CompanyId = 4,
                            Description = "regulate hydration of nose and nasal cavity; avoid sinusitis, flue and other common diseases",
                            Name = "DeHydra Vaxx"
                        },
                        new
                        {
                            Id = 27,
                            BodyPartId = 3,
                            CompanyId = 6,
                            Description = "strengthens the teethstructure making the teeth razor sharp ",
                            Name = "Teeth Barrier"
                        },
                        new
                        {
                            Id = 28,
                            BodyPartId = 4,
                            CompanyId = 8,
                            Description = "influences stimulus transfer from ear to brains improving soundexperience",
                            Name = "Dolby Atmos Vaxx"
                        },
                        new
                        {
                            Id = 29,
                            BodyPartId = 5,
                            CompanyId = 1,
                            Description = "strengthens tip of elbow",
                            Name = "Iron Elbow Vaxx"
                        },
                        new
                        {
                            Id = 30,
                            BodyPartId = 6,
                            CompanyId = 3,
                            Description = "makes right arm more rigid and sensitive to certain sounds (i.e. words, sentences, songs…); governance admission required",
                            Name = "XXtreme Righteous"
                        },
                        new
                        {
                            Id = 31,
                            BodyPartId = 7,
                            CompanyId = 5,
                            Description = "regulates intensity of transpiration and hydration",
                            Name = "NoTrans Scentexx"
                        },
                        new
                        {
                            Id = 32,
                            BodyPartId = 8,
                            CompanyId = 7,
                            Description = "modifies blood pressure and veinthickness for concentrated explosions of mass energy boosts",
                            Name = "Silver Trampolympixx"
                        },
                        new
                        {
                            Id = 33,
                            BodyPartId = 1,
                            CompanyId = 2,
                            Description = "transforms iris and dark chamber into instant photo memories directly implemented into memory; extendable with HD",
                            Name = "Scan Optixx"
                        },
                        new
                        {
                            Id = 34,
                            BodyPartId = 2,
                            CompanyId = 4,
                            Description = "increases stimulus transfer from nose to brains saving more scentdata in memory for certain period; period extendable per 25, 50 or 100 years ",
                            Name = "Scentury 2000 Vaxx"
                        },
                        new
                        {
                            Id = 35,
                            BodyPartId = 3,
                            CompanyId = 6,
                            Description = "influences jaw interior creating ability to modify the sound, quality, tone… of voice",
                            Name = "Voice Ovexx"
                        },
                        new
                        {
                            Id = 36,
                            BodyPartId = 4,
                            CompanyId = 8,
                            Description = "improves detection in distance and frequency",
                            Name = "Enigma Pulsar Vaxx"
                        },
                        new
                        {
                            Id = 37,
                            BodyPartId = 5,
                            CompanyId = 1,
                            Description = "ionizes the nervesystem into linking and fasten stimulus transfer from left arm to brains",
                            Name = "Write & Wrong Vaxx"
                        },
                        new
                        {
                            Id = 38,
                            BodyPartId = 6,
                            CompanyId = 3,
                            Description = "recalibrates muscle tension and joint pressure for optimal coffeecup holding; discount for softwaredevelopers",
                            Name = "StarBoxx"
                        },
                        new
                        {
                            Id = 39,
                            BodyPartId = 7,
                            CompanyId = 5,
                            Description = "recalibrates muscle tension and volume for optimal bodysculpture",
                            Name = "Cathedral FX 2.0"
                        },
                        new
                        {
                            Id = 40,
                            BodyPartId = 8,
                            CompanyId = 7,
                            Description = "increases production of pheromones and  smoothness skinmodification and auto hairgrowth management",
                            Name = "Golden Lady Vaxx"
                        });
                });

            modelBuilder.Entity("VaccineApp.Entities.VaccineCompany", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Country")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsEmaApproved")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("VaccineCompanies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Country = "Russia",
                            IsEmaApproved = false,
                            Name = "BigEvilCo"
                        },
                        new
                        {
                            Id = 2,
                            Country = "United States of America",
                            IsEmaApproved = true,
                            Name = "Pfizer-BioNTech"
                        },
                        new
                        {
                            Id = 3,
                            Country = "Belgium",
                            IsEmaApproved = true,
                            Name = "Janssen Pharmaceutica"
                        },
                        new
                        {
                            Id = 4,
                            Country = "United States of America",
                            IsEmaApproved = true,
                            Name = "Johnson & Johnson"
                        },
                        new
                        {
                            Id = 5,
                            Country = "United Kingdom",
                            IsEmaApproved = true,
                            Name = "AstraZeneca"
                        },
                        new
                        {
                            Id = 6,
                            Country = "United States of America",
                            IsEmaApproved = false,
                            Name = "Moderna"
                        },
                        new
                        {
                            Id = 7,
                            Country = "Russia",
                            IsEmaApproved = false,
                            Name = "Sputnik"
                        },
                        new
                        {
                            Id = 8,
                            Country = "Netherlands",
                            IsEmaApproved = false,
                            Name = "Heineken"
                        });
                });

            modelBuilder.Entity("VaccineApp.Entities.Appointment", b =>
                {
                    b.HasOne("VaccineApp.Entities.VaccinationCenter", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VaccineApp.Entities.AppointmentStatus", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VaccineApp.Entities.User", null)
                        .WithMany("Appointments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VaccineApp.Entities.Vaccine", "Vaccination")
                        .WithMany()
                        .HasForeignKey("VaccinationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Location");

                    b.Navigation("Status");

                    b.Navigation("Vaccination");
                });

            modelBuilder.Entity("VaccineApp.Entities.User", b =>
                {
                    b.HasOne("VaccineApp.Entities.Login", "Login")
                        .WithMany()
                        .HasForeignKey("LoginId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Login");
                });

            modelBuilder.Entity("VaccineApp.Entities.Vaccine", b =>
                {
                    b.HasOne("VaccineApp.Entities.BodyPart", "BodyPart")
                        .WithMany()
                        .HasForeignKey("BodyPartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VaccineApp.Entities.VaccineCompany", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BodyPart");

                    b.Navigation("Company");
                });

            modelBuilder.Entity("VaccineApp.Entities.User", b =>
                {
                    b.Navigation("Appointments");
                });
#pragma warning restore 612, 618
        }
    }
}
