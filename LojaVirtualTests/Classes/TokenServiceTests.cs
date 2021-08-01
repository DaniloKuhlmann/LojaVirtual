using Microsoft.VisualStudio.TestTools.UnitTesting;
using LojaVirtual.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaVirtual.Classes.Tests
{
	[TestClass()]
	public class TokenServiceTests
	{
		[TestMethod()]
		public void HASHCalculateTest()
		{
			var HASH = TokenService.HASHCalculate("Teste");
			Assert.IsTrue(TokenService.CompareHASH("Teste", HASH));
		}
	}
}