using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Models
{
	public static class DbConfig
	{
		public static void Initialize()
		{
			//var optionsBuilder = new DbContextOptionsBuilder<BDContext>();
			//optionsBuilder.UseNpgsql(Environment.GetEnvironmentVariable("ConnectionDB"));
			////optionsBuilder.EnableSensitiveDataLogging();
			////optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
			////optionsBuilder.UseMySql(connectionString, ServerVersion.Parse("8.0.25-mysql"));
			//var context = new BDContext(optionsBuilder.Options);
			//return context;
		}
	}
}
