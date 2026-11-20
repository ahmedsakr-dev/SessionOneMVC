using Microsoft.AspNetCore.Mvc;
using SessionOneMVC.Models;

namespace SessionOneMVC.Controllers
{
    public class ProductsController : Controller
    {

        #region Actions

        //[HttpGet]
        //public IActionResult Index()
        //{
        //    return View();
        //}

        //public string Test()
        //{
        //    return $"Hello from test";
        //}

        //[HttpGet]
        //public IActionResult Test()
        //{
        //    ContentResult result = new ContentResult();
        //    result.ContentType = "text/html";
        //    result.Content = $"Hello from test </br> Bye";
        //    result.StatusCode = StatusCodes.Status200OK;
        //    return result;

        //        //return Content(content: $"Hello from test </br> Bye", contentType: "text/html");

        //}

        //[HttpGet]
        //public IActionResult GetProducts()
        //{
        //    var products = new List<Product>()
        //    {
        //        new Product() {Id = 1 , Name = "Mobile"},
        //        new Product() {Id = 2 , Name = "Tablet"},
        //    };
        //    return Json(products);
        //}

        //[NonAction]
        //public IActionResult Test()
        //{
        //    return View();
        //}

        //public IActionResult GetProductById (int id)
        //{
        //    if (id < 0)
        //        return BadRequest();
        //    else if (id == 0)
        //        //return RedirectToAction("GetProducts");
        //        return RedirectToAction(nameof(GetProducts));
        //    else if (id < 10)
        //        return NotFound();
        //    else
        //        return Json(new Product() { Id = id, Name = "Laptop" });
        //}

        //[HttpGet]
        //public IActionResult RedirectAction()
        //{
        //    return Redirect("https://docs.google.com/presentation/d/1TPKT3Esh3c8jtX1FJAifaLxjL2NlzjKM/edit?slide=id.p10#slide=id.p10");
        //}

        //[HttpGet]
        //public IActionResult FileAction()
        //{
        //    byte[] fileBytes = System.IO.File.ReadAllBytes("wwwroot/files/PdfSample.pdf");
        //    return File(fileBytes, "application/pdf", "Group01.pdf");
        //}

        #endregion

        #region Routing
        //[HttpGet("Products/Test01")]
        //public IActionResult TestRouting()
        //{
        //    return Json($"Hello From TestRouting");
        //}

        //[HttpGet("TestingRoute/Test{id:int}")]
        //public IActionResult TestRouting(int id)
        //{
        //    return Json($"Hello with id: {id}");
        //}

        //public IActionResult TestRouting(int id, string name)
        //{
        //    return Json($"Hello from TestRouting : id={id}, name={name}");
        //}

        //[HttpGet("json")]
        //public IActionResult JsonAction()
        //{
        //    return Json("Hello From JsonAction");
        //}

        //[HttpGet("ProductCode/{code:int}")]
        //public IActionResult GetProductByCode(int code)
        //{
        //    return Json(new Product() { Id = code, Name = "Mobile" });
        //}
        #endregion

        #region Model Binding
        [HttpGet]
        public IActionResult GetById([FromQuery] int id, [FromQuery(Name = "id2")] int anotherId)
        {
            return Json(new { Id = id, AnotherId = anotherId });
        }

        [HttpGet]
        public IActionResult Search(ProductFilter filter)
        {
            return Content("Search Completed");
        }

        [HttpGet]
        public IActionResult GetByIds(int[] ids)
        {
            return Json(new { Ids = ids });
        }
        #endregion
    }
}
