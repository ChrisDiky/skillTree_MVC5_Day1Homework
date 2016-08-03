using HomeWork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HomeWork.Controllers
{

    public class MoneyController : Controller
    {
        // GET: Money
        public ActionResult ShowMoney()
        {
            return View();
        }
        [ChildActionOnly]
        public ActionResult ListMoney()
        {
            var item = new List<MoneyClass>();
            
            for (int i = 1; i < 5; i++)
            {
                var model = new MoneyClass();
                if(i % 5 == 0)
                    model.MoneyType = "支出";
                else
                    model.MoneyType = "收入";

                model.MoneyAmount = i * 100;
                model.MoneyDate = DateTime.Now.AddMonths(i);
                model.MoneyNote = "第" + i + "筆備註。";
                model.MoneyCount = i;             
                item.Add(model);
            }
            
            return View(item);
        }
    }
}