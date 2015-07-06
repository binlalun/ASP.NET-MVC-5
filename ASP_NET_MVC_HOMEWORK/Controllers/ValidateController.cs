using ASP_NET_MVC_HOMEWORK.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace ASP_NET_MVC_HOMEWORK.Controllers
{
    public class ValidateController : Controller
    {
        private CustomEntities db = new CustomEntities();

        public JsonResult CheckCustomContactEmail(int 客戶Id)
        {
            bool isValidate = false;

            var 客戶聯絡人 = db.客戶聯絡人.Where(客 => 客.客戶Id == 客戶Id);
            if (客戶聯絡人 == null)
            {
                isValidate = true;
            }

            //if (Url.IsLocalUrl(Request.Url.AbsoluteUri))
            //{
            //    //var 客戶聯絡人 = db.客戶聯絡人.Include(客 => 客.客戶資料).Where(客 => 客.客戶Id == 客戶Id);
            //    //利用 IsLocalUrl檢查是否為網站呼叫的
            //    //借此忽略一些不必要的流量
            //    //if (userName != "demoshop")
            //    //{
            //    //    //因連資料庫麻煩
            //    //    //所以假裝示範不可以註冊某一名字
            //    //    isValidate = true;
            //    //}
            //    //if (客戶聯絡人.Where(客 => 客.Email == Email) == null)
            //    //{
            //    //    isValidate = true;
            //    //}
            //}
            // Remote 驗證是使用 Get 因此要開放
            return Json(isValidate, JsonRequestBehavior.AllowGet);
        }
    }
}