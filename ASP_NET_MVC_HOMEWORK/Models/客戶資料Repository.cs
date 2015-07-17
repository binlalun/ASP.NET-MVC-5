using System;
using System.Linq;
using System.Collections.Generic;
	
namespace ASP_NET_MVC_HOMEWORK.Models
{   
	public  class 客戶資料Repository : EFRepository<客戶資料>, I客戶資料Repository
	{

	}

	public  interface I客戶資料Repository : IRepository<客戶資料>
	{

	}
}