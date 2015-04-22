using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebTranslator.Models
{
    public class Currency
    {
        public SelectList From { get; set; }


        public SelectList To { get; set; }


        public string SelectedValueFrom { get; set; }


        public string SelectedValueTo { get; set; }


        public string QuotedValue { get; set; }


        public string CurrencyResult { get; set; }
    }
}