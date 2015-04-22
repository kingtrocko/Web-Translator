using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Services.Currency;
using WebTranslator.Models;

namespace WebTranslator.Controllers
{
    public class CurrencyController : Controller
    {
        private OpenExchangeRatesAPI api;


        public CurrencyController()
        {
            api = new OpenExchangeRatesAPI();
        }

        public ActionResult Index()
        {
            Dictionary<string, string> currencyNames = api.GetCurrencyNames();
            //var items = currencyNames.Select(x => new SelectListItem
            //                                            {
            //                                                Text = x.Value,
            //                                                Value = x.Key
            //                                            });


            var model = new Currency
            {
                From = new SelectList(currencyNames, "Key", "Value", "USD"),
                To = new SelectList(currencyNames, "Key", "Value", "EUR")
            };

            return View(model);
        }
        [HttpPost]
        public string Convert(string value, string from, string to)
        {
            string result = api.ConvertCurrency(value, from, to);
            return result;
        }
    }
}