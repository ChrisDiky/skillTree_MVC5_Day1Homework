using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HomeWork.Models
{
    public class MoneyClass
    {
        public string MoneyType { get; set; }
        public int MoneyAmount { get; set; }
        public DateTime MoneyDate { get; set; }
        public string MoneyNote { get; set; }

        public int MoneyCount { get; set; }
    }

    
}