using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using PointOfSalesV2.Entities;
using PointOfSalesV2.Repository;
using static PointOfSalesV2.Common.Enums;

namespace PointOfSalesV2.FrontEnd.Controllers
{
    public class ViewsController : Controller
    {
        readonly IDataRepositoryFactory dataRepository;
        IHttpContextAccessor httpContextAccessor;
        IMemoryCache memoryCache;
        List<LanguageKey> languageKeys;
        
        public ViewsController(IDataRepositoryFactory dataRepositoryFactory, IHttpContextAccessor context, IMemoryCache _cache) : base() 
        {
            this.dataRepository = dataRepositoryFactory;
            this.httpContextAccessor = context;
            this.memoryCache = _cache;
            languageKeys = memoryCache.Get<List<LanguageKey>>("languageKeysMem");
            if (languageKeys == null) 
            {
                this.languageKeys = dataRepository.GetDataRepositories<LanguageKey>().GetAll(x => x, y => y.Active == true).Data.ToList();
                memoryCache.Set("languageKeysMem", languageKeys);
            }
                
           
        }
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult InvoicePrint(long id, string language="es") 
        {
            this.httpContextAccessor.HttpContext.Request.Headers.Add("languageid", language);

            var invoiceRepo = dataRepository.GetDataRepositories<Invoice>();
            var invoice = invoiceRepo.Get(x => x.Include(i=>i.Customer).Include(i=>i.Seller)
            .Include(i=>i.Currency).Include(i=>i.InvoiceDetails).ThenInclude(d=>d.Product), y => y.Active == true && y.Id == id);
            var selectedLanguageKeys = languageKeys.Where(x=>x.LanguageCode.ToLower()==language.ToLower()).ToList();
            invoice.InvoiceDetails = invoice.InvoiceDetails.Where(x => x.Active == true ).ToList();
            ViewBag.LanguageKeys = selectedLanguageKeys;
            ViewBag.Invoice = invoice;
            ViewBag.CurrentLanguage = language;
            return View();
        }

        public ActionResult ExpensePrint(long id, string language = "es")
        {
            this.httpContextAccessor.HttpContext.Request.Headers.Add("languageid", language);

            var invoiceRepo = dataRepository.GetDataRepositories<Expense>();
            var invoice = invoiceRepo.Get(x => x.Include(i => i.Supplier).Include(i => i.Currency), y => y.Active == true && y.Id == id);
            var selectedLanguageKeys = languageKeys.Where(x => x.LanguageCode.ToLower() == language.ToLower()).ToList();
            ViewBag.LanguageKeys = selectedLanguageKeys;
            ViewBag.Expense = invoice;
            ViewBag.CurrentLanguage = language;
            return View();
        }

        public ActionResult InvoicePayment(long invoiceId, string language = "es")
        {
            this.httpContextAccessor.HttpContext.Request.Headers.Add("languageid", language);

            var invoiceRepo = dataRepository.GetDataRepositories<Invoice>();
            var invoice = invoiceRepo.Get(x => x.Include(i => i.Customer).Include(i => i.Seller)
            .Include(i=>i.Payments).ThenInclude(p=>p.Seller)
            .Include(i => i.Currency), y => y.Active == true && y.Id == invoiceId);
            invoice.Payments = invoice.Payments.Where(p => p.Active == true).ToList();
            var selectedLanguageKeys = languageKeys.Where(x => x.LanguageCode.ToLower() == language.ToLower()).ToList();
            ViewBag.LanguageKeys = selectedLanguageKeys;
            ViewBag.Invoice = invoice;
            ViewBag.CurrentLanguage = language;
            return View();
        }

        public ActionResult ExpensePayment(long id, string language = "es")
        {
            this.httpContextAccessor.HttpContext.Request.Headers.Add("languageid", language);

            var invoiceRepo = dataRepository.GetDataRepositories<Expense>();
            var invoice = invoiceRepo.Get(x => x.Include(i => i.Supplier).Include(i => i.Currency)
            .Include(i=>i.Payments), y => y.Active == true && y.Id == id);
            invoice.Payments = invoice.Payments.Where(y => y.Active == true).ToList();
            var selectedLanguageKeys = languageKeys.Where(x => x.LanguageCode.ToLower() == language.ToLower()).ToList();
            ViewBag.LanguageKeys = selectedLanguageKeys;
            ViewBag.Expense = invoice;
            ViewBag.CurrentLanguage = language;
            return View();
        }

        public ActionResult InvoiceLeadPrint(long id, string language = "es")
        {
            this.httpContextAccessor.HttpContext.Request.Headers.Add("languageid", language);

            var invoiceRepo = dataRepository.GetDataRepositories<InvoiceLead>();
            var invoice = invoiceRepo.Get(x => x.Include(i => i.Customer).Include(i => i.Seller)
            .Include(i => i.Currency).Include(i => i.LeadDetails).ThenInclude(d => d.Product)
            .Include(i=>i.School).Include(i=>i.LeadDetails).ThenInclude(i=>i.Unit), y => y.Active == true && y.Id == id);
            var selectedLanguageKeys = languageKeys.Where(x => x.LanguageCode.ToLower() == language.ToLower()).ToList();
            invoice.LeadDetails = invoice.LeadDetails.Where(x => x.Active == true).ToList();
            ViewBag.LanguageKeys = selectedLanguageKeys;
            ViewBag.Invoice = invoice;
            ViewBag.CurrentLanguage = language;
            return View();
        }
    }
}
