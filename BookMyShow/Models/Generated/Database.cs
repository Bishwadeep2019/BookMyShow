﻿
// This file was automatically generated by the PetaPoco T4 Template
// Do not make changes directly to this file - edit the template instead
// 
// The following connection settings were used to generate this file
// 
//     Connection String Name: ``
//     Provider:               `System.Data.SqlClient`
//     Connection String:      `Server=DEAD-INSIDE;Database=BookMyShow;Trusted_Connection=True`
//     Schema:                 ``
//     Include Views:          `True`

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PetaPoco;

namespace BookMyShow.DataModels
{
	public partial class PetaPocoDB : Database
	{
		public PetaPocoDB()
			: base("BookMyShow", "")
		{
			CommonConstruct();
		}

		public PetaPocoDB(string connectionstring)
				: base(connectionstring, "System.Data.SqlClient")
		{
			CommonConstruct();
		}


		partial void CommonConstruct();
		
		public interface IFactory
		{
			PetaPocoDB GetInstance();
		}
		
		public static IFactory Factory { get; set; }
        public static PetaPocoDB GetInstance()
        {
			if (_instance!=null)
				return _instance;
				
			if (Factory!=null)
				return Factory.GetInstance();
			else
				return new PetaPocoDB();
        }

		[ThreadStatic] static PetaPocoDB _instance;
		
		public override void OnBeginTransaction()
		{
			if (_instance==null)
				_instance=this;
		}
		
		public override void OnEndTransaction()
		{
			if (_instance==this)
				_instance=null;
		}
        
		public class Record<T> where T:new()
		{
			public static PetaPocoDB repo { get { return PetaPocoDB.GetInstance(); } }
			public bool IsNew() { return repo.IsNew(this); }
			public object Insert() { return repo.Insert(this); }
			public void Save() { repo.Save(this); }
			public int Update() { return repo.Update(this); }
			public int Update(IEnumerable<string> columns) { return repo.Update(this, columns); }
			public static int Update(string sql, params object[] args) { return repo.Update<T>(sql, args); }
			public static int Update(Sql sql) { return repo.Update<T>(sql); }
			public int Delete() { return repo.Delete(this); }
			public static int Delete(string sql, params object[] args) { return repo.Delete<T>(sql, args); }
			public static int Delete(Sql sql) { return repo.Delete<T>(sql); }
			public static int Delete(object primaryKey) { return repo.Delete<T>(primaryKey); }
			public static bool Exists(object primaryKey) { return repo.Exists<T>(primaryKey); }
			public static bool Exists(string sql, params object[] args) { return repo.Exists<T>(sql, args); }
			public static T SingleOrDefault(object primaryKey) { return repo.SingleOrDefault<T>(primaryKey); }
			public static T SingleOrDefault(string sql, params object[] args) { return repo.SingleOrDefault<T>(sql, args); }
			public static T SingleOrDefault(Sql sql) { return repo.SingleOrDefault<T>(sql); }
			public static T FirstOrDefault(string sql, params object[] args) { return repo.FirstOrDefault<T>(sql, args); }
			public static T FirstOrDefault(Sql sql) { return repo.FirstOrDefault<T>(sql); }
			public static T Single(object primaryKey) { return repo.Single<T>(primaryKey); }
			public static T Single(string sql, params object[] args) { return repo.Single<T>(sql, args); }
			public static T Single(Sql sql) { return repo.Single<T>(sql); }
			public static T First(string sql, params object[] args) { return repo.First<T>(sql, args); }
			public static T First(Sql sql) { return repo.First<T>(sql); }
			public static List<T> Fetch(string sql, params object[] args) { return repo.Fetch<T>(sql, args); }
			public static List<T> Fetch(Sql sql) { return repo.Fetch<T>(sql); }
			public static List<T> Fetch(long page, long itemsPerPage, string sql, params object[] args) { return repo.Fetch<T>(page, itemsPerPage, sql, args); }
			public static List<T> Fetch(long page, long itemsPerPage, Sql sql) { return repo.Fetch<T>(page, itemsPerPage, sql); }
			public static List<T> SkipTake(long skip, long take, string sql, params object[] args) { return repo.SkipTake<T>(skip, take, sql, args); }
			public static List<T> SkipTake(long skip, long take, Sql sql) { return repo.SkipTake<T>(skip, take, sql); }
			public static Page<T> Page(long page, long itemsPerPage, string sql, params object[] args) { return repo.Page<T>(page, itemsPerPage, sql, args); }
			public static Page<T> Page(long page, long itemsPerPage, Sql sql) { return repo.Page<T>(page, itemsPerPage, sql); }
			public static IEnumerable<T> Query(string sql, params object[] args) { return repo.Query<T>(sql, args); }
			public static IEnumerable<T> Query(Sql sql) { return repo.Query<T>(sql); }
		}
	}
	

    
	[TableName("dbo.Booking")]
	[PrimaryKey("Id")]
	[ExplicitColumns]
    public partial class Booking : PetaPocoDB.Record<Booking>  
    {
		[Column] public int Id { get; set; }
		[Column] public int RequiredSeats { get; set; }
		[Column] public DateTime BookingDate { get; set; }
		[Column] public int CustomerId { get; set; }
		[Column] public int ShowId { get; set; }
		[Column] public bool IsDeleted { get; set; }
		[Column] public DateTime? DateDeleted { get; set; }
	}
    
	[TableName("dbo.City")]
	[PrimaryKey("Id")]
	[ExplicitColumns]
    public partial class City : PetaPocoDB.Record<City>  
    {
		[Column] public int Id { get; set; }
		[Column] public string CityName { get; set; }
		[Column] public string Pincode { get; set; }
	}
    
	[TableName("dbo.Customer")]
	[PrimaryKey("Id")]
	[ExplicitColumns]
    public partial class Customer : PetaPocoDB.Record<Customer>  
    {
		[Column] public int Id { get; set; }
		[Column] public string CustomerName { get; set; }
		[Column] public string Email { get; set; }
		[Column] public string PhoneNumber { get; set; }
		[Column] public bool? IsDeleted { get; set; }
		[Column] public DateTime? DateDeleted { get; set; }
	}
    
	[TableName("dbo.CustomerSeat")]
	[PrimaryKey("Id")]
	[ExplicitColumns]
    public partial class CustomerSeat : PetaPocoDB.Record<CustomerSeat>  
    {
		[Column] public int Id { get; set; }
		[Column] public int Price { get; set; }
		[Column] public int TheaterSeatId { get; set; }
		[Column] public int BookingId { get; set; }
		[Column] public bool IsDeleted { get; set; }
		[Column] public DateTime? DateDeleted { get; set; }
	}
    
	[TableName("dbo.Movie")]
	[PrimaryKey("Id")]
	[ExplicitColumns]
    public partial class Movie : PetaPocoDB.Record<Movie>  
    {
		[Column] public int Id { get; set; }
		[Column] public string Title { get; set; }
		[Column] public DateTime ReleaseDate { get; set; }
		[Column] public string Language { get; set; }
		[Column] public string MovieImageUrl { get; set; }
		[Column] public string Genre { get; set; }
		[Column] public string Duration { get; set; }
		[Column] public bool IsDeleted { get; set; }
		[Column] public DateTime? DateDeleted { get; set; }
	}
    
	[TableName("dbo.Seat")]
	[PrimaryKey("Id")]
	[ExplicitColumns]
    public partial class Seat : PetaPocoDB.Record<Seat>  
    {
		[Column] public int Id { get; set; }
		[Column] public int SeatId { get; set; }
		[Column] public int HallId { get; set; }
		[Column] public bool IsDeleted { get; set; }
		[Column] public DateTime? DateDeleted { get; set; }
	}
    
	[TableName("dbo.Show")]
	[PrimaryKey("Id")]
	[ExplicitColumns]
    public partial class Show : PetaPocoDB.Record<Show>  
    {
		[Column] public int Id { get; set; }
		[Column] public string StartTime { get; set; }
		[Column] public string EndTime { get; set; }
		[Column] public DateTime ShowDate { get; set; }
		[Column] public int HallId { get; set; }
		[Column] public int MovieID { get; set; }
		[Column] public bool IsDeleted { get; set; }
		[Column] public DateTime? DateDeleted { get; set; }
	}
    
	[TableName("dbo.sysdiagrams")]
	[PrimaryKey("diagram_id")]
	[ExplicitColumns]
    public partial class sysdiagram : PetaPocoDB.Record<sysdiagram>  
    {
		[Column] public string name { get; set; }
		[Column] public int principal_id { get; set; }
		[Column] public int diagram_id { get; set; }
		[Column] public int? version { get; set; }
		[Column] public byte[] definition { get; set; }
	}
    
	[TableName("dbo.Theater")]
	[PrimaryKey("Id")]
	[ExplicitColumns]
    public partial class Theater : PetaPocoDB.Record<Theater>  
    {
		[Column] public int Id { get; set; }
		[Column] public string TheaterName { get; set; }
		[Column] public int TotalHall { get; set; }
		[Column] public bool IsDeleted { get; set; }
		[Column] public int CityId { get; set; }
		[Column] public DateTime? DateDeleted { get; set; }
	}
    
	[TableName("dbo.TheaterHall")]
	[PrimaryKey("Id")]
	[ExplicitColumns]
    public partial class TheaterHall : PetaPocoDB.Record<TheaterHall>  
    {
		[Column] public int Id { get; set; }
		[Column] public int TotalSeats { get; set; }
		[Column] public int ShowID { get; set; }
		[Column] public int TheaterId { get; set; }
		[Column] public bool IsDeleted { get; set; }
		[Column] public DateTime? DateDeleted { get; set; }
	}
    
	[TableName("dbo.UserDetails")]
	[PrimaryKey("Id")]
	[ExplicitColumns]
    public partial class UserDetail : PetaPocoDB.Record<UserDetail>  
    {
		[Column] public int Id { get; set; }
		[Column] public string Email { get; set; }
		[Column] public string Name { get; set; }
		[Column] public byte[] PasswordHash { get; set; }
		[Column] public byte[] PasswordSalt { get; set; }
	}
    
	[TableName("dbo.CityTheaters")]
	[ExplicitColumns]
    public partial class CityTheater : PetaPocoDB.Record<CityTheater>  
    {
		[Column] public string TheaterName { get; set; }
		[Column] public string CityName { get; set; }
		[Column] public string StartTime { get; set; }
		[Column] public int MovieID { get; set; }
		[Column] public int TheaterId { get; set; }
	}
    
	[TableName("dbo.MoviesInCity")]
	[ExplicitColumns]
    public partial class MoviesInCity : PetaPocoDB.Record<MoviesInCity>  
    {
		[Column] public string title { get; set; }
	}
    
	[TableName("dbo.TicketDetails")]
	[ExplicitColumns]
    public partial class TicketDetail : PetaPocoDB.Record<TicketDetail>  
    {
		[Column] public DateTime bookingdate { get; set; }
		[Column] public string TheaterName { get; set; }
		[Column] public int TotalSeats { get; set; }
		[Column] public string Title { get; set; }
		[Column] public string Language { get; set; }
	}
    
	[TableName("dbo.TotalSeats")]
	[ExplicitColumns]
    public partial class TotalSeat : PetaPocoDB.Record<TotalSeat>  
    {
		[Column] public int TotalSeats { get; set; }
		[Column] public int theaterId { get; set; }
	}
}
