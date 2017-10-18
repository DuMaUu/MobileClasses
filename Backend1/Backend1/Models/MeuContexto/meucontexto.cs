using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Backend1.Models.MeuContexto
{
	public class meucontexto : DbContext
	{
		public meucontexto(): base("strConn")
		{
			
		}
	}
}