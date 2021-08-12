using LojaVirtual.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace LojaVirtual.Classes
{
	public static class DbConfig
	{
		public static BDContext Initialize()
		{
			var optionsBuilder = new DbContextOptionsBuilder<BDContext>();
			optionsBuilder.UseNpgsql(Environment.GetEnvironmentVariable("ConnectionDB"));
			optionsBuilder.EnableSensitiveDataLogging();
			var context = new BDContext(optionsBuilder.Options);
			return context;
		}
	}
}