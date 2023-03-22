using ChapterInventory.Data;
using ChapterInventory.Models;
using Microsoft.AspNetCore.Mvc;

namespace ChapterInventory.Controllers
{
   
    public class ZambeziController : Controller
    {
        private readonly ApplicationContext context;
        public ZambeziController(ApplicationContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult RecordsAClass()
        { 
            var results = context.Records.ToList();
            return View(results);
        }
        public IActionResult addRecordA()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddRecordA(RecordsTamplate rt, IFormFile file) { 

            if(ModelState.IsValid)
            {
                var record = new RecordsTamplate()
                {
                    ProductDescription = rt.ProductDescription,
                    Quantity = rt.Quantity,
                    IssuedBy= rt.IssuedBy,
                    VerifiedBy= rt.VerifiedBy,
                    DateSend= rt.DateSend,
                    DateRecieved= rt.DateRecieved,
                };
                context.Records.Add(record);
                context.SaveChanges();
                return RedirectToAction("RecordsAClass");
            }
            return View();
        }
    }
}
