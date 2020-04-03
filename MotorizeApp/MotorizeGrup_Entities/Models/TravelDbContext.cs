using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MotorizeGrup_Entities.Models
{
    public partial class TravelDbContext : DbContext
    {
        public TravelDbContext()
        {
        }

        public TravelDbContext(DbContextOptions<TravelDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AirRoutes> AirRoutes { get; set; }
        public virtual DbSet<AirSeatType> AirSeatType { get; set; }
        public virtual DbSet<AirShipExpedition> AirShipExpedition { get; set; }
        public virtual DbSet<AirShipTickets> AirShipTickets { get; set; }
        public virtual DbSet<AirShips> AirShips { get; set; }
        public virtual DbSet<AirWayCompany> AirWayCompany { get; set; }
        public virtual DbSet<Airports> Airports { get; set; }
        public virtual DbSet<CarLuxury> CarLuxury { get; set; }
        public virtual DbSet<Cars> Cars { get; set; }
        public virtual DbSet<CarsHasRent> CarsHasRent { get; set; }
        public virtual DbSet<Countries> Countries { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<District> District { get; set; }
        public virtual DbSet<Facilities> Facilities { get; set; }
        public virtual DbSet<ItemCars> ItemCars { get; set; }
        public virtual DbSet<OtelRoomType> OtelRoomType { get; set; }
        public virtual DbSet<OtelRooms> OtelRooms { get; set; }
        public virtual DbSet<OtelTypes> OtelTypes { get; set; }
        public virtual DbSet<Otels> Otels { get; set; }
        public virtual DbSet<Photos> Photos { get; set; }
        public virtual DbSet<Provinces> Provinces { get; set; }
        public virtual DbSet<RentcarCompany> RentcarCompany { get; set; }
        public virtual DbSet<RestaurantCoupons> RestaurantCoupons { get; set; }
        public virtual DbSet<Restauranties> Restauranties { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=OUZ;Database=TravelDb;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AirRoutes>(entity =>
            {
                entity.HasKey(e => e.RoutesId)
                    .HasName("PK__AirRoute__EC7E59D4D5AA2348");

                entity.Property(e => e.RoutesId).HasColumnName("Routes_Id");

                entity.Property(e => e.RoutesFromId).HasColumnName("Routes_From_Id");

                entity.Property(e => e.RoutesToId).HasColumnName("Routes_To_Id");

                entity.HasOne(d => d.RoutesFrom)
                    .WithMany(p => p.AirRoutesRoutesFrom)
                    .HasForeignKey(d => d.RoutesFromId)
                    .HasConstraintName("FK__AirRoutes__Route__45F365D3");

                entity.HasOne(d => d.RoutesTo)
                    .WithMany(p => p.AirRoutesRoutesTo)
                    .HasForeignKey(d => d.RoutesToId)
                    .HasConstraintName("FK__AirRoutes__Route__46E78A0C");
            });

            modelBuilder.Entity<AirSeatType>(entity =>
            {
                entity.HasKey(e => e.SeatTypeId)
                    .HasName("PK__AirSeatT__9BB5FA080D435B36");

                entity.Property(e => e.SeatTypeId).HasColumnName("SeatType_Id");

                entity.Property(e => e.SeatTypeName)
                    .HasColumnName("SeatType_Name")
                    .HasMaxLength(15);
            });

            modelBuilder.Entity<AirShipExpedition>(entity =>
            {
                entity.HasKey(e => e.ExpeditionId)
                    .HasName("PK__AirShipE__0522DA3FB14ED224");

                entity.Property(e => e.ExpeditionId).HasColumnName("Expedition_Id");

                entity.Property(e => e.AirShipsIdNumb).HasColumnName("AirShips_IdNumb");

                entity.Property(e => e.IsFull).HasDefaultValueSql("((0))");

                entity.Property(e => e.Price).HasColumnType("money");

                entity.HasOne(d => d.ExpeditionClassNavigation)
                    .WithMany(p => p.AirShipExpedition)
                    .HasForeignKey(d => d.ExpeditionClass)
                    .HasConstraintName("FK__AirShipEx__AirSh__5070F446");

                entity.HasOne(d => d.ExpeditionClass1)
                    .WithMany(p => p.AirShipExpedition)
                    .HasForeignKey(d => d.ExpeditionClass)
                    .HasConstraintName("FK__AirShipEx__Exped__5165187F");
            });

            modelBuilder.Entity<AirShipTickets>(entity =>
            {
                entity.HasKey(e => e.TicketId)
                    .HasName("PK__AirShipT__ED7260B902FEE7A3");

                entity.Property(e => e.TicketId).HasColumnName("Ticket_Id");

                entity.Property(e => e.ExpeditionId).HasColumnName("Expedition_Id");

                entity.HasOne(d => d.CustomerNumbNavigation)
                    .WithMany(p => p.AirShipTickets)
                    .HasForeignKey(d => d.CustomerNumb)
                    .HasConstraintName("FK__AirShipTi__Custo__5535A963");

                entity.HasOne(d => d.Expedition)
                    .WithMany(p => p.AirShipTickets)
                    .HasForeignKey(d => d.ExpeditionId)
                    .HasConstraintName("FK__AirShipTi__Custo__5441852A");
            });

            modelBuilder.Entity<AirShips>(entity =>
            {
                entity.Property(e => e.AirShipsId).HasColumnName("AirShips_Id");

                entity.Property(e => e.AirwayIdNumb).HasColumnName("Airway_IdNumb");

                entity.Property(e => e.FlyDate).HasColumnType("date");

                entity.Property(e => e.LandingDate).HasColumnType("date");

                entity.Property(e => e.RoutesIdNumb).HasColumnName("Routes_IdNumb");

                entity.HasOne(d => d.AirwayIdNumbNavigation)
                    .WithMany(p => p.AirShips)
                    .HasForeignKey(d => d.AirwayIdNumb)
                    .HasConstraintName("FK__AirShips__Airway__4BAC3F29");

                entity.HasOne(d => d.RoutesIdNumbNavigation)
                    .WithMany(p => p.AirShips)
                    .HasForeignKey(d => d.RoutesIdNumb)
                    .HasConstraintName("FK__AirShips__Routes__4CA06362");
            });

            modelBuilder.Entity<AirWayCompany>(entity =>
            {
                entity.HasKey(e => e.AirWayId)
                    .HasName("PK__AirWayCo__A23DF552E09C8957");

                entity.Property(e => e.AirWayId).HasColumnName("AirWay_Id");

                entity.Property(e => e.AirWayCompName)
                    .HasColumnName("AirWayComp_Name")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<Airports>(entity =>
            {
                entity.HasKey(e => e.AirportId)
                    .HasName("PK__Airports__3DBD86F3693E2CAF");

                entity.Property(e => e.AirportId).HasColumnName("Airport_Id");

                entity.Property(e => e.AirportName)
                    .HasColumnName("Airport_Name")
                    .HasMaxLength(55);

                entity.Property(e => e.DiscId).HasColumnName("Disc_Id");

                entity.HasOne(d => d.Disc)
                    .WithMany(p => p.Airports)
                    .HasForeignKey(d => d.DiscId)
                    .HasConstraintName("FK__Airports__Disc_I__412EB0B6");
            });

            modelBuilder.Entity<CarLuxury>(entity =>
            {
                entity.HasKey(e => e.LuxId)
                    .HasName("PK__Car_Luxu__3E6894DCBCA729A2");

                entity.ToTable("Car_Luxury");

                entity.Property(e => e.LuxId).HasColumnName("Lux_Id");

                entity.Property(e => e.LuxName)
                    .HasColumnName("Lux_Name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Cars>(entity =>
            {
                entity.HasKey(e => e.CarId)
                    .HasName("PK__Cars__523653F90FB677BD");

                entity.Property(e => e.CarId).HasColumnName("Car_Id");

                entity.Property(e => e.CarLuxury).HasColumnName("Car_Luxury");

                entity.Property(e => e.CarModel)
                    .HasColumnName("Car_Model")
                    .HasMaxLength(50);

                entity.HasOne(d => d.CarLuxuryNavigation)
                    .WithMany(p => p.Cars)
                    .HasForeignKey(d => d.CarLuxury)
                    .HasConstraintName("FK__Cars__Car_Luxury__6E01572D");
            });

            modelBuilder.Entity<CarsHasRent>(entity =>
            {
                entity.HasKey(e => e.EventId)
                    .HasName("PK__Cars_Has__FD6BEF848B3668C8");

                entity.ToTable("Cars_HasRent");

                entity.Property(e => e.EventId).HasColumnName("Event_Id");

                entity.Property(e => e.CustomerIdNumber).HasColumnName("Customer_IdNumber");

                entity.Property(e => e.ItemsCarId).HasColumnName("Items_Car_Id");

                entity.Property(e => e.RentTimeDay).HasColumnName("Rent_TimeDay");

                entity.HasOne(d => d.CustomerIdNumberNavigation)
                    .WithMany(p => p.CarsHasRent)
                    .HasForeignKey(d => d.CustomerIdNumber)
                    .HasConstraintName("FK__Cars_HasR__Custo__778AC167");

                entity.HasOne(d => d.ItemsCar)
                    .WithMany(p => p.CarsHasRent)
                    .HasForeignKey(d => d.ItemsCarId)
                    .HasConstraintName("FK__Cars_HasR__Rent___76969D2E");
            });

            modelBuilder.Entity<Countries>(entity =>
            {
                entity.HasKey(e => e.CountryId)
                    .HasName("PK__Countrie__8036CBAE47F9BAFE");

                entity.Property(e => e.CountryId).HasColumnName("Country_Id");

                entity.Property(e => e.CountryName)
                    .HasColumnName("Country_Name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Customers>(entity =>
            {
                entity.HasKey(e => e.CustomerId)
                    .HasName("PK__Customer__8CB286995128DE78");

                entity.Property(e => e.CustomerId).HasColumnName("Customer_Id");

                entity.Property(e => e.CustomerName)
                    .HasColumnName("Customer_Name")
                    .HasMaxLength(25);

                entity.Property(e => e.CustomerPhone)
                    .HasColumnName("Customer_Phone")
                    .HasMaxLength(16);

                entity.Property(e => e.CustomerSurname)
                    .HasColumnName("Customer_Surname")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<District>(entity =>
            {
                entity.Property(e => e.DistrictId).HasColumnName("District_Id");

                entity.Property(e => e.CustomDisctName)
                    .HasColumnName("Custom_Disct_Name")
                    .HasMaxLength(60);

                entity.Property(e => e.DistrictName)
                    .HasColumnName("District_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.ProvId).HasColumnName("Prov_Id");

                entity.HasOne(d => d.Prov)
                    .WithMany(p => p.District)
                    .HasForeignKey(d => d.ProvId)
                    .HasConstraintName("FK__District__Prov_I__3C69FB99");
            });

            modelBuilder.Entity<Facilities>(entity =>
            {
                entity.Property(e => e.FacilitiesId).HasColumnName("Facilities_Id");

                entity.Property(e => e.FacitiliesDescription)
                    .HasColumnName("Facitilies_Description")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ItemCars>(entity =>
            {
                entity.HasKey(e => e.CarItemId)
                    .HasName("PK__ItemCars__CF55E1E88E629BDD");

                entity.Property(e => e.CarItemId).HasColumnName("Car_Item_Id");

                entity.Property(e => e.AirportIdNumb).HasColumnName("Airport_IdNumb");

                entity.Property(e => e.CarId).HasColumnName("Car_Id");

                entity.Property(e => e.CompanyIdNumb).HasColumnName("Company_IdNumb");

                entity.Property(e => e.ItemCount).HasColumnName("Item_Count");

                entity.Property(e => e.ItemIsActive)
                    .HasColumnName("Item_IsActive")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.RentPrice).HasColumnType("money");

                entity.HasOne(d => d.AirportIdNumbNavigation)
                    .WithMany(p => p.ItemCars)
                    .HasForeignKey(d => d.AirportIdNumb)
                    .HasConstraintName("FK__ItemCars__Airpor__71D1E811");

                entity.HasOne(d => d.Car)
                    .WithMany(p => p.ItemCars)
                    .HasForeignKey(d => d.CarId)
                    .HasConstraintName("FK__ItemCars__Car_Id__72C60C4A");

                entity.HasOne(d => d.CompanyIdNumbNavigation)
                    .WithMany(p => p.ItemCars)
                    .HasForeignKey(d => d.CompanyIdNumb)
                    .HasConstraintName("FK__ItemCars__Compan__73BA3083");
            });

            modelBuilder.Entity<OtelRoomType>(entity =>
            {
                entity.ToTable("Otel_RoomType");

                entity.Property(e => e.OtelRoomTypeId).HasColumnName("Otel_RoomType_Id");

                entity.Property(e => e.OtelRoomTypeName)
                    .HasColumnName("Otel_RoomType_Name")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<OtelRooms>(entity =>
            {
                entity.HasKey(e => e.RoomId)
                    .HasName("PK__OtelRoom__19EE6A1313357C06");

                entity.Property(e => e.RoomId).HasColumnName("Room_Id");

                entity.Property(e => e.OteId).HasColumnName("Ote_Id");

                entity.Property(e => e.RoomIsFull)
                    .HasColumnName("Room_IsFULL")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RoomPrice)
                    .HasColumnName("Room_Price")
                    .HasColumnType("money");

                entity.Property(e => e.RoomTypeint).HasColumnName("Room_Typeint");

                entity.HasOne(d => d.Ote)
                    .WithMany(p => p.OtelRooms)
                    .HasForeignKey(d => d.OteId)
                    .HasConstraintName("FK__OtelRooms__Ote_I__66603565");

                entity.HasOne(d => d.RoomTypeintNavigation)
                    .WithMany(p => p.OtelRooms)
                    .HasForeignKey(d => d.RoomTypeint)
                    .HasConstraintName("FK__OtelRooms__Room___6754599E");
            });

            modelBuilder.Entity<OtelTypes>(entity =>
            {
                entity.HasKey(e => e.TypesId)
                    .HasName("PK__Otel_Typ__B9F9743A1D108107");

                entity.ToTable("Otel_Types");

                entity.Property(e => e.TypesId).HasColumnName("Types_Id");

                entity.Property(e => e.TypesDescription)
                    .HasColumnName("Types_Description")
                    .HasMaxLength(35);
            });

            modelBuilder.Entity<Otels>(entity =>
            {
                entity.HasKey(e => e.OtelId)
                    .HasName("PK__Otels__4345D2616FE55FB1");

                entity.Property(e => e.OtelId).HasColumnName("Otel_Id");

                entity.Property(e => e.OtelAddress)
                    .HasColumnName("Otel_Address")
                    .HasMaxLength(255);

                entity.Property(e => e.OtelDistrictId).HasColumnName("Otel_District_Id");

                entity.Property(e => e.OtelFacilitiesId).HasColumnName("Otel_Facilities_Id");

                entity.Property(e => e.OtelName)
                    .HasColumnName("Otel_Name")
                    .HasMaxLength(55);

                entity.Property(e => e.OtelTypeId).HasColumnName("Otel_Type_Id");

                entity.HasOne(d => d.OtelDistrict)
                    .WithMany(p => p.Otels)
                    .HasForeignKey(d => d.OtelDistrictId)
                    .HasConstraintName("FK__Otels__Otel_Dist__5CD6CB2B");

                entity.HasOne(d => d.OtelFacilities)
                    .WithMany(p => p.Otels)
                    .HasForeignKey(d => d.OtelFacilitiesId)
                    .HasConstraintName("FK__Otels__Otel_Faci__5BE2A6F2");

                entity.HasOne(d => d.OtelType)
                    .WithMany(p => p.Otels)
                    .HasForeignKey(d => d.OtelTypeId)
                    .HasConstraintName("FK__Otels__Otel_Type__5DCAEF64");
            });

            modelBuilder.Entity<Photos>(entity =>
            {
                entity.HasKey(e => e.PhotoId)
                    .HasName("PK__Photos__7A07F6E278C2CD31");

                entity.Property(e => e.PhotoId).HasColumnName("Photo_Id");

                entity.Property(e => e.OteleId).HasColumnName("Otele_Id");

                entity.Property(e => e.PhotoSource).HasColumnType("image");

                entity.HasOne(d => d.Otele)
                    .WithMany(p => p.Photos)
                    .HasForeignKey(d => d.OteleId)
                    .HasConstraintName("FK__Photos__Otele_Id__60A75C0F");
            });

            modelBuilder.Entity<Provinces>(entity =>
            {
                entity.HasKey(e => e.ProvinceId)
                    .HasName("PK__Province__D445B662A1D1BBA1");

                entity.Property(e => e.ProvinceId).HasColumnName("Province_Id");

                entity.Property(e => e.ContId).HasColumnName("Cont_Id");

                entity.Property(e => e.ProvName)
                    .HasColumnName("Prov_Name")
                    .HasMaxLength(50);

                entity.HasOne(d => d.Cont)
                    .WithMany(p => p.Provinces)
                    .HasForeignKey(d => d.ContId)
                    .HasConstraintName("FK__Provinces__Cont___398D8EEE");
            });

            modelBuilder.Entity<RentcarCompany>(entity =>
            {
                entity.Property(e => e.RentcarCompanyId).HasColumnName("RentcarCompany_Id");

                entity.Property(e => e.RentcarCompanyName)
                    .HasColumnName("RentcarCompany_Name")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<RestaurantCoupons>(entity =>
            {
                entity.HasKey(e => e.CouponId)
                    .HasName("PK__Restaura__2A776B9CDE96CB72");

                entity.ToTable("Restaurant_Coupons");

                entity.Property(e => e.CouponId).HasColumnName("Coupon_Id");

                entity.Property(e => e.CouponDescription)
                    .HasColumnName("Coupon_Description")
                    .HasMaxLength(44);

                entity.Property(e => e.CustomerIdNumb).HasColumnName("Customer_IdNumb");

                entity.Property(e => e.ExpirationDate)
                    .HasColumnName("Expiration_Date")
                    .HasColumnType("date");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.RestId).HasColumnName("Rest_Id");

                entity.HasOne(d => d.CustomerIdNumbNavigation)
                    .WithMany(p => p.RestaurantCoupons)
                    .HasForeignKey(d => d.CustomerIdNumb)
                    .HasConstraintName("FK__Restauran__IsAct__7E37BEF6");

                entity.HasOne(d => d.Rest)
                    .WithMany(p => p.RestaurantCoupons)
                    .HasForeignKey(d => d.RestId)
                    .HasConstraintName("FK__Restauran__Rest___7F2BE32F");
            });

            modelBuilder.Entity<Restauranties>(entity =>
            {
                entity.HasKey(e => e.RestaurantId)
                    .HasName("PK__Restaura__B422BC6BFF3C5E2A");

                entity.Property(e => e.RestaurantId).HasColumnName("Restaurant_Id");

                entity.Property(e => e.DisctIdNumb).HasColumnName("Disct_IdNumb");

                entity.Property(e => e.RestaurantAddress)
                    .HasColumnName("Restaurant_Address")
                    .HasMaxLength(255);

                entity.Property(e => e.RestaurantName)
                    .HasColumnName("Restaurant_Name")
                    .HasMaxLength(55);

                entity.HasOne(d => d.DisctIdNumbNavigation)
                    .WithMany(p => p.Restauranties)
                    .HasForeignKey(d => d.DisctIdNumb)
                    .HasConstraintName("FK__Restauran__Disct__7A672E12");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
