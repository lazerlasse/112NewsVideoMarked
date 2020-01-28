using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using _112NewsVideoMarked.Models;

namespace _112NewsVideoMarked.Data
{
	public class ApplicationDbContext : IdentityDbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{
		}
		public DbSet<CaseContent> CaseContent { get; set; }
		public DbSet<Image> Image { get; set; }
		public DbSet<Video> Video { get; set; }
	}
}
