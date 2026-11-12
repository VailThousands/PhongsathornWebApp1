using Microsoft.AspNetCore.Mvc;
using PhongsathornWebApp1.Models;
using System.Diagnostics;

namespace PhongsathornWebApp1.Controllers
{

    public class HomeController : Controller
    {
        public IActionResult Index(int page = 1)
        {
            const int pageSize = 3;
            var products = new List<Product>
            {
                new() { Id = 1, Name = "กระเป๋าผ้า Everyday", Price = 390m, Quantity = 100 },
                new() { Id = 2, Name = "แก้วเก็บอุณหภูมิ", Price = 590m, Quantity = 50 },
                new() { Id = 3, Name = "โคมไฟมินิมอล", Price = 890m, Quantity = 25 },
                new() { Id = 4, Name = "หูฟังไร้สาย", Price = 1290m, Quantity = 10 },
                new() { Id = 5, Name = "นาฬิกา Everyday", Price = 1590m, Quantity = 5 },
                new() { Id = 6, Name = "กล้องฟิล์มพกพา", Price = 990m, Quantity = 2 },
                new() { Id = 7, Name = "ต้นไม้แต่งโต๊ะ", Price = 250m, Quantity = 1 }
            };

            var totalPages = (int)Math.Ceiling(products.Count / (double)pageSize);
            page = Math.Clamp(page, 1, totalPages);

            ViewBag.CurrentPage = page;
            ViewBag.TotalPages = totalPages;

            var productsOnPage = products
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            return View(productsOnPage);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult about()
        {
            return View();
        }

            [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
