using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using QRmenu.Models;
namespace QRmenu.Data
{
	public class ApplicationContext : DbContext
	{
		public ApplicationContext(DbContextOptions<ApplicationContext> options)	:	base(options)
		{	}
		public DbSet<Company>? Companies { get; set; }
		public DbSet<Status>? Statuses { get; set; }
		public DbSet<Food>?	Foods { get; set; }
		public DbSet<Category>? Categories { get; set; }
		public DbSet<Restaurant>? Restaurants { get; set; }
        public DbSet<User>? Users { get; set; }
		
		
    }
}