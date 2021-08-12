using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LojaVirtual.Models;
namespace LojaVirtual.Classes
{
	public class UserClass
	{
		public void AddUser(Users User)
		{
			try
			{
				var context = DbConfig.Initialize();
				var user = context.Users.FirstOrDefault(x=>x.Email== User.Email);
				var googleAccount = context.GoogleAccounts.FirstOrDefault(x => x.Email == user.Email);
				var microsoftAccount = context.MicrosoftAccounts.FirstOrDefault(x => x.Email == user.Email);
				if (user != null || googleAccount != null || microsoftAccount != null)
				{
					throw new Exception("Usuário já cadastrado");
				}
				context.Users.Add(User);
				context.SaveChanges();
			}
			catch
			{
				throw;
			}
		}
		public void UserAddGoogle(int users, GoogleAccount google)
		{
			try
			{
				var context = DbConfig.Initialize();
				var user = context.Users.FirstOrDefault(x => x.id == users);
				user.Google = google;
				context.SaveChanges();
			}
			catch
			{

			}
		}
		public void UserAddMicrosoft(int users, MicrosoftAccount microsoft)
		{
			try
			{
				var context = DbConfig.Initialize();
				var user = context.Users.FirstOrDefault(x => x.id == users);
				user.Microsoft = microsoft;
				context.SaveChanges();
			}
			catch
			{

			}
		}

	}
}