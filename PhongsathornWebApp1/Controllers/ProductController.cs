using Microsoft.AspNetCore.Mvc;
using PhongsathornWebApp1.Models;

namespace PhongsathornWebApp1.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            var products = new List<Product>
            {
                new() { Id = 1, Name = "กระเป๋าผ้า Everyday", Price = 390m, quantity = 100 },
                new() { Id = 2, Name = "แก้วเก็บอุณหภูมิ", Price = 590m, quantity = 50 },
                new() { Id = 3, Name = "โคมไฟมินิมอล", Price = 890m, quantity = 25 },
                new() { Id = 4, Name = "หูฟังไร้สาย", Price = 1290m, quantity = 10 },
                new() { Id = 5, Name = "นาฬิกา Everyday", Price = 1590m, quantity = 5 },
                new() { Id = 6, Name = "กล้องฟิล์มพกพา", Price = 990m, quantity = 2 },
                new() { Id = 7, Name = "ต้นไม้แต่งโต๊ะ", Price = 250m, quantity = 1 }
            };
            return View(products);
        }
    }
}
