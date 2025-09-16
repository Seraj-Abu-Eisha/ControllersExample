using Microsoft.AspNetCore.Mvc;
using ControllersExample.Models;
namespace ControllersExample.Controllers
{
    [Controller]
    public class HomeController :Controller
    {
        [Route("home")]
        [Route("/")]
        public ContentResult Index()
        {
            return Content("<h1>:3</h1><h2>Meow</h2>", "text/HTML"); 
        }
        [Route("person")]
        public JsonResult person()
        {
            Person person = new Person() { Id = Guid.NewGuid(),
                FName = "James", LName = "Smith", Age = 36};
            return Json(person);
        }
        [Route("file-download")]
        public IActionResult FileDownload()
        {
            return File("/sample.pdf", "application/pdf");
        }
        [Route("file-download2")]
        public IActionResult FileDownload2()
        {
            return new PhysicalFileResult(@"c:\aspnetcore\sample.pdf", "application/pdf");
        }
        [Route("file-download3")]
        public IActionResult FileDownload3()
        {
            byte[] bytes = System.IO.File.ReadAllBytes(@"c:\aspnetcore\sample.pdf");
            return new FileContentResult(bytes, "application/pdf");
        }
    
    }
}
