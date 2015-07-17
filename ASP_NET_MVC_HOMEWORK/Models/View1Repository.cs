using System;
using System.Linq;
using System.Collections.Generic;
	
namespace ASP_NET_MVC_HOMEWORK.Models
{   
	public  class View1Repository : EFRepository<View1>, IView1Repository
	{

	}

	public  interface IView1Repository : IRepository<View1>
	{

	}
}