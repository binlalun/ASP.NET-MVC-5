using System;
using System.Linq;
using System.Collections.Generic;
	
namespace ASP_NET_MVC_HOMEWORK.Models
{   
	public  class sysdiagramsRepository : EFRepository<sysdiagrams>, IsysdiagramsRepository
	{

	}

	public  interface IsysdiagramsRepository : IRepository<sysdiagrams>
	{

	}
}